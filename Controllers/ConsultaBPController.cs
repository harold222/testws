using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Reflection;
using WSGYG63.Models.QueryBP;
using WSGYG63.Models.Token;
using WSGYG63.Shared.Functions;

namespace WSGYG63.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsultaBPController : ControllerBase
    {
        private string url { get; set; }
        private readonly IConfiguration _config;
        private readonly string complement = "/ConsultaBP/ObtenerDataBPSet";
        private ModelToDictionary toDict = new();
        private TokenParams tokenParams;
        private GlobalToken currentToken;

        public ConsultaBPController(IConfiguration config, IOptions<GlobalToken> token)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
            this.currentToken = token.Value;
        }

        [HttpGet]
        public async Task<IActionResult> index([FromQuery] QueryBPRequest request)
        {
            Http http = new();

            try
            {
                // cuando tenga acceso a hacerle peticiones a los 6 endpoints revisar que me devuelven
                // con un token que no funciona, para volver a intentarla peticion, con un nuevo token

                bool successToken = false;

                if (!string.IsNullOrEmpty(this.currentToken?.AccessToken))
                {
                    bool expiredToken = new CheckDate().IsExpired(this.currentToken.DateExpire);

                    if (expiredToken)
                    {
                        TokenResponse newToken = await http.GetToken<TokenResponse>(this.currentToken.UrlToken, this.tokenParams.client_id, this.currentToken.DataToGetToken).ConfigureAwait(false);

                        if (newToken != null)
                        {
                            try
                            {
                                DateTime dateRefresh = DateTime.Now.AddSeconds(Convert.ToDouble(newToken.ExpiresIn));
                                this.currentToken.DateExpire = dateRefresh;
                            }
                            catch (Exception e)
                            {
                                // log de conversion de fecha a expirar e.ToString();
                            }

                            successToken = true;
                            this.currentToken.AccessToken = newToken.AccessToken;
                            this.currentToken.ExpiresIn = newToken.ExpiresIn;
                        }
                    }
                    else
                        successToken = true;
                }
                else
                {
                    Dictionary<string, string> data =
                            this.currentToken?.DataToGetToken == null ?
                            new ModelToDictionary().Trasform<TokenParams>(this.tokenParams) :
                            this.currentToken.DataToGetToken;

                    string urlToken = string.IsNullOrEmpty(this.currentToken?.UrlToken) ?
                        $"{this.url}/OAuth_APIM/GenerateToken" :
                        this.currentToken.UrlToken;

                    TokenResponse newToken = await http.GetToken<TokenResponse>(urlToken, this.tokenParams.client_id, data).ConfigureAwait(false);

                    if (newToken != null)
                    {
                        successToken = true;
                        this.currentToken.UrlToken = urlToken;
                        this.currentToken.AccessToken = newToken.AccessToken;
                        this.currentToken.DataToGetToken = data;
                        this.currentToken.ExpiresIn = newToken.ExpiresIn;
                    }
                }

                if (successToken)
                {
                    Dictionary<string, string?>? requestDict = this.toDict.Trasform<QueryBPRequest>(request);
                    QueryBPResponse? response = await http.GETAsync<QueryBPResponse, QueryBPRequest>(this.url, this.tokenParams.client_id, requestDict, this.currentToken.AccessToken).ConfigureAwait(false);
                    return Ok(response);
                }
                else
                    return StatusCode(500);
            }
            catch (Exception e)
            {
                // escribir en log
                return StatusCode(500);
            }
        }
    }
}

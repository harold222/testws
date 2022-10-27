using WSGYG63.Models.UpdateBP;
using WSGYG63.Models.Token;
using WSGYG63.Shared.Functions;
using WSGYG63.Shared.Enums;
using Microsoft.Extensions.Options;

namespace WSGYG63.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ActualizarBPController : Controller
    {
        private string url { get; set; }
        private readonly IConfiguration _config;
        private readonly string complement = "/ActualizaBPCRM";
        private TokenParams tokenParams;
        private readonly string openTagXml = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:urn='urn:sap-com:document:sap:rfc:functions'><soapenv:Header/><soapenv:Body><urn:ZFM_ACTUALIZAR_BPDATOSGENER>";
        private readonly string closeTagXml = "</urn:ZFM_ACTUALIZAR_BPDATOSGENER></soapenv:Body></soapenv:Envelope>";
        private GlobalToken currentToken = new();

        public ActualizarBPController(IConfiguration config, IOptions<GlobalToken> token)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
            this.currentToken = token.Value;
        }

        [HttpPost]
        public async Task<IActionResult> index([FromBody] UpdateBPRequest request)
        {
            Http http = new();
            try
            {
                GlobalToken? newOrCurrentToken = await new RefreshToken().verify(
                    this.url,
                    this.tokenParams,
                    this.currentToken?.UrlToken,
                    this.currentToken?.AccessToken,
                    this.currentToken?.DateExpire,
                    this.currentToken?.DataToGetToken).ConfigureAwait(false);

                if (newOrCurrentToken != null)
                {
                    if (this.currentToken?.AccessToken != newOrCurrentToken.AccessToken)
                    {
                        this.currentToken.AccessToken = newOrCurrentToken.AccessToken;
                        this.currentToken.UrlToken = newOrCurrentToken.UrlToken;
                        this.currentToken.DataToGetToken = newOrCurrentToken.DataToGetToken;
                        this.currentToken.DateExpire = newOrCurrentToken.DateExpire;
                    }

                    string requestXml = Deserialize.Serialize<UpdateBPRequest>(request, this.openTagXml, this.closeTagXml);
                    UpdateBPResponse response = await http.postXMLData<UpdateBPResponse>(this.url, this.tokenParams.client_id, requestXml, AuthorizationEnum.ACCES_TOKEN, this.currentToken.AccessToken).ConfigureAwait(false);
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

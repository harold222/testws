using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Reflection;
using System.Text;
using WSGYG63.Models.QueryBP;
using WSGYG63.Models.Token;
using WSGYG63.Shared.Enums;
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
        private GlobalToken currentToken = new();
        private string rutaI { get; set; }

        public ConsultaBPController(IConfiguration config, IOptions<GlobalToken> token)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
            this.rutaI = this._config.GetSection("Comfama:RutaI").Value;
            this.currentToken = token.Value;
        }

        [HttpGet]
        public async Task<IActionResult> index([FromQuery] QueryBPRequest request)
        {
            Http http = new();
            StringBuilder log = new StringBuilder();
            log.Append($"Entrada controlador: {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff")}");

            try
            {
                // cuando tenga acceso a hacerle peticiones a los 6 endpoints revisar que me devuelven
                // con un token que no funciona, para volver a intentarla peticion, con un nuevo token

                GlobalToken? newOrCurrentToken = await new RefreshToken().verify(
                    this.url,
                    this.tokenParams,
                    log,
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
                    
                    Dictionary<string, string?>? requestDict = this.toDict.Trasform<QueryBPRequest>(request);
                    log.Append($"\nTrama envio: {JsonConvert.SerializeObject(request)}");
                    
                    QueryBPResponse? response = await http.GETAsync<QueryBPResponse, QueryBPRequest>(this.url, this.tokenParams.client_id, requestDict, this.currentToken.AccessToken).ConfigureAwait(false);
                    log.Append($"\nTrama regreso: {JsonConvert.SerializeObject(response)}");

                    Log.write(log.ToString(), this.rutaI, ControllersNames.Query);
                    log.Clear();
                    return Ok(response);
                }
                else
                {
                    log.Append("\nSalida controlador");
                    Log.write(log.ToString(), this.rutaI, ControllersNames.Query);
                    log.Clear();
                    return StatusCode(500);
                }
            }
            catch (Exception e)
            {
                log.Append("\n" + e.ToString());
                
                Log.write(log.ToString(), this.rutaI, ControllersNames.Query);
                // clean memory
                log.Clear();
                return StatusCode(500);
            }
        }
    }
}

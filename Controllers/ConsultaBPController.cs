using Microsoft.Extensions.Options;
using Newtonsoft.Json;
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

        [HttpPost]
        public async Task<IActionResult> index([FromBody] QueryBPRequest request)
        {
            Http http = new();
            StringBuilder log = new StringBuilder();
            log.Append($"Entrada controlador: {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff")}");

            try
            {
                TimeSpan horaii = DateTime.Parse(DateTime.Now.ToString("o")).TimeOfDay;

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
                    log.Append($"{Environment.NewLine}Trama envio: {JsonConvert.SerializeObject(request)}");

                    QueryBPResponse? response = await http.GETAsync<QueryBPResponse, QueryBPRequest>(
                        this.url,
                        this.tokenParams.client_id,
                        requestDict,
                        this.currentToken.AccessToken,
                        "properties"
                    ).ConfigureAwait(false);

                    log.Append($"{Environment.NewLine}Trama regreso: {JsonConvert.SerializeObject(response)}");

                    TimeSpan horaf = DateTime.Parse(DateTime.Now.ToString("o")).TimeOfDay;
                    string horaff = (horaf - horaii).ToString();

                    log.Append($"{Environment.NewLine}Tiempo total: {horaff} segundos.");
                    Log.write(log.ToString(), this.rutaI, ControllersNames.Query);
                    log.Clear();

                    return Ok(new ResponseQuery
                    {
                        Response = response
                    });
                }
                else
                {
                    log.Append($"{Environment.NewLine}Salida controlador");
                    Log.write(log.ToString(), this.rutaI, ControllersNames.Query);
                    log.Clear();
                    return StatusCode(400);
                }
            }
            catch (Exception e)
            {
                log.Append(Environment.NewLine + e.ToString());
                Log.write(log.ToString(), this.rutaI, ControllersNames.Query);
                log.Clear();
                return StatusCode(400);
            }
        }
    }
}

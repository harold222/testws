using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;
using WSGYG63.Models.CreateBP;
using WSGYG63.Models.Token;
using WSGYG63.Shared.Enums;
using WSGYG63.Shared.Functions;

namespace WSGYG63.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CreacionBPController : ControllerBase
    {
        private string url { get; set; }
        private readonly IConfiguration _config;
        private readonly string complement = "/CrearBPCRM";
        private TokenParams tokenParams;
        private readonly string openTagXml = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:urn='urn:sap-com:document:sap:rfc:functions'><soapenv:Header/><soapenv:Body><urn:ZFM_CREATE_BP>";
        private readonly string closeTagXml = "</urn:ZFM_CREATE_BP></soapenv:Body></soapenv:Envelope>";
        private GlobalToken currentToken = new();
        private string rutaI { get; set; }

        public CreacionBPController(IConfiguration config, IOptions<GlobalToken> token)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
            this.rutaI = this._config.GetSection("Comfama:RutaI").Value;
            this.currentToken = token.Value;
        }

        [HttpPost]
        public async Task<IActionResult> index([FromBody] CreateBPrequest request)
        {
            Http http = new();
            StringBuilder log = new();
            log.Append($"Entrada controlador: {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff")}");

            try
            {
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

                    string requestXml = Deserialize.Serialize<CreateBPrequest>(request, this.openTagXml, this.closeTagXml);
                    log.Append($"\nTrama envio: \n{requestXml}");

                    CreateBPResponse response = await http.postXMLData<CreateBPResponse>(this.url, this.tokenParams.client_id, requestXml, AuthorizationEnum.AUTHORIZATION, this.currentToken.AccessToken).ConfigureAwait(false);
                    log.Append($"\nTrama regreso: {JsonConvert.SerializeObject(response)}");

                    Log.write(log.ToString(), this.rutaI, ControllersNames.Create);
                    log.Clear();
                    return Ok(response);
                }
                else
                {
                    log.Append("\nSalida controlador");
                    Log.write(log.ToString(), this.rutaI, ControllersNames.Create);
                    log.Clear();
                    return StatusCode(500);
                }
            }
            catch (Exception e)
            {
                log.Append("\n" + e.ToString());
                Log.write(log.ToString(), this.rutaI, ControllersNames.Create);
                log.Clear();
                return StatusCode(500);
            }
        }
    }
}
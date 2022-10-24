using WSGYG63.Models.UpdateBP;
using WSGYG63.Models.Token;
using WSGYG63.Shared.Functions;
using WSGYG63.Shared.Enums;
using Newtonsoft.Json;

namespace WSGYG63.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ActualizarBPController : Controller
    {
        private string url { get; set; }
        private readonly IConfiguration _config;
        private readonly string complement = "//OAuth_APIM/GenerateToken";
        private TokenResponse tokenResponse;
        private TokenParams tokenParams;
        private readonly string openTagXml = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:urn='urn:sap-com:document:sap:rfc:functions'><soapenv:Header/><soapenv:Body><urn:ZFM_ACTUALIZAR_BPDATOSGENER>";
        private readonly string closeTagXml = "</urn:ZFM_ACTUALIZAR_BPDATOSGENER></soapenv:Body></soapenv:Envelope>";

        public ActualizarBPController(IConfiguration config)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
        }

        //Estaba trabajándolo de esta forma, que la verdad no sé si está muy bien. Pero siempre
        //me estaba dando error y los response me los devolvía null
        //[HttpPost]
        //public async Task<IActionResult> Index([FromBody] TokenResponse request)
        //{
        //    Http http = new();
        //    try
        //    {
        //        string requestXml = Deserialize.Serialize<TokenResponse>(request);
        //        string content_type = "application/json";
        //        TokenResponse response = await http.GetToken<TokenResponse>(this.url, tokenParams.client_id, content_type, requestXml).ConfigureAwait(false);
        //        return Ok(response);
        //    }
        //    catch (Exception e)
        //    {
        //        // escribir en log
        //        throw;
        //    }
        //}
        [HttpPost]
        public async Task<IActionResult> index([FromBody] UpdateBPRequest request)
        {
            Http http = new();
            try
            {
                string requestXml = Deserialize.Serialize<UpdateBPRequest>(request, this.openTagXml, this.closeTagXml);
                UpdateBPResponse response = await http.postXMLData<UpdateBPResponse>(this.url, this.tokenParams.client_id, requestXml, AuthorizationEnum.ACCES_TOKEN).ConfigureAwait(false);
                return Ok(response);
            }
            catch (Exception e)
            {
                // escribir en log
                return StatusCode(500);
            }
        }
    }
}

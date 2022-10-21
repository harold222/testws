using WSGYG.Models.CreateBP;
using WSGYG.Models.Token;
using WSGYG.Shared.Enums;
using WSGYG.Shared.Functions;

namespace WSGYG.Controllers
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

        public CreacionBPController(IConfiguration config)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
        }

        [HttpPost]
        public async Task<IActionResult> index([FromBody] CreateBPrequest request)
        {
            Http http = new();
            try
            {
                string requestXml = Deserialize.Serialize<CreateBPrequest>(request, this.openTagXml, this.closeTagXml);
                CreateBPResponse response = http.postXMLData<CreateBPResponse>(this.url, this.tokenParams.client_id, requestXml, AuthorizationEnum.AUTHORIZATION);
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
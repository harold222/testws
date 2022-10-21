using Microsoft.AspNetCore.Mvc;
using WSGYG.Models.AssignBP;
using WSGYG.Models.Token;
using WSGYG.Shared.Enums;
using WSGYG.Shared.Functions;

namespace WSGYG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AsignarRolesBPController : ControllerBase
    {
        private string url { get; set; }
        private readonly IConfiguration _config;
        private readonly string complement = "/ActualizaRolesBPCRM";
        private TokenParams tokenParams;
        private readonly string openTagXml = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:urn='urn:sap-com:document:sap:soap:functions:mc-style'><soapenv:Header/><soapenv:Body>";
        private readonly string closeTagXml = "</soapenv:Body></soapenv:Envelope>";

        public AsignarRolesBPController(IConfiguration config)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
        }

        [HttpPost]
        public async Task<IActionResult> index([FromBody] AssignBPRequest request)
        {
            Http http = new();
            try
            {
                string requestXml = Deserialize.Serialize<AssignBPRequest>(request, this.openTagXml, this.closeTagXml);
                AssignBPResponse response = await http.postXMLData<AssignBPResponse>(this.url, this.tokenParams.client_id, requestXml, AuthorizationEnum.ACCES_TOKEN).ConfigureAwait(false);
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

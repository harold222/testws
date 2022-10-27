using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WSGYG63.Models.AssignBP;
using WSGYG63.Models.Token;
using WSGYG63.Shared.Enums;
using WSGYG63.Shared.Functions;

namespace WSGYG63.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AsignarRolesBPController : ControllerBase
    {
        private string url { get; set; }
        private readonly IConfiguration _config;
        private readonly string complement = "/ActualizaRolesBPCRM";
        private TokenParams tokenParams;
        private readonly string openTagXml = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:urn='urn:sap-com:document:sap:soap:functions:mc-style'><soapenv:Header/><soapenv:Body><urn:ZSdserviciosCargaRol>";
        private readonly string closeTagXml = "<ImTest></ImTest></urn:ZSdserviciosCargaRol></soapenv:Body></soapenv:Envelope>";
        private GlobalToken currentToken;

        public AsignarRolesBPController(IConfiguration config, IOptions<GlobalToken> token)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
            this.currentToken = token.Value;
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

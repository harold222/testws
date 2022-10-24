using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WSGYG63.Models.AssignSaleAreaBP;
using WSGYG63.Models.Token;
using WSGYG63.Shared.Enums;
using WSGYG63.Shared.Functions;

namespace WSGYG63.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AsignarAreaVentaBPController : ControllerBase
    {
        private string url { get; set; }
        private readonly IConfiguration _config;
        private readonly string complement = "/ActualizaAreasVentasBP";
        private TokenParams tokenParams;
        private readonly string openTagXml = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:urn='urn:sap-com:document:sap:rfc:functions'><soapenv:Header/><soapenv:Body><urn:Z_SDSERVICIOS_CARGA_BP>";
        private readonly string closeTagXml = "<I_TEST></I_TEST></urn:Z_SDSERVICIOS_CARGA_BP></soapenv:Body></soapenv:Envelope>";
        private readonly GlobalToken currentToken;

        public AsignarAreaVentaBPController(IConfiguration config, IOptions<GlobalToken> token)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
            this.currentToken = token.Value;
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody] AssignSaleAreaBPRequest request)
        {
            Http http = new();
            try
            { 
                if (request.item?.Count > 0)
                {
                    request.item.ForEach(item =>
                    {
                        if (!string.IsNullOrEmpty(item.Partner))
                            item.Partner = item.Partner.Trim().PadLeft(10, '0');
                    });
                }

                string requestXml = Deserialize.Serialize<AssignSaleAreaBPRequest>(request, this.openTagXml, this.closeTagXml);
                AssignSaleAreaBPResponse response = await http.postXMLData<AssignSaleAreaBPResponse>(this.url, this.tokenParams.client_id, requestXml, AuthorizationEnum.ACCES_TOKEN).ConfigureAwait(false);
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

using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WSGYG.Models.QueryBP;
using WSGYG.Models.QueryBP.Response;
using WSGYG.Models.Token;
using WSGYG.Shared.Functions;

namespace WSGYG.Controllers
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

        public ConsultaBPController(IConfiguration config)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
        }

        [HttpGet]
        public async Task<IActionResult> index([FromQuery] QueryBPRequest request)
        {
            Http http = new();

            try
            {
                Dictionary<string, string?>? requestDict = this.toDict.Trasform<QueryBPRequest>(request);
                QueryBPResponseXML? response = await http.GETAsync<QueryBPResponseXML, QueryBPRequest>(this.url, this.tokenParams.client_id, requestDict, "ogCcLVNmPgZZQJEwV5sQdmgNHzUf").ConfigureAwait(false);
                return Ok(response);
            }
            catch (Exception e)
            {
                // determinar la causa del error del http para enviar su respectivo codigo
                return StatusCode(500);
            }
        }
    }
}

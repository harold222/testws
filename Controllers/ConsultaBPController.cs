using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Reflection;
using WSGYG63.Models.QueryBP;
using WSGYG63.Models.Token;
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

        private readonly GlobalToken currentToken;

        public ConsultaBPController(IConfiguration config, IOptions<GlobalToken> token)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
            this.currentToken = token.Value;
        }

        [HttpGet]
        public async Task<IActionResult> index([FromQuery] QueryBPRequest request)
        {
            Http http = new();

            try
            {
                Dictionary<string, string?>? requestDict = this.toDict.Trasform<QueryBPRequest>(request);
                QueryBPResponse? response = await http.GETAsync<QueryBPResponse, QueryBPRequest>(this.url, this.tokenParams.client_id, requestDict).ConfigureAwait(false);
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

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WSGYG63.Models.AssignBankAccountBP;
using WSGYG63.Models.Token;
using WSGYG63.Shared.Functions;

namespace WSGYG63.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AsignarCuentaBancariaBPController : ControllerBase
    {
        private string url { get; set; }
        private readonly IConfiguration _config;
        private readonly string complement = "/CuentaBancoBp";
        private TokenParams tokenParams;
        private readonly GlobalToken currentToken;

        public AsignarCuentaBancariaBPController(IConfiguration config, IOptions<GlobalToken> token)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
            this.currentToken = token.Value;
        }

        [HttpPost]
        public async Task<IActionResult> index([FromBody] AssignBankAccountBPRequest request)
        {
            Http http = new();

            try
            {
                AssignBankAccountBPResponse response = await http.PostFromUrl<AssignBankAccountBPResponse>(this.url, request);
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

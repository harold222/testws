using Microsoft.AspNetCore.Mvc;
using WSGYG.Models.UpdateBP;
using WSGYG.Models.Token;
using WSGYG.Shared.Functions;

namespace WSGYG.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class UpdateBPController : Controller
    {
        private string url { get; set; }
        private readonly IConfiguration _config;
        private readonly string complement = "ActualizaBPCRM";
        private ModelToDictionary toDict = new();
        private TokenParams tokenParams;

        public UpdateBPController(IConfiguration config)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FIRSTNAME, MIDDLENAME, LASTNAME, SECONDNAME, STREET, CITY, COUNTRY, REGION, LANGU, MOVIL, FAX")] Bd bd)
        {
            return View(bd);
        }
    }
}

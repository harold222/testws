using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml.Serialization;
using WSGYG.Models.CreateBP;
using WSGYG.Models.Token;
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
        private ModelToDictionary toDict = new();
        private TokenParams tokenParams;

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
                CreateBPResponse response = new();

                var d = Deserialize.Serialize<CreateBPrequest>(request);

                string s = JsonConvert.SerializeObject(request);
                System.Xml.XmlDocument? a = JsonConvert.DeserializeXmlNode(s, "I_ES_DATA_BP");

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
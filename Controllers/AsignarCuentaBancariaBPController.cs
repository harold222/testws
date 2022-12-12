using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;
using WSGYG63.Models.AssignBankAccountBP;
using WSGYG63.Models.Token;
using WSGYG63.Shared.Enums;
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
        private GlobalToken currentToken = new();
        private string rutaI { get; set; }


        public AsignarCuentaBancariaBPController(IConfiguration config, IOptions<GlobalToken> token)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
            this.rutaI = this._config.GetSection("Comfama:RutaI").Value;
            this.currentToken = token.Value;
        }

        [HttpPost]
        public async Task<IActionResult> index([FromBody] AssignBankAccountBPRequest request)
        {
            Http http = new();
            StringBuilder log = new();
            log.Append($"Entrada controlador: {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff")}");

            try
            {
                TimeSpan horaii = DateTime.Parse(DateTime.Now.ToString("o")).TimeOfDay;

                GlobalToken? newOrCurrentToken = await new RefreshToken().verify(
                    this.url,
                    this.tokenParams,
                    log,
                    this.currentToken?.UrlToken,
                    this.currentToken?.AccessToken,
                    this.currentToken?.DateExpire,
                    this.currentToken?.DataToGetToken).ConfigureAwait(false);

                if (newOrCurrentToken != null)
                {
                    if (this.currentToken?.AccessToken != newOrCurrentToken.AccessToken)
                    {
                        this.currentToken.AccessToken = newOrCurrentToken.AccessToken;
                        this.currentToken.UrlToken = newOrCurrentToken.UrlToken;
                        this.currentToken.DataToGetToken = newOrCurrentToken.DataToGetToken;
                        this.currentToken.DateExpire = newOrCurrentToken.DateExpire;
                    }

                    log.Append($"{Environment.NewLine}Trama envio: {JsonConvert.SerializeObject(request)}");

                    AssignBankAccountBPResponse response = await http.PostFromUrl<AssignBankAccountBPResponse>(
                        this.url,
                        request,
                        this.tokenParams.client_id,
                        log,
                        this.currentToken.AccessToken,
                        "properties"
                    ).ConfigureAwait(false);
                    
                    if (response != null)
                    {
                        TimeSpan horaf = DateTime.Parse(DateTime.Now.ToString("o")).TimeOfDay;
                        string horaff = (horaf - horaii).ToString();

                        log.Append($"{Environment.NewLine}Trama regreso: {JsonConvert.SerializeObject(response)}");
                        log.Append($"{Environment.NewLine}Tiempo total: {horaff} segundos.");
                        Log.write(log.ToString(), this.rutaI, ControllersNames.AssignBank);
                        log.Clear();

                        return Ok(new ResponseAssignBank
                        {
                             Response = response,
                        });
                    }
                    else
                    {
                        log.Append($"{Environment.NewLine}Salida controlador");
                        Log.write(log.ToString(), this.rutaI, ControllersNames.AssignBank);
                        log.Clear();

                        return StatusCode(400);
                    }
                }
                else
                {
                    log.Append($"{Environment.NewLine}Salida controlador");
                    Log.write(log.ToString(), this.rutaI, ControllersNames.AssignBank);
                    log.Clear();

                    return StatusCode(400);
                }
            }
            catch (Exception e)
            {
                log.Append(Environment.NewLine + e.ToString());
                Log.write(log.ToString(), this.rutaI, ControllersNames.AssignBank);
                log.Clear();

                return StatusCode(400);
            }
        }
    }
}

using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
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
        private GlobalToken currentToken = new();
        private string rutaI { get; set; }

        public AsignarRolesBPController(IConfiguration config, IOptions<GlobalToken> token)
        {
            this._config = config;
            this.url = this._config.GetSection("Comfama:host").Value + complement;
            this.tokenParams = this._config.GetSection("Comfama:token").Get<TokenParams>();
            this.rutaI = this._config.GetSection("Comfama:RutaI").Value;
            this.currentToken = token.Value;
        }

        //[NonAction]
        //private static XElement RemoveAllNamespaces(XElement xmlDocument)
        //{
        //    if (!xmlDocument.HasElements)
        //    {
        //        XElement xElement = new XElement(xmlDocument.Name.LocalName);
        //        xElement.Value = xmlDocument.Value;

        //        foreach (XAttribute attribute in xmlDocument.Attributes())
        //            xElement.Add(attribute);

        //        return xElement;
        //    }
        //    return new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNamespaces(el)));
        //}

        [HttpPost]
        public async Task<IActionResult> index([FromBody] AssignBPRequest request)
        {
            //try
            //{
            //    List<string> specifPrefix = new List<string>
            //    {
            //        "n0",
            //        "soap-env"
            //    };

            //    string xmlResponse = "<soap-env:Envelope xmlns:soap-env='http://schemas.xmlsoap.org/soap/envelope/'><soap-env:Header/><soap-env:Body><n0:ZSdserviciosCargaRolResponse xmlns:n0='urn:sap-com:document:sap:soap:functions:mc-style'><ExTreturn></ExTreturn></n0:ZSdserviciosCargaRolResponse></soap-env:Body></soap-env:Envelope>";

            //    if (specifPrefix != null)
            //    {
            //        specifPrefix.ForEach(@namespace =>
            //        {
            //            // remove specific prefix tag example = soap-env:body -> body
            //            xmlResponse = Regex.Replace(xmlResponse, $@"((?<=\</|\<){@namespace}:|xmlns:{@namespace}=""[^""]+"")", "");
            //        });
            //    }

            //    string searchTag = "ExTreturn";

            //    if (!string.IsNullOrEmpty(searchTag))
            //    {
            //        // remove all prefixes in tags example = n0:head -> head
            //        xmlResponse = Regex.Replace(xmlResponse, @"(<\s*\/?)\s*(\w+):(\w+)", "$1$3");

            //        XDocument xdoc = XDocument.Parse(xmlResponse);

            //        List<XElement> allTagsWithoutNamespaces = new();

            //        foreach (var item in xdoc.Descendants())
            //        {
            //            allTagsWithoutNamespaces.Add(RemoveAllNamespaces(item));
            //        }

            //        // get tag inside other tags
            //        IEnumerable<XElement>? specificTag = allTagsWithoutNamespaces.Descendants(searchTag);

            //        if (specificTag.Count() > 0)
            //        {
            //            xmlResponse = specificTag.First().ToString(SaveOptions.DisableFormatting);
            //        }

            //        var a = Deserialize.Xml<AssignBPResponse>(xmlResponse);

            //        return Ok(a);
            //    }
            //}
            //catch (Exception e)
            //{

            //    throw;
            //}


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

                    if (request.item.Count > 0)
                    {
                        var partners = request.item.First().PartnerRole.item.Where(item => 
                            !string.IsNullOrEmpty(item.PartnerRole));

                        request.item.First().PartnerRole.item = partners.ToList();
                    }

                    string requestXml = Deserialize.Serialize<AssignBPRequest>(request, this.openTagXml, this.closeTagXml);
                    log.Append($"{Environment.NewLine}Trama envio: {Environment.NewLine}{requestXml}");

                    AssignBPResponse response = await http.postXMLData<AssignBPResponse>(
                        this.url,
                        this.tokenParams.client_id,
                        requestXml,
                        AuthorizationEnum.ACCES_TOKEN,
                        this.currentToken.AccessToken,
                        "ExTreturn",
                        new List<string>
                        {
                            "n0",
                            "soap-env"
                        },
                        log
                    ).ConfigureAwait(false);
                    
                    log.Append($"{Environment.NewLine}Trama regreso: {JsonConvert.SerializeObject(response)}");
                    
                    TimeSpan horaf = DateTime.Parse(DateTime.Now.ToString("o")).TimeOfDay;
                    string horaff = (horaf - horaii).ToString();

                    log.Append($"{Environment.NewLine}Tiempo total: {horaff} segundos.");
                    Log.write(log.ToString(), this.rutaI, ControllersNames.AssignRoles);
                    log.Clear();

                    return Ok(response);
                }
                else
                {
                    log.Append($"{Environment.NewLine}Salida controlador");
                    Log.write(log.ToString(), this.rutaI, ControllersNames.AssignRoles);
                    log.Clear();

                    return StatusCode(400);
                }
            }
            catch (Exception e)
            {
                log.Append(Environment.NewLine + e.ToString());
                Log.write(log.ToString(), this.rutaI, ControllersNames.AssignRoles);
                log.Clear();

                return StatusCode(400);
            }
        }
    }
}

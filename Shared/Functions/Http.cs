using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using WSGYG63.Shared.Enums;

namespace WSGYG63.Shared.Functions
{
    public class Http
    {
        public async Task<TResponse> GETAsync<TResponse, TRequest>(string url, string apiKey, IDictionary<string, string>? dict = null, string? accessToken = null, string searchTag = "")
        {
            if (dict != null)
                url += QueryString(dict);

            HttpWebRequest web = WebRequest.Create(url) as HttpWebRequest;

            web.Method = "GET";
            //web.ContentType = "text/xml; charset='utf-8'";
            web.Headers.Add("apikey", apiKey);

            if (!string.IsNullOrEmpty(accessToken))
                web.Headers.Add("Authorization", $"Bearer {accessToken}");

            HttpWebResponse response = (HttpWebResponse)await web.GetResponseAsync().ConfigureAwait(false);

            Stream stream = response.GetResponseStream();

            Encoding encoding = Encoding.Default;
            ContentType contentType = new ContentType(response.Headers[HttpResponseHeader.ContentType]);

            if (!string.IsNullOrEmpty(contentType.CharSet))
                encoding = Encoding.GetEncoding(contentType.CharSet);

            string text;
            using (StreamReader reader = new StreamReader(stream, encoding))
            {
                text = await reader.ReadToEndAsync().ConfigureAwait(false);
            }

            if (!string.IsNullOrEmpty(searchTag))
            {
                try
                {
                    // remove attributes in tag example = m:properties -> properties
                    text = Regex.Replace(text, @"(<\s*\/?)\s*(\w+):(\w+)", "$1$3");

                    XDocument xdoc = XDocument.Parse(text);

                    // get tag inside other tags
                    IEnumerable<XElement>? specificTag = xdoc.Descendants(searchTag);

                    if (specificTag.Count() > 0)
                        text = specificTag.First().ToString(SaveOptions.DisableFormatting);
                }
                catch (Exception e){}
            }

            return Deserialize.Xml<TResponse>(text);
        }

        public async Task<TResponse> postXMLData<TResponse>(string url, string apiKey, string requestXml, AuthorizationEnum typeAuth,string? accessToken = null, string? searchTag = "", List<string>? specifPrefix = null)
        {
            HttpWebRequest web = (HttpWebRequest)WebRequest.Create(url);
            byte[] bytes = Encoding.ASCII.GetBytes(requestXml);
            web.ContentType = "text/xml; encoding='utf-8'";
            web.ContentLength = bytes.Length;
            web.Method = "POST";

            web.Headers.Add("apikey", apiKey);

            if (!string.IsNullOrEmpty(accessToken))
            {
                switch (typeAuth)
                {
                    case AuthorizationEnum.AUTHORIZATION:
                        web.Headers.Add("Authorization", $"Bearer {accessToken}");
                        break;
                    case AuthorizationEnum.ACCES_TOKEN:
                        web.Headers.Add("access_token", accessToken);
                        break;
                }
            }

            Stream requestStream = web.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();

            HttpWebResponse response = (HttpWebResponse)await web.GetResponseAsync().ConfigureAwait(false);
            Stream responseStream = response.GetResponseStream();
            // Get response in XML
            string responseStr = new StreamReader(responseStream).ReadToEnd();

            try
            {
                if (specifPrefix != null)
                {
                    specifPrefix.ForEach(@namespace =>
                    {
                        // remove specific prefix tag example = soap-env:body -> body
                        responseStr = Regex.Replace(responseStr, $@"((?<=\</|\<){@namespace}:|xmlns:{@namespace}=""[^""]+"")", "");
                    });
                }
                
                if (!string.IsNullOrEmpty(searchTag))
                {
                    // remove all prefixes in tags example = n0:head -> head
                    responseStr = Regex.Replace(responseStr, @"(<\s*\/?)\s*(\w+):(\w+)", "$1$3");

                    XDocument xdoc = XDocument.Parse(responseStr);

                    // get tag inside other tags
                    IEnumerable<XElement>? specificTag = xdoc.Descendants(searchTag);

                    if (specificTag.Count() > 0)
                        responseStr = specificTag.First().ToString(SaveOptions.DisableFormatting);
                }
            }
            catch (Exception e) { }

            return Deserialize.Xml<TResponse>(responseStr);
        }

        //public TResponse PostExpedia<TResponse>(string url, string apiKey, object postData, string? accessToken)
        //{
        //    HttpWebRequest web = (HttpWebRequest)WebRequest.Create(url);

        //    web.Method = "POST";
        //    web.ContentType = "text/xml; encoding='utf-8'";
        //    web.Headers.Add("apikey", apiKey);

        //    if (!string.IsNullOrEmpty(accessToken))
        //        web.Headers.Add("Authorization", $"Bearer {accessToken}");

        //    using (StreamWriter streamWriter = new StreamWriter(web.GetRequestStream()))
        //    {
        //        string data = JsonConvert.SerializeObject(postData);
        //        streamWriter.Write(data);
        //    }

        //    string text;
        //    using (HttpWebResponse response = (HttpWebResponse)web.GetResponse())
        //    {
        //        // Get the stream associated with the response.
        //        Stream stream = response.GetResponseStream();
        //        Encoding encoding = Encoding.UTF8;
        //        ContentType contentType = new ContentType(response.Headers[HttpResponseHeader.ContentType]);
        //        if (!string.IsNullOrEmpty(contentType.CharSet))
        //        {
        //            encoding = Encoding.GetEncoding(contentType.CharSet);
        //        }

        //        using (StreamReader reader = new StreamReader(stream, encoding))
        //        {
        //            text = reader.ReadToEnd();
        //        }
        //    }

        //    return Deserialize.Xml<TResponse>(text);
        //}

        //public async Task<XmlDocument> ObtenerInformacionTotalStay(string url, string xmlinput)
        //{
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        //    string postData = "Data=" + xmlinput;
        //    byte[] data = Encoding.ASCII.GetBytes(postData);

        //    request.Method = "POST";
        //    request.ContentType = "application/x-www-form-urlencoded";
        //    request.ContentLength = data.Length;
        //    request.AutomaticDecompression = DecompressionMethods.GZip;
        //    // Set some reasonable limits on resources used by this request
        //    request.MaximumAutomaticRedirections = 4;
        //    request.MaximumResponseHeadersLength = 4;
        //    // Set credentials to use for this request.
        //    request.Credentials = CredentialCache.DefaultCredentials;

        //    using (Stream stream = await request.GetRequestStreamAsync())
        //    {
        //        await stream.WriteAsync(data, 0, data.Length);
        //    }

        //    HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

        //    string text = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();


        //    XmlDocument xDoc = new XmlDocument();
        //    xDoc.LoadXml(text);

        //    return xDoc;
        //}

        public async Task<Response> GetToken<Response>(string url, string apikey, IDictionary<string, string> dict, StringBuilder? log = null)
        {
            Response returnObject = default;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Content-Typen", "text/xml");
                httpClient.DefaultRequestHeaders.Add("apikey", apikey);

                httpClient.Timeout = TimeSpan.FromHours(10);

                if (!dict.ContainsKey("Content-Type"))
                    dict.Add("Content-Type", "application/x-www-form-urlencoded");

                using HttpResponseMessage response = await httpClient.PostAsync(url, new FormUrlEncodedContent(dict));

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    returnObject = JsonConvert.DeserializeObject<Response>(apiResponse);

                    if (log != null)
                        log.Append($"\nTrama respuesta token = {apiResponse}");
                }
                else
                {
                    if (log != null)
                    {
                        try
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            log.Append($"\nTrama respuesta token = {apiResponse}");
                        }
                        catch (Exception e)
                        {
                            if (response != null)
                                log.Append($"\nError get token: {e.Message.ToString()}");
                            else
                                log.Append($"\nError get token: {e.Message.ToString()} - status: {response.StatusCode}");
                        }
                    }
                }
            }

            return returnObject;
        }

        public async Task<Response> PostFromUrl<Response>(string url, object body, string apiKey, StringBuilder log, string accessToken = null, string? searchTag = "")
        {
            Response returnObject = default;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromHours(10);

                if (accessToken != null)
                    httpClient.DefaultRequestHeaders.Add("access_token", accessToken);

                httpClient.DefaultRequestHeaders.Add("apikey", apiKey);

                using HttpResponseMessage response = await httpClient.PostAsJsonAsync(url, body);

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    log.Append($"\nTrama respuesta: {apiResponse}");


                    if (!string.IsNullOrEmpty(searchTag))
                    {
                        try
                        {
                            // remove all prefixes in tags example = n0:head -> head
                            apiResponse = Regex.Replace(apiResponse, @"(<\s*\/?)\s*(\w+):(\w+)", "$1$3");

                            XDocument xdoc = XDocument.Parse(apiResponse);

                            // get tag inside other tags
                            IEnumerable<XElement>? specificTag = xdoc.Descendants(searchTag);

                            if (specificTag.Count() > 0)
                                apiResponse = specificTag.First().ToString(SaveOptions.DisableFormatting);
                        }
                        catch (Exception e){}
                    }

                    returnObject = Deserialize.Xml<Response>(apiResponse);
                }
                else
                {
                    try
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        log.Append($"\nTrama respuesta: {apiResponse}");
                    }
                    catch (Exception e)
                    {
                        if (response != null)
                            log.Append($"\nError get token: {e.Message.ToString()}");
                        else
                            log.Append($"\nError get token: {e.Message.ToString()} - status: {response.StatusCode}");
                    }
                }
            }

            return returnObject;
        }

        private static string QueryString(IDictionary<string, string> dict)
        {
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> item in dict)
            {
                list.Add(item.Key + "=" + item.Value);
            }

            return $"?{string.Join("&", list)}";
        }
    }
}

using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace WSGYG.Shared.Functions
{
    public class Http
    {
        public async Task<TResponse> GETAsync<TResponse, TRequest>(string url, string apiKey, IDictionary<string, string>? dict = null, string? accessToken = null)
        {
            if (dict != null)
                url += QueryString(dict);

            HttpWebRequest web = WebRequest.Create(url) as HttpWebRequest;

            web.Method = "GET";
            web.ContentType = "text/xml; charset=utf-8";
            web.Headers.Add("apikey", apiKey);

            if (!string.IsNullOrEmpty(accessToken))
                web.Headers.Add("Authorization", $"Bearer {accessToken}");

            HttpWebResponse response = (HttpWebResponse)await web.GetResponseAsync().ConfigureAwait(false);

            // Get the stream associated with the response.
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

            return Deserialize.Xml<TResponse>(text);
        }

        public static async Task<Response> PostFromUrl<Response>(string url, object body, string accessToken = null)
        {
            Response returnObject = default;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromHours(10);
                if (accessToken != null)
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                }

                using HttpResponseMessage response = await httpClient.PostAsJsonAsync(url, body);
                string apiResponse = await response.Content.ReadAsStringAsync();
                returnObject = JsonConvert.DeserializeObject<Response>(apiResponse);
            }

            return returnObject;
        }

        public static string QueryString(IDictionary<string, string> dict)
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

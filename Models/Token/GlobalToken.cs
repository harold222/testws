namespace WSGYG63.Models.Token
{
    public class GlobalToken
    {
        public string UrlToken { get; set; }

        public Dictionary<string, string> DataToGetToken { get; set; }

        public string AccessToken { get; set; }

        public string ExpiresIn { get; set; }

        public DateTime DateExpire { get; set; }
    }
}

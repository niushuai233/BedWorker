using Newtonsoft.Json;

namespace BedWorker.Entity
{
    public class GiteeAuthResponse
    {
        [JsonProperty("access_token")]
        private string access_token;
        public string AccessToken
        {
            get { return access_token; }
            set { access_token = value; }
        }
        [JsonProperty("token_type")]
        private string token_type { get; set; }
        public string TokenType
        {
            get { return token_type; }
            set { token_type = value; }
        }
        [JsonProperty("expires_in")]
        private string expires_in { get; set; }
        public string ExpiresIn
        {
            get { return expires_in; }
            set { expires_in = value; }
        }
        [JsonProperty("refresh_token")]
        private string refresh_token { get; set; }
        public string RefreshToken
        {
            get { return refresh_token; }
            set { refresh_token = value; }
        }
        [JsonProperty("scope")]
        private string scope { get; set; }
        public string Scope
        {
            get { return scope; }
            set { scope = value; }
        }
        [JsonProperty("created_at")]
        private string created_at { get; set; } 
        public string CreatedAt
        {
            get { return created_at; }
            set { created_at = value; }
        }
    }
}

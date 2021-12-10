using Newtonsoft.Json;

namespace BedWorker.Entity.Gitee
{
    public class GiteeUserInfo
    {
        [JsonProperty("id")]
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        [JsonProperty("name")]
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [JsonProperty("email")]
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [JsonProperty("login")]
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        [JsonProperty("url")]
        private string url;
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        [JsonProperty("avatar_url")]
        private string avatar_url;
        public string AvatarUrl
        {
            get { return avatar_url; }
            set { avatar_url = value; }
        }
        [JsonProperty("repos_url")]
        private string repos_url;
        public string ReposUrl
        {
            set { repos_url = value; }
            get { return repos_url; }
        }
    }
}

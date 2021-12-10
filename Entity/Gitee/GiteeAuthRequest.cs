namespace BedWorker.Entity.Gitee
{
    public class GiteeAuthRequest
    {
        private string GrantType;
        public string grant_type
        {
            get { return GrantType; }
            set { GrantType = value; }
        }
        private string Code;
        public string code
        {
            get { return Code; }
            set { Code = value; }
        }
        private string ClientId;
        public string client_id
        {
            get { return ClientId; }
            set { ClientId = value; }
        }
        private string ClientSecret;
        public string client_secret
        {
            get { return ClientSecret; }
            set { ClientSecret = value; }
        }
        private string RedirectUri;
        public string redirect_uri
        {
            get { return RedirectUri; }
            set { RedirectUri = value; }
        }
    }
}

namespace BedWorker.Utils
{
    public class UrlConstant
    {
        public static string HttpServer = "http://localhost:65501/BedWorker/";
        public static string Gitee_GetCode = "https://gitee.com/oauth/authorize?client_id={0}&redirect_uri={1}&response_type=code";
        public static string Gitee_Code2Token = "https://gitee.com/oauth/token?grant_type=authorization_code&code={0}&client_id={1}&redirect_uri={2}&client_secret={3}";
        public static string Gitee_Userinfo = "https://gitee.com/api/v5/user";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedWorker.Utils
{
    public class UrlConstant
    {
        public static string Url_HttpServer = "http://localhost:65501/BedWorker/";
        public static string Url_Gitee_GetCode = "https://gitee.com/oauth/authorize?client_id={0}&redirect_uri={1}&response_type=code";
        public static string Url_Gitee_Code2Token = "https://gitee.com/oauth/token?grant_type=authorization_code&code={0}&client_id={1}&redirect_uri={2}&client_secret={3}";
    }
}

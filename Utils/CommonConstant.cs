using System;

namespace BedWorker.Utils
{
    public class CommonConstant
    {
        /// <summary>
        /// 用户主目录
        /// </summary>
        public static string USER_PROFILE_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        /// <summary>
        /// 配置文件名称
        /// </summary>
        public static string CONFIG_FILENAME = "bedworker.xml";
        /// <summary>
        /// 默认代理主机
        /// </summary>
        public static string Default_Proxy_Host = "127.0.0.1";
        /// <summary>
        /// 默认代理端口
        /// </summary>
        public static int Default_Proxy_Port = 7890;

        public static string GITEE_REDIRECT_URI = "http://localhost:65501/BedWorker/login";

        /// <summary>
        /// gitee 第三方应用id
        /// </summary>
        public static string GITEE_CLIENT_ID = "950e8a9fd2ef1121dfb84d2d1041ccb7cdb1aed4c10bf87bf66ddd0986d24cd9";
        /// <summary>
        /// gitee 第三方应用秘钥
        /// </summary>
        public static string GITEE_CLIENT_SECRET = "3e6f0d911ccf293bd89ceed01f4812570f4e56442136966347683ee10f03124a";

        public const string GITEE_AUTHORIZATION_CODE = "authorization_code";
    }
}

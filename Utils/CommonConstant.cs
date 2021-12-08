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
    }
}

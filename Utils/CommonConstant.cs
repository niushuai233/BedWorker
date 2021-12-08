using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// 配置文件位置
        /// </summary>
        /// <returns>配置文件全路径</returns>
        public static string GetConfigLocation()
        {
            return CommonConstant.USER_PROFILE_DIRECTORY + "/" + CommonConstant.CONFIG_FILENAME;
        }


        [Obsolete]
        public static string GetSystemProxyProtocol()
        {
            Uri proxyAddress = System.Net.WebProxy.GetDefaultProxy().Address;
            if (null == proxyAddress)
            {
                return null;
            }
            return proxyAddress.Scheme;
        }
        [Obsolete]
        public static string GetSystemProxyHost ()
        {
            Uri proxyAddress = System.Net.WebProxy.GetDefaultProxy().Address;
            if (null == proxyAddress)
            {
                return null;
            }
            return proxyAddress.Host;
        }

        [Obsolete]
        public static int GetSystemProxyPort ()
        {
            Uri proxyAddress = System.Net.WebProxy.GetDefaultProxy().Address;
            if (null == proxyAddress)
            {
                return 0;
            }
            return proxyAddress.Port;
        }
    }
}

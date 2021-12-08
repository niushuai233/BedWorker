using System;

namespace BedWorker.Utils
{
    public class CommonUtil
    {

        /// <summary>
        /// 配置文件位置
        /// </summary>
        /// <returns>配置文件全路径</returns>
        public static string GetConfigLocation()
        {
            return CommonConstant.USER_PROFILE_DIRECTORY + "/" + CommonConstant.CONFIG_FILENAME;
        }


        public static string GetSystemProxyProtocol()
        {
            Uri proxyAddress = System.Net.WebProxy.GetDefaultProxy().Address;
            if (null == proxyAddress)
            {
                return null;
            }
            return proxyAddress.Scheme;
        }
        public static string GetSystemProxyHost()
        {
            Uri proxyAddress = System.Net.WebProxy.GetDefaultProxy().Address;
            if (null == proxyAddress)
            {
                return null;
            }
            return proxyAddress.Host;
        }

        public static int GetSystemProxyPort()
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

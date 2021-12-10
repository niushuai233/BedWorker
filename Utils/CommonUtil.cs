using System;
using System.Collections.Generic;
using System.Reflection;

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

        public static string Data2GetQuery(Dictionary<string, object> dict, bool startWithQuestion = true)
        {
            string res = "";
            if (startWithQuestion)
            {
                res += "?";
            }
            foreach (var item in dict)
            {
                res += item.Key + "=" + item.Value + "&";
            }
            return res + "time=" + 1;
        }

        public static string GetValueByKeyFromUrl(string url, string code)
        {
            Uri uri = new Uri(url);

            string[] paramArr = uri.Query.Split('?');
            if (null != paramArr && 2 == paramArr.Length)
            {
                foreach (var item in paramArr)
                {
                    string[] keyValue = item.Split('=');
                    if (keyValue[0].Equals(code))
                    {
                        return keyValue[1];
                    }
                }
            }

            return "";
        }

        public static Dictionary<string, object> Object2Dict<T>(T obj, bool ignoreGetMethod = false)
        {
            if (obj is Dictionary<string, object>)
            {
                return (Dictionary<string, object>)Convert.ChangeType(obj, typeof(Dictionary<string, object>));
            }

            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static |BindingFlags.Instance);

            foreach (var property in properties)
            {
                MethodInfo method = property.GetGetMethod();

                if (null == method && !ignoreGetMethod)
                {
                    // 设null
                    dictionary.Add(property.Name, null);
                } 
                else
                {
                    // 获取实际值
                    dictionary.Add(property.Name, method.Invoke(obj, new object[] { }));
                }
            }

            return dictionary;
        }
    }
}

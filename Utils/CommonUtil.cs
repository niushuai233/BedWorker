﻿using BedWorker.Entity.Base;
using System;
using System.Collections.Generic;
using System.IO;
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

        public static string Data2GetQuery(MapExt dict, bool startWithQuestion = true)
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

        public static string GetRandomFilePath(string filePath)
        {
            return DateUtil.GetFolderTodayDate() + "/" + DateUtil.GetFolderTodayTime() + "-" + GetRandomString(8) + "-" + Path.GetFileName(filePath);
        }

        public static string GetRandomString(int length)
        {
            string result = "";
            for (int i = 0; i < length; i++)
            {
                bool _tmp = true;
                while (_tmp)
                {
                    // 随机一个数字
                    int randomIntValue = new Random(Guid.NewGuid().GetHashCode()).Next(48, 123);

                    if ((randomIntValue >=48 && randomIntValue <= 57) // 数字
                        || (randomIntValue >= 65 && randomIntValue <= 90) // 大写字母
                        || (randomIntValue >= 97 && randomIntValue <= 122)) // 小写字母
                    {
                        result += (char)randomIntValue;
                        _tmp = false;
                    }
                }
            }
            return result;
        }

        public static MapExt Object2Map<T>(T obj, bool ignoreGetMethod = false)
        {
            if (obj is Dictionary<string, object> || obj is MapExt)
            {
                return (MapExt)Convert.ChangeType(obj, typeof(MapExt));
            }

            MapExt map = new MapExt();

            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static |BindingFlags.Instance);

            foreach (var property in properties)
            {
                MethodInfo method = property.GetGetMethod();

                if (null == method && !ignoreGetMethod)
                {
                    // 设null
                    map.Put(property.Name, null);
                } 
                else
                {
                    // 获取实际值
                    map.Put(property.Name, method.Invoke(obj, new object[] { }));
                }
            }

            return map;
        }

        public static bool IsImgFile(string filePath)
        {
            string ext = Path.GetExtension(filePath);
            List<string> extList = new List<string>();

            extList.Add(".jpg");
            extList.Add(".jpeg");
            extList.Add(".png");
            extList.Add(".bmp");
            extList.Add(".gif");
            extList.Add(".tif");

            if (extList.Contains(ext.ToLower()))
            {
                return true;
            }

            return false;
        }

        public static void UpdateMainStatusLabel(System.Windows.Forms.ToolStripStatusLabel statusLabel, string text)
        {
            statusLabel.Text = text;
        }
    }
}

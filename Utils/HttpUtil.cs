using System;
using System.Collections.Generic;
using EasyHttp.Http;
using Newtonsoft.Json;

using BedWorker.Entity.Base;

namespace BedWorker.Utils
{
    public class HttpUtil
    {
        private HttpUtil() {}

       public static T Post<T>(string url, object data, string contentType)
        {
            // data转dictionary 防止easyhttp转换为帕斯卡命名
            data = CommonUtil.Object2Dict(data);

            HttpClient client = new HttpClient();

            HttpResponse response = client.Post(url, data, contentType);

            string res = response.RawText;
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("post request url [{0}]\nres [{1}]", url, res);
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            try
            {
                return JsonConvert.DeserializeObject<T>(res);
            }
            catch (Exception e)
            {
                Console.WriteLine("反序列化对象失败: {0} | {1}", res, e.Message);
                return default;
            }
        }

        public static T Get<T>(string url, object data)
        {
            // data转dictionary 防止easyhttp转换为帕斯卡命名
            Dictionary<string, object> dict = CommonUtil.Object2Dict(data);

            string _query = CommonUtil.Data2GetQuery(dict);

            HttpClient client = new HttpClient();

            url = url + _query;

            HttpResponse response = client.Get(url);

            string res = response.RawText;
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("get request url [{0}]\nres [{1}]", url, res);
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            try
            {
                return JsonConvert.DeserializeObject<T>(res);
            }
            catch (Exception e)
            {
                Console.WriteLine("反序列化对象失败: {0} | {1}", res, e.Message);
                return default;
            }
        }

        private static MapExt NullMapExt()
        {
            return new MapExt();
        }
    }
}

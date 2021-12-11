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
            // data转mapExt 防止easyhttp转换为帕斯卡命名
            MapExt _data = CommonUtil.Object2Map(data);

            HttpClient client = new HttpClient();

            HttpResponse response = client.Post(url, _data, contentType);

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
            // data转MapExt 防止easyhttp转换为帕斯卡命名
            MapExt _data = CommonUtil.Object2Map(data);

            string _query = CommonUtil.Data2GetQuery(_data);

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

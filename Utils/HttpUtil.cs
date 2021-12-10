using System;
using EasyHttp.Http;
using Newtonsoft.Json;

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
            Console.WriteLine("request url [{0}], res [{1}]", url, res);
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
    }
}

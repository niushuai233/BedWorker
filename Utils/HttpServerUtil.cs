using System;
using System.Net;

namespace BedWorker.Utils
{
    public class HttpServerUtil
    {
        public static HttpListener StartListenServer(string url)
        {
            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add(url);
            httpListener.Start();
            Console.WriteLine("httpServer listener at " + url);

            return httpListener;
        }
    }
}

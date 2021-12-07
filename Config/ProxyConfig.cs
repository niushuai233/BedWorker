namespace BedWorker.Config
{
    public class ProxyConfig
    {
        /// <summary>
        /// 代理方式 1无代理 2系统代理 3自定义代理
        /// </summary>
        public int ProxyWay { get; set; }

        /// <summary>
        /// 自定义代理 代理协议 HTTP SOCKS
        /// </summary>
        public string ProxyProtocol { get; set; }

        /// <summary>
        /// 代理主机
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 代理端口号
        /// </summary>
        public int Port { get; set; }

        public ProxyConfig()
        {
            ProxyWay = 1;
            ProxyProtocol = "HTTP";
            Host = "127.0.0.1";
            Port = 7890;
        }
    }
}

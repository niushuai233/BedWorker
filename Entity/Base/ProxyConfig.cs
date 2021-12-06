using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedWorker.Entity.Base
{
    public class ProxyConfig
    {
        /// <summary>
        /// 代理方式 1无代理 2系统代理 3自定义代理
        /// </summary>
        public int ProxyWay { get; set; }

        /// <summary>
        /// 代理主机
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 代理端口号
        /// </summary>
        public int Port { get; set; }

        public ProxyConfig LoadProxyConfig(int ProxyWay)
        {
            ProxyConfig proxyConfig = new ProxyConfig();

            switch (ProxyWay)
            {
                case 1:
                    return null;
                case 2:
                    return this.LoadSystemProxy();
                case 3:
                    return this.LoadCustomProxy();
            }

            return proxyConfig;
        }
        /// <summary>
        /// 加载系统代理为proxyConfig对象
        /// </summary>
        /// <returns></returns>
        private ProxyConfig LoadSystemProxy()
        {

            return null;
        }
        /// <summary>
        /// 加载自定义代理为proxyConfig对象
        /// </summary>
        /// <returns></returns>
        private ProxyConfig LoadCustomProxy()
        {
            return null;
        }
    }
}

using System;
using System.Xml.Serialization;

namespace BedWorker.Config
{
    /// <summary>
    /// 总体设置汇总
    /// </summary>
    [XmlRootAttribute("Configs", IsNullable =false)]
    public class Configs
    {
        /// <summary>
        /// 代理设置
        /// </summary>
        public ProxyConfig ProxyConfig { get; set; }

        public Gitee Gitee { get; set; }

        public static Configs Configs_Ref = new Configs()
        {
            ProxyConfig = new ProxyConfig(),
            Gitee = new Gitee()
        };
    }
}

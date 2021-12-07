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
        public static Configs Configs_Ref = new Configs();
        /// <summary>
        /// 代理设置
        /// </summary>
        public ProxyConfig ProxyConfig { get; set; }
    }
}

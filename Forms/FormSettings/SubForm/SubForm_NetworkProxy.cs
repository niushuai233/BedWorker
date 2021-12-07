using System;
using System.Windows.Forms;

using BedWorker.Config;
using BedWorker.Utils;

namespace BedWorker.Forms.FormSettings.SubForm
{
    public partial class SubForm_NetworkProxy : Form
    {
        public SubForm_NetworkProxy()
        {
            InitializeComponent();
            LoadProxyConfig();
        }
        /// <summary>
        /// 加载代理设置
        /// </summary>
        private void LoadProxyConfig()
        {
            // 默认禁用代理选项
            this.DisableCustomProxy();
            // 读取代理配置进行初始化设置界面
            ProxyConfig proxyConfig = this.LoadFromFile();

            int proxyWay = proxyConfig.ProxyWay;
            switch (proxyWay)
            {
                case 1:
                    // 无代理
                    this.ClearAllProxy(proxyConfig);
                    break;
                case 2:
                    // 系统代理
                    this.InitSystemProxy(proxyConfig);
                    break;
                case 3:
                    // 自定义代理
                    this.InitCustomProxy(proxyConfig);
                    break;
            }
        }

        private void ClearAllProxy(ProxyConfig proxyConfig)
        {
            throw new NotImplementedException();
        }

        private void InitSystemProxy(ProxyConfig proxyConfig)
        {
            throw new NotImplementedException();
        }

        private void InitCustomProxy(ProxyConfig proxyConfig)
        {
            throw new NotImplementedException();
        }

        private ProxyConfig LoadFromFile()
        {
            // XmlUtil.Obj2Xml<Configs>(CommonConstant.getConfigLocation(), Configs.Configs_Ref);

            Configs.Configs_Ref = XmlUtil.Xml2Obj<Configs>(CommonConstant.getConfigLocation());
            return Configs.Configs_Ref.ProxyConfig;
        }

        /// <summary>
        /// 无代理
        /// </summary>
        /// <param name="sender">触发对象</param>
        /// <param name="e">当前值</param>
        private void NoProxy_click(object sender, EventArgs e)
        {
            this.DisableCustomProxy();
        }

        /// <summary>
        /// 系统代理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemProxy_click(object sender, EventArgs e)
        {
            this.DisableCustomProxy();
        }
        /// <summary>
        /// 自定义代理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomProxy_click(object sender, EventArgs e)
        {
            this.EnableCustomProxy();
        }

        /// <summary>
        /// 启用自定义代理
        /// </summary>
        private void EnableCustomProxy()
        {
            this.groupBox_proxyProtocol.Enabled = true;
        }
        /// <summary>
        /// 禁用自定义代理
        /// </summary>
        private void DisableCustomProxy()
        {
            this.groupBox_proxyProtocol.Enabled = false;
        }
    }
}

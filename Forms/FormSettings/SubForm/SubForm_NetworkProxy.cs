using System;
using System.Windows.Forms;

using BedWorker.Config;
using BedWorker.Utils;

namespace BedWorker.Forms.FormSettings.SubForm
{
    public partial class SubForm_NetworkProxy : Form
    {
        public Form_Settings parentForm = null;
        public SubForm_NetworkProxy(Form_Settings _this)
        {
            InitializeComponent();
            parentForm = _this;
            LoadProxyConfig();
        }
        /// <summary>
        /// 加载代理设置
        /// </summary>
        private void LoadProxyConfig()
        {
            // 默认禁用代理选项
            this.DisableCustomProxyGroupBox();
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
            this.InitCustomProxy(proxyConfig);
            // 禁用选项
            this.EnableNoProxy();
            this.DisableSystemProxy();
            this.DisableCustomProxy();
            this.DisableCustomProxyGroupBox();
        }

        [Obsolete]
        private void InitSystemProxy(ProxyConfig proxyConfig)
        {
            // 取系统代理属性
            proxyConfig.ProxyProtocol = CommonConstant.GetSystemProxyProtocol();
            proxyConfig.Host = CommonConstant.GetSystemProxyHost();
            proxyConfig.Port = CommonConstant.GetSystemProxyPort(); 

            this.InitCustomProxy(proxyConfig);
            // 禁用选项
            this.DisableNoProxy();
            this.EnableSystemProxy();
            this.DisableCustomProxy();
            this.DisableCustomProxyGroupBox();
        }

        private void InitCustomProxy(ProxyConfig proxyConfig)
        {
            // 禁用选项
            this.DisableNoProxy();
            this.DisableSystemProxy();
            this.EnableCustomProxy();
            this.EnableCustomProxyGroupBox();

            // 回显网络代理主机和端口号
            this.textBox_proxy_host.Text = string.IsNullOrEmpty(proxyConfig.Host) || string.IsNullOrWhiteSpace(proxyConfig.Host) ? CommonConstant.Default_Proxy_Host : proxyConfig.Host;
            this.numericUpDown_proxy_port.Value = (0 == proxyConfig.Port) ? CommonConstant.Default_Proxy_Port : proxyConfig.Port;
            if ("SOCKS".Equals(proxyConfig.ProxyProtocol))
            {
                this.radioButton_proxy_http.Checked = false;
                this.radioButton_proxy_socks.Checked = true;
            }
            else
            {
                this.radioButton_proxy_http.Checked = true;
                this.radioButton_proxy_socks.Checked = false;
            }
        }

        private ProxyConfig LoadFromFile()
        {
            // XmlUtil.Obj2Xml<Configs>(CommonConstant.getConfigLocation(), Configs.Configs_Ref);

            Configs.Configs_Ref = XmlUtil.Xml2Obj<Configs>(CommonConstant.GetConfigLocation());
            return Configs.Configs_Ref.ProxyConfig;
        }

        /// <summary>
        /// 无代理
        /// </summary>
        /// <param name="sender">触发对象</param>
        /// <param name="e">当前值</param>
        private void NoProxy_click(object sender, EventArgs e)
        {
            this.DisableCustomProxyGroupBox();
        }

        /// <summary>
        /// 系统代理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemProxy_click(object sender, EventArgs e)
        {
            this.DisableCustomProxyGroupBox();
        }
        /// <summary>
        /// 自定义代理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomProxy_click(object sender, EventArgs e)
        {
            this.EnableCustomProxyGroupBox();
        }

        /// <summary>
        /// 启用自定义代理
        /// </summary>
        private void EnableCustomProxyGroupBox()
        {
            this.groupBox_proxyProtocol.Enabled = true;
        }
        /// <summary>
        /// 禁用自定义代理
        /// </summary>
        private void DisableCustomProxyGroupBox()
        {
            this.groupBox_proxyProtocol.Enabled = false;
        }
        /// <summary>
        /// 启用无代理选项
        /// </summary>
        private void EnableNoProxy()
        {
            this.radioButton_noProxy.Checked = true;
        }
        /// <summary>
        /// 停用无代理选项
        /// </summary>
        private void DisableNoProxy()
        {
            this.radioButton_noProxy.Checked = false;
        }
        /// <summary>
        /// 启用系统代理选项
        /// </summary>
        private void EnableSystemProxy()
        {
            this.radioButton_SystemProxy.Checked = true;
        }
        /// <summary>
        /// 停用系统代理选项
        /// </summary>
        private void DisableSystemProxy()
        {
            this.radioButton_SystemProxy.Checked = false;
        }
        /// <summary>
        /// 启用自定义代理选项
        /// </summary>
        private void EnableCustomProxy()
        {
            this.radioButton_CustomProxy.Checked = true;
        }
        /// <summary>
        /// 停用自定义代理选项
        /// </summary>
        private void DisableCustomProxy()
        {
            this.radioButton_CustomProxy.Checked = false;
        }

        /// <summary>
        /// 确定点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProxyConfirm_click(object sender, EventArgs e)
        {
            this.ProxyApply_click(sender, e);
            this.ProxyCancel_click(sender, e);
        }

        /// <summary>
        /// 取消点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProxyCancel_click(object sender, EventArgs e)
        {
            // 隐藏弹窗
            parentForm.Dispose();
        }

        /// <summary>
        /// 应用点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProxyApply_click(object sender, EventArgs e)
        {
            // 将内容写到文件中
            // 首先读取界面中的设置项设置到常量类中
            ProxyConfig tmpConfig = new ProxyConfig()
            {
                ProxyWay = this.GetProxyWayVal(),
                ProxyProtocol = this.GetProxyProtocol(),
                Host = this.textBox_proxy_host.Text,
                Port = int.Parse(this.numericUpDown_proxy_port.Value.ToString())
            };

            Configs.Configs_Ref.ProxyConfig = tmpConfig;
            // 写入到xml中
            XmlUtil.Obj2Xml<Configs>(CommonConstant.GetConfigLocation(), Configs.Configs_Ref);
        }

        private int GetProxyWayVal()
        {
            if (this.radioButton_noProxy.Checked == true)
            {
                return 1;
            }
            else if (this.radioButton_SystemProxy.Checked == true)
            {
                return 2;
            }
            else if (this.radioButton_CustomProxy.Checked == true)
            {
                return 3;
            }
            else
            {
                // 默认无代理
                return 1;
            }
        }
        private string GetProxyProtocol()
        {
            if (this.radioButton_proxy_http.Checked == true)
            {
                return "HTTP";
            }
            else if (this.radioButton_proxy_socks.Checked == true)
            {
                return "SOCKS";
            }
            else
            {
                // 默认HTTP
                return "HTTP";
            }
        }
    }
}

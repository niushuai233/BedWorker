using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedWorker.Forms.FormSettings.SubForm
{
    public partial class SubForm_NetworkProxy : Form
    {
        public SubForm_NetworkProxy()
        {
            InitializeComponent();
            loadProxyConfig();
        }
        /// <summary>
        /// 加载代理设置
        /// </summary>
        private void loadProxyConfig()
        {
            // 默认禁用代理选项
            this.disableCustomProxy();
            // 读取代理配置进行初始化设置界面
        }
        /// <summary>
        /// 无代理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noProxy_click(object sender, EventArgs e)
        {
            this.disableCustomProxy();
        }

        /// <summary>
        /// 系统代理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void systemProxy_click(object sender, EventArgs e)
        {
            this.disableCustomProxy();
        }
        /// <summary>
        /// 自定义代理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customProxy_click(object sender, EventArgs e)
        {
            this.enableCustomProxy();
        }

        /// <summary>
        /// 启用自定义代理
        /// </summary>
        private void enableCustomProxy()
        {
            this.groupBox_proxyProtocol.Enabled = true;
        }
        /// <summary>
        /// 禁用自定义代理
        /// </summary>
        private void disableCustomProxy()
        {
            this.groupBox_proxyProtocol.Enabled = false;
        }
    }
}

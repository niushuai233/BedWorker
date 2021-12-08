using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BedWorker.Entity.Enums;
using BedWorker.Forms.FormSettings.SubForm;

namespace BedWorker.Forms.FormSettings
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
            this.CustomInit();
        }

        /// <summary>
        /// 自定义初始化内容
        /// </summary>
        private void CustomInit()
        {
            // 默认展开所有节点
            this.setTreeMenuTreeView.ExpandAll();
        }

        private void SetNodeSelect_click(object sender, TreeNodeMouseClickEventArgs e)
        {
            // panel2的form对象
            Form form = null ;

            // 获取到不同的form
            ToolSetNameEnum nodeEnum = ToolSetNameProgram.match(e.Node.Name);
            switch (nodeEnum)
            {
                case ToolSetNameEnum.SetNetowrkNode:
                    // 网络
                    return;
                case ToolSetNameEnum.SetNetworkProxySubNode:
                    // 代理
                    form = new SubForm_NetworkProxy(this);
                    break;
                case ToolSetNameEnum.SetServiceNode:
                    // 服务
                    return;
                case ToolSetNameEnum.SetServiceGiteeSubNode:
                    // Gitee
                    form  = new SubForm_Service_Gitee();
                    break;
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            // 清空面板
            this.setSplitContainer.Panel2.Controls.Clear();
            // 添加新的面板
            this.setSplitContainer.Panel2.Controls.Add(form);

            form.Show();
        }
    }
}

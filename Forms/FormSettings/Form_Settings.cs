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

namespace BedWorker.Forms.SettingsForm
{
    public partial class Form_SettingsTabControl : Form
    {
        public Form_SettingsTabControl()
        {
            InitializeComponent();
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
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
                    form = new SubForm_NetworkProxy();
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
            this.setSplitContainer.Panel2.Controls.Add(form);

            form.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            SubForm_NetworkProxy form = new SubForm_NetworkProxy();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.setSplitContainer.Panel2.Controls.Add(form);

            form.Show();
        }
    }
}

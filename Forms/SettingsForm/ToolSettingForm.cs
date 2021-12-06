using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedWorker.Forms.SettingsForm
{
    public partial class ToolSettingForm : Form
    {
        public ToolSettingForm()
        {
            InitializeComponent();
        }

        private void selectNode_click(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

using BedWorker.Config;
using BedWorker.Utils;
using BedWorker.Forms.FormSettings;

namespace BedWorker
{
    public partial class BedWorkerApplicationForm : Form
    {
        public BedWorkerApplicationForm()
        {
            InitializeComponent();
            InitConfigs();
        }

        private void InitConfigs()
        {
            // 加载文件到流中
            string configFilePath = CommonUtil.GetConfigLocation();
            if (!File.Exists(configFilePath))
            {
                Console.WriteLine("配置文件不存在, 新建. | " + configFilePath);
                XmlUtil.Obj2Xml<Configs>(configFilePath, Configs.Configs_Ref);
            }
            
        }

        private void aboutMenuItem_click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "图床工助手v1.0 © 版权所有 2021.12 @niushuai233\n\n" +
                "主页：https://github.com/niushuai233\n" +
                "邮箱：shuai.niu@foxmail.com",
                "关于", MessageBoxButtons.OK);
        }

        private void ToolSettingsMenuItem_click(object sender, EventArgs e)
        {
            // 打开设置窗口
            Form_Settings toolSettingForm = new Form_Settings();

            toolSettingForm.ShowDialog(this);
        }

        private void dragDropFile_click(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // 获取拖拽进来的文件列表
                string[] filesPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in filesPath)
                {
                    FileStream fs = new FileStream(file, FileMode.Open);
                    Console.WriteLine(file);
                    fs.Close();
                }
            }
        }

        private void dragEnterFile_click(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}

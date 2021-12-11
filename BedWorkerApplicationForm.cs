﻿using System;
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
            } else
            {
                Configs.Configs_Ref = XmlUtil.Xml2Obj<Configs>(configFilePath);
            }
        }

        private void AboutMenuItem_click(object sender, EventArgs e)
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

        private void DragDropFile_click(object sender, DragEventArgs e)
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

        private void DragEnterFile_click(object sender, DragEventArgs e)
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

        private void GroupBoxOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif|JPEG图片|*.jpg;*.jpeg|PNG图片|*.png|BMP图片|*.bmp|Gif图片|*.gif|TIF图片|*.tif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 已选择文件
                string uploadFilePath = this.ServerUpload(openFileDialog.FileName);

                // MessageBox.Show(uploadFilePath);
                this.textBox_lastUploadUrl.Text = uploadFilePath;
            }

        }

        private string ServerUpload(string filePath)
        {
            int server = 1;
            switch (server)
            {
                case 1:
                    return ApiGiteeUtil.GiteeUpload(filePath);

                default:
                    return null;
            }
        }

        private void GroupBoxMouseHover_Click(object sender, EventArgs e)
        {
            this.groupBox_upload.Cursor = Cursors.Hand;
        }

        private void GroupBoxMouseLeave_Click(object sender, EventArgs e)
        {
            if (!IsAboveGroupBox(sender as GroupBox))
            {
                this.groupBox_upload.BackColor = System.Drawing.Color.Empty;
            }
        }

        private bool IsAboveGroupBox(GroupBox gb)
        {
            System.Drawing.Point cursorPos = PointToClient(Cursor.Position);
            bool resultX = (cursorPos.X > gb.Location.X && cursorPos.X < gb.Location.X + gb.Size.Width) ? true : false;
            bool resultY = (cursorPos.Y > gb.Location.Y && cursorPos.Y < gb.Location.Y + gb.Size.Height) ? true : false;

            return resultX && resultY;
        }

        private void Button_copySource_Click(object sender, EventArgs e)
        {
            Copy(1);
        }

        private void Button_copyMarkdown_Click(object sender, EventArgs e)
        {
            Copy(2);
        }

        private void Button_copyHtml_Click(object sender, EventArgs e)
        {
            Copy(3);
        }

        private void Copy(int type)
        {
            string uploadUrl = GetCopyData(type);
            if (string.IsNullOrEmpty(uploadUrl))
            {
                return;
            }

            Clipboard.SetDataObject(uploadUrl, true);
        }

        private string GetCopyData(int type)
        {
            string uploadUrl = this.textBox_lastUploadUrl.Text.Trim();
            switch (type)
            {
                case 1:
                    // 源数据
                    return uploadUrl;
                case 2:
                    // markdown
                    uploadUrl = "![](" + uploadUrl + ")";
                    return uploadUrl;
                case 3:
                    // html
                    uploadUrl = "<img src='" + uploadUrl + "'></img>";
                    return uploadUrl;
                default:
                    // 默认
                    return uploadUrl;
            }
        }
    }
}

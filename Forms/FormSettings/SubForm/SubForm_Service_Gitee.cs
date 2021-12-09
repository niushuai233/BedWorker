using System;
using System.Windows.Forms;

using Newtonsoft.Json;

using BedWorker.Config;
using BedWorker.Utils;

namespace BedWorker.Forms.FormSettings.SubForm
{
    public partial class SubForm_Service_Gitee : Form
    {
        public Form_Settings parentForm = null;
        public SubForm_Service_Gitee(Form_Settings _this)
        {
            parentForm = _this;
            InitializeComponent();
        }

        /// <summary>
        /// gitee confirm click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiteeConfirm_click(object sender, EventArgs e)
        {
            this.GiteeApply_click(sender, e);
            this.GiteeCancel_click(sender, e);
        }

        /// <summary>
        /// gitee cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiteeCancel_click(object sender, EventArgs e)
        {
            parentForm.Dispose();
        }

        /// <summary>
        /// gitee apply click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiteeApply_click(object sender, EventArgs e)
        {
            string _branch = string.IsNullOrEmpty(this.textBox_gitee_branch.Text) ? "master" : this.textBox_gitee_branch.Text;
            string _directory = string.IsNullOrEmpty(this.textBox_gitee_directory_path.Text) ? "/img" : this.textBox_gitee_directory_path.Text;
            if (!_directory.StartsWith("/"))
            {
                _directory = "/" + _directory;
            }
            Configs.Configs_Ref.Gitee = new Gitee()
            {
                Username = this.textBox_gitee_username.Text,
                RepositoryName = this.textBox_gitee_repo.Text,
                Branch = _branch,
                Token = this.textBox_gitee_token.Text,
                Directory = _directory
            };

            // 如果branch为null 默认为master
            this.textBox_gitee_branch.Text = _branch;
            // 如果directory_path为null 默认为/img 且强制以‘/’开头
            this.textBox_gitee_directory_path.Text = _directory;

            // 完整地址
            Configs.Configs_Ref.Gitee.RepoAbsolutePath = Configs.Configs_Ref.Gitee.GetRepoAbsolutePath();
            this.textBox_gitee_repoAbsolutePath.Text = Configs.Configs_Ref.Gitee.GetRepoAbsolutePath();
            XmlUtil.Obj2Xml<Configs>(CommonUtil.GetConfigLocation(), Configs.Configs_Ref);
        }

        private void Gitee_OAuth_Click(object sender, EventArgs e)
        {

        }
    }
}

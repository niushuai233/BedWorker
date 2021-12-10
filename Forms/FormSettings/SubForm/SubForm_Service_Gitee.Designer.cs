namespace BedWorker.Forms.FormSettings.SubForm
{
    partial class SubForm_Service_Gitee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_gitee_confirm = new System.Windows.Forms.Button();
            this.button_gitee_cancel = new System.Windows.Forms.Button();
            this.button_gitee_apply = new System.Windows.Forms.Button();
            this.button_gitee_oauth = new System.Windows.Forms.Button();
            this.textBox_gitee_repoAbsolutePath = new BedWorker.Entity.Base.TextBoxExt();
            this.textBox_gitee_directory_path = new BedWorker.Entity.Base.TextBoxExt();
            this.textBox_gitee_token = new BedWorker.Entity.Base.TextBoxExt();
            this.textBox_gitee_branch = new BedWorker.Entity.Base.TextBoxExt();
            this.textBox_gitee_repo = new BedWorker.Entity.Base.TextBoxExt();
            this.textBox_gitee_username = new BedWorker.Entity.Base.TextBoxExt();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "分支：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Token：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "文件夹：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Url：";
            // 
            // button_gitee_confirm
            // 
            this.button_gitee_confirm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_gitee_confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.button_gitee_confirm.Location = new System.Drawing.Point(202, 308);
            this.button_gitee_confirm.Name = "button_gitee_confirm";
            this.button_gitee_confirm.Size = new System.Drawing.Size(75, 32);
            this.button_gitee_confirm.TabIndex = 16;
            this.button_gitee_confirm.Text = "确定";
            this.button_gitee_confirm.UseVisualStyleBackColor = false;
            this.button_gitee_confirm.Click += new System.EventHandler(this.GiteeConfirm_click);
            // 
            // button_gitee_cancel
            // 
            this.button_gitee_cancel.Location = new System.Drawing.Point(283, 308);
            this.button_gitee_cancel.Name = "button_gitee_cancel";
            this.button_gitee_cancel.Size = new System.Drawing.Size(75, 32);
            this.button_gitee_cancel.TabIndex = 17;
            this.button_gitee_cancel.Text = "取消";
            this.button_gitee_cancel.UseVisualStyleBackColor = true;
            this.button_gitee_cancel.Click += new System.EventHandler(this.GiteeCancel_click);
            // 
            // button_gitee_apply
            // 
            this.button_gitee_apply.Location = new System.Drawing.Point(364, 308);
            this.button_gitee_apply.Name = "button_gitee_apply";
            this.button_gitee_apply.Size = new System.Drawing.Size(75, 32);
            this.button_gitee_apply.TabIndex = 18;
            this.button_gitee_apply.Text = "应用";
            this.button_gitee_apply.UseVisualStyleBackColor = true;
            this.button_gitee_apply.Click += new System.EventHandler(this.GiteeApply_click);
            // 
            // button_gitee_oauth
            // 
            this.button_gitee_oauth.Location = new System.Drawing.Point(324, 144);
            this.button_gitee_oauth.Name = "button_gitee_oauth";
            this.button_gitee_oauth.Size = new System.Drawing.Size(50, 32);
            this.button_gitee_oauth.TabIndex = 19;
            this.button_gitee_oauth.Text = "获取";
            this.button_gitee_oauth.UseVisualStyleBackColor = true;
            this.button_gitee_oauth.Click += new System.EventHandler(this.Gitee_OAuth_Click);
            // 
            // textBox_gitee_repoAbsolutePath
            // 
            this.textBox_gitee_repoAbsolutePath.Enabled = false;
            this.textBox_gitee_repoAbsolutePath.Location = new System.Drawing.Point(70, 65);
            this.textBox_gitee_repoAbsolutePath.Name = "textBox_gitee_repoAbsolutePath";
            this.textBox_gitee_repoAbsolutePath.Placeholder = "完整仓库地址";
            this.textBox_gitee_repoAbsolutePath.Size = new System.Drawing.Size(304, 26);
            this.textBox_gitee_repoAbsolutePath.TabIndex = 15;
            // 
            // textBox_gitee_directory_path
            // 
            this.textBox_gitee_directory_path.Location = new System.Drawing.Point(70, 191);
            this.textBox_gitee_directory_path.Name = "textBox_gitee_directory_path";
            this.textBox_gitee_directory_path.Placeholder = "仓库内文件夹, 支持 / 多级文件夹";
            this.textBox_gitee_directory_path.Size = new System.Drawing.Size(304, 26);
            this.textBox_gitee_directory_path.TabIndex = 13;
            this.textBox_gitee_directory_path.Text = "/img";
            // 
            // textBox_gitee_token
            // 
            this.textBox_gitee_token.Location = new System.Drawing.Point(70, 147);
            this.textBox_gitee_token.Name = "textBox_gitee_token";
            this.textBox_gitee_token.Placeholder = "API: token";
            this.textBox_gitee_token.Size = new System.Drawing.Size(235, 26);
            this.textBox_gitee_token.TabIndex = 10;
            // 
            // textBox_gitee_branch
            // 
            this.textBox_gitee_branch.Location = new System.Drawing.Point(70, 103);
            this.textBox_gitee_branch.Name = "textBox_gitee_branch";
            this.textBox_gitee_branch.Placeholder = "分支名: 默认master";
            this.textBox_gitee_branch.Size = new System.Drawing.Size(235, 26);
            this.textBox_gitee_branch.TabIndex = 8;
            this.textBox_gitee_branch.Text = "master";
            // 
            // textBox_gitee_repo
            // 
            this.textBox_gitee_repo.Location = new System.Drawing.Point(214, 25);
            this.textBox_gitee_repo.Name = "textBox_gitee_repo";
            this.textBox_gitee_repo.Placeholder = "仓库: repo_name";
            this.textBox_gitee_repo.Size = new System.Drawing.Size(160, 26);
            this.textBox_gitee_repo.TabIndex = 5;
            // 
            // textBox_gitee_username
            // 
            this.textBox_gitee_username.Location = new System.Drawing.Point(70, 25);
            this.textBox_gitee_username.Name = "textBox_gitee_username";
            this.textBox_gitee_username.Placeholder = "用户名: username";
            this.textBox_gitee_username.Size = new System.Drawing.Size(125, 26);
            this.textBox_gitee_username.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tag = "ffx";
            // 
            // SubForm_Service_Gitee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 352);
            this.Controls.Add(this.button_gitee_oauth);
            this.Controls.Add(this.button_gitee_apply);
            this.Controls.Add(this.button_gitee_cancel);
            this.Controls.Add(this.button_gitee_confirm);
            this.Controls.Add(this.textBox_gitee_repoAbsolutePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_gitee_directory_path);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_gitee_token);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_gitee_branch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_gitee_repo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_gitee_username);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SubForm_Service_Gitee";
            this.Text = "Gitee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BedWorker.Entity.Base.TextBoxExt textBox_gitee_username;
        private System.Windows.Forms.Label label3;
        private BedWorker.Entity.Base.TextBoxExt textBox_gitee_repo;
        private System.Windows.Forms.Label label4;
        private BedWorker.Entity.Base.TextBoxExt textBox_gitee_branch;
        private System.Windows.Forms.Label label5;
        private BedWorker.Entity.Base.TextBoxExt textBox_gitee_token;
        private System.Windows.Forms.Label label7;
        private BedWorker.Entity.Base.TextBoxExt textBox_gitee_directory_path;
        private System.Windows.Forms.Label label2;
        private BedWorker.Entity.Base.TextBoxExt textBox_gitee_repoAbsolutePath;
        private System.Windows.Forms.Button button_gitee_confirm;
        private System.Windows.Forms.Button button_gitee_cancel;
        private System.Windows.Forms.Button button_gitee_apply;
        private System.Windows.Forms.Button button_gitee_oauth;
        private System.Windows.Forms.Timer timer1;
    }
}
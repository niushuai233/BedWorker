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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new BedWorker.Entity.Base.TextBoxExt();
            this.textBox_gitee_directory_path = new BedWorker.Entity.Base.TextBoxExt();
            this.textBox2 = new BedWorker.Entity.Base.TextBoxExt();
            this.textBox1 = new BedWorker.Entity.Base.TextBoxExt();
            this.textBox_gitee_repo = new BedWorker.Entity.Base.TextBoxExt();
            this.textBox_gitee_username = new BedWorker.Entity.Base.TextBoxExt();
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
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(70, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Placeholder = "完整仓库地址";
            this.textBox3.Size = new System.Drawing.Size(304, 26);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Placeholder = "API: token";
            this.textBox2.Size = new System.Drawing.Size(235, 26);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Placeholder = "分支名: 默认master";
            this.textBox1.Size = new System.Drawing.Size(235, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "master";
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
            // SubForm_Service_Gitee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 232);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_gitee_directory_path);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
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
        private BedWorker.Entity.Base.TextBoxExt textBox1;
        private System.Windows.Forms.Label label5;
        private BedWorker.Entity.Base.TextBoxExt textBox2;
        private System.Windows.Forms.Label label7;
        private BedWorker.Entity.Base.TextBoxExt textBox_gitee_directory_path;
        private System.Windows.Forms.Label label2;
        private BedWorker.Entity.Base.TextBoxExt textBox3;
    }
}
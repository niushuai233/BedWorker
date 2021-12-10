
namespace BedWorker
{
    partial class BedWorkerApplicationForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedWorkerApplicationForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AllSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BedServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giteeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_upload = new System.Windows.Forms.GroupBox();
            this.pictureBox_index_upload = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.groupBox_upload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_index_upload)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllSettingsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.mainMenuStrip.Size = new System.Drawing.Size(688, 29);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // AllSettingsToolStripMenuItem
            // 
            this.AllSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppSettingsToolStripMenuItem,
            this.BedServerToolStripMenuItem});
            this.AllSettingsToolStripMenuItem.Name = "AllSettingsToolStripMenuItem";
            this.AllSettingsToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.AllSettingsToolStripMenuItem.Text = "首选项";
            // 
            // AppSettingsToolStripMenuItem
            // 
            this.AppSettingsToolStripMenuItem.Name = "AppSettingsToolStripMenuItem";
            this.AppSettingsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.AppSettingsToolStripMenuItem.Text = "工具设置";
            this.AppSettingsToolStripMenuItem.Click += new System.EventHandler(this.ToolSettingsMenuItem_click);
            // 
            // BedServerToolStripMenuItem
            // 
            this.BedServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giteeToolStripMenuItem});
            this.BedServerToolStripMenuItem.Name = "BedServerToolStripMenuItem";
            this.BedServerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.BedServerToolStripMenuItem.Text = "图床设置";
            // 
            // giteeToolStripMenuItem
            // 
            this.giteeToolStripMenuItem.Name = "giteeToolStripMenuItem";
            this.giteeToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.giteeToolStripMenuItem.Text = "Gitee";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.AboutToolStripMenuItem.Text = "关于";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutMenuItem_click);
            // 
            // groupBox_upload
            // 
            this.groupBox_upload.Controls.Add(this.pictureBox_index_upload);
            this.groupBox_upload.Controls.Add(this.label1);
            this.groupBox_upload.Location = new System.Drawing.Point(12, 32);
            this.groupBox_upload.Name = "groupBox_upload";
            this.groupBox_upload.Size = new System.Drawing.Size(664, 371);
            this.groupBox_upload.TabIndex = 1;
            this.groupBox_upload.TabStop = false;
            this.groupBox_upload.MouseLeave += new System.EventHandler(this.GroupBoxMouseLeave_Click);
            this.groupBox_upload.MouseHover += new System.EventHandler(this.GroupBoxMouseHover_Click);
            // 
            // pictureBox_index_upload
            // 
            this.pictureBox_index_upload.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_index_upload.Image")));
            this.pictureBox_index_upload.Location = new System.Drawing.Point(232, 32);
            this.pictureBox_index_upload.Name = "pictureBox_index_upload";
            this.pictureBox_index_upload.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_index_upload.TabIndex = 1;
            this.pictureBox_index_upload.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(161, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "点击或拖拽文件到此处上传";
            // 
            // BedWorkerApplicationForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 441);
            this.Controls.Add(this.groupBox_upload);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BedWorkerApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BedWorker v1.0 @niushuai233";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile_click);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile_click);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.groupBox_upload.ResumeLayout(false);
            this.groupBox_upload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_index_upload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AllSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BedServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giteeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_upload;
        private System.Windows.Forms.PictureBox pictureBox_index_upload;
        private System.Windows.Forms.Label label1;
    }
}


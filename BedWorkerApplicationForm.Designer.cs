
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AllSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BedServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giteeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllSettingsToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 25);
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
            this.AppSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AppSettingsToolStripMenuItem.Text = "工具设置";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.aboutMenuItem_click);
            // 
            // BedServerToolStripMenuItem
            // 
            this.BedServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giteeToolStripMenuItem});
            this.BedServerToolStripMenuItem.Name = "BedServerToolStripMenuItem";
            this.BedServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BedServerToolStripMenuItem.Text = "图床设置";
            // 
            // giteeToolStripMenuItem
            // 
            this.giteeToolStripMenuItem.Name = "giteeToolStripMenuItem";
            this.giteeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.giteeToolStripMenuItem.Text = "Gitee";
            // 
            // BedWorkerApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "BedWorkerApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BedWorker v1.0 @niushuai233";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AllSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BedServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giteeToolStripMenuItem;
    }
}


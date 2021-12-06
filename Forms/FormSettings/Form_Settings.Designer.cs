﻿namespace BedWorker.Forms.SettingsForm
{
    partial class Form_SettingsTabControl
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("代理");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("网络", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Gitee");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("服务", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.setSplitContainer = new System.Windows.Forms.SplitContainer();
            this.setTreeMenuTreeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.setSplitContainer)).BeginInit();
            this.setSplitContainer.Panel1.SuspendLayout();
            this.setSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // setSplitContainer
            // 
            this.setSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.setSplitContainer.Name = "setSplitContainer";
            // 
            // setSplitContainer.Panel1
            // 
            this.setSplitContainer.Panel1.Controls.Add(this.setTreeMenuTreeView);
            this.setSplitContainer.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.setSplitContainer.Size = new System.Drawing.Size(584, 311);
            this.setSplitContainer.SplitterDistance = 194;
            this.setSplitContainer.TabIndex = 0;
            // 
            // setTreeMenuTreeView
            // 
            this.setTreeMenuTreeView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setTreeMenuTreeView.ItemHeight = 28;
            this.setTreeMenuTreeView.Location = new System.Drawing.Point(12, 12);
            this.setTreeMenuTreeView.Name = "setTreeMenuTreeView";
            treeNode9.Name = "SetNetworkProxySubNode";
            treeNode9.Text = "代理";
            treeNode10.Name = "SetNetowrkNode";
            treeNode10.Text = "网络";
            treeNode11.Name = "SetServiceGiteeSubNode";
            treeNode11.Text = "Gitee";
            treeNode12.Name = "SetServiceNode";
            treeNode12.Text = "服务";
            this.setTreeMenuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode12});
            this.setTreeMenuTreeView.Size = new System.Drawing.Size(251, 426);
            this.setTreeMenuTreeView.TabIndex = 0;
            this.setTreeMenuTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SetNodeSelect_click);
            // 
            // Form_SettingsTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.setSplitContainer);
            this.Name = "Form_SettingsTabControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.setSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setSplitContainer)).EndInit();
            this.setSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer setSplitContainer;
        private System.Windows.Forms.TreeView setTreeMenuTreeView;
    }
}
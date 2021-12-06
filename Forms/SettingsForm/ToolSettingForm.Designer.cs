
namespace BedWorker.Forms.SettingsForm
{
    partial class ToolSettingForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("代理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("网络", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Gitee");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("服务", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.ToolSettingTreeView = new System.Windows.Forms.TreeView();
            this.SetPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ToolSettingTreeView
            // 
            this.ToolSettingTreeView.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolSettingTreeView.HideSelection = false;
            this.ToolSettingTreeView.ItemHeight = 32;
            this.ToolSettingTreeView.Location = new System.Drawing.Point(10, 10);
            this.ToolSettingTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToolSettingTreeView.Name = "ToolSettingTreeView";
            treeNode1.Name = "SetProxyNetworkSubNode";
            treeNode1.Text = "代理";
            treeNode2.Name = "SetNetworkSetNode";
            treeNode2.Text = "网络";
            treeNode3.Name = "SetGiteeSubNode";
            treeNode3.Text = "Gitee";
            treeNode4.Name = "SetServiceNode";
            treeNode4.Text = "服务";
            this.ToolSettingTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.ToolSettingTreeView.Size = new System.Drawing.Size(191, 428);
            this.ToolSettingTreeView.TabIndex = 0;
            this.ToolSettingTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.selectNode_click);
            // 
            // SetPanel
            // 
            this.SetPanel.Location = new System.Drawing.Point(220, 12);
            this.SetPanel.Name = "SetPanel";
            this.SetPanel.Size = new System.Drawing.Size(568, 426);
            this.SetPanel.TabIndex = 1;
            // 
            // ToolSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetPanel);
            this.Controls.Add(this.ToolSettingTreeView);
            this.Name = "ToolSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ToolSettingTreeView;
        private System.Windows.Forms.Panel SetPanel;
    }
}
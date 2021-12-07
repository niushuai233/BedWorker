namespace BedWorker.Forms.SettingsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("代理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("网络", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Gitee");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("服务", new System.Windows.Forms.TreeNode[] {
            treeNode3});
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
            // 
            // setSplitContainer.Panel2
            // 
            this.setSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.setSplitContainer.Size = new System.Drawing.Size(634, 361);
            this.setSplitContainer.SplitterDistance = 155;
            this.setSplitContainer.TabIndex = 0;
            // 
            // setTreeMenuTreeView
            // 
            this.setTreeMenuTreeView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setTreeMenuTreeView.ItemHeight = 28;
            this.setTreeMenuTreeView.Location = new System.Drawing.Point(12, 12);
            this.setTreeMenuTreeView.Name = "setTreeMenuTreeView";
            treeNode1.Name = "SetNetworkProxySubNode";
            treeNode1.Text = "代理";
            treeNode2.Name = "SetNetowrkNode";
            treeNode2.Text = "网络";
            treeNode3.Name = "SetServiceGiteeSubNode";
            treeNode3.Text = "Gitee";
            treeNode4.Name = "SetServiceNode";
            treeNode4.Text = "服务";
            this.setTreeMenuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.setTreeMenuTreeView.Size = new System.Drawing.Size(131, 337);
            this.setTreeMenuTreeView.TabIndex = 0;
            this.setTreeMenuTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SetNodeSelect_click);
            // 
            // Form_SettingsTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.setSplitContainer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
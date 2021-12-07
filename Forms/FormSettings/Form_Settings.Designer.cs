namespace BedWorker.Forms.FormSettings
{
    partial class Form_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("代理");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("网络", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Gitee");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("服务", new System.Windows.Forms.TreeNode[] {
            treeNode7});
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
            treeNode5.Name = "SetNetworkProxySubNode";
            treeNode5.Text = "代理";
            treeNode6.Name = "SetNetowrkNode";
            treeNode6.Text = "网络";
            treeNode7.Name = "SetServiceGiteeSubNode";
            treeNode7.Text = "Gitee";
            treeNode8.Name = "SetServiceNode";
            treeNode8.Text = "服务";
            this.setTreeMenuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode8});
            this.setTreeMenuTreeView.Size = new System.Drawing.Size(131, 337);
            this.setTreeMenuTreeView.TabIndex = 0;
            this.setTreeMenuTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SetNodeSelect_click);
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.setSplitContainer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Settings";
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
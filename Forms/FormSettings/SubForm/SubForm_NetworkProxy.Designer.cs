namespace BedWorker.Forms.FormSettings.SubForm
{
    partial class SubForm_NetworkProxy
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
            this.radioButton_noProxy = new System.Windows.Forms.RadioButton();
            this.radioButton_SystemProxy = new System.Windows.Forms.RadioButton();
            this.radioButton_CustomProxy = new System.Windows.Forms.RadioButton();
            this.groupBox_proxyWay = new System.Windows.Forms.GroupBox();
            this.groupBox_proxyProtocol = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_proxy_socks = new System.Windows.Forms.RadioButton();
            this.radioButton_proxy_http = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_proxy_host = new System.Windows.Forms.TextBox();
            this.numericUpDown_proxy_port = new System.Windows.Forms.NumericUpDown();
            this.groupBox_proxyWay.SuspendLayout();
            this.groupBox_proxyProtocol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_proxy_port)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_noProxy
            // 
            this.radioButton_noProxy.AutoSize = true;
            this.radioButton_noProxy.Checked = true;
            this.radioButton_noProxy.Location = new System.Drawing.Point(16, 27);
            this.radioButton_noProxy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_noProxy.Name = "radioButton_noProxy";
            this.radioButton_noProxy.Size = new System.Drawing.Size(69, 24);
            this.radioButton_noProxy.TabIndex = 0;
            this.radioButton_noProxy.TabStop = true;
            this.radioButton_noProxy.Text = "无代理";
            this.radioButton_noProxy.UseVisualStyleBackColor = true;
            // 
            // radioButton_SystemProxy
            // 
            this.radioButton_SystemProxy.AutoSize = true;
            this.radioButton_SystemProxy.Location = new System.Drawing.Point(16, 61);
            this.radioButton_SystemProxy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_SystemProxy.Name = "radioButton_SystemProxy";
            this.radioButton_SystemProxy.Size = new System.Drawing.Size(111, 24);
            this.radioButton_SystemProxy.TabIndex = 1;
            this.radioButton_SystemProxy.Text = "使用系统代理";
            this.radioButton_SystemProxy.UseVisualStyleBackColor = true;
            // 
            // radioButton_CustomProxy
            // 
            this.radioButton_CustomProxy.AutoSize = true;
            this.radioButton_CustomProxy.Location = new System.Drawing.Point(16, 95);
            this.radioButton_CustomProxy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_CustomProxy.Name = "radioButton_CustomProxy";
            this.radioButton_CustomProxy.Size = new System.Drawing.Size(97, 24);
            this.radioButton_CustomProxy.TabIndex = 2;
            this.radioButton_CustomProxy.Text = "自定义代理";
            this.radioButton_CustomProxy.UseVisualStyleBackColor = true;
            // 
            // groupBox_proxyWay
            // 
            this.groupBox_proxyWay.Controls.Add(this.groupBox_proxyProtocol);
            this.groupBox_proxyWay.Controls.Add(this.radioButton_noProxy);
            this.groupBox_proxyWay.Controls.Add(this.radioButton_CustomProxy);
            this.groupBox_proxyWay.Controls.Add(this.radioButton_SystemProxy);
            this.groupBox_proxyWay.Location = new System.Drawing.Point(12, 12);
            this.groupBox_proxyWay.Name = "groupBox_proxyWay";
            this.groupBox_proxyWay.Size = new System.Drawing.Size(465, 304);
            this.groupBox_proxyWay.TabIndex = 3;
            this.groupBox_proxyWay.TabStop = false;
            this.groupBox_proxyWay.Text = "选择代理方式";
            // 
            // groupBox_proxyProtocol
            // 
            this.groupBox_proxyProtocol.Controls.Add(this.numericUpDown_proxy_port);
            this.groupBox_proxyProtocol.Controls.Add(this.textBox_proxy_host);
            this.groupBox_proxyProtocol.Controls.Add(this.label2);
            this.groupBox_proxyProtocol.Controls.Add(this.label1);
            this.groupBox_proxyProtocol.Controls.Add(this.radioButton_proxy_socks);
            this.groupBox_proxyProtocol.Controls.Add(this.radioButton_proxy_http);
            this.groupBox_proxyProtocol.Location = new System.Drawing.Point(16, 127);
            this.groupBox_proxyProtocol.Name = "groupBox_proxyProtocol";
            this.groupBox_proxyProtocol.Size = new System.Drawing.Size(443, 171);
            this.groupBox_proxyProtocol.TabIndex = 3;
            this.groupBox_proxyProtocol.TabStop = false;
            this.groupBox_proxyProtocol.Text = "选择代理协议";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "主机：";
            // 
            // radioButton_proxy_socks
            // 
            this.radioButton_proxy_socks.AutoSize = true;
            this.radioButton_proxy_socks.Location = new System.Drawing.Point(98, 26);
            this.radioButton_proxy_socks.Name = "radioButton_proxy_socks";
            this.radioButton_proxy_socks.Size = new System.Drawing.Size(72, 24);
            this.radioButton_proxy_socks.TabIndex = 1;
            this.radioButton_proxy_socks.Text = "SOCKS";
            this.radioButton_proxy_socks.UseVisualStyleBackColor = true;
            // 
            // radioButton_proxy_http
            // 
            this.radioButton_proxy_http.AutoSize = true;
            this.radioButton_proxy_http.Checked = true;
            this.radioButton_proxy_http.Location = new System.Drawing.Point(29, 26);
            this.radioButton_proxy_http.Name = "radioButton_proxy_http";
            this.radioButton_proxy_http.Size = new System.Drawing.Size(63, 24);
            this.radioButton_proxy_http.TabIndex = 0;
            this.radioButton_proxy_http.TabStop = true;
            this.radioButton_proxy_http.Text = "HTTP";
            this.radioButton_proxy_http.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口：";
            // 
            // textBox_proxy_host
            // 
            this.textBox_proxy_host.Location = new System.Drawing.Point(70, 62);
            this.textBox_proxy_host.Name = "textBox_proxy_host";
            this.textBox_proxy_host.Size = new System.Drawing.Size(163, 26);
            this.textBox_proxy_host.TabIndex = 4;
            this.textBox_proxy_host.Text = "127.0.0.1";
            // 
            // numericUpDown_proxy_port
            // 
            this.numericUpDown_proxy_port.Location = new System.Drawing.Point(70, 103);
            this.numericUpDown_proxy_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_proxy_port.Name = "numericUpDown_proxy_port";
            this.numericUpDown_proxy_port.Size = new System.Drawing.Size(163, 26);
            this.numericUpDown_proxy_port.TabIndex = 5;
            this.numericUpDown_proxy_port.Value = new decimal(new int[] {
            7890,
            0,
            0,
            0});
            // 
            // SubForm_NetworkProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 328);
            this.Controls.Add(this.groupBox_proxyWay);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SubForm_NetworkProxy";
            this.Text = "网络代理";
            this.groupBox_proxyWay.ResumeLayout(false);
            this.groupBox_proxyWay.PerformLayout();
            this.groupBox_proxyProtocol.ResumeLayout(false);
            this.groupBox_proxyProtocol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_proxy_port)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_noProxy;
        private System.Windows.Forms.RadioButton radioButton_SystemProxy;
        private System.Windows.Forms.RadioButton radioButton_CustomProxy;
        private System.Windows.Forms.GroupBox groupBox_proxyWay;
        private System.Windows.Forms.GroupBox groupBox_proxyProtocol;
        private System.Windows.Forms.RadioButton radioButton_proxy_socks;
        private System.Windows.Forms.RadioButton radioButton_proxy_http;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_proxy_port;
        private System.Windows.Forms.TextBox textBox_proxy_host;
    }
}
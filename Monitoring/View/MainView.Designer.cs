namespace Monitoring.View
{
    partial class MainView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gboxConnection = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConnect = new System.Windows.Forms.Label();
            this.gboxStatus = new System.Windows.Forms.GroupBox();
            this.pnlDeviceView = new System.Windows.Forms.FlowLayoutPanel();
            this.gboxLog = new System.Windows.Forms.GroupBox();
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.gboxService = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.chkReboot = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gboxConnection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gboxStatus.SuspendLayout();
            this.gboxLog.SuspendLayout();
            this.gboxService.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.gboxConnection, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gboxStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gboxLog, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gboxService, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 495);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gboxConnection
            // 
            this.gboxConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxConnection.Controls.Add(this.panel1);
            this.gboxConnection.Location = new System.Drawing.Point(271, 5);
            this.gboxConnection.Margin = new System.Windows.Forms.Padding(3, 5, 10, 0);
            this.gboxConnection.Name = "gboxConnection";
            this.gboxConnection.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gboxConnection.Size = new System.Drawing.Size(94, 42);
            this.gboxConnection.TabIndex = 11;
            this.gboxConnection.TabStop = false;
            this.gboxConnection.Text = "Connect";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblConnect);
            this.panel1.Location = new System.Drawing.Point(3, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 25);
            this.panel1.TabIndex = 0;
            // 
            // lblConnect
            // 
            this.lblConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnect.Location = new System.Drawing.Point(3, 4);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(82, 19);
            this.lblConnect.TabIndex = 0;
            this.lblConnect.Text = "대기";
            // 
            // gboxStatus
            // 
            this.gboxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gboxStatus, 4);
            this.gboxStatus.Controls.Add(this.pnlDeviceView);
            this.gboxStatus.Location = new System.Drawing.Point(10, 54);
            this.gboxStatus.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.gboxStatus.Name = "gboxStatus";
            this.gboxStatus.Size = new System.Drawing.Size(517, 163);
            this.gboxStatus.TabIndex = 8;
            this.gboxStatus.TabStop = false;
            this.gboxStatus.Text = "Status";
            // 
            // pnlDeviceView
            // 
            this.pnlDeviceView.AutoScroll = true;
            this.pnlDeviceView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeviceView.Location = new System.Drawing.Point(3, 17);
            this.pnlDeviceView.Name = "pnlDeviceView";
            this.pnlDeviceView.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDeviceView.Size = new System.Drawing.Size(511, 143);
            this.pnlDeviceView.TabIndex = 0;
            // 
            // gboxLog
            // 
            this.gboxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gboxLog, 4);
            this.gboxLog.Controls.Add(this.richLog);
            this.gboxLog.Location = new System.Drawing.Point(10, 227);
            this.gboxLog.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.gboxLog.Name = "gboxLog";
            this.gboxLog.Size = new System.Drawing.Size(517, 258);
            this.gboxLog.TabIndex = 7;
            this.gboxLog.TabStop = false;
            this.gboxLog.Text = "Log";
            // 
            // richLog
            // 
            this.richLog.BackColor = System.Drawing.Color.White;
            this.richLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richLog.Location = new System.Drawing.Point(3, 17);
            this.richLog.Name = "richLog";
            this.richLog.ReadOnly = true;
            this.richLog.Size = new System.Drawing.Size(511, 238);
            this.richLog.TabIndex = 1;
            this.richLog.Text = "";
            // 
            // gboxService
            // 
            this.gboxService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gboxService, 2);
            this.gboxService.Controls.Add(this.flowLayoutPanel1);
            this.gboxService.Location = new System.Drawing.Point(378, 5);
            this.gboxService.Margin = new System.Windows.Forms.Padding(3, 5, 10, 0);
            this.gboxService.Name = "gboxService";
            this.gboxService.Size = new System.Drawing.Size(149, 42);
            this.gboxService.TabIndex = 10;
            this.gboxService.TabStop = false;
            this.gboxService.Text = "CMD";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.chkSMS);
            this.flowLayoutPanel1.Controls.Add(this.chkReboot);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 25);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.Location = new System.Drawing.Point(3, 3);
            this.chkSMS.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(51, 16);
            this.chkSMS.TabIndex = 4;
            this.chkSMS.Text = "SMS";
            this.chkSMS.UseVisualStyleBackColor = true;
            this.chkSMS.CheckedChanged += new System.EventHandler(this.chkSMS_CheckedChanged);
            // 
            // chkReboot
            // 
            this.chkReboot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReboot.AutoSize = true;
            this.chkReboot.Location = new System.Drawing.Point(67, 3);
            this.chkReboot.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.chkReboot.Name = "chkReboot";
            this.chkReboot.Size = new System.Drawing.Size(63, 16);
            this.chkReboot.TabIndex = 5;
            this.chkReboot.Text = "Reboot";
            this.chkReboot.UseVisualStyleBackColor = true;
            this.chkReboot.CheckedChanged += new System.EventHandler(this.chkReboot_CheckedChanged);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(388, 534);
            this.Name = "MainView";
            this.Text = "배터리 모니터링";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gboxConnection.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gboxStatus.ResumeLayout(false);
            this.gboxLog.ResumeLayout(false);
            this.gboxService.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkReboot;
        private System.Windows.Forms.CheckBox chkSMS;
        private System.Windows.Forms.GroupBox gboxStatus;
        private System.Windows.Forms.FlowLayoutPanel pnlDeviceView;
        private System.Windows.Forms.GroupBox gboxLog;
        private System.Windows.Forms.RichTextBox richLog;
        private System.Windows.Forms.GroupBox gboxService;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gboxConnection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConnect;
    }
}
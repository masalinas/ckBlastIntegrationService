namespace com.thingtrack.ckblast.service.manager
{
    partial class CkBlastIntegrationServiceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CkBlastIntegrationServiceManager));
            this.notifyIcon_CkBlastIntegrationService = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_CkBlastIntegrationService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceController_CkBlastIntegrationService = new System.ServiceProcess.ServiceController();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClearReadData = new System.Windows.Forms.Button();
            this.timerReadData = new System.Windows.Forms.Timer(this.components);
            this.btnReadValue = new System.Windows.Forms.Button();
            this.lstBoxReadData = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_CkBlastIntegrationService.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon_CkBlastIntegrationService
            // 
            this.notifyIcon_CkBlastIntegrationService.ContextMenuStrip = this.contextMenuStrip_CkBlastIntegrationService;
            this.notifyIcon_CkBlastIntegrationService.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_CkBlastIntegrationService.Icon")));
            this.notifyIcon_CkBlastIntegrationService.Text = "Demo Windows Service";
            this.notifyIcon_CkBlastIntegrationService.Visible = true;
            this.notifyIcon_CkBlastIntegrationService.Click += new System.EventHandler(this.notifyIcon_DemoWinService_Click);
            this.notifyIcon_CkBlastIntegrationService.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_DemoWinService_MouseDoubleClick);
            // 
            // contextMenuStrip_CkBlastIntegrationService
            // 
            this.contextMenuStrip_CkBlastIntegrationService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.showApplicationToolStripMenuItem});
            this.contextMenuStrip_CkBlastIntegrationService.Name = "contextMenuStrip_DemoWinService";
            this.contextMenuStrip_CkBlastIntegrationService.Size = new System.Drawing.Size(168, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // showApplicationToolStripMenuItem
            // 
            this.showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem";
            this.showApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.showApplicationToolStripMenuItem.Text = "Show Application";
            this.showApplicationToolStripMenuItem.Click += new System.EventHandler(this.showApplicationToolStripMenuItem_Click);
            // 
            // serviceController_CkBlastIntegrationServiceService
            // 
            this.serviceController_CkBlastIntegrationService.ServiceName = "CkBlastIntegrationWinService";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(90, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClearReadData
            // 
            this.btnClearReadData.Location = new System.Drawing.Point(90, 41);
            this.btnClearReadData.Name = "btnClearReadData";
            this.btnClearReadData.Size = new System.Drawing.Size(75, 23);
            this.btnClearReadData.TabIndex = 9;
            this.btnClearReadData.Text = "Clear";
            this.btnClearReadData.UseVisualStyleBackColor = true;
            this.btnClearReadData.Click += new System.EventHandler(this.btnClearReadData_Click);
            // 
            // timerReadData
            // 
            this.timerReadData.Interval = 300;
            this.timerReadData.Tick += new System.EventHandler(this.timerReadData_Tick);
            // 
            // btnReadValue
            // 
            this.btnReadValue.Location = new System.Drawing.Point(11, 40);
            this.btnReadValue.Name = "btnReadValue";
            this.btnReadValue.Size = new System.Drawing.Size(75, 23);
            this.btnReadValue.TabIndex = 8;
            this.btnReadValue.Text = "Read Data";
            this.btnReadValue.UseVisualStyleBackColor = true;
            this.btnReadValue.Click += new System.EventHandler(this.btnReadValue_Click);
            // 
            // lstBoxReadData
            // 
            this.lstBoxReadData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxReadData.FormattingEnabled = true;
            this.lstBoxReadData.HorizontalScrollbar = true;
            this.lstBoxReadData.IntegralHeight = false;
            this.lstBoxReadData.Location = new System.Drawing.Point(12, 69);
            this.lstBoxReadData.Name = "lstBoxReadData";
            this.lstBoxReadData.Size = new System.Drawing.Size(347, 220);
            this.lstBoxReadData.TabIndex = 7;
            // 
            // CkBlastIntegrationServiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 300);
            this.Controls.Add(this.btnClearReadData);
            this.Controls.Add(this.btnReadValue);
            this.Controls.Add(this.lstBoxReadData);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "CkBlastIntegrationServiceManager";
            this.Text = "CkBlast Integration Service Manager";
            this.Load += new System.EventHandler(this.formDemoWinServiceApp_Load);
            this.Resize += new System.EventHandler(this.formDemoWinServiceApp_Resize);
            this.contextMenuStrip_CkBlastIntegrationService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon_CkBlastIntegrationService;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_CkBlastIntegrationService;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showApplicationToolStripMenuItem;
        private System.ServiceProcess.ServiceController serviceController_CkBlastIntegrationService;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClearReadData;
        private System.Windows.Forms.Timer timerReadData;
        private System.Windows.Forms.Button btnReadValue;
        public System.Windows.Forms.ListBox lstBoxReadData;
    }
}


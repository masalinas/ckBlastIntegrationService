namespace com.thingtrack.integration.service
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller_ckBlastIntegrationWinService = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller_ckBlastIntegrationWinService = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller_ckBlastIntegrationWinService
            // 
            this.serviceProcessInstaller_ckBlastIntegrationWinService.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.serviceProcessInstaller_ckBlastIntegrationWinService.Password = null;
            this.serviceProcessInstaller_ckBlastIntegrationWinService.Username = null;
            // 
            // serviceInstaller_ckBlastIntegrationWinService
            // 
            this.serviceInstaller_ckBlastIntegrationWinService.DisplayName = "CkBlast Integration Service";
            this.serviceInstaller_ckBlastIntegrationWinService.ServiceName = "CkBlastIntegrationWinService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller_ckBlastIntegrationWinService,
            this.serviceInstaller_ckBlastIntegrationWinService});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller_ckBlastIntegrationWinService;
        private System.ServiceProcess.ServiceInstaller serviceInstaller_ckBlastIntegrationWinService;
    }
}
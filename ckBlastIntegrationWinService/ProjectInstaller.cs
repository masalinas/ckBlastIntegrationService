using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;

namespace com.thingtrack.integration.service
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();

            serviceInstaller_ckBlastIntegrationWinService.Description = "Este servicio es responsable de la integración entre ckBlast Desktop y ckBlast Cloud";
        }
    }
}
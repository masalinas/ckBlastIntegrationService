using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace com.thingtrack.ckblast.service.manager
{
    public partial class CkBlastIntegrationServiceManager : Form
    {
        public CkBlastIntegrationServiceManager()
        {
            InitializeComponent();

            SetDisplay(serviceController_CkBlastIntegrationService);
        }

        private void notifyIcon_DemoWinService_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void formDemoWinServiceApp_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon_DemoWinService_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            serviceController_CkBlastIntegrationService.Start();
            btnStart.Enabled=false;
            btnStop.Enabled=true;
            timerReadData.Enabled = true;

            Cursor.Current = Cursors.Default;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            serviceController_CkBlastIntegrationService.Stop();
            btnStart.Enabled =true;
            btnStop.Enabled=false;
            timerReadData.Enabled = false;

            Cursor.Current = Cursors.Default;
        }

        private void SetDisplay(ServiceController sc)
        {
            sc.Refresh();

            if(sc.Status == ServiceControllerStatus.Stopped)
            {
                btnStop.Enabled = false;
            }
            else if(sc.Status == ServiceControllerStatus.Running)
            {
                btnStart.Enabled = false;
            }
        }
        public void ConnectToWinService()
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            Cursor.Current = Cursors.Default;
        }
        private void formDemoWinServiceApp_Load(object sender, EventArgs e)
        {   
        }

        private void btnReadValue_Click(object sender, EventArgs e)
        {
        }

        private void btnClearReadData_Click(object sender, EventArgs e)
        {
            for (int nIndex = (lstBoxReadData.Items.Count -1); nIndex >= 0; nIndex--)
            {
              lstBoxReadData.Items.RemoveAt(nIndex);
            }
        }

        private void Log(string data)
        {
            lstBoxReadData.Items.Add(data);
            int itemsPerPage = (int)(lstBoxReadData.Height / lstBoxReadData.ItemHeight);
            lstBoxReadData.TopIndex = lstBoxReadData.Items.Count - itemsPerPage + 2;
        }

        private void timerReadData_Tick(object sender, EventArgs e)
        {
            SetDisplay(serviceController_CkBlastIntegrationService);
            try
            {
  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                timerReadData.Enabled = false;
            }
        }
    }
}
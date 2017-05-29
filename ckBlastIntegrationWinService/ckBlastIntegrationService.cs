using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.IO;
using System.Net;

using log4net;

using com.thingtrack.integration.service.util;

namespace com.thingtrack.integration.service
{
    public partial class ckBlastIntegrationService : ServiceBase
    {
        // Define a static logger variable so that it references the Logger instance named "ckBlastIntegrationWinService".
        private static readonly ILog log = LogManager.GetLogger(typeof(ckBlastIntegrationService));

        private FileSystemWatcher watcher = null;

        private string watchPath;
        private string backupPath;
        private string errorPath;

        private string ftpServer;
        private string ftpUsername;
        private string ftpPassword;

        public ckBlastIntegrationService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            log.Info("Starting ckBlast Integration Service.");
            
            // recovering FTP tokens
            this.ftpServer = Util.GetSetting("FtpServer");
            this.ftpUsername = Util.GetSetting("FtpUsername");
            this.ftpPassword = Util.GetSetting("FtpPassword");

            // get WatchPath parameter and create directory if not exist
            this.watchPath = Util.GetSetting("WatchPath");
            Util.IsDirectoryPresent(watchPath, true);

            // get BackupPath parameter and create directory if not exist
            this.backupPath = Util.GetSetting("BackupPath");
            Util.IsDirectoryPresent(backupPath, true);

            this.errorPath = Util.GetSetting("ErrorPath");
            Util.IsDirectoryPresent(errorPath, true);

            // Create a new FileSystemWatcher with the path and xml file filter
            watcher = new FileSystemWatcher(watchPath, "*.xml");

            //Watch for changes in LastAccess and LastWrite times, and the renaming of files or directories.
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            // Add event handlers.
            watcher.Created += new FileSystemEventHandler(OnChanged);
            //watcher.Changed += new FileSystemEventHandler(OnChanged);
            //watcher.Deleted += new FileSystemEventHandler(OnChanged);
            //watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            log.Info("Monitoring Started");
        }

        protected override void OnStop()
        {            
            log.Info("Stopping ckBlast Integration Service.");

            // Stopping watching.
            watcher.EnableRaisingEvents = false;
            watcher.Dispose();
           
            log.Info("Monitoring Stopped");
        }

        void OnChanged(object sender, FileSystemEventArgs e)
        {
            try
            {
                // Get the object used to communicate with the server.
                log.Info("Getting FTP server connection: " + ftpServer + "/" + e.Name);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer + "/" + e.Name);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                // connect to ftp server.
                log.Info("Connecting to FTP server using credentials: " + ftpUsername + "/" + ftpPassword);
                request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

                // Copy the contents of the file to the request stream.
                log.Info("Uploading file: " + e.FullPath);
                StreamReader sourceStream = new StreamReader(e.FullPath);
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                request.ContentLength = fileContents.Length;

                log.Info("Sending " + fileContents.Length + " bytes");
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                log.Info("Uploaded file correctly, status: " + response.StatusDescription);

                // backup file
                File.Move(e.FullPath, backupPath + "\\" + e.Name);
                log.Info("File " + e.FullPath + " backup correctly");
            }
            catch (Exception ex)
            {
                log.Error("Error uploading file", ex);
                try
                {
                    File.Move(e.FullPath, errorPath + "\\" + e.Name);

                    // move to error directory
                    log.Info("File " + e.FullPath + " moved to error directory");
                }
                catch (Exception)
                { }
            }
            
        }

        private void LogEvent(string message)
        {
            // using Windows Event Log
            string eventSource = "File Monitor Service";

            DateTime dt = new DateTime();
            dt = System.DateTime.UtcNow;

            message = dt.ToLocalTime() + ": " + message;

            EventLog.WriteEntry(eventSource, message);
        }
    }
}

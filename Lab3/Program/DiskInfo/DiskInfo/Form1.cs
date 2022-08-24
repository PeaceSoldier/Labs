using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DiskInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listView1.View = View.Details;
           
            DriveInfo[] drives = DriveInfo.GetDrives(); 
            for (int i = 0; i < drives.Length; i++) 
            {
                string freeSpace, totalSize, format, volume, type; 
                try 
                {
                    freeSpace = drives[i].AvailableFreeSpace.ToString();
                    format = drives[i].DriveFormat;
                    totalSize = drives[i].TotalSize.ToString();
                    volume = drives[i].VolumeLabel.ToString();

                }
                catch 
                {
                    freeSpace = "Невідомо";
                    format = "Невідомо";
                    totalSize = "Невідомо";
                    volume = "Невідомо";
                }

                type = drives[i].DriveType.ToString();
                
                columnHeader1.ListView.Items.Add(drives[i].Name);
                columnHeader2.ListView.Items[i].SubItems.Add(type);
                columnHeader3.ListView.Items[i].SubItems.Add(freeSpace);
                columnHeader4.ListView.Items[i].SubItems.Add(totalSize);
                columnHeader5.ListView.Items[i].SubItems.Add(format);
                columnHeader6.ListView.Items[i].SubItems.Add(volume);          
            }
            var allMemory = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
            label1.Text = "RAM: " + allMemory.ToString();
            label2.Text = "Computer name: " + Environment.MachineName;
            label3.Text = "User name: " + Environment.UserName;
            label4.Text = "System direction: " + Environment.SystemDirectory;
            label5.Text = "Temp direction: " + Path.GetTempPath();
            label6.Text = "Windows direction: " + Environment.GetEnvironmentVariable("SystemRoot");
            label7.Text = "Directory: " + Directory.GetCurrentDirectory();
        }
        public void Run()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"C:\Users\Yaroslav\Desktop";
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.txt";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.EnableRaisingEvents = true;
            File.Delete(@"D:\Labs\3kurs\labs\lab3\log.txt");
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            string path = @"D:\Labs\3kurs\labs\lab3\log.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"File: {e.FullPath} {e.ChangeType}");
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            string path = @"D:\Labs\3kurs\labs\lab3\log.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Run();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
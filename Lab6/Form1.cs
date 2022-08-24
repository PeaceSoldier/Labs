using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Form1 : Form
    {
        private WindowsPrincipal principal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializePrincipal();
            WriteUsersInfo();
            InitializeAdminInfoLabel();
        }

        private void InitializePrincipal()
        {
            principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
        }

        private bool CheckIfAdmin() => principal.IsInRole(WindowsBuiltInRole.Administrator);

        private void WriteUsersInfo()
        {
            ManagementObjectSearcher usersSearcher = new ManagementObjectSearcher(@"SELECT * FROM Win32_UserAccount");
            ManagementObjectCollection users = usersSearcher.Get();

            var localUsers = users.Cast<ManagementObject>().Where(
                u =>
                     (bool)u["Disabled"] == false &&
                     (bool)u["Lockout"] == false &&
                     int.Parse(u["SIDType"].ToString()) == 1 &&
                     u["Name"].ToString() != "HomeGroupUser$");

            foreach (ManagementObject user in users)
            {
                textBoxUsers.Text += "Name: " + user["Name"].ToString() + Environment.NewLine;
                textBoxUsers.Text += "Caption: " + user["Caption"].ToString() + Environment.NewLine;
                textBoxUsers.Text += "Description: " + user["Description"].ToString() + Environment.NewLine;
                textBoxUsers.Text += "Password Required: " + user["PasswordRequired"].ToString() + Environment.NewLine;
                textBoxUsers.Text += "Account Type: " + user["AccountType"].ToString() + Environment.NewLine;
                textBoxUsers.Text += Environment.NewLine;
            }
        }

        private void InitializeAdminInfoLabel()
        {
            if (CheckIfAdmin())
                labelAdminInfo.Text = "User have pormissions";
            else
                labelAdminInfo.Text = "User dont have ";
        }


        private void buttonShowInfoMessage_Click(object sender, EventArgs e)
        {
            if (CheckIfAdmin())
                MessageBox.Show("You have permissions");
            else
                MessageBox.Show("you dont have permission");
        }

        private void textBoxUsers_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGetAdminRights_Click(object sender, EventArgs e)
        {
            if (CheckIfAdmin())
                MessageBox.Show("You already have permissions");
            else
                GetAdminRights();

        }

        private void GetAdminRights()
        {
            string fileName = Assembly.GetExecutingAssembly().Location;
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.Verb = "runas";
            processInfo.FileName = fileName;

            try
            {
                this.Close();
                Process.Start(processInfo);
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}

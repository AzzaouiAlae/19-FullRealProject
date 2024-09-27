using DVLD_Business;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD.Forms
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            FillForm();
            clsUser.AppPath = Application.StartupPath;
        }
        void FillForm()
        {
            string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\DVLD";
            try
            {
                string Username = Registry.GetValue(keyPath, "UserValue", null) as string;
                string Pass = Registry.GetValue(keyPath, "PassValue", null) as string;

                if (Username != null && Pass != null)
                {
                    txt_Username.Text = Username;
                    txt_Pass.Text = Pass;
                    cbx_RememberMe.Checked = true;
                }
            }
            catch (Exception ex)
            {
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                    Console.WriteLine("Event source created.");
                }
                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        Point downPoint = Point.Empty;
        private void LoginFrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }
        private void LoginFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }
        private void LoginFrm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }
        void SaveLogin(string username, string password)
        {
            string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\DVLD";
            string valueName1 = "UserValue";
            string valueName2 = "PassValue";

            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, valueName1, username, RegistryValueKind.String);
                Registry.SetValue(keyPath, valueName2, password, RegistryValueKind.String);
            }
            catch (Exception ex)
            {
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                    Console.WriteLine("Event source created.");
                }
                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
        }
        void DeleteLogin()
        {
            string KeyPath = @"SOFTWARE\DVLD";
            string ValueName1 = "UserValue";
            string ValueName2 = "PassValue";

            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(KeyPath, true))
                    {
                        if (key == null) return;

                        if (key.ValueCount > 0)
                        {
                            key.DeleteValue(ValueName1);
                            key.DeleteValue(ValueName2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            int result = clsUser.Login(txt_Username.Text, txt_Pass.Text);
            if (result != -1)
            {
                MainForm frm = new MainForm(result);
                Visible = false;
                if (cbx_RememberMe.Checked)
                    SaveLogin(txt_Username.Text, txt_Pass.Text);
                else
                    DeleteLogin();
                frm.ShowDialog();
                Visible = true;
            }
            else
                MessageBox.Show("Invalid Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

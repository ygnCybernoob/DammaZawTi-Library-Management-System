using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LMS_UI
{
    public partial class FrmServerRegister : Form
    {

        public FrmServerRegister()
        {
            InitializeComponent();
        }

        #region myCode

        private void OpenMain(object obj)
        {
            FrmMain main = new FrmMain();
            Application.Run(main);
        }

        public bool CheckRequiredFiled()
        {
            if (string.IsNullOrEmpty(txtServer.Text.Trim()))
            {
                Utilities.ToolTipControl("please fill the server name", txtServer);
                txtServer.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtDatabase.Text.Trim()))
            {
                Utilities.ToolTipControl("please fill the database name", txtDatabase);
                txtDatabase.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                Utilities.ToolTipControl("please fill the user name", txtUsername);
                txtUsername.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                Utilities.ToolTipControl("please fill the password", txtPassword);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConnect_Click(null, null);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (CheckRequiredFiled())
            {
                string connectionString = string.Format("Data Source={0};Initial Catalog={1}; User ID={2}; Password={3}", txtServer.Text.Trim(), txtDatabase.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text);
                try
                {
                    SqlHelper helper = new SqlHelper(connectionString);
                    if (helper.IsConnection())
                    {
                        Utilities.ShowMessage(Utilities.MessageType.Information, "Connection Succeeded");
                        AppSetting setting = new AppSetting();
                        setting.SaveConnectionString("ServerConnection", connectionString);

                        Utilities.ShowMessage(Utilities.MessageType.Information, "Please re-open the software after software closed");
                        Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    Utilities.ShowMessage(Utilities.MessageType.Error, ex.ToString());
                } 
            }
        }

        private void FrmServerRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
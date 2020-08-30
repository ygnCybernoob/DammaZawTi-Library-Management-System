using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LMS_INFO;
using LMS_BLL;

namespace LMS_UI
{
    public partial class FrmLogin_OpenAdmin : Form
    {
        Account_Controller controller;
        Account_Collection collection;
        Account_Info info;

        int count = 0;
        int count2 = 0;

        bool Correct = false;


        public FrmLogin_OpenAdmin()
        {
            InitializeComponent();
        }

        #region myCode

        private void Bind_Account()
        {
            controller = new Account_Controller();
            collection = controller.Select_Account();
            cboAccount.DisplayMember = "UserName";
            cboAccount.ValueMember = "AccountId";
            cboAccount.DataSource = collection;
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_OpenAdmin_Load(object sender, EventArgs e)
        {
            Bind_Account();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning,"လွ်ိဳ႕၀ွက္ကုဒ္ကို ထည့္သြင္းေပးပါ");
                txtPassword.Focus();
            }
            else
            {

                controller = new Account_Controller();

                string password = Utilities.PasswordEncrypt(txtPassword.Text);
                Account_Controller.Status status = controller.CheckAccount(cboAccount.SelectedValue.ToString(), password);

                if (status == Account_Controller.Status.ActiveTrueAdmin)
                {
                    info = controller.SelectAccountInfo((cboAccount.SelectedValue.ToString()));
                    FrmMain.Accountinfo = info;
                    FrmMain.Accountstaus = Account_Controller.Status.ActiveTrueAdmin;
                    Correct = true;
                    this.Close();
                }
                else if (status == Account_Controller.Status.ActiveTrue)
                {
                    info = controller.SelectAccountInfo(cboAccount.SelectedValue.ToString());
                    FrmMain.Accountinfo = info;
                    FrmMain.Accountstaus = Account_Controller.Status.ActiveTrue;
                    Correct = true;
                    this.Close();
                }
                else if (status == Account_Controller.Status.Active_False)
                {
                    info = controller.SelectAccountInfo(cboAccount.SelectedValue.ToString());

                    FrmChangePassword cp = new FrmChangePassword(info);
                    cp.ShowDialog();
                }
                else if (status == Account_Controller.Status.Ban)
                {
                    Utilities.ShowMessage(Utilities.MessageType.Information, "သင္၏ အေကာင့္မွာ အပိတ္ခံထားရပါသည္");
                }
                else
                {
                    Utilities.ShowMessage(Utilities.MessageType.Information, "သင္၏လွ်ိဳ႕၀ွက္ကုဒ္မွာ မွားယြင္းေနပါသည္");
                    count++;
                    if (count >= 5)
                    {
                        this.Cursor = System.Windows.Forms.Cursors.AppStarting;
                        txtPassword.Enabled = false;
                        btnLogin.Enabled = false;
                        timer1.Start();
                    }

                }
                txtPassword.Text = string.Empty;

            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void cboAccount_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count2 < 1)
            {
                count2++;
            }
            else
            {
                count--;
                txtPassword.Enabled = true;
                btnLogin.Enabled = true;
                txtPassword.Focus();
                this.Cursor = System.Windows.Forms.Cursors.Default;
                timer1.Stop();
            }
        }

        private void FrmLogin_OpenAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Correct)
            {
                FrmMain.Accountstaus = Account_Controller.Status.NotExist;
            }
        }
    }
}

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
    public partial class FrmChangePassword : Form
    {
        private string accountid;
        private string password;

        public FrmChangePassword(Account_Info info)
        {
            InitializeComponent();

            txtAccount.Text = info.Username;
            accountid = info.Accountid;
            password = info.Password;
        }

        #region myCode

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "လွ်ဳိ႕၀ွက္ကုဒ္ကို ထည့္သြင္းေပးပါ");
                txtPassword.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtConfirm.Text))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "လွ်ဳိ႕၀ွက္ကုဒ္အတည္ျပဳျခင္းကို ထည့္သြင္းေပးပါ");
                txtConfirm.Focus();
                return false;
            }
            else if (!txtPassword.Text.Equals(txtConfirm.Text))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "လွ်ိဳ႕၀ွက္ကုဒ္နွင့္ လွ်ိဳ႕၀ွက္ကုဒ္အတည္ျပဳခ်က္တို႕မွာ မတူညီပါသျဖင့္ ျပန္လည္စစ္ေဆး ထည့္သြင္းေပးပါ");
                txtPassword.Text = string.Empty;
                txtConfirm.Text = string.Empty;
                txtPassword.Focus();
                return false;
            }
            else if (password.Equals(Utilities.PasswordEncrypt(txtPassword.Text)))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "စနစ္လုံျခံဳေရးအရ ယခင္ကုဒ္နွင့္မတူညီေသာ လွ်ိဳ႕၀ွက္ကုဒ္ကို ထည့္သြင္းေပးပါ");
                txtPassword.Text = string.Empty;
                txtConfirm.Text = string.Empty;
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void Clear()
        {

        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckRequiredField())
            {
                Account_Controller controller = new Account_Controller();
                password = Utilities.PasswordEncrypt(txtPassword.Text);
                controller.UpdatePassword(accountid, password);

                Utilities.ShowMessage(Utilities.MessageType.Information, "လွ်ိဳ႕၀ွက္ကုဒ္ကို ေျပာင္းလဲျပီးပါျပီ");
                this.Close();
            }
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }

        private void FrmChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
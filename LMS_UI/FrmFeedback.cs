using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LMS_BLL;
using LMS_INFO;

namespace LMS_UI
{
    public partial class FrmFeedback : Form
    {
        Feedback_Controller controller;
        Feedback_Info info;

        public FrmFeedback()
        {
            InitializeComponent();
        }

        #region myCode

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtMemberBarcode.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "အသင္း၀င္ ဘားကုဒ္ကို ထည့္သြင္းေပးပါ");
                txtMemberBarcode.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtSubject.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "အေၾကာင္းအရာေခါင္းစဉ္ကို ထည့္သြင္းေပးပါ");
                txtSubject.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "အေၾကာင္းအရာကို ထည့္သြင္းေပးပါ");
                txtDescription.Focus();
                return false;
            }

            return true;
        }

        private void Clear()
        {
            txtMemberBarcode.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtDescription.Text = string.Empty;

            txtMemberBarcode.Focus();
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    controller = new Feedback_Controller();
                    info = new Feedback_Info();

                    info.Memberbarcode = txtMemberBarcode.Text.Trim();
                    info.Subject = txtSubject.Text.Trim();
                    info.Feedback = txtDescription.Text.Trim();

                    controller.Insert_Feedback(info);

                    Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, ex.Message);
            }
        }

        private void FrmFeedback_Load(object sender, EventArgs e)
        {
            Utilities.CenterMyControl(picImage);
            Utilities.CenterMyControl(pnlBack);
        }

        private void FrmFeedback_SizeChanged(object sender, EventArgs e)
        {
            Utilities.CenterMyControl(picImage);
            Utilities.CenterMyControl(pnlBack);
        }

        private void txtMemberBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtSubject_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
        }
    }
}
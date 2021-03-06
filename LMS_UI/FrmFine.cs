using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LMS_BLL;

namespace LMS_UI
{
    public partial class FrmFine : Form
    {
        Fine_Controller fine_controller;

        public FrmFine()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFine.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ဒဏ္ေၾကးေငြကို ထည့္သြင္းေပးပါ");
                txtFine.Focus();
            }
            else
            {
                fine_controller = new Fine_Controller();
                fine_controller.Update_Fine(Convert.ToInt64(txtFine.Text.Trim()));

                Utilities.ShowMessage(Utilities.MessageType.Information, "ဒဏ္ေၾကးေငြကို  " + txtFine.Text.Trim() + "က်ပ္  သို႕ ေျပာင္းလဲသတ္မွတ္ျပီးပါျပီ");
                btnCancel.Focus();
            }
        }

        private void txtFine_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if (!((i >= '0' && i <= '9') || i == 8))
            {
                e.Handled = true;
                txtFine.ForeColor = Color.Red;
            }
            else
            {
                txtFine.ForeColor = Color.Black;
            }
        }

        private void txtFine_Leave(object sender, EventArgs e)
        {
            txtFine.ForeColor = Color.Black;
        }

        private void FrmFine_Load(object sender, EventArgs e)
        {
            fine_controller = new Fine_Controller();
            txtFine.Text = Convert.ToString(fine_controller.Select_Fine());
        }

        private void txtFine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }

        private void FrmFine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
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
    public partial class FrmBookCategory : Form
    {
        BookCategory_Controller controller;
        BookCategory_Collection collection;
        BookCategory_Info info;
        private int categoryid;

        public FrmBookCategory()
        {
            InitializeComponent();
        }

        #region myCode

        private void Clear()
        {
            txtCategoryCode.Focus();
            btnSave.Text = "ထည့္သြင္းရန္";
            btnCancel.Text = "ထြက္ရန္";

            txtCategoryCode.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtDesp.Text = string.Empty;
        }

        private void Bind_BookCategory()
        {
            controller = new BookCategory_Controller();
            collection = controller.Select_Category();
            dgvBookCategory.AutoGenerateColumns = false;
            dgvBookCategory.DataSource = collection;
        }

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtCategoryCode.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "စာအုပ္အမ်ိဳးအစားကုဒ္ ကို ထည့္သြင္းေပးပါ");
                txtCategoryCode.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtCategory.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "စာအုပ္အမ်ိဳးအစားကို ထည့္သြင္းေပးပါ");
                txtCategory.Focus();
                return false;
            }
            return true;
        }

        #endregion

        private void FrmBookCategory_Load(object sender, EventArgs e)
        {
            Bind_BookCategory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    controller = new BookCategory_Controller();
                    info = new BookCategory_Info();

                    switch (btnSave.Text)
                    {
                        case "ထည့္သြင္းရန္":

                            info.Categorycode = txtCategoryCode.Text.Trim();
                            info.Category = txtCategory.Text.Trim();
                            info.Desp = txtDesp.Text.Trim();
                            controller.Insert_Category(info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                            break;

                        case "ျပင္ဆင္ရန္":

                            info.Categoryid = categoryid;
                            info.Categorycode = txtCategoryCode.Text.Trim();
                            info.Category = txtCategory.Text.Trim();
                            info.Desp = txtDesp.Text.Trim();
                            controller.Update_Category(info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ျပင္ဆင္ျပီးပါျပီ");
                            break;
                    }
                    Clear();
                    Bind_BookCategory();
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            switch (btnCancel.Text)
            {
                case "ထြက္ရန္":
                    this.Close();
                    break;

                case "မလုပ္ေသးပါ":
                    Clear();
                    break;
            }
        }

        private void txtCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void dgvBookCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvBookCategory.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colEdit":
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnCancel.Text = "မလုပ္ေသးပါ";

                    categoryid = Convert.ToInt32(row.Cells[colCategoryid.Index].Value);
                    txtCategoryCode.Text = row.Cells[colCategoryCode.Index].Value.ToString();
                    txtCategory.Text = row.Cells[colCategory.Index].Value.ToString();
                    txtDesp.Text = row.Cells[colDesp.Index].Value.ToString();

                    break;
            }
            Bind_BookCategory();
        }

        private void txtCategoryCode_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void FrmBookCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtCategoryCode_Leave(object sender, EventArgs e)
        {
            txtCategoryCode.Text = txtCategoryCode.Text.ToUpper();
        }
    }
}
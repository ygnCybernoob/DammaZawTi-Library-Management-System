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
    public partial class FrmAuthor : Form
    {
        Author_Collection author_collection;
        Author_Controller author_controller;
        Author_Info author_info;
        private int authorid;

        public FrmAuthor()
        {
            InitializeComponent();
        }

        #region myCode
        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtAuthor.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "စာေရးဆရာအမည္ကို ထည့္သြင္းေပးပါ");
                txtAuthor.Focus();
                return false;
            }
            return true;
        }

        private void Clear()
        {
            txtAuthor.Focus();
            btnSave.Text = "ထည့္သြင္းရန္";
            btnCancel.Text = "ထြက္ရန္";

            txtAuthor.Text = string.Empty;
            cboGender.SelectedIndex = 0;
            txtDesp.Text = string.Empty;
        }


        private void Bind_Author(int type)
        {
            author_controller = new Author_Controller();
            author_collection = author_controller.Select_Author(type, txtAuthor.Text.Trim());
            dgvAuthor.AutoGenerateColumns = false;
            dgvAuthor.DataSource = author_collection;
        }
    
        #endregion

        private void FrmAuthor_Load(object sender, EventArgs e)
        {
            cboGender.SelectedIndex = 0;
            Bind_Author(3);
        }

        private void cboAuthortype_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            switch (btnCancel.Text)
            {
                case  "ထြက္ရန္":
                    this.Close();
                    break;

                case "မလုပ္ေသးပါ":
                    Clear();
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    author_controller = new Author_Controller();
                    author_info = new Author_Info();

                    switch (btnSave.Text)
                    {
                        case "ထည့္သြင္းရန္":

                            author_info.Author = txtAuthor.Text.Trim();
                            author_info.Gender = (cboGender.SelectedIndex == 0) ? "male" : "female";
                            author_info.Desp = txtDesp.Text.Trim();
                            author_controller.Insert_Author(author_info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                            break;

                        case "ျပင္ဆင္ရန္":

                            author_info.Authorid = authorid;
                            author_info.Author = txtAuthor.Text.Trim();
                            author_info.Gender = (cboGender.SelectedIndex == 0) ? "male" : "female";
                            author_info.Desp = txtDesp.Text.Trim();
                            author_controller.Update_Author(author_info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ျပင္ဆင္ျပီးပါျပီ");
                            break;
                    }
                    Clear();
                    Bind_Author(3);
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, ex.Message);
            }
        }

        private void dgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvAuthor.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colEdit":
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnCancel.Text = "မလုပ္ေသးပါ";

                    authorid = Convert.ToInt32(row.Cells[colAuthorid.Index].Value);
                    txtAuthor.Text = row.Cells[colAuthor.Index].Value.ToString();
                    cboGender.SelectedItem = row.Cells[colGender.Index].Value;
                    txtDesp.Text = row.Cells[colDesp.Index].Value.ToString();
                    
                    break;
            }
        }

        private void FrmAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            Bind_Author(4);
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGender.SelectedIndex == 0)
            {
                Bind_Author(1);
            }
            else
            {
                Bind_Author(2);
            }

        }
    }
}
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
    public partial class FrmEducation : Form
    {
        Education_Controller controller;
        Education_Collection collection;
        Education_Info info;
        private int educationid;

        public FrmEducation()
        {
            InitializeComponent();
        }

        #region myCode

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtEducation.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ပညာအရည္အခ်င္းကို ထည့္သြင္းေပးပါ");
                txtEducation.Focus();
                return false;  
            }
            return true;
        }

        private void Clear()
        {
            txtEducation.Focus();
            btnSave.Text = "ထည့္သြင္းရန္";
            btnCancel.Text = "ထြက္ရန္";

            txtEducation.Text = string.Empty;
        }

        private void Bind_Education(int type)
        {
            controller = new Education_Controller();
            collection = controller.Select_Education(type, txtEducation.Text.Trim());
            dgvEducation.AutoGenerateColumns = false;
            dgvEducation.DataSource = collection;
        }

        #endregion

        private void dgvEducation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvEducation.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colEdit":
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnCancel.Text = "မလုပ္ေသးပါ";

                    educationid = Convert.ToInt32(row.Cells[coleducationid.Index].Value);
                    txtEducation.Text = row.Cells[coleducation.Index].Value.ToString();

                    break;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    controller = new Education_Controller();
                    info = new Education_Info();

                    switch (btnSave.Text)
                    {
                        case "ထည့္သြင္းရန္":

                            info.Education = txtEducation.Text.Trim();
                            controller.Insert_Education(info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                            break;

                        case "ျပင္ဆင္ရန္":

                            info.Educationid = educationid;
                            info.Education = txtEducation.Text.Trim();
                            controller.Update_Education(info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ျပင္ဆင္ျပီးပါျပီ");
                            break;
                    }
                    Clear();
                    Bind_Education(1);
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, ex.Message);
            }
           
        }

        private void FrmEducation_Load(object sender, EventArgs e)
        {
            Bind_Education(1);
        }

        private void txtEducation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }

        private void FrmEducation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtEducation_KeyUp(object sender, KeyEventArgs e)
        {
            Bind_Education(2);
        }
    }
}
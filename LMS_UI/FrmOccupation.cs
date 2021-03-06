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
    public partial class FrmOccupation : Form
    {
        Occupation_Controller controller;
        Occupation_Collection collection;
        Occupation_Info info;
        private int occupationid;

        public FrmOccupation()
        {
            InitializeComponent();
        }

        #region myCode

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtOccupation.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "အလုပ္အကိုင္ကို ထည့္သြင္းေပးပါ");
                txtOccupation.Focus();
                return false;
            }
            return true;
        }

        private void Clear()
        {
            txtOccupation.Focus();
            btnSave.Text = "ထည့္သြင္းရန္";
            btnCancel.Text = "ထြက္ရန္";

            txtOccupation.Text = string.Empty;
        }

        private void Bind_Occupation(int type)
        {
            controller = new Occupation_Controller();
            collection = controller.Select_Occupation(type, txtOccupation.Text.Trim());
            dgvOccupation.AutoGenerateColumns = false;
            dgvOccupation.DataSource = collection;
        }

        #endregion


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    controller = new Occupation_Controller();
                    info = new Occupation_Info();

                    switch (btnSave.Text)
                    {
                        case "ထည့္သြင္းရန္":

                            info.Occupation = txtOccupation.Text.Trim();
                            controller.Insert_Occupation(info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                            break;

                        case "ျပင္ဆင္ရန္":

                            info.Occupationid = occupationid;
                            info.Occupation = txtOccupation.Text.Trim();
                            controller.Update_Occupation(info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ျပင္ဆင္ျပီးပါျပီ");



                            break;
                    }
                    Clear();
                    Bind_Occupation(1);
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

        private void dgvOccupation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvOccupation.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colEdit":
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnCancel.Text = "မလုပ္ေသးပါ";

                    occupationid = Convert.ToInt32(row.Cells[coloccupationid.Index].Value);
                    txtOccupation.Text = row.Cells[coloccupation.Index].Value.ToString();

                    break;
            }
        }

        private void FrmOccupation_Load(object sender, EventArgs e)
        {
            Bind_Occupation(1);
        }

        private void txtOccupation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }

        private void FrmOccupation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtOccupation_KeyUp(object sender, KeyEventArgs e)
        {
            Bind_Occupation(2);
        }
    }
}
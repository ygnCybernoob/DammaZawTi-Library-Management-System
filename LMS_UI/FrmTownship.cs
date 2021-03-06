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
    public partial class FrmTownship : Form
    {
        Township_Controller township_controller;
        Township_Collection township_collection;
        Township_Info township_info;
        private int townshipid;

        public FrmTownship()
        {
            InitializeComponent();
        }

        #region myCode

        private int stateid;
        public void SetValue(int stateid)
        {
            this.stateid = stateid;
        }

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtTownship.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ျမိဳ႕နယ္အမည္ကို ထည့္သြင္းေပးပါ");
                txtTownship.Focus();
                return false;
            }
            return true;
        }

        private void Clear()
        {
            cboState.Focus();
            btnSave.Text = "ထည့္သြင္းရန္";
            btnCancel.Text = "ထြက္ရန္";

            txtTownship.Text = string.Empty;
            txtDesp.Text = string.Empty;
        }

        private void Bind_State()
        {
            StateDivision_Controller state_controller = new StateDivision_Controller();
            cboState.DataSource = state_controller.Select_StateDivision();
            cboState.DisplayMember = "state";
            cboState.ValueMember = "stateid";
        }

        private void Bind_Township(int type)
        {
            township_controller = new Township_Controller();

            if (type == 1)
            {
                township_collection = township_controller.Select_Township(1, -1, "");
            }
            else if (type == 2)
            {
                township_collection = township_controller.Select_Township(2, (int)cboState.SelectedValue, "");
            }
            else if (type == 3)
            {
                township_collection = township_controller.Select_Township(3, -1, txtTownship.Text.Trim());
            }

            dgvTownship.AutoGenerateColumns = false;
            dgvTownship.DataSource = township_collection;
        }

        #endregion

        private void FrmTownship_Load(object sender, EventArgs e)
        {
            Bind_State();
            Bind_Township(1);

            if (stateid != 0)
            {
                cboState.SelectedValue = stateid;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    township_controller = new Township_Controller();
                    township_info = new Township_Info();

                    switch (btnSave.Text)
                    {
                        case "ထည့္သြင္းရန္":

                            township_info.Stateid = Convert.ToInt32(cboState.SelectedValue);
                            township_info.Township = txtTownship.Text.Trim();
                            township_info.Desp = txtDesp.Text.Trim();
                            township_controller.Insert_Township(township_info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                            break;

                        case "ျပင္ဆင္ရန္":

                            township_info.Townshipid = townshipid;
                            township_info.Stateid = Convert.ToInt32(cboState.SelectedValue);
                            township_info.Township = txtTownship.Text.Trim();
                            township_info.Desp = txtDesp.Text.Trim();
                            township_controller.Update_Township(township_info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ျပင္ဆင္ျပီးပါျပီ");
                            break;
                    }
                    Clear();
                    Bind_Township(1);
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

        private void dgvTownship_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvTownship.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colEdit":
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnCancel.Text = "မလုပ္ေသးပါ";

                    townshipid = (int)row.Cells[colTownshipid.Index].Value;
                    cboState.SelectedValue = (int)row.Cells[colStateid.Index].Value;
                    txtTownship.Text = row.Cells[colTownship.Index].Value.ToString();
                    txtDesp.Text = row.Cells[colDesp.Index].Value.ToString();

                    break;
            }
        }

        private void cboState_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtTownship_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void FrmTownship_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cboState_DropDownClosed(object sender, EventArgs e)
        {
            Bind_Township(2); // by stateid
        }

        private void txtTownship_KeyUp(object sender, KeyEventArgs e)
        {
            Bind_Township(3);
        }
    }
}
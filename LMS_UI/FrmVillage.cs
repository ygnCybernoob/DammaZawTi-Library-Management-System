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
    public partial class FrmVillage : Form
    {
        Village_Controller village_controller;
        Village_Collection village_collection;
        Village_Info village_info;
        private int villageid;

        public FrmVillage()
        {
            InitializeComponent();
        }

        #region myCode

        private int stateid,
            townshipid;
        public void SetValue(int stateid, int townshipid)
        {
            this.stateid = stateid;
            this.townshipid = townshipid;
        }

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtVillage.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ေက်းရြာ/ ရပ္ကြက္အမည္ကို ထည့္သြင္းေပးပါ");
                txtVillage.Focus();
                return false;
            }
            return true;
        }

        private void Clear()
        {
            cboState.Focus();
            btnSave.Text = "ထည့္သြင္းရန္";
            btnCancel.Text = "ထြက္ရန္";

            txtVillage.Text = string.Empty;
            txtDesp.Text = string.Empty;
        }

        private void Bind_Township()
        {
            Township_Controller township_controller = new Township_Controller();
            cboTownship.DataSource = township_controller.Select_Township(2, (int)cboState.SelectedValue, "");
            cboTownship.DisplayMember = "township";
            cboTownship.ValueMember = "townshipid";
        }

        private void Bind_State()
        {
            StateDivision_Controller state_controller = new StateDivision_Controller();
            cboState.DataSource = state_controller.Select_StateDivision();
            cboState.DisplayMember = "state";
            cboState.ValueMember = "stateid";
        }

        private void Bind_Village(int type)
        {
            village_controller = new Village_Controller();

            if (type == 1) // all
            {
                village_collection = village_controller.Select_Village(type, -1, -1, "");
            }
            else if (type == 2) // by township
            {
                village_collection = village_controller.Select_Village(type, (int)cboTownship.SelectedValue, - 1, "");
            }
            else if (type == 3) //by state
            {
                village_collection = village_controller.Select_Village(type, -1, (int)cboState.SelectedValue, "");
            }
            else if (type == 4) //by village
            {
                village_collection = village_controller.Select_Village(type, -1,-1, txtVillage.Text.Trim());
            }

            dgvVillage.AutoGenerateColumns = false;
            dgvVillage.DataSource = village_collection;
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    village_controller = new Village_Controller();
                    village_info = new Village_Info();
                    switch (btnSave.Text)
                    {
                        case "ထည့္သြင္းရန္":

                            village_info.Townshipid = (int)cboTownship.SelectedValue;
                            village_info.Village = txtVillage.Text.Trim();
                            village_info.Desp = txtDesp.Text.Trim();
                            village_controller.Insert_Village(village_info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                            break;

                        case "ျပင္ဆင္ရန္":

                            village_info.Villageid = villageid;
                            village_info.Townshipid = (int)cboTownship.SelectedValue;
                            village_info.Village = txtVillage.Text.Trim();
                            village_info.Desp = txtDesp.Text.Trim();
                            village_controller.Update_Village(village_info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ျပင္ဆင္ျပီးပါျပီ");
                            break;
                    }
                    Clear();
                    Bind_Village(1);
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, ex.Message);
            }
        }

        private void FrmVillage_Load(object sender, EventArgs e)
        {
            Bind_State();
            Bind_Village(1);

            if (stateid != 0)
            {
                cboState.SelectedValue = stateid;
                Bind_Township();
                if (townshipid != 0)
                {
                    cboTownship.SelectedValue = townshipid;
                }
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

        private void dgvVillage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvVillage.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colEdit":
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnCancel.Text = "မလုပ္ေသးပါ";

                    villageid = (int)row.Cells[colvillageid.Index].Value;
                    cboState.SelectedValue = (int)row.Cells[colStateid.Index].Value;
                    Bind_Township(); // to bind the township 
                    cboTownship.SelectedValue = (int)row.Cells[colTownshipid.Index].Value;
                    txtVillage.Text = row.Cells[colVillage.Index].Value.ToString();
                    txtDesp.Text = row.Cells[colDesp.Index].Value.ToString();

                    break;
            }
        }

        private void cboState_DropDownClosed(object sender, EventArgs e)
        {
            Bind_Township();
            Bind_Village(3);
        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            FrmTownship t = new FrmTownship();
            t.SetValue((int)cboState.SelectedValue);
            t.ShowDialog();
            Bind_Township();
        }

        private void cboState_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboTownship_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtVillage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void cboTownship_DropDownClosed(object sender, EventArgs e)
        {
            if (cboTownship.Items.Count == 0)
            {
                FrmTownship t = new FrmTownship();
                t.SetValue((int)cboState.SelectedValue);
                t.ShowDialog();
                Bind_Township();
            }
            else
            {
                Bind_Village(2);
            }
        }

        private void FrmVillage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtVillage_KeyUp(object sender, KeyEventArgs e)
        {
            Bind_Village(4);
        }
    }
}
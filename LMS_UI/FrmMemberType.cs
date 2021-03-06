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
    public partial class FrmMemberType : Form
    {
        MemberType_Controller membertype_controller;
        MemberType_Collection membertype_collection;
        MemberType_Info membertype_info;
        private int membertypeid;

        public FrmMemberType()
        {
            InitializeComponent();
        }

        #region myCode

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtMembertype.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "အသင္း၀င္ အမ်ိဳးအစားကို ထည့္သြင္းေပးပါ");
                txtMembertype.Focus();
                return false;
            }
            return true;
        }

        private void Clear()
        {
            txtMembertype.Focus();
            btnSave.Text = "ထည့္သြင္းရန္";
            btnCancel.Text = "ထြက္ရန္";


            txtMembertype.Text = string.Empty;
            numAllowbook.Value = 1;
            numAllowDay.Value = 7;
            numExpireDate.Value = 1;
            chbLifetime.Checked = false;
        }

        private void Bind_Memebertype()
        {
            membertype_controller = new MemberType_Controller();
            membertype_collection = membertype_controller.Select_MemberType();
            dgvMembertype.AutoGenerateColumns = false;
            dgvMembertype.DataSource = membertype_collection;
        }

        #endregion

        private void chbLifetime_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLifetime.Checked)
            {
                numExpireDate.Enabled = false;
            }
            else
            {
                numExpireDate.Enabled = true;
            }
        }

        private void dgvMembertype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvMembertype.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colEdit":
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnCancel.Text = "မလုပ္ေသးပါ";

                    membertypeid = (int)row.Cells[colMembertypeid.Index].Value;
                    txtMembertype.Text = row.Cells[colMembertype.Index].Value.ToString();
                    numAllowbook.Value = (int)row.Cells[colAllowbook.Index].Value;
                    numAllowDay.Value = (int)row.Cells[colallowday.Index].Value;

                    if (row.Cells[colExpiredate.Index].Value.ToString().Equals("Life Time"))
                    {
                        chbLifetime.Checked = true;
                    }
                    else
                    {
                        numExpireDate.Value = Convert.ToInt32(row.Cells[colExpiredate.Index].Value);
                        chbLifetime.Checked = false;
                    }

                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    membertype_controller = new MemberType_Controller();
                    membertype_info = new MemberType_Info();

                    switch (btnSave.Text)
                    {
                        case "ထည့္သြင္းရန္":

                            membertype_info.Membertype = txtMembertype.Text.Trim();
                            membertype_info.Allowbook = (int)numAllowbook.Value;
                            membertype_info.Allowday = (int)numAllowDay.Value;

                            if (chbLifetime.Checked)
                            {
                                membertype_info.Expiredate = "Life Time";
                            }
                            else
                            {
                                membertype_info.Expiredate = Convert.ToString(numExpireDate.Value);
                            }

                            membertype_controller.Insert_MemberType(membertype_info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                            break;

                        case "ျပင္ဆင္ရန္":

                            membertype_info.Membertypeid = membertypeid;
                            membertype_info.Membertype = txtMembertype.Text.Trim();
                            membertype_info.Allowbook = (int)numAllowbook.Value;
                            membertype_info.Allowday = (int)numAllowDay.Value;

                            if (chbLifetime.Checked)
                            {
                                membertype_info.Expiredate = "Life Time";
                            }
                            else
                            {
                                membertype_info.Expiredate = Convert.ToString(numExpireDate.Value);
                            }
                            membertype_controller.Update_MemberType(membertype_info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ျပင္ဆင္ျပီးပါျပီ");
                            break;
                    }
                    Clear();
                    Bind_Memebertype();
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

        private void FrmMemberType_Load(object sender, EventArgs e)
        {
            Bind_Memebertype();
        }

        private void txtMembertype_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void numAllowbook_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void numAllowDay_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void numExpireDate_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void chbLifetime_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtTypeCode_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }
    }
}
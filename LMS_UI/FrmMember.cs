using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LMS_BLL;
using LMS_INFO;
using System.IO;

namespace LMS_UI
{
    public partial class FrmMember : Form
    {
        Member_Controller member_controller;
        Member_Collection member_collection;
        Member_Info member_info;
       
        private string imageLocation = "default";
        private Image Limage;

        private int memberid = 0;
        private string memberStatus;
        private DateTime addedDate;

        private Account_Info accountinfo;

        public FrmMember(Account_Info accountinfo)
        {
            InitializeComponent();
            this.accountinfo = accountinfo;
        }

        #region myCode

        private void Generate_Code()
        {
            CodeGenerator_Controller codeGeneratorController = new CodeGenerator_Controller();
            txtBarcode.Text ="MB"+(codeGeneratorController.Select_MemberCode()+1).ToString();
        }

        private void Bind_Member(int selectType)
        {
            member_controller = new Member_Controller();
            member_collection = member_controller.Select_Member(selectType, txtSBarcode.Text.Trim(), txtSName.Text.Trim());
            dgvMemberList.AutoGenerateColumns = false;
            dgvMemberList.DataSource = member_collection;
        }

        private void Bind_State()
        {
            StateDivision_Controller state_controller = new StateDivision_Controller();
            cboState.DataSource = state_controller.Select_StateDivision();
            cboState.DisplayMember = "state";
            cboState.ValueMember = "stateid";
        }

        private void Bind_Township()
        {
            Township_Controller township_controller = new Township_Controller();
            cboTownship.DataSource = township_controller.Select_Township(2,(int)cboState.SelectedValue, "");
            cboTownship.DisplayMember = "township";
            cboTownship.ValueMember = "townshipid";
        }

        private void Bind_Village()
        {
            Village_Controller Village_controller = new Village_Controller();
            cboVillage.DataSource = Village_controller.Select_Village(2, (int)cboTownship.SelectedValue, -1 , "");
            cboVillage.DisplayMember = "Village";
            cboVillage.ValueMember = "Villageid";
        }

        private void Bind_Occupation()
        {
            Occupation_Controller controller = new Occupation_Controller();
            Occupation_Collection collection = controller.Select_Occupation(1, "");
            Occupation_Collection collection2 = controller.Select_Occupation(1, "");
            cboOccupation.DisplayMember = "occupation";
            cboOccupation.ValueMember = "occupationid";
            cboOccupation.DataSource = collection;

            cboGOccupation.DisplayMember = "occupation";
            cboGOccupation.ValueMember = "occupationid";
            cboGOccupation.DataSource = collection2;
        }

        private void Bind_Education()
        {
            Education_Controller controller = new Education_Controller();
            Education_Collection collection = controller.Select_Education(1, "");
            cboEducation.DisplayMember = "Education";
            cboEducation.ValueMember = "Educationid";
            cboEducation.DataSource = collection;
        }

        private void Bind_Memebertype()
        {
            MemberType_Controller controller = new MemberType_Controller();
            MemberType_Collection collection = controller.Select_MemberType();
            cboMemberType.DisplayMember = "MemberType";
            cboMemberType.ValueMember = "MemberTypeid";
            cboMemberType.DataSource = collection;
        }

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtBarcode.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ဘားကုဒ္ကို ထည့္သြင္းေပးပါ");
                txtBarcode.Focus();
                return false;
            }
            else if (cboMemberType.Items.Count == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "အသင္း၀င္အမ်ိဳးအစားမ်ားကို ဦးစြာထည့္သြင္းေပးပါ");
                cboMemberType.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtMembername.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "အသင္း၀င္အမည္ကို ထည့္သြင္းေပးပါ");
                txtMembername.Focus();
                return false;
            }
            else if (cboEducation.Items.Count ==0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ပညာအရည္အခ်င္းမ်ားကို ဦးစြာထည့္သြင္းေပးပါ");
                cboEducation.Focus();
                return false;
            }
            else if (cboOccupation.Items.Count == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "အလုပ္အကိုင္မ်ားကို ဦးစြာထည့္သြင္းေပးပါ");
                cboOccupation.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtStreet.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "လမ္းအမည္ကို ထည့္သြင္းေပးပါ");
                txtStreet.Focus();
                return false;
            }
            else if (cboTownship.Items.Count == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ျပည္နယ္/ တိုင္းကို ေရြးခ်ယ္ေပးပါ");
                cboState.Focus();
                return false;
            }
            else if (cboVillage.Items.Count == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ျမိဳ႕နယ္ကို ေရြးခ်ယ္ေပးပါ");
                cboTownship.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ဖုန္းနံပါတ္ကို ထည့္သြင္းေပးပါ");
                txtPhone.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtGuarantor.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ေထာက္ခံသူအမည္ကို ထည့္သြင္းေပးပါ");
                txtGuarantor.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtGNrc.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ေထာက္ခံသူ၏ မွတ္ပုံတင္အမွတ္ကို ထည့္သြင္းေပးပါ");
                txtGNrc.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtGAddress.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ေထာက္ခံသူ၏ ေနရပ္လိပ္စာ အျပည့္အစုံကို ထည့္သြင္းေပးပါ");
                txtGAddress.Focus();
                return false;
            }
            return true;
        }

        private void Clear()
        {
            txtBarcode.Focus();
            btnSave.Text = "ထည့္သြင္းရန္";
            btnCancel.Text = "ထြက္ရန္";

            Bind_Memebertype();
            gboxBanMember.Visible = false;
            txtBarcode.Text = string.Empty;
            txtMembername.Text = string.Empty;
            cboGender.SelectedIndex = 0;
            txtNrc.Text = string.Empty;
            Bind_Education();
            Bind_Occupation();
            txtStreet.Text = string.Empty;
            txtHomeno.Text = string.Empty;
            cboState.SelectedIndex = 0;
            cboTownship.DataSource = null;
            cboVillage.DataSource = null;
            txtPhone.Text = string.Empty;
            dtpkDateofBirth.Value = System.DateTime.Today;

            txtGuarantor.Text = string.Empty;
            txtGNrc.Text = string.Empty;
            txtGAddress.Text = string.Empty;
            btnClear_Click(null, null);
        }

        #endregion

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Title = "ဓာတ္ပုံေရြးပါ";
            open.Filter = "All Files (*.*)| *.*|JPG Files (*.jpg)| *.jpg|PNG Files (*.png) | *.png|GIF Files (*.gif)| *.gif";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imageLocation = open.FileName.ToString();

                this.Cursor = System.Windows.Forms.Cursors.AppStarting;
                Bitmap m = new Bitmap(imageLocation);

                int width = m.Width;
                int height = m.Height;

                Color[,] img = new Color[height, width];

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        img[i, j] = m.GetPixel(j, i);
                    }
                }

                int scale = 4;
                Bitmap m2 = new Bitmap(m.Width / scale, m.Height / scale);

                for (int i = 0; i < height / scale; i++)
                {
                    for (int j = 0; j < width / scale; j++)
                    {
                        m2.SetPixel(j, i, img[i * scale, j * scale]);
                    }
                }

                Limage = m2;
                picImage.Image = Limage;
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picImage.Image = Properties.Resources.member_image;
            imageLocation = "default";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    member_controller = new Member_Controller();
                    member_info = new Member_Info();
                    byte[] img = null;

                    switch (btnSave.Text)
                    {
                        case "ထည့္သြင္းရန္":

                            if (imageLocation.Equals("default"))
                            {
                                img = new byte[0];
                            }
                            else
                            {
                                img = Utilities.ConvertImageToBinary(Limage);
                            }

                            member_info.Memberimagebyte = img;
                            member_info.Membertypeid = (int)cboMemberType.SelectedValue;
                            member_info.Memberbarcode = txtBarcode.Text.Trim();
                            member_info.Membername = txtMembername.Text.Trim();
                            member_info.Occupationid = (int)cboOccupation.SelectedValue;
                            member_info.Nrc = txtNrc.Text.Trim();

                            member_info.Street = txtStreet.Text.Trim();
                            member_info.Homeno = txtHomeno.Text.Trim();
                            member_info.Villageid = (int)cboVillage.SelectedValue;
                            member_info.Phoneno = txtPhone.Text.Trim();
                            member_info.Educationid = (int)cboEducation.SelectedValue;

                            member_info.Gender = (cboGender.SelectedIndex == 0) ? "male" : "female";

                            member_info.Guarantor = txtGuarantor.Text.Trim();
                            member_info.Guarantoraddress = txtGAddress.Text.Trim();
                            member_info.Guarantoroccupation = cboGOccupation.SelectedItem.ToString();
                            member_info.Guarantornrc = txtGNrc.Text.Trim();

                            member_info.Addedby = accountinfo.Username;
                            member_info.Dateofbirth = dtpkDateofBirth.Value.Date;
                            member_info.Addeddate = System.DateTime.Today;

                            member_controller.Insert_Member(member_info);


                            Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                            break;

                        case "ျပင္ဆင္ရန္":

                            if (imageLocation.Equals("default"))
                            {
                                img = new byte[0];
                            }
                            else
                            {
                                img = Utilities.ConvertImageToBinary(picImage.Image);
                            }

                            member_info.Memberid = memberid;
                            member_info.Memberimagebyte = img;
                            member_info.Membertypeid = (int)cboMemberType.SelectedValue;
                            member_info.Membername = txtMembername.Text.Trim();
                            member_info.Occupationid = (int)cboOccupation.SelectedValue;
                            member_info.Nrc = txtNrc.Text.Trim();

                            member_info.Street = txtStreet.Text.Trim();
                            member_info.Homeno = txtHomeno.Text.Trim();
                            member_info.Villageid = (int)cboVillage.SelectedValue;
                            member_info.Phoneno = txtPhone.Text.Trim();
                            member_info.Educationid = (int)cboEducation.SelectedValue;

                            member_info.Gender = (cboGender.SelectedIndex == 0) ? "male" : "female";

                            member_info.Guarantor = txtGuarantor.Text.Trim();
                            member_info.Guarantoraddress = txtGAddress.Text.Trim();
                            member_info.Guarantoroccupation = cboGOccupation.SelectedItem.ToString();
                            member_info.Guarantornrc = txtGNrc.Text.Trim();

                            member_info.Addedby = accountinfo.Username;
                            member_info.Dateofbirth = dtpkDateofBirth.Value.Date;

                            if (chbUpdateExpired.Checked)
                            {
                                member_info.Addeddate = System.DateTime.Today;
                                member_info.Memberstatus = "act";
                            }
                            else if (chbBanMember.Checked)
                            {
                                member_info.Addeddate = addedDate;
                                member_info.Memberstatus = "ban";
                            }
                            else
                            {
                                member_info.Addeddate = addedDate;
                                member_info.Memberstatus = "act";
                            }

                            member_controller.Update_Member(member_info);

                            Utilities.ShowMessage(Utilities.MessageType.Information, "ျပင္ဆင္ျပီးပါျပီ");
                            break;
                    }
                    Clear();
                    Generate_Code();
                    Bind_Member(1);
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
                    Generate_Code();
                    break;
            }
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            cboGender.SelectedIndex = 0;

            Generate_Code();

            Bind_Memebertype();
            Bind_Education();
            Bind_Occupation();
            Bind_State();

            Bind_Member(1);
        }

        private void cboState_DropDownClosed(object sender, EventArgs e)
        {
            cboVillage.DataSource = null;
            if (cboState.Items.Count > 0)
            {
                Bind_Township();
            }
        }

        private void cboTownship_DropDownClosed(object sender, EventArgs e)
        {
            if (cboTownship.Items.Count > 0)
            {
                Bind_Village();
            }
            else
            {
                FrmTownship t = new FrmTownship();
                t.SetValue((int)cboState.SelectedValue);
                t.ShowDialog();
                Bind_Township();
            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtMembername_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtNrc_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtStreet_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtHomeno_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtGuarantor_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtGNrc_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboMemberType_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboGender_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboEducation_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboOccupation_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboState_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboTownship_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboVillage_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboGOccupation_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void dtpkDateofBirth_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvMemberList.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colEdit":
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnCancel.Text = "မလုပ္ေသးပါ";

                    if ((Image)row.Cells[colMemberimage.Index].Value == null)
                    {
                        btnClear_Click(null, null);
                    }
                    else
                    {
                        picImage.Image = (Image)row.Cells[colMemberimage.Index].Value;
                        imageLocation = "image";
                    }

                    memberid = (int)row.Cells[colMemberId.Index].Value;
                    txtBarcode.Text = row.Cells[colmemberbarcode.Index].Value.ToString();
                    cboMemberType.SelectedValue =(int) row.Cells[colmembertypeid.Index].Value;
                    txtMembername.Text = row.Cells[colmembername.Index].Value.ToString();
                    cboGender.SelectedItem = row.Cells[colGender.Index].Value;
                    txtNrc.Text = row.Cells[colnrc.Index].Value.ToString();

                    cboEducation.SelectedValue = (int)row.Cells[colEducationid.Index].Value;
                    cboOccupation.SelectedValue = (int)row.Cells[colOccupationid.Index].Value;
                    txtStreet.Text = row.Cells[colstreet.Index].Value.ToString();
                    txtHomeno.Text = row.Cells[colhomeno.Index].Value.ToString();

                    cboState.SelectedValue = (int)row.Cells[colStateid.Index].Value;
                    Bind_Township();
                    cboTownship.SelectedValue = (int)row.Cells[colTownshipid.Index].Value;
                    Bind_Village();
                    cboVillage.SelectedValue = (int)row.Cells[colVillageid.Index].Value;
                    txtPhone.Text = row.Cells[colPhoneno.Index].Value.ToString();
                    dtpkDateofBirth.Value = (DateTime)row.Cells[colDateofbirth.Index].Value;

                    txtGuarantor.Text = row.Cells[colGuarantor.Index].Value.ToString();
                    txtGNrc.Text = row.Cells[colGuarantorNrc.Index].Value.ToString();
                    cboGOccupation.SelectedItem = row.Cells[colGuarantorOccupation.Index].Value;
                    txtGAddress.Text = row.Cells[colGuarantoraddress.Index].Value.ToString();

                    memberStatus = row.Cells[colMemberStatus.Index].Value.ToString();
                    addedDate = (DateTime)row.Cells[colAddedDate.Index].Value;

                    if (memberStatus.Equals("expired"))
                    {
                        gboxUpdateExpired.Location = new Point(667, 413);
                        gboxUpdateExpired.Visible = true;
                    }
                    else if (memberStatus.Equals("ban"))
                    {
                        gboxBanMember.Visible = true;
                        chbBanMember.Checked = true;
                    }
                    else
                    {
                        gboxBanMember.Visible = true;
                    }

                    tabctrlMember.SelectedIndex = 0;
                    break;
            }
        }

        private void cboEducation_DropDownClosed(object sender, EventArgs e)
        {
            if (cboEducation.Items.Count == 0)
            {
                FrmEducation edu = new FrmEducation();
                edu.ShowDialog();
                Bind_Education();
            }

        }

        private void cboOccupation_DropDownClosed(object sender, EventArgs e)
        {
            if (cboOccupation.Items.Count ==0)
            {
                FrmOccupation occ = new FrmOccupation();
                occ.ShowDialog();
                Bind_Occupation(); 
            }
        }

        private void cboVillage_DropDownClosed(object sender, EventArgs e)
        {
            if (cboTownship.Items.Count == 0)
            {
                return;
            }

            if (cboVillage.Items.Count == 0)
            {
                FrmVillage village = new FrmVillage();
                village.SetValue((int)cboState.SelectedValue, (int)cboTownship.SelectedValue);
                village.ShowDialog();
                Bind_Village();
            }
        }

        private void cboGOccupation_DropDownClosed(object sender, EventArgs e)
        {
            if (cboGOccupation.Items.Count == 0)
            {
                FrmOccupation occ = new FrmOccupation();
                occ.ShowDialog();
                Bind_Occupation();
            }
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            Bind_Member(2);
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            Bind_Member(3);
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            Bind_Member(1);
        }

        private void txtSBarcode_TextChanged(object sender, EventArgs e)
        {
            Bind_Member(4);
        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {
            Bind_Member(5);
        }

        private void btnExpired_Click_1(object sender, EventArgs e)
        {
            Bind_Member(2);
        }

        private void btnBan_Click_1(object sender, EventArgs e)
        {
            Bind_Member(3);
        }

        private void cboMemberType_DropDownClosed(object sender, EventArgs e)
        {
            if (cboMemberType.Items.Count == 0)
            {
                FrmMemberType mt = new FrmMemberType();
                mt.ShowDialog();
                Bind_Memebertype();
            }
        }

    }
}
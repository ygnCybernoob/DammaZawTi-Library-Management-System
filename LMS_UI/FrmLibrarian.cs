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
    public partial class FrmLibrarian : Form
    {
        Librarian_Controller librarian_controller;
        Librarian_Collection librarian_collection;
        Librarian_Info librarian_info;
       
        private string imageLocation = "default";
        private Image Limage;

        private int librarianId;
        private string username;

        public FrmLibrarian(int librarianid, string username)
        {
            InitializeComponent();

            this.librarianId = librarianid;
            this.username = username;
        }

        #region myCode

        private void Bind_Librarian()
        {
            librarian_controller = new Librarian_Controller();
            librarian_collection = librarian_controller.Select_Librarian();

            dgvLibrarianList.AutoGenerateColumns = false;
            dgvLibrarianList.DataSource = librarian_collection;
        }

        private void Clear()
        {
            btnSave.Text = "ထည့္သြင္းရန္";
            btnCancel.Text = "ထြက္ရန္";

            gboxBanLibrarian.Visible = false;
            btnClear_Click(null, null); //clear the photo
            txtName.Text = string.Empty;
            txtAccount.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirm.Text = string.Empty;
            cboAccountType.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            txtNrc.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtHomeno.Text = string.Empty;

            txtPhone.Text = string.Empty;
            txtDesp.Text = string.Empty;
            chbBanLibrarian.Checked = false;
            txtName.Focus();
     
        }

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "အမည္ကို ထည့္သြင္းေပးပါ");
                txtName.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtAccount.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "အေကာင့္အမည္ကို ထည့္သြင္းေပးပါ");
                txtAccount.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "လွ်ဳိ႕၀ွက္ကုဒ္ကို ထည့္သြင္းေပးပါ");
                txtPassword.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtConfirm.Text))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "လွ်ဳိ႕၀ွက္ကုဒ္အတည္ျပဳျခင္းကို ထည့္သြင္းေပးပါ");
                txtConfirm.Focus();
                return false;
            }
            else if (!txtPassword.Text.Equals(txtConfirm.Text))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "လွ်ိဳ႕၀ွက္ကုဒ္နွင့္ လွ်ိဳ႕၀ွက္ကုဒ္အတည္ျပဳခ်က္တို႕မွာ မတူညီပါသျဖင့္ ျပန္လည္စစ္ေဆး ထည့္သြင္းေပးပါ");
                txtPassword.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtNrc.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "မွတ္ပုံတင္အမွတ္ကို ထည့္သြင္းေပးပါ");
                txtNrc.Focus();
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
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ျမိဳ႕နယ္ ကို ေရြးခ်ယ္ေပးပါ");
                cboTownship.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ဖုန္းနံပါတ္ကို ထည့္သြင္းေပးပါ");
                txtPhone.Focus();
                return false;
            }
            return true;
        }

        private void BindState()
        {
            StateDivision_Controller state_controller = new StateDivision_Controller();
            cboState.DataSource = state_controller.Select_StateDivision();
            cboState.DisplayMember = "state";
            cboState.ValueMember = "stateid";
        }

        private void Bind_Township()
        {
            Township_Controller township_controller = new Township_Controller();
            cboTownship.DataSource = township_controller.Select_Township(2, (int)cboState.SelectedValue, "");
            cboTownship.DisplayMember = "township";
            cboTownship.ValueMember = "townshipid";
        }

        private void Bind_Village()
        {
            Village_Controller Village_controller = new Village_Controller();
            cboVillage.DataSource = Village_controller.Select_Village(2, (int)cboTownship.SelectedValue, -1, "");
            cboVillage.DisplayMember = "Village";
            cboVillage.ValueMember = "Villageid";
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

        private void FrmLibrarian_Load(object sender, EventArgs e)
        {
            cboAccountType.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            BindState();
            Bind_Librarian();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picImage.Image = Properties.Resources.admin_image;
            imageLocation = "default";
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtAccount_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboAccountType_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboGender_KeyDown(object sender, KeyEventArgs e)
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

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    librarian_controller = new Librarian_Controller();
                    byte[] img = null;

                    switch (btnSave.Text)
                    {
                        case "ထည့္သြင္းရန္":

                            librarian_info = new Librarian_Info();

                            if (imageLocation.Equals("default"))
                            {
                                img = new byte[0];
                            }
                            else
                            {
                                img = Utilities.ConvertImageToBinary(Limage);
                            }

                            librarian_info.Imagebyte = img;
                            librarian_info.Librarianname = txtName.Text.Trim();
                            librarian_info.Username = txtAccount.Text.Trim();
                            librarian_info.Password = Utilities.PasswordEncrypt(txtPassword.Text);
                            librarian_info.Accounttype = cboAccountType.SelectedItem.ToString();

                            librarian_info.Gender = (cboGender.SelectedIndex == 0) ? "male" : "female";

                            librarian_info.Nrc = txtNrc.Text.Trim();
                            librarian_info.Street = txtStreet.Text.Trim();
                            librarian_info.Homeno = txtHomeno.Text.Trim();

                            librarian_info.Villageid = (int)cboVillage.SelectedValue;

                            librarian_info.Phoneno = txtPhone.Text.Trim();
                            librarian_info.Dateadded = System.DateTime.Today;
                            librarian_info.Addedby = username; //this user is add by admin or someone
                            librarian_info.Desp = txtDesp.Text.Trim();

                            librarian_controller.Insert_Librarian(librarian_info);

                            Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                            break;

                        case "ျပင္ဆင္ရန္":

                            librarian_info = new Librarian_Info();

                            if (imageLocation.Equals("default"))
                            {
                                img = new byte[0];
                            }
                            else
                            {
                                img = Utilities.ConvertImageToBinary(picImage.Image);
                            }

                            librarian_info.Imagebyte = img;

                            librarian_info.Librarianid = librarianId;
                            librarian_info.Librarianname = txtName.Text.Trim();
                            librarian_info.Username = txtAccount.Text.Trim();
                            librarian_info.Password = Utilities.PasswordEncrypt(txtPassword.Text);
                            librarian_info.Accounttype = cboAccountType.SelectedItem.ToString();

                            librarian_info.Gender = (cboGender.SelectedIndex == 0) ? "male" : "female";

                            librarian_info.Nrc = txtNrc.Text.Trim();
                            librarian_info.Street = txtStreet.Text.Trim();
                            librarian_info.Homeno = txtHomeno.Text.Trim();

                            librarian_info.Villageid = (int)cboVillage.SelectedValue;

                            librarian_info.Phoneno = txtPhone.Text.Trim();
                            librarian_info.Addedby = username;
                            librarian_info.Desp = txtDesp.Text.Trim();

                            if (chbBanLibrarian.Checked)
                            {
                                librarian_info.Status = "ban";
                                librarian_info.Accountstatus = "ban";
                            }
                            else
                            {
                                librarian_info.Status = "act";
                                librarian_info.Accountstatus = "no";
                            }

                            librarian_controller.Update_Librarian(librarian_info);

                            Utilities.ShowMessage(Utilities.MessageType.Information, "ျပင္ဆင္ျပီးပါျပီ");
                            break;
                    }
                    Clear();
                    Bind_Librarian();
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, ex.Message);
            }
        }

        private void cboState_DropDownClosed(object sender, EventArgs e)
        {
            cboVillage.DataSource = null;
            if (cboState.Items.Count>0)
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

        private void dgvLibrarianList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvLibrarianList.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colEdit":
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnCancel.Text = "မလုပ္ေသးပါ";
                    gboxBanLibrarian.Visible = true;

                    if ((Image)row.Cells[colLibrarianImage.Index].Value == null)
                    {
                        btnClear_Click(null, null);
                    }
                    else
                    {
                        picImage.Image = (Image)row.Cells[colLibrarianImage.Index].Value;
                        imageLocation = "image";
                    }

                    librarianId = (int)row.Cells[colLibrarianid.Index].Value;
                    txtName.Text = row.Cells[colLibrarianName.Index].Value.ToString();
                    txtAccount.Text = row.Cells[colUsername.Index].Value.ToString();
                    cboAccountType.SelectedItem = row.Cells[colAccounttype.Index].Value.ToString();

                    if (row.Cells[colGender.Index].Value.ToString().Equals("male"))
                    {
                        cboGender.SelectedIndex = 0;
                    }
                    else
                    {
                        cboGender.SelectedIndex = 1;
                    }

                    txtNrc.Text = row.Cells[colNrc.Index].Value.ToString();
                    txtStreet.Text = row.Cells[colStreet.Index].Value.ToString();
                    txtHomeno.Text = row.Cells[colHomeno.Index].Value.ToString();

                    cboState.SelectedValue = row.Cells[colstateid.Index].Value;
                    Bind_Township();
                    cboTownship.SelectedValue = row.Cells[colTownshipid.Index].Value;
                    Bind_Village();
                    cboVillage.SelectedValue = row.Cells[colVillageid.Index].Value;

                    txtPhone.Text = row.Cells[colPhone.Index].Value.ToString();
                    txtDesp.Text = row.Cells[colDesp.Index].Value.ToString();

                    tabCtrl.SelectedIndex = 0;

                    break;
            }
        }

        private void btnNew1_Click(object sender, EventArgs e)
        {
            FrmTownship t = new FrmTownship();
            t.ShowDialog();
        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            FrmVillage v = new FrmVillage();
            v.ShowDialog();
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

        private void btnNew1_Click_1(object sender, EventArgs e)
        {
            FrmTownship t = new FrmTownship();
            t.SetValue((int)cboState.SelectedValue);
            t.ShowDialog();
        }

        private void btnNew2_Click_1(object sender, EventArgs e)
        {
            FrmVillage village = new FrmVillage();
            if (cboTownship.Items.Count == 0)
            {
                village.SetValue((int) cboState.SelectedValue, 0);
            }
            else
            {
                village.SetValue((int)cboState.SelectedValue, (int)cboTownship.SelectedValue);
            }

            village.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LMS_INFO;
using LMS_BLL;
using System.IO;

namespace LMS_UI
{
    public partial class FrmLibraryInformation : Form
    {
        LibraryInformation_Controller controller;   
        private string imageLocation = "default";
        private byte[] img = null;

        public FrmLibraryInformation()
        {
            InitializeComponent();
        }

        #region myCode

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtLibraryName.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "စာၾကည့္တိုက္ အမည္ကိုထည့္သြင္းေပးပါ");
                txtLibraryName.Focus();
                return false;
            }

            return true;
        }
        #endregion

        private void FrmLibraryInformation_Load(object sender, EventArgs e)
        {
            Utilities.CenterMyControl(pnlBack);
            controller = new LibraryInformation_Controller();
            LibraryInfomation_Info info = controller.Select_LibraryInformation();

            if (info.Librarylogo.Length == 0)
            {
                picImage.Image = Properties.Resources.library_image;
                txtLibraryName.Text = info.Libraryname;
                imageLocation = "default";
            }
            else
            {
                MemoryStream ms = new MemoryStream(info.Librarylogo);
                picImage.Image = Image.FromStream(ms);
                txtLibraryName.Text = info.Libraryname;
                imageLocation = "image";
            }

        }

        private void FrmLibraryInformation_SizeChanged(object sender, EventArgs e)
        {
            Utilities.CenterMyControl(pnlBack);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picImage.Image = Properties.Resources.library_image;
            imageLocation ="default";
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Title = "စာၾကည့္တိုက္ Logo ေရြးပါ";
            open.Filter = "All Files (*.*)| *.*|JPG Files (*.jpg)| *.jpg|PNG Files (*.png) | *.png|GIF Files (*.gif)| *.gif";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imageLocation = open.FileName.ToString();
                picImage.ImageLocation = imageLocation;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (CheckRequiredField())
            {
                controller = new LibraryInformation_Controller();
                LibraryInfomation_Info info = new LibraryInfomation_Info();
       
                if (imageLocation.Equals("default"))
                {
                    info.Librarylogo = new byte[0];
                }
                else
                {
                    img = Utilities.ConvertImageToBinary(picImage.Image);
                    info.Librarylogo = img;
                }
                info.Libraryname = txtLibraryName.Text.Trim();
                controller.Update_LibraryInformation(info);

                Utilities.ShowMessage(Utilities.MessageType.Information, "စာၾကည့္တိုက္ အခ်က္အလက္မ်ားကို ေျပာင္းလဲသတ္မွတ္ျပီးပါျပီ");
                btnCancel.Focus();
            }

        }

        private void txtLibraryName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }
    }
}
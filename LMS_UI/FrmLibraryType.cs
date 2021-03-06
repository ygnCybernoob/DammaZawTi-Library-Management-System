using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LMS_BLL;

namespace LMS_UI
{
    public partial class FrmLibraryType : Form
    {
        LibraryType_Controller controller;

        public FrmLibraryType()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboLibrarytype.SelectedIndex < 0)
            {
                return;
            }
            if (Utilities.ShowMessage(Utilities.MessageType.Question, cboLibrarytype.Text+ "အျဖစ္ သတ္မွတ္ရန္ ေသခ်ာပါသလား?") == DialogResult.Yes)
            {
                controller = new LibraryType_Controller();

                if (cboLibrarytype.SelectedIndex == 0)
                {
                    controller.InsertLibraryType("DAILY");
                }
                else
                {
                    controller.InsertLibraryType("BYQTY");
                }

                Utilities.ShowMessage(Utilities.MessageType.Information, "စာၾကည့္တိုက္အမ်ိဳးအစားကို သတ္မွတ္ျပီးပါျပီ");
                btnCancel.Focus();
            }
        }

        private void FrmLibraryType_Load(object sender, EventArgs e)
        {
            controller = new LibraryType_Controller();

            string librarytype = controller.SelectLibraryType();

            if (librarytype.Equals("DAILY"))
            {
                cboLibrarytype.SelectedIndex = 0;
            }
            else if(librarytype.Equals("BYQTY"))
            {
                cboLibrarytype.SelectedIndex = 1;
            }
        }

        private void FrmLibraryType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
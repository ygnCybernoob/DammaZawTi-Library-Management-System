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
    public partial class FrmBookLostDamage : Form
    {
        private int bookid;

        public FrmBookLostDamage(int bookid, string booktitle, string bookbarcode, int maxQty)
        {
            InitializeComponent();
            this.bookid = bookid;
            this.txtBooktitle.Text = booktitle;
            this.txtBarcode.Text = bookbarcode;
            this.numQty.Maximum = maxQty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book_Controller controller = new Book_Controller();
            controller.Insert_LostorDamage(bookid, (int)numQty.Value);

            Utilities.ShowMessage(Utilities.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBookLostDamage_Load(object sender, EventArgs e)
        {

        }

        private void FrmBookLostDamage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
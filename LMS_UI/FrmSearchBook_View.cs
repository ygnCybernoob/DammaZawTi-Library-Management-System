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
    public partial class FrmSearchBook_View : Form
    {
        private int bookid;

        public FrmSearchBook_View(int bookid)
        {
            InitializeComponent();
            this.bookid = bookid;
        }

        private void FrmSearchBook_View_Load(object sender, EventArgs e)
        {
            Book_Controller controller = new Book_Controller();
            Book_Info info = controller.Select_QtyAndEarlyDueDate(bookid);

            txtQty.Text = Convert.ToString(info.Bookcopy);
            txtStatus.Text = info.Earlyduedate ;

        }

        private void FrmSearchBook_View_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

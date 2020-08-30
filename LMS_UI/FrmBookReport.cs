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
    public partial class FrmBookReport : Form
    {
        Book_Controller controller;
        Book_Collection collection;
        Book_Info info;

        public FrmBookReport()
        {
            InitializeComponent();
        }

        #region myCode

        private void SelectBookQty()
        {
            controller = new Book_Controller();
            info = controller.Select_BookQty();

            lblTotalBook.Text = lblTotalBook.Text + " " + info.Qtyofbook + " အုပ္";
            lblLost.Text = lblLost.Text + " " + info.Lost + " အုပ္";
            lblRenting.Text = lblRenting.Text + " " + info.Renting + " အုပ္";
            lblRemain.Text = lblRemain.Text + " " + info.Remain + " အုပ္";
            lblAdult.Text = lblAdult.Text + " " + info.Adult + " အုပ္";
            lblChild.Text = lblChild.Text + " " + info.Child + " အုပ္";
        }

        private void Bind_Author()
        {
            controller = new Book_Controller();
            collection = controller.Select_BookQtyByAuthor();

            dgvAuthor.AutoGenerateColumns = false;
            dgvAuthor.DataSource = collection;
        }

        private void Bind_Category()
        {
            controller = new Book_Controller();
            collection = controller.Select_BookQtyByCategory();

            dgvBookCategory.AutoGenerateColumns = false;
            dgvBookCategory.DataSource = collection;
        }

        #endregion

        private void FrmBookReport_Load(object sender, EventArgs e)
        {
            SelectBookQty();
            Bind_Author();
            Bind_Category();
        }
    }
}

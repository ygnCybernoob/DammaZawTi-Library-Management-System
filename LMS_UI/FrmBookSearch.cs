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
    public partial class FrmBookSearch : Form
    {
        Book_Controller book_controller;
        Book_Collection book_collection;
        Book_Info book_info;
        FrmSearchBook_View view;

        private int bookid;

        public FrmBookSearch()
        {
            InitializeComponent();
        }

        #region myCode

        private void Bind_BookCategory()
        {
            BookCategory_Controller book_controller = new BookCategory_Controller();
            BookCategory_Collection book_collection = book_controller.Select_Category();

            cboBookCategory.DisplayMember = "category";
            cboBookCategory.ValueMember = "categoryid";
            cboBookCategory.DataSource = book_collection;
        }

        private void Bind_Author()
        {
            int type;
            if (chbMale.Checked && chbFemale.Checked)
            {
                type = 3;
            }
            else if (chbMale.Checked)
            {
                type = 1;
            }
            else if (chbFemale.Checked)
            {
                type = 2;
            }
            else
            {
                return;
            }

            Author_Controller author_controller = new Author_Controller();
            Author_Collection author_collection = author_controller.Select_Author(type, "");

            cboAuthor.DisplayMember = "author";
            cboAuthor.ValueMember = "authorid";

            cboAuthor.DataSource = author_collection;
        }

        private void Bind_Book(int select_type)
        {
            book_controller = new Book_Controller();

            book_info = new Book_Info();

            book_info.Selecttype = select_type;

            if (cboBookCategory.Items.Count > 0)
            {
                book_info.Categoryid = (int)cboBookCategory.SelectedValue;
            }
            else
            {
                book_info.Categoryid = -1;
            }

            book_info.Bookbarcode = txtBarcode.Text.Trim();
            book_info.Booktitle = txtBookTitle.Text.Trim();

            if (cboAuthor.Items.Count > 0)
            {
                book_info.Authorid = (int)cboAuthor.SelectedValue;
            }
            else
            {
                book_info.Authorid = -1;
            }

            book_info.Adultchild = (cboTypebyAge.SelectedIndex == 0) ? "adult" : "child";
            book_info.Dateadded = System.DateTime.Today.AddDays(-14);

            book_collection = book_controller.Search_Book(book_info);

            dgvBookList.AutoGenerateColumns = false;
            dgvBookList.DataSource = book_collection;
        }

        #endregion 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            Bind_Book(3);
        }

        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {
            Bind_Book(4);
        }

        private void btnNewArrival_Click(object sender, EventArgs e)
        {
            Bind_Book(7);
        }

        private void btnTopBook_Click(object sender, EventArgs e)
        {
            FrmTopRent toprent = new FrmTopRent();
            toprent.WindowState = FormWindowState.Maximized;
            toprent.ShowDialog();
        }


        private void FrmBookSearch_Load(object sender, EventArgs e)
        {
            cboTypebyAge.SelectedIndex = 0;
            Bind_BookCategory();
            Bind_Author();
        }



        private void cboAuthortype_DropDownClosed(object sender, EventArgs e)
        {
            Bind_Book(8);
        }

        private void cboAuthor_DropDownClosed(object sender, EventArgs e)
        {
            if (cboAuthor.Items.Count > 0)
            {
                Bind_Book(5); 
            }
        }

        private void cboBookCategory_DropDownClosed(object sender, EventArgs e)
        {
            if (cboBookCategory.Items.Count >0)
            {
                Bind_Book(2); 
            }
        }

        private void cboTypebyAge_DropDownClosed(object sender, EventArgs e)
        {
            if (cboTypebyAge.Items.Count >0)
            {
                Bind_Book(6); 
            }
        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvBookList.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colView":
                    bookid =(int) row.Cells[colbookid.Index].Value;

                    view = new FrmSearchBook_View(bookid);
                    view.ShowDialog();
                    break;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = string.Empty;
            txtBookTitle.Text = string.Empty;
        }

        private void chbMale_CheckedChanged(object sender, EventArgs e)
        {
            Bind_Author();
        }

        private void chbFemale_CheckedChanged(object sender, EventArgs e)
        {
            Bind_Author();
        }

        private void cboAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
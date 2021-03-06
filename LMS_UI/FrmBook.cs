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
    public partial class FrmBook : Form
    {
        Book_Controller book_controller;
        Book_Collection book_collection;
        Book_Info book_info;

        private int bookid;
        private string imageLocation = "default";
        private Image Limage;

        public FrmBook()
        {
            InitializeComponent();
        }

        #region myCode

        private void GenerateCode()
        {
            CodeGenerator_Controller codeGenerator_Controller = new CodeGenerator_Controller();
            txtBarcode.Text = Select_BookTypeCode() + (codeGenerator_Controller.Select_BookCode((int)cboBookCategory.SelectedValue) + 1).ToString();
        }

        private string Select_BookTypeCode()
        {
            BookCategory_Controller category_controller = new BookCategory_Controller();

            return category_controller.Select_BookTypeCode((int)cboBookCategory.SelectedValue);
        }

        private void Bind_Book(int select_type)
        {
            book_controller = new Book_Controller();

            book_info = new Book_Info();
            book_info.Selecttype = select_type;

            if (cboBookCategory.Items.Count > 0)
            {
                book_info.Categoryid = (int)cboBookCategory2.SelectedValue;
            }
            else
            {
                book_info.Categoryid = -1;
            }


            book_info.Bookbarcode = txtBookbarcode2.Text.Trim();
            book_info.Booktitle = txtBookTitle2.Text.Trim();

            book_collection = book_controller.Select_Book(book_info);

            dgvBookList.AutoGenerateColumns = false;
            dgvBookList.DataSource = book_collection;
        }

        private void DisableAuthorControl()
        {
            cboAuthor1.Enabled = false;
            cboAuthor2.Enabled = false;
            chbAuthor2.Enabled = false;
        }

        private void EnableAuthorControl()
        {
            cboAuthor1.Enabled = true;
            cboAuthor2.Enabled = true;
            chbAuthor2.Enabled = true;
        }

        private void Clear()
        {
            btnSave.Text = "ထည့္သြင္းရန္";
            btnCancel.Text = "ထြက္ရန္";

            EnableAuthorControl();
            cboBookCategory.Focus();
            txtBarcode.Text = string.Empty;
            Bind_BookCategory();
            txtBooktitle.Text = string.Empty;
            Bind_Author();
            chbAuthor2.Checked = false;
            cboAuthor2.Enabled = false;
            numQty.Value = 1;
            txtPrice.Text = string.Empty;
            txtPublisher.Text = string.Empty;
            dtpkPublishDate.Value = System.DateTime.Today.Date;
            rbtAdult.Checked = true;
            txtDesp.Text = string.Empty;
            btnClear_Click(null, null);
            
        }

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtBarcode.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ဘားကုဒ္ကို ထည့္သြင္းေပးပါ");
                txtBarcode.Focus();
                return false;
            }
            else if (cboBookCategory.Items.Count == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "စာအုပ္အမ်ိဳးအစားမ်ားကို ဦးစြာထည့္သြင္းေပးပါ");
                cboBookCategory.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtBooktitle.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "စာအုပ္အမည္ကို ထည့္သြင္းေပးပါ");
                txtBooktitle.Focus();
                return false;
            }
            else if (cboAuthor1.Items.Count == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "စာေရးဆရာအမည္မ်ားကို ဦးစြာထည့္သြင္းေပးပါ");
                cboAuthor1.Focus();
                return false;
            }
            return true;
        }

        private void Bind_Author()
        {
            Author_Controller author_controller = new Author_Controller();
            Author_Collection author_collection = author_controller.Select_Author(3, "");
            Author_Collection author_collection2 = author_controller.Select_Author(3, "");

            cboAuthor1.DisplayMember = "author";
            cboAuthor1.ValueMember = "authorid";

            cboAuthor2.DisplayMember = "author";
            cboAuthor2.ValueMember = "authorid";

            cboAuthor1.DataSource = author_collection;
            cboAuthor2.DataSource = author_collection2;
        }

        private void Bind_BookCategory()
        {
            BookCategory_Controller book_controller = new BookCategory_Controller();
            BookCategory_Collection book_collection = book_controller.Select_Category();
            BookCategory_Collection book_collection2 = book_controller.Select_Category();

            cboBookCategory.DisplayMember = "category";
            cboBookCategory.ValueMember = "categoryid";
            cboBookCategory.DataSource = book_collection;

            cboBookCategory2.DisplayMember = "category";
            cboBookCategory2.ValueMember = "categoryid";
            cboBookCategory2.DataSource = book_collection2;
        }

        #endregion


        private void btnClear_Click(object sender, EventArgs e)
        {
            picImage.Image = Properties.Resources.book_image;
            imageLocation = "default";
        }

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

        private void FrmBook_Load(object sender, EventArgs e)
        {
            Bind_BookCategory();
            Bind_Author();
            Bind_Book(1);
        }

        private void chbAuthor2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAuthor2.Checked)
            {
                cboAuthor2.Enabled = true;
            }
            else
            {
                cboAuthor2.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField())
                {
                    book_controller = new Book_Controller();
                    book_info = new Book_Info();
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

                            book_info.CoverByte = img;
                            book_info.Categoryid = (int)cboBookCategory.SelectedValue;
                            book_info.Booktitle = txtBooktitle.Text.Trim();

                            book_info.Bookbarcode = txtBarcode.Text.Trim();

                            book_info.Author1id = (int)cboAuthor1.SelectedValue;

                            if (chbAuthor2.Checked)
                            {
                                book_info.Author2id = (int)cboAuthor2.SelectedValue;
                            }
                            else
                            {
                                book_info.Author2id = -1;
                            }

                            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
                            {
                                book_info.Price = 0;
                            }
                            else
                            {
                                book_info.Price = Convert.ToInt64(txtPrice.Text);
                            }

                            book_info.Bookcopy = (int)numQty.Value;
                            book_info.Publisher = txtPublisher.Text.Trim();
                            book_info.Publishdate = dtpkPublishDate.Value.Date;
                            book_info.Dateadded = System.DateTime.Today.Date;
                            book_info.Adultchild = (rbtAdult.Checked) ? "adult" : "child";
                            book_info.Desp = txtDesp.Text.Trim();
                            book_controller.Insert_Book(book_info);
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

                            book_info.Bookid = bookid;
                            book_info.CoverByte = img;
                            book_info.Categoryid = (int)cboBookCategory.SelectedValue;
                            book_info.Bookbarcode = txtBarcode.Text.Trim();
                            book_info.Booktitle = txtBooktitle.Text.Trim();

                            book_info.Author1id = (int)cboAuthor1.SelectedValue;

                            if (chbAuthor2.Checked)
                            {
                                book_info.Author2id = (int)cboAuthor2.SelectedValue;
                            }
                            else
                            {
                                book_info.Author2id = -1;
                            }

                            book_info.Bookcopy = (int)numQty.Value;
                            book_info.Price = Convert.ToInt64(txtPrice.Text);
                            book_info.Publisher = txtPublisher.Text.Trim();
                            book_info.Publishdate = dtpkPublishDate.Value.Date;
                            book_info.Dateadded = System.DateTime.Today.Date;
                            book_info.Adultchild = (rbtAdult.Checked) ? "adult" : "child";
                            book_info.Desp = txtDesp.Text.Trim();
                            book_info.Status = "act";

                            book_controller.Update_Book(book_info);
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ျပင္ဆင္ျပီးပါျပီ");
                            break;
                    }
                    Clear();
                    Bind_Book(1);
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, ex.Message);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if (!((i >= '0' && i <= '9') || i == 8))
            {
                e.Handled = true;
                txtPrice.ForeColor = Color.Red;
            }
            else
            {
                txtPrice.ForeColor = Color.Black;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtPrice.ForeColor = Color.Black;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmBook_Load(null, null);
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
                case "colEdit":
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnCancel.Text = "မလုပ္ေသးပါ";

                    if ((Image)row.Cells[colbookcover.Index].Value == null)
                    {
                        btnClear_Click(null, null);
                    }
                    else
                    {
                        picImage.Image = (Image)row.Cells[colbookcover.Index].Value;
                        imageLocation = "image";
                    }

                    bookid = (int)row.Cells[colbookid.Index].Value ;
                    txtBarcode.Text = row.Cells[colbookbarcode.Index].Value.ToString();
                    txtBooktitle.Text = row.Cells[colbooktitle.Index].Value.ToString();
                    cboBookCategory.SelectedValue = (int)row.Cells[colcategoryid.Index].Value;

                    cboAuthor1.SelectedValue = (int)row.Cells[colAuthor1id.Index].Value;

                    if ((int)row.Cells[colAuthor2Id.Index].Value == -1)
                    {
                        chbAuthor2.Checked = false;
                    }
                    else
                    {
                        chbAuthor2.Checked = true;
                        cboAuthor2.SelectedValue = (int)row.Cells[colAuthor2Id.Index].Value;
                    }

                    numQty.Value = (int)row.Cells[colbookcopy.Index].Value;

                    txtPrice.Text = row.Cells[colprice.Index].Value.ToString();
                    txtPublisher.Text = row.Cells[colpublisher.Index].Value.ToString();
                    dtpkPublishDate.Value = (DateTime)row.Cells[colpublishdate.Index].Value;

                    //for book type by age
                    if (row.Cells[coladultchild.Index].Value.ToString().Equals("adult"))
                    {
                        rbtAdult.Checked = true;
                    }
                    else
                    {
                        rbtChild.Checked = true;
                    }
                    //end
                    txtDesp.Text = row.Cells[colDesp.Index].Value.ToString();

                    tabctrlBook.SelectedIndex = 0;

                    break;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Bind_Book(1);
        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            FrmAuthor frm = new FrmAuthor();
            frm.ShowDialog();
            Bind_Author();
        }

        private void btnNewBookCate_Click(object sender, EventArgs e)
        {
            FrmBookCategory frm = new FrmBookCategory();
            frm.ShowDialog();
            Bind_BookCategory();
        }

        private void dgvBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvBookList.Rows[e.RowIndex];

            FrmBookLostDamage frm = new FrmBookLostDamage((int)row.Cells[colbookid.Index].Value,
                row.Cells[colbooktitle.Index].Value.ToString(), row.Cells[colbookbarcode.Index].Value.ToString(),
                (int)row.Cells[colbookcopy.Index].Value);

            frm.ShowDialog();

            Bind_Book(1);
        }

        private void cboBookCategory2_DropDownClosed(object sender, EventArgs e)
        {
            if (cboBookCategory2.Items.Count > 0)
            {
                Bind_Book(2);
            }
        }

        private void txtBookbarcode2_TextChanged(object sender, EventArgs e)
        {
            Bind_Book(3);
        }

        private void txtBookTitle2_TextChanged(object sender, EventArgs e)
        {
            Bind_Book(4);
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtBooktitle_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtPublisher_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboBookCategory_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboAuthor1_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboAuthor2_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void numQty_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void dtpkPublishDate_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void rbtAdult_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void rbtChild_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboBookCategory_DropDownClosed(object sender, EventArgs e)
        {
            if (cboBookCategory.Items.Count > 0)
            {
                GenerateCode();
            }
        }
    }
}
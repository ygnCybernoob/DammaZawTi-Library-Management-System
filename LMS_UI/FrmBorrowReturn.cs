using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LMS_INFO;
using LMS_BLL;
using System.Collections.ObjectModel;
using System.IO;

namespace LMS_UI
{
    public partial class FrmBorrowReturn : Form
    {
        #region declaration

        Member_Controller member_controller;
        Member_Info member_info;

        Book_Controller book_controller;
        Book_Info book_info;

        Fine_Controller fine_controller;

        LibraryType_Controller librarytype_controller;

        BorrowBook_Controller borrowbook_controller;
        BorrowBook_Collection borrowbook_collection;
        BorrowBook_Info borrowBook_info;

        #endregion

        #region variable

        private float FINE, 
            TOTAL_FINE;

        private int librarianid,
            borrowedbook,
            allowbook;

        //private Image bookcover;
        private string LIBRARY_TYPE;// BYQTY - DAILY

        #endregion

        public FrmBorrowReturn(int librarianid)
        {
            InitializeComponent();
            this.librarianid = librarianid;
        }

        #region myCode

        private bool CheckRequiredField()
        {
            return true;
        }

        private void Clear_Borrow()
        {
            txtBarcode.Enabled = true;
            txtBookbarcode.Enabled = false;
            btnSave.Enabled = false;

            txtBarcode.Focus();

            txtBarcode.Text = string.Empty;
            txtBookbarcode.Text = string.Empty;

            picImage.Image = Properties.Resources.member_image;
            txtMemberInfo.Text = string.Empty;

            //dgvToReturn.DataSource = -1;
            dgvToBorrow.RowCount = 0;
        }

        private void Clear_Return()
        {
            TOTAL_FINE = 0;
            txtMemberBarcode.Enabled = true;
            btnReturn.Enabled = false;
            txtMemberBarcode.Focus();

            txtMemberBarcode.Text = string.Empty;

            picImage2.Image = Properties.Resources.member_image;
            txtMemberInfo2.Text = string.Empty;

            dgvToReturn.DataSource = 0;
        }

        private void Select_MemberInfoForReturn(int selectType)
        {
            try
            {
                member_controller = new Member_Controller();
                member_info = member_controller.Select_MemberBasicInfo(txtMemberBarcode.Text.Trim(), selectType);

                if (string.IsNullOrEmpty(member_info.Membername))
                {
                    Utilities.ShowMessage(Utilities.MessageType.Warning, "အသင္း၀င္ကုဒ္နံပါတ္မွာ မွားယြင္းေနပါသည္\nျပန္လည္စစ္ေဆးေပးပါ");
                    txtMemberBarcode.Text = string.Empty;
                    return;
                }

                string text = string.Format(
    @"    အသင္း၀င္အမည္        - {0}
    ဘားကုဒ္                   - {1}
    အသင္း၀င္အမ်ိဳးအစား  - {2}
    ခြင့္ျပဳစာအုပ္               - {3}အုပ္
    ခြင့္ျပဳရက္                  - {4}ရက္
    အသင္း၀င္သက္တမ္း   - {5}",
      member_info.Membername,
      member_info.Memberbarcode,
      member_info.Membertype,
      member_info.Allowbook,
      member_info.Allowday,
      member_info.Expiredate);

                txtMemberInfo2.Text = text;

                if (member_info.Memberimagebyte.Length == 0)
                {
                    picImage2.Image = Properties.Resources.member_image;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(member_info.Memberimagebyte);
                    picImage2.Image = Image.FromStream(ms);
                }

                borrowbook_controller = new BorrowBook_Controller();
                borrowbook_collection = borrowbook_controller.Select_BorrowedBook(member_info.Memberid, FINE);
                dgvToReturn.AutoGenerateColumns = false;
                dgvToReturn.DataSource = borrowbook_collection;

                if (dgvToReturn.RowCount == 0)
                {
                    Utilities.ShowMessage(Utilities.MessageType.Information, member_info.Membername + " မွ  ငွားထားေသာ စာအုပ္  မရွိေသးပါ");
                    Clear_Return();
                    return;
                }

                foreach (DataGridViewRow row in dgvToReturn.Rows)
                {
                    if (Convert.ToInt32(row.Cells[colFine.Index].Value) > 0)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }

                txtMemberBarcode.Enabled = false;
                btnReturn.Enabled = true;

                dgvToReturn.Focus();
            }
            catch (Exception ex)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, ex.Message);
            }
        }

        private void Select_MemberInfo(int selectType)
        {
            try
            {
                member_controller = new Member_Controller();
                member_info = member_controller.Select_MemberBasicInfo(txtBarcode.Text.Trim(), selectType);

                if (string.IsNullOrEmpty(member_info.Membername))
                {
                    Utilities.ShowMessage(Utilities.MessageType.Warning, "အသင္း၀င္ကုဒ္နံပါတ္မွာ မွားယြင္းေနပါသည္\nျပန္လည္စစ္ေဆးေပးပါ");
                    Clear_Borrow();
                    return;
                }

                borrowbook_controller = new BorrowBook_Controller();

                borrowBook_info = new BorrowBook_Info();
                borrowBook_info.Librarytype = LIBRARY_TYPE;
                borrowBook_info.Memberid = member_info.Memberid;
                borrowBook_info.Dateborrowed = System.DateTime.Today;
                //assign to the variable 
                borrowedbook = borrowbook_controller.Select_BorrwedBook_Qty(borrowBook_info);

                if (borrowedbook == member_info.Allowbook)
                {
                    Utilities.ShowMessage(Utilities.MessageType.Information, "အသင္း၀င္၏ ခြင့္ျပဳစာအုပ္အေရအတြက္ ျပည့္ေနပါေသာေၾကာင့္ ငွားရမ္း၍ မရေသးပါ");
                    txtBarcode.Text = string.Empty;
                    return;
                }

                allowbook = member_info.Allowbook - borrowedbook;

                string text = string.Format(
    @"    အသင္း၀င္အမည္        - {0}
    ဘားကုဒ္                   - {1}
    အသင္း၀င္အမ်ိဳးအစား  - {2}
    ခြင့္ျပဳစာအုပ္               - {3}အုပ္
    ခြင့္ျပဳရက္                  - {4}ရက္
    အသင္း၀င္သက္တမ္း   - {5}",
                  member_info.Membername,
                  member_info.Memberbarcode,
                  member_info.Membertype,
                  member_info.Allowbook,
                  member_info.Allowday,
                  member_info.Expiredate);

                txtMemberInfo.Text = text;
                if (member_info.Memberimagebyte.Length == 0)
                {
                    picImage.Image = Properties.Resources.member_image;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(member_info.Memberimagebyte);
                    picImage.Image = Image.FromStream(ms);
                }

                txtBarcode.Enabled = false;
                txtBookbarcode.Enabled = true;
                btnSave.Enabled = true;

                txtBookbarcode.Focus();
            }
            catch (Exception ex)
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, ex.Message);
            }
        }

        private void Add_BookToBorrow()
        {
            if (allowbook > 0)
            {
                book_controller = new Book_Controller();
                book_info = book_controller.Select_BookBasicInfo(txtBookbarcode.Text.Trim());

                if (string.IsNullOrEmpty(book_info.Booktitle))
                {
                    Utilities.ShowMessage(Utilities.MessageType.Warning, "စာအုပ္ကုဒ္နံပါတ္မွာ မွားယြင္းေနပါသည္\nျပန္လည္စစ္ေဆးေပးပါ");
                    txtBookbarcode.Text = string.Empty;
                    return;
                }
                dgvToBorrow.Rows.Add(book_info.Bookid, member_info.Memberid, book_info.Bookbarcode, book_info.BookCover, book_info.Booktitle);

                allowbook--;
                if (allowbook == 0)
                {
                    btnSave.Focus();
                }
            }
            else
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "အသင္း၀င္၏ ခြင့္ျပဳစာအုပ္အေရအတြက္ ျပည့္သြားပါျပီ");
                btnSave.Focus();
            }

        }

        #endregion

        private void FrmBorrowReturn_Load(object sender, EventArgs e)
        {
            txtBarcode.Focus();

            fine_controller = new Fine_Controller();
            FINE = fine_controller.Select_Fine();

            librarytype_controller = new LibraryType_Controller();
            LIBRARY_TYPE = librarytype_controller.SelectLibraryType();// BYQTY - DAILY
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (chkboxBarcodeSystem.Checked && (!string.IsNullOrEmpty(txtBarcode.Text.Trim())))
            {
                Select_MemberInfo(1);
            }
        }

        private void txtBookbarcode_TextChanged(object sender, EventArgs e)
        {
            if (chkboxBarcodeSystem.Checked && (!string.IsNullOrEmpty(txtBookbarcode.Text.Trim())))
            {
                Add_BookToBorrow();
                txtBookbarcode.Text = string.Empty;
            }

        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((!chkboxBarcodeSystem.Checked) && e.KeyCode == Keys.Enter)
            {
                Select_MemberInfo(1);
                txtBookbarcode.Focus();
            }
        }

        private void txtBookbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((!chkboxBarcodeSystem.Checked) && e.KeyCode == Keys.Enter)
            {
                Add_BookToBorrow();
                txtBookbarcode.Text = string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvToBorrow.RowCount > 0)
            {
                book_controller = new Book_Controller();

                foreach (DataGridViewRow row in dgvToBorrow.Rows)
                {
                    borrowBook_info = new BorrowBook_Info();

                    borrowBook_info.Bookid = (int)row.Cells[colbookid.Index].Value;
                    borrowBook_info.Memberid = (int)row.Cells[colmemberid.Index].Value;
                    borrowBook_info.Librarianid = librarianid;
                    borrowBook_info.Dateborrowed = System.DateTime.Today;
                    borrowBook_info.Duedate = System.DateTime.Today.AddDays(member_info.Allowday);

                    borrowbook_controller.Insert_BorrwedBook(borrowBook_info);
                }

                Clear_Borrow();
            }
            else
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "ငွားမည့္ စာအုပ္၏ ဘားကုဒ္မ်ားကို ဦးစြာထည့္သြင္းေပးပါ ");
                txtBookbarcode.Focus();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear_Borrow();
        }

        private void dgvToBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvToBorrow.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colDelete":
                    dgvToBorrow.Rows.RemoveAt(e.RowIndex);
                    txtBookbarcode.Focus();
                    ++allowbook;
                    break;
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            Clear_Return();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            bool hasChecked = false;

            foreach (DataGridViewRow row in dgvToReturn.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colReturn"].Value))
                {
                    hasChecked = true;
                }
            }

            if (hasChecked)
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "စုစုေပါင္းရက္လြန္ေၾကးမွာ " + TOTAL_FINE + "က်ပ္  ျဖစ္ပါသည္");

                borrowbook_controller = new BorrowBook_Controller();


                foreach (DataGridViewRow row in dgvToReturn.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["colReturn"].Value))
                    {
                        hasChecked = true;

                        borrowBook_info = new BorrowBook_Info();
                        borrowBook_info.Borrowbookid = (int)row.Cells[colBorrowBookId.Index].Value;
                        borrowBook_info.Returndate = System.DateTime.Today;
                        borrowBook_info.Fine = (float)row.Cells[colFine.Index].Value;

                        borrowbook_controller.Insert_ReturnBook(borrowBook_info);
                    }
                }
                Clear_Return();
            }
            else
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "အပ္မည့္စာအုပ္ကို ဦးစြာအမွန္ျခစ္ ျခစ္ေပးပါရန္");
            }
        }

        private void txtMemberBarcode_TextChanged(object sender, EventArgs e)
        {
            if (chkboxBarcodeSystem.Checked && (!string.IsNullOrEmpty(txtMemberBarcode.Text.Trim())))
            {
                Select_MemberInfoForReturn(2);
            }
        }

        private void txtMemberBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((!chkboxBarcodeSystem.Checked) && e.KeyCode == Keys.Enter)
            {
                Select_MemberInfoForReturn(2);
            }
        }

        private void dgvToReturn_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvToReturn.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colReturn":

                    if (Convert.ToBoolean(row.Cells["colReturn"].Value))
                    {
                        TOTAL_FINE += (float)row.Cells[colFine.Index].Value;

                    }
                    else
                    {
                        TOTAL_FINE -= (float)row.Cells[colFine.Index].Value;
                    }
                    break;
            }
        }

        private void tabctrlBorrwReturn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrlBorrwReturn.SelectedIndex == 0)
            {
                txtBarcode.Focus();
            }
            else
            {
                txtMemberBarcode.Focus();
            }
        }
    }
}
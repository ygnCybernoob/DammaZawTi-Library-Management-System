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
    public partial class FrmBorrowedQtyReport : Form
    {
        public FrmBorrowedQtyReport()
        {
            InitializeComponent();
        }

        #region myCode

        private void Bind_BorrowedReport(int type)
        {
            int month = System.DateTime.Today.Month;
            int year   = System.DateTime.Today.Year;
            int qty =  (int)numQty.Value;

            BorrowBook_Controller controller = new BorrowBook_Controller();
            BorrowBook_Collection collection = controller.Select_BorrowedReport(type, month, year, dtpkStart.Value.Date, dtpkEnd.Value.Date, qty);

            dgvMemberRentReport.AutoGenerateColumns = false;
            dgvMemberRentReport.DataSource = collection;
        }

        #endregion

        private void btnBorrowedNowMonth_Click(object sender, EventArgs e)
        {
            Bind_BorrowedReport(1);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Bind_BorrowedReport(2);
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            Bind_BorrowedReport(3);
        }

    }
}

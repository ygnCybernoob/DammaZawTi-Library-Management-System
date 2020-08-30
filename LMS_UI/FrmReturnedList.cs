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
    public partial class FrmReturnedList : Form
    {
        public FrmReturnedList()
        {
            InitializeComponent();
        }

        #region myCode

        private void Bind_ReturnedList(int type)
        {

            BorrowBook_Controller controller = new BorrowBook_Controller();
            BorrowBook_Collection collection = controller.Select_ReturnedList(type, txtBarcode.Text.Trim(), dtpkDate.Value.Month, dtpkDate.Value.Year);

            dgvReturnedList.AutoGenerateColumns = false;
            dgvReturnedList.DataSource = collection;

            foreach (DataGridViewRow row in dgvReturnedList.Rows)
            {
                if (Convert.ToInt64(row.Cells[colFine.Index].Value) > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(251, 106, 118);
                }
            }
        }

        #endregion


        private void btnShow_Click(object sender, EventArgs e)
        {
            Bind_ReturnedList(1);
        }

        private void dtpkDate_CloseUp(object sender, EventArgs e)
        {
            Bind_ReturnedList(2);
        }

    }
}
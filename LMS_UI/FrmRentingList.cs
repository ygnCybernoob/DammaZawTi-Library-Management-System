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
    public partial class FrmRentingList : Form
    {
        BorrowBook_Controller controller;
        BorrowBook_Collection collection;
        //BorrowBook_Info info;

        public FrmRentingList()
        {
            InitializeComponent();
        }

        #region myCode

        private void Bind_RentingList()
        {
            controller = new BorrowBook_Controller();
            collection = controller.Select_RentingList();
            dgvRentingList.AutoGenerateColumns = false;
            dgvRentingList.DataSource = collection;
        }

        #endregion

        private void FrmRentingList_Load(object sender, EventArgs e)
        {
           Bind_RentingList();
        }

        private void FrmRentingList_Activated(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRentingList.Rows)
            {
                if (Convert.ToInt32(row.Cells[colOverday.Index].Value) > 0)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void dgvRentingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class FrmTopRent : Form
    {
        public FrmTopRent()
        {
            InitializeComponent();
        }

        #region myCode


        private void Bind_TopRent()
        {
            Book_Controller controller = new Book_Controller();
            Book_Collection collection = controller.Select_TopRent();

            dgvTopRentList.AutoGenerateColumns = false;
            dgvTopRentList.DataSource = collection;
        }

        #endregion

        private void FrmTopRent_Load(object sender, EventArgs e)
        {
            Bind_TopRent();
        }
    }
}

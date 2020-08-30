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
    public partial class FrmLostOrDamage : Form
    {
        public FrmLostOrDamage()
        {
            InitializeComponent();
        }

        #region myCode

        private void Bind_Lost()
        {
            Book_Controller controller = new Book_Controller();
            Book_Collection collection = controller.Select_LostBook();

            dgvLostOrDamage.AutoGenerateColumns = false;
            dgvLostOrDamage.DataSource = collection;
        }

        #endregion

        private void FrmLostOrDamage_Load(object sender, EventArgs e)
        {
            Bind_Lost();
        }
    }
}

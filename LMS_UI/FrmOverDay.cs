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
    public partial class FrmOverDay : Form
    {
        OverDay_Controller overday_controller;
        OverDay_Collection overday_collection;

        public FrmOverDay()
        {
            InitializeComponent();
        }

        #region myCode

        private void Bind_OverDayList()
        {
            overday_controller = new OverDay_Controller();
            overday_collection = overday_controller.Select_OverDay_List();
            dgvOverDay.AutoGenerateColumns = false;
            dgvOverDay.DataSource = overday_collection;
        }

        #endregion

        private void FrmOverDay_Load(object sender, EventArgs e)
        {
            Bind_OverDayList();
        }

        private void dgvOverDay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
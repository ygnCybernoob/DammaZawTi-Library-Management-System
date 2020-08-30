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
    public partial class FrmFeedbackList : Form
    {
        Feedback_Controller controller;
        Feedback_Collection collection;
        Feedback_Info info;

        public FrmFeedbackList()
        {
            InitializeComponent();
        }

        #region myCode

        private void Bind_FeedBack(int type)
        {
            controller = new Feedback_Controller();
            collection = controller.Select_Feedback(type, dtpkDate.Value.Month, dtpkDate.Value.Year);

            dgvFeedback.AutoGenerateColumns = false;
            dgvFeedback.DataSource = collection;
        }

        #endregion 

        private void FrmFeedbackList_Load(object sender, EventArgs e)
        {
            Bind_FeedBack(2);
        }

        private void dgvFeedback_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvFeedback.Rows[e.RowIndex];

            info = new Feedback_Info();

            info.Feedbackid = (int)row.Cells[colFeedbackid.Index].Value;
            info.Feedbackdate = (DateTime)row.Cells[colfeedbackdate.Index].Value;
            info.Subject = row.Cells[colsubject.Index].Value.ToString();
            info.Feedback = row.Cells[colFeedback.Index].Value.ToString();
            info.Membername = row.Cells[colmembername.Index].Value.ToString();

            FrmFeedbackViewer fb= new FrmFeedbackViewer(info);
            fb.ShowDialog();

            controller = new Feedback_Controller();
            controller.Update_Feedback(info.Feedbackid);

            Bind_FeedBack(2);
        }

        private void btnChecked_Click(object sender, EventArgs e)
        {
            Bind_FeedBack(1);
        }

        private void btnUnchecked_Click(object sender, EventArgs e)
        {
            Bind_FeedBack(2);
        }

        private void dtpkDate_CloseUp(object sender, EventArgs e)
        {
            Bind_FeedBack(2);
        }
    }
}
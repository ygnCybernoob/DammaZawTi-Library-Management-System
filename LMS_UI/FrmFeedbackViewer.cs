using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LMS_INFO;

namespace LMS_UI
{
    public partial class FrmFeedbackViewer : Form
    {
        public FrmFeedbackViewer(Feedback_Info info)
        {
            InitializeComponent();

            this.Text = info.Feedbackdate.ToShortDateString() +" : "+info.Membername + "​ ၏ အေၾကာင္းၾကားစာ : " + info.Subject;
            lblMemberName.Text = info.Membername + " ထံမွ........";
            rtxtFeedback.Text = info.Feedback;
        }

        private void FrmFeedbackViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
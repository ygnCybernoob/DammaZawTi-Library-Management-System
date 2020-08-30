using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace LMS_UI
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        #region myCode

        private void OpenServerReigster(object obj)
        {
            FrmServerRegister sg = new FrmServerRegister();
            Application.Run(sg);
        }

        private void OpenMain(object obj)
        {
            FrmMain main = new FrmMain();
            Application.Run(main);
        }

        #endregion

        private void FrmFlash_Load(object sender, EventArgs e)
        {
            Utilities.CenterMyControl(lblLibraryName);
            timerFlash.Interval = 20;
            timerFlash.Start();
        }

        private void timerFlash_Tick(object sender, EventArgs e)
        {
            if (!(++pgbProgress.Value < 100))
            {
                timerFlash.Stop();
                this.Close();
            }
            //else
            //{

            //}
        }
    }
}
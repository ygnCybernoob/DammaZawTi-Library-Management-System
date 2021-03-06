using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LMS_BLL;
using LMS_INFO;
using System.Threading;
using System.Configuration;

namespace LMS_UI
{
    public partial class FrmMain : Form
    {
        private static Account_Info accountinfo;
        private static Account_Controller.Status accountstaus;
        private bool Librarian_Login = false;

        FrmBorrowReturn borrow_return;
        FrmBookSearch book_search;
        FrmFeedback feedback;

        FrmBook book;
        FrmLibrarian librarian;
        FrmMember member;

        FrmOverDay overday;
        FrmLibraryInformation libraryinformation;
        FrmFeedbackList feedbacklist;

        FrmRentingList rentinglist;
        FrmReturnedList returnedList;
        FrmBorrowedQtyReport memberborrowedqtyreport;

        FrmMemberReport memberreport;
        FrmBookReport bookreport;
        FrmLostOrDamage lostOrDamage;

        public FrmMain()
        {
            InitializeComponent();
            HideMenu();
            Init_Task();
        }

        #region myCode

        private void HideMenu()
        {
            adminPanelToolStripMenuItem.Visible = false;
            reportToolStripMenuItem.Visible = false;
            dataEntryToolStripMenuItem.Visible = false;
            memberToolStripMenuItem.Visible = false;
            bookToolStripMenuItem1.Visible = false;
            librarianToolStripMenuItem3.Visible = false;
            librarySettingToolStripMenuItem.Visible = false;
        }

        private void ShowMenu()
        {
            adminPanelToolStripMenuItem.Visible = true ;
            reportToolStripMenuItem.Visible = true;
            dataEntryToolStripMenuItem.Visible = true;
            memberToolStripMenuItem.Visible = true;
            bookToolStripMenuItem1.Visible = true;
            librarianToolStripMenuItem3.Visible = true;
            librarySettingToolStripMenuItem.Visible = true;
        }

        public static Account_Controller.Status Accountstaus
        {
            get { return FrmMain.accountstaus; }
            set { FrmMain.accountstaus = value; }
        } 

        public static Account_Info Accountinfo
        {
            get { return FrmMain.accountinfo; }
            set { FrmMain.accountinfo = value; }
        }

        private void Init_Task()
        {
            this.Hide();
            FrmSplash s = new FrmSplash();
            s.ShowDialog();
            try
            {
                SqlHelper helper = new SqlHelper(ConfigurationManager.ConnectionStrings["ServerConnection"].ConnectionString);
                helper.IsConnection();
            }
            catch (Exception)
            {
                FrmServerRegister sg = new FrmServerRegister();
                sg.ShowDialog();
            }

            FrmLogin l = new FrmLogin();
            l.ShowDialog();
            if (accountinfo != null)
            {
                lblUserName.Text = accountinfo.Username;
            }

            OverDay_Controller overday_controller = new OverDay_Controller();
            int qty = overday_controller.Select_OverdayMember_Qty();

            if (qty > 0)
            {
                if (Utilities.ShowMessage(Utilities.MessageType.Question, "ရက္ေက်ာ္လြန္ေသာ အသင္း၀င္မ်ား  ရွိပါသည္\nၾကည့္ရႈလိုပါသလား") == DialogResult.Yes)
                {
                    overDayMemberToolStripMenuItem_Click(null, null);
                }
            }

            Member_Controller member_controller = new Member_Controller();
            int expired = member_controller.Check_Expired();

            if ( expired > 0)
            {
                if (expired % 100 == 0)
                {
                    Utilities.ShowMessage(Utilities.MessageType.Information, "အသင္း၀င္ အေယာက္ " + expired + " သက္တမ္းကုန္ဆုံးပါသည္");
                }
                else
                {
                    Utilities.ShowMessage(Utilities.MessageType.Information, "အသင္း၀င္ " + expired + " ေယာက္ သက္တမ္းကုန္ဆုံးပါသည္");
                } 
            }

            this.Show();
        }

        private void CheckLibrarianLogin()
        {
            switch (accountstaus)
            {
                case Account_Controller.Status.ActiveTrueAdmin:
                    Utilities.ShowMessage(Utilities.MessageType.Information, "Welcome Admin!");
                    Librarian_Login = true;
                    ShowMenu();
                    break;

                case Account_Controller.Status.ActiveTrue:
                    Utilities.ShowMessage(Utilities.MessageType.Information, "Encoder");
                    Librarian_Login = true;
                    break;
            }
        }

        #endregion

        private void authorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAuthor a = new FrmAuthor();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void librarianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLibrarian l = new FrmLibrarian(accountinfo.Librarianid, accountinfo.Username);
            l.MdiParent = this;
            l.WindowState = FormWindowState.Maximized;
            l.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Utilities.ShowMessage(Utilities.MessageType.Question, "ေဆာ့ဖ္၀ဲလ္ကို ပိတ္လိုပါသလား?") == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void libraryInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibraryInformation l = new FrmLibraryInformation();
            l.MdiParent = this;
            l.WindowState = FormWindowState.Maximized;
            l.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBook l = new FrmBook();
            l.MdiParent = this;
            l.WindowState = FormWindowState.Maximized;
            l.Show();
        }

        private void townshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTownship frm = new FrmTownship();
            frm.Show();
        }

        private void villageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVillage frm = new FrmVillage();
            frm.Show();
        }

        private void memberTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMemberType frm = new FrmMemberType();
            frm.Show();
        }

        private void mEMBERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMember frm = new FrmMember(accountinfo);
            frm.Show();
        }

        private void educationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEducation frm = new FrmEducation();
            frm.Show();
        }

        private void occupationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOccupation frm = new FrmOccupation();
            frm.Show();
        }

        private void bookTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBookCategory frm = new FrmBookCategory();
            frm.Show();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        void overday_FormClosed(object sender, FormClosedEventArgs e)
        {
            overday = null;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //pnlSliderHome.Visible = true;
            //timer1.Start();

            pnlSlider.Visible = false;
            pnlSliderHome.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pnlSlider.Width > 0)
            {
                pnlSlider.Width -= 20;
            }
            else
            {
                timer1.Stop();
                pnlSliderHome.Visible = true;
                pnlSlider.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pnlSlider.Width < 200)
            {
                pnlSlider.Width += 20;
            }
            else
            {
                timer2.Stop();
                pnlSliderHome.Visible = false;
            }
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            if (borrow_return == null)
            {
                borrow_return = new FrmBorrowReturn(accountinfo.Librarianid);
                borrow_return.MdiParent = this;
                borrow_return.FormClosed += new FormClosedEventHandler(borrow_return_FormClosed);
                borrow_return.Show();
            }
            else
            {
                borrow_return.Activate();
            }
            borrow_return.WindowState = FormWindowState.Maximized;
        }

        void borrow_return_FormClosed(object sender, FormClosedEventArgs e)
        {
            borrow_return = null;
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            if (book_search == null)
            {
                book_search = new FrmBookSearch();
                book_search.MdiParent = this;
                book_search.FormClosed += new FormClosedEventHandler(book_search_FormClosed);
                book_search.Show();
            }
            else
            {
                book_search.Activate();
            }
            book_search.WindowState = FormWindowState.Maximized;
        }

        void book_search_FormClosed(object sender, FormClosedEventArgs e)
        {
            book_search = null;
        }

        private void libraryTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibraryType lt = new FrmLibraryType();
            lt.ShowDialog();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void librarianToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmLibrarian l = new FrmLibrarian(accountinfo.Librarianid, accountinfo.Username);
            l.MdiParent = this;
            l.WindowState = FormWindowState.Maximized;
            l.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            if (feedback == null)
            {
                feedback = new FrmFeedback();
                feedback.MdiParent = this;
                feedback.FormClosed += new FormClosedEventHandler(feedback_FormClosed);
                feedback.Show();
            }
            else
            {
                feedback.Activate();
            }
            feedback.WindowState = FormWindowState.Maximized;
        }


        void feedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            feedback = null;
        }

        private void fineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFine fine = new FrmFine();
            fine.ShowDialog();
        }

        private void libraryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (libraryinformation == null)
            {
                libraryinformation = new FrmLibraryInformation();
                libraryinformation.MdiParent = this;
                libraryinformation.FormClosed += new FormClosedEventHandler(libraryinformation_FormClosed);
                libraryinformation.Show();
            }
            else
            {
                libraryinformation.Activate();
            }
            libraryinformation.WindowState = FormWindowState.Maximized;
        }

        void libraryinformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            libraryinformation = null;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeAllFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in (this.MdiChildren))
            {
                frm.Close();
            }
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {

        }

        private void bookToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (book == null)
            {
                book = new FrmBook();
                book.MdiParent = this;
                book.FormClosed += new FormClosedEventHandler(book_FormClosed);
                book.Show();
            }
            else
            {
                book.Activate();
            }
            book.WindowState = FormWindowState.Maximized;
        }

        void book_FormClosed(object sender, FormClosedEventArgs e)
        {
            book = null;
        }

        private void memberToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (member == null)
            {
                member = new FrmMember(accountinfo);
                member.MdiParent = this;
                member.FormClosed += new FormClosedEventHandler(member_FormClosed);
                member.Show();
            }
            else
            {
                member.Activate();
            }
            member.WindowState = FormWindowState.Maximized;
        }

        void member_FormClosed(object sender, FormClosedEventArgs e)
        {
            member = null;
        }

        private void memberTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMemberType membertype = new FrmMemberType();
            membertype.ShowDialog();
        }

        private void bookCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBookCategory bookcategory = new FrmBookCategory();
            bookcategory.ShowDialog();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmChangePassword cp = new FrmChangePassword(accountinfo);
            cp.ShowDialog();
        }

        private void librarianToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (librarian == null)
            {
                librarian = new FrmLibrarian(accountinfo.Librarianid, accountinfo.Username);
                librarian.MdiParent = this;
                librarian.FormClosed += new FormClosedEventHandler(librarian_FormClosed);
                librarian.Show();
            }
            else
            {
                librarian.Activate();
            }
            librarian.WindowState = FormWindowState.Maximized;
        }

        void librarian_FormClosed(object sender, FormClosedEventArgs e)
        {
            librarian = null;
        }

        private void authorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAuthor author = new FrmAuthor();
            author.ShowDialog();
        }

        private void townshipToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTownship township = new FrmTownship();
            township.ShowDialog();
        }

        private void villageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVillage village = new FrmVillage();
            village.ShowDialog();
        }

        private void educationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEducation education = new FrmEducation();
            education.ShowDialog();
        }

        private void occupationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmOccupation occupation = new FrmOccupation();
            occupation.ShowDialog();
        }

        private void borrowReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBorrowReturn_Click(null, null);
        }

        private void bookSearchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBookSearch_Click(null, null);
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFeedback_Click(null, null);
        }

        private void overDayMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (overday == null)
            {
                overday = new FrmOverDay();
                overday.MdiParent = this;
                overday.FormClosed += new FormClosedEventHandler(overday_FormClosed);
                overday.Show();
            }
            else
            {
                overday.Activate();
            }
            overday.WindowState = FormWindowState.Maximized;
        }

        private void borrowedListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void feedbackCheckingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (feedbacklist == null)
            {
                feedbacklist = new FrmFeedbackList();
                feedbacklist.MdiParent = this;
                feedbacklist.FormClosed += new FormClosedEventHandler(feedbacklist_FormClosed);
                feedbacklist.WindowState = FormWindowState.Maximized;
                feedbacklist.Show();
            }
            else
            {
                feedbacklist.WindowState = FormWindowState.Maximized;
                feedbacklist.Activate();
            }
        }

        void feedbacklist_FormClosed(object sender, FormClosedEventArgs e)
        {
            feedbacklist = null;
        }

        private void rentingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rentinglist == null)
            {
                rentinglist = new FrmRentingList();
                rentinglist.MdiParent = this;
                rentinglist.FormClosed += new FormClosedEventHandler(rentinglist_FormClosed);
                rentinglist.WindowState = FormWindowState.Maximized;
                rentinglist.Show();
            }
            else
            {
                rentinglist.WindowState = FormWindowState.Maximized;
                rentinglist.Activate();
            }
        }

        void rentinglist_FormClosed(object sender, FormClosedEventArgs e)
        {
            rentinglist = null;
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            if (Librarian_Login)
            {
                Librarian_Login = false;
                HideMenu();

            }
            else
            {
                FrmLogin_OpenAdmin login = new FrmLogin_OpenAdmin();
                login.ShowDialog();
                CheckLibrarianLogin();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            pnlSliderHome.Visible = false;
            pnlSlider.Visible = true;

            //timer2.Start();
        }

        private void zawgyiHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmZawgyiHelp zawgyi = new FrmZawgyiHelp();
            zawgyi.Show();
        }

        private void qtyOfBorrowedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (memberborrowedqtyreport == null)
            {
                memberborrowedqtyreport = new FrmBorrowedQtyReport();
                memberborrowedqtyreport.MdiParent = this;
                memberborrowedqtyreport.FormClosed += new FormClosedEventHandler(memberborrowedqtyreport_FormClosed);
                memberborrowedqtyreport.WindowState = FormWindowState.Maximized;
                memberborrowedqtyreport.Show();
            }
            else
            {
                memberborrowedqtyreport.WindowState = FormWindowState.Maximized;
                memberborrowedqtyreport.Activate();
            }
        }

        void memberborrowedqtyreport_FormClosed(object sender, FormClosedEventArgs e)
        {
            memberborrowedqtyreport = null;
        }

        private void returnedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (returnedList == null)
            {
                returnedList = new FrmReturnedList();
                returnedList.MdiParent = this;
                returnedList.FormClosed += new FormClosedEventHandler(returnedList_FormClosed);
                returnedList.WindowState = FormWindowState.Maximized;
                returnedList.Show();
            }
            else
            {
                returnedList.WindowState = FormWindowState.Maximized;
                returnedList.Activate();
            }
        }

        void returnedList_FormClosed(object sender, FormClosedEventArgs e)
        {
            returnedList = null;
        }

        private void memberReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (memberreport == null)
            {
                memberreport = new FrmMemberReport();
                memberreport.MdiParent = this;
                memberreport.FormClosed += new FormClosedEventHandler(memberreport_FormClosed);
                memberreport.WindowState = FormWindowState.Maximized;
                memberreport.Show();
            }
            else
            {
                memberreport.WindowState = FormWindowState.Maximized;
                memberreport.Activate();
            }
        }

        void memberreport_FormClosed(object sender, FormClosedEventArgs e)
        {
            memberreport = null;
        }

        private void bookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bookreport == null)
            {
                bookreport = new FrmBookReport();
                bookreport.MdiParent = this;
                bookreport.FormClosed += new FormClosedEventHandler(bookreport_FormClosed);
                bookreport.WindowState = FormWindowState.Maximized;
                bookreport.Show();
            }
            else
            {
                bookreport.WindowState = FormWindowState.Maximized;
                bookreport.Activate();
            }
        }

        void bookreport_FormClosed(object sender, FormClosedEventArgs e)
        {
            bookreport = null;
        }

        private void lostBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lostOrDamage == null)
            {
                lostOrDamage = new FrmLostOrDamage();
                lostOrDamage.MdiParent = this;
                lostOrDamage.FormClosed += new FormClosedEventHandler(lostOrDamage_FormClosed);
                lostOrDamage.WindowState = FormWindowState.Maximized;
                lostOrDamage.Show();
            }
            else
            {
                lostOrDamage.WindowState = FormWindowState.Maximized;
                lostOrDamage.Activate();
            }
        }

        void lostOrDamage_FormClosed(object sender, FormClosedEventArgs e)
        {
            lostOrDamage = null;
        }

        private void barcodeGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBarcodeGenerator bg = new FrmBarcodeGenerator();
            bg.ShowDialog();
        }
    }
}
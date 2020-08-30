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
    public partial class FrmMemberReport : Form
    {
        Member_Controller controller;
        Member_Info info;
        Member_Collection collection;

        public FrmMemberReport()
        {
            InitializeComponent();
        }

        #region myCode

        private void SelectQtyOfMember()
        {
            controller = new Member_Controller();
            info = controller.Select_QtyOfMember();

            lblMemberQty.Text = lblMemberQty.Text + " " + info.Active + " ဦး ";
            lblExpired.Text = lblExpired.Text + " " + info.Expired + " ဦး ";
            lblBaned.Text = lblBaned.Text + " " + info.Ban + " ဦး ";
            lblMale.Text = lblMale.Text + " " + info.Male + " ဦး ";
            lblFemale.Text = lblFemale.Text + " " + info.Female + " ဦး ";
        }

        private void SelectQtyOfMemberByAge()
        {
            controller = new Member_Controller();
            info = controller.Select_QtyOfMemberByAge();

            lblLower18.Text = lblLower18.Text + " " + info.Lower18 + " ဦး ";
            lbl18to30.Text = lbl18to30.Text + " " + info.F18to30 + " ဦး ";
            lbl30to50.Text = lbl30to50.Text + " " + info.F30to50 + " ဦး ";
            lblAbove50.Text = lblAbove50.Text + " " + info.Above50 + " ဦး ";
        }

        private void Bind_State()
        {
            StateDivision_Controller state_controller = new StateDivision_Controller();
            cboState.DataSource = state_controller.Select_StateDivision();
            cboState.DisplayMember = "state";
            cboState.ValueMember = "stateid";
        }

        private void Bind_Township()
        {
            Township_Controller township_controller = new Township_Controller();
            cboTownship.DataSource = township_controller.Select_Township(2,(int)cboState.SelectedValue, "");
            cboTownship.DisplayMember = "township";
            cboTownship.ValueMember = "townshipid";
        }

        private void Select_MemberByState()
        {
            controller = new Member_Controller();
            lblState.Text = "ျပည္နယ္/ တုိင္း ( " + controller.Select_QtyMemberByState((int)cboState.SelectedValue)+" ဦး)";
        }

        private void Bind_MemberByTownship()
        {
            controller = new Member_Controller();
            collection = controller.Select_QtyMemberByTownship((int)cboState.SelectedValue);
            dgvTownship.AutoGenerateColumns = false;
            dgvTownship.DataSource = collection;
        }

        private void Bind_MemberByVillage()
        {
            controller = new Member_Controller();
            collection = controller.Select_QtyMemberByVillage((int)cboTownship.SelectedValue);
            dgvVillage.AutoGenerateColumns = false;
            dgvVillage.DataSource = collection;
        }

        private void Bind_MemberByMemberType()
        {
            controller = new Member_Controller();
            collection = controller.Select_QtyMemberByType();
            dgvMembertype.AutoGenerateColumns = false;
            dgvMembertype.DataSource = collection;
        }

        private void Bind_MemberByOccupation()
        {
            controller = new Member_Controller();
            collection = controller.Select_QtyMemberByOccupation();
            dgvOccupation.AutoGenerateColumns = false;
            dgvOccupation.DataSource = collection;
        }

        private void Bind_MemberByEducation()
        {
            controller = new Member_Controller();
            collection = controller.Select_QtyMemberByEducation();
            dgvEducation.AutoGenerateColumns = false;
            dgvEducation.DataSource = collection;
        }

        #endregion

        private void FrmMemberReport_Load(object sender, EventArgs e)
        {
            SelectQtyOfMember();
            SelectQtyOfMemberByAge();
            Bind_MemberByMemberType();
            Bind_MemberByOccupation();
            Bind_MemberByEducation();
        }

        private void btnShowWithAddress_Click(object sender, EventArgs e)
        {
            switch (btnShowWithAddress.Text)
            {
                case "ေဒသလိုက္ အသင္း၀င္မ်ား အစီရင္ခံစာ":

                    btnShowWithAddress.Text = "အသင္း၀င္မ်ား အစီရင္ခံစာ";
                    Bind_State();
                    pnlWithAddress.Show();
                    break;

                case "အသင္း၀င္မ်ား အစီရင္ခံစာ":

                    btnShowWithAddress.Text = "ေဒသလိုက္ အသင္း၀င္မ်ား အစီရင္ခံစာ";
                    pnlWithAddress.Hide();
                    break;
            }
        }

        private void cboState_DropDownClosed(object sender, EventArgs e)
        {
            dgvVillage.DataSource = null;
            if (cboState.Items.Count > 0)
            {
                Select_MemberByState();
                Bind_MemberByTownship();
                Bind_Township();
            }
        }

        private void cboTownship_DropDownClosed(object sender, EventArgs e)
        {
            if (cboTownship.Items.Count > 0)
            {
                Bind_MemberByVillage();
            }
        }
    }
}

using DVLDBussinesLibary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private int _ApplicationID = -1;
        private clsApplication _Application;

        private bool _ShowPersonInfo = false;
        public bool ShowPersonInfo
        {
            get { return _ShowPersonInfo; }
            set { _ShowPersonInfo = value; llblPersonInfo.Visible = _ShowPersonInfo; pbPersonInfo.Visible = _ShowPersonInfo; }

        }

        public int ApplicationID { get { return _ApplicationID; } }
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }


        private void _FillApplicationsInfo()
        {
            _ApplicationID = _Application.ApplicationID;
            llblPersonInfo.Visible = true;
            pbPersonInfo.Visible = true;


            lblAppID.Text = _Application.ApplicationID.ToString();
            lblStatus.Text = _Application.StatusText;
            lblFees.Text = _Application.PaidFees.ToString("0.000");
            lblType.Text = _Application.ApplicationType.ApplicationTypeTitle;
            lblApplicant.Text = _Application.ApplicantFullName;
            lblApplicationDate.Text = _Application.ApplicationDate.ToString("dd/mm/yyyy _ HH:mm:ss");
            lblLastStatusDate.Text = _Application.LastStatusDate.ToString("dd/mm/yyyy _ HH:mm:ss");
            lblCreatedBy.Text = _Application.CreatedByUser.UserName;

        }

        public void LoadApplicationInfo(int ApplicationID)
        {

            _Application = clsApplication.Find(ApplicationID);

            if (_Application == null)
            {
                ResetDefaultValue();
                MessageBox.Show($"No Driving License Application With ID Number {_ApplicationID} is Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillApplicationsInfo();
        }


        public void ResetDefaultValue()
        {
            _ApplicationID = -1;
            lblAppID.Text = lblStatus.Text = lblType.Text = lblApplicant.Text =  lblCreatedBy.Text = "[????]";
            lblFees.Text = "[$$$$]";
            lblApplicationDate.Text = lblLastStatusDate.Text = "[??/??/??]";


        }

        private void llblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frmShowPersonInfo = new frmShowPersonInfo(_Application.ApplicantPersonID);
            frmShowPersonInfo.ShowDialog();

            // Refresh If Person Updated His Data
            LoadApplicationInfo(_Application.ApplicationID);
        }
    }
}

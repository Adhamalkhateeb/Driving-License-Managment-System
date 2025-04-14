using CountriesBussinessLayer;
using DVLD.Properties;
using PeopleBusinessLayer;
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
    public partial class ctrlPersonCard : UserControl
    {
        private string _NationlNo = string.Empty;
        private int _PersonID = -1;
        clsPerson _person;
        private bool _EnableUpdatePerson = true; 

        public int PersonID { get { return _PersonID; } }
        public clsPerson SelectedPerson { get { return _person; } }

        public bool ShowUpdatePerson { get { return _EnableUpdatePerson; } set { _EnableUpdatePerson = value; llblUpdate.Visible = _EnableUpdatePerson; } }
        public ctrlPersonCard()
        {
            InitializeComponent();

        }
        public void LoadPersonInfo(string NationalNo)
        {
            _NationlNo = NationalNo;
            _person = clsPerson.Find(NationalNo);

            if (_person == null)
            {
                ResetPersonInfo();
                MessageBox.Show($"No Person With National Number {NationalNo} is Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillpersonInfo();


        }

        public void LoadPersonInfo(int PersonID)
        {
            _PersonID = PersonID;
            _person = clsPerson.Find(PersonID);

            if (_person == null)
            {
                ResetPersonInfo();
                MessageBox.Show($"No Person With ID Number {PersonID} is Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillpersonInfo();
        }

        private void _FillpersonInfo()
        {
            _PersonID = _person.PersonID;
            llblUpdate.Enabled = true;
            lblID.Text = _person.PersonID.ToString();
            lblNationalNo.Text = _person.NationalNumber;
            lblName.Text = _person.FirstName + " " + _person.SecondName;
            if (!string.IsNullOrEmpty(_person.ThirdName))
                lblName.Text +=  " " + _person.ThirdName + " " + _person.LastName;
            else
                lblName.Text += " " + _person.LastName;
            lblEmail.Text = _person.Email;
            lblAddress.Text = _person.Address;
            if (_person.Gendor == 0)
            {
                lblGendor.Text = "Male";
                pbGendorImage.Image = Resources.administrator;
            }
            else
            {
                lblGendor.Text = "Female";
                pbGendorImage.Image = Resources.woman__2_;
            }

            lblDateOFBirth.Text = _person.DateOFBirth.ToShortDateString();
            lblPhone.Text = _person.Phone;
            lblCountry.Text = clsCountry.FindCountry(_person.NationalCountryID).CountryName;
            _LoadPersonImage();

        }

        private void _LoadPersonImage()
        {
            if (!string.IsNullOrEmpty(_person.ImagePath))
            {
                if (File.Exists(_person.ImagePath))
                    pbPersonImage.ImageLocation = _person.ImagePath;
                else
                    MessageBox.Show($"Could't Find image File Path {_person.ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (_person.Gendor == 0)
                    pbPersonImage.Image = Resources.Anonymous_Man;
                else
                    pbPersonImage.Image= Resources.Anonymous_Woman;
            }
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblName.Text = "[????]";
            pbGendorImage.Image = Resources.administrator;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOFBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Anonymous_Man;

        }

        private void llblUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdd_UpdatePerson add_Update = new frmAdd_UpdatePerson(_PersonID);
            add_Update.ShowDialog();

            LoadPersonInfo(_PersonID);
        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }
    }
}

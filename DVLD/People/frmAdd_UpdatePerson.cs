using DVLD.Properties;
using PeopleBusinessLayer;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountriesBussinessLayer;
using System.Data;
using Microsoft.VisualBasic.Devices;
using Microsoft.SqlServer.Server;
namespace DVLD
{
    public partial class frmAdd_UpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 1, Update = 2 }
        public enum enGendor { Male = 0, Female = 1 }

        private enMode _Mode;
        private int _PersonID = -1;
        clsPerson _Person;

        public frmAdd_UpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            btnSave.Enabled = false;
        }
        public frmAdd_UpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Update;
            btnSave.Enabled = false;
        }

        private void _ResetDefualtValues()
        {
            btnClose.CausesValidation = false;
            _FillCountryComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                this.Text = lblTitle.Text;
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update Person";
                this.Text = lblTitle.Text;
            }


            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Anonymous_Man;
            else
                pbPersonImage.Image = Resources.Anonymous_Woman;


            llblRemove.Visible = (pbPersonImage.ImageLocation != null);

            dtpBirth.MinDate = new DateTime(DateTime.Now.Year -100, 1, 1);
            dtpBirth.MaxDate = new DateTime(DateTime.Now.Year -18, DateTime.Now.Month, DateTime.Now.Day);
            dtpBirth.Value = dtpBirth.MaxDate;
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.CustomFormat = "MM/dd/yyyy";


            cmbCountries.SelectedIndex = cmbCountries.FindString("Egypt");

            mskFirstName.Text =  mskSecondName.Text = mskThirdName.Text = mskLastName.Text =  txtNationalNo.Text =
                mskPhone.Text = txtEmail.Text =txtAddress.Text = string.Empty;


        }

        private void _FillCountryComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow row in dt.Rows)
            {
                cmbCountries.Items.Add(row["CountryName"]);
            }

        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }


            lblID.Text = _Person.PersonID.ToString();
            mskFirstName.Text = _Person.FirstName;
            mskSecondName.Text = _Person.SecondName;
            mskThirdName.Text = _Person.ThirdName;
            mskLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNumber;
            dtpBirth.Value = _Person.DateOFBirth;
            if (_Person.Gendor == 'F')
                rbFemail.Checked = true;
            else
                rbMale.Checked = true;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            mskPhone.Text = _Person.Phone;
            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
                llblRemove.Visible = true;
            }

            cmbCountries.SelectedIndex = cmbCountries.FindString(_Person.Country.CountryName);

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {


            ErrorValidating(sender, e, "National Number is Required");

            if (clsPerson.IsPersonExist(((TextBox)sender).Text))
            {
                ErrorValidating(sender, e, "Person's National Number is Already Exist", true);
            }

        }

        private void ErrorValidating(object sender, CancelEventArgs e, string ErrorMessage, bool Errorhappend = false)
        {
            if (string.IsNullOrEmpty(((Control)sender).Text) || Errorhappend)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, ErrorMessage);

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Control)sender, null);
            }
            ValidatebtnSave();
        }

        private void mskFirstName_Validating(object sender, CancelEventArgs e)
        {
            ErrorValidating(sender, e, "First Name is Required");
        }

        private void mskSecondName_Validating(object sender, CancelEventArgs e)
        {
            ErrorValidating(sender, e, "Second Name is Required");
        }

        private void mskLastName_Validating(object sender, CancelEventArgs e)
        {
            ErrorValidating(sender, e, "Last Name is Required");
        }

        private void rbFemail_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemail.Checked)
            {
                pbPersonImage.Image = Resources.Anonymous_Woman;
                pbSmallPersonImage.Image = Resources.woman__2_;
                pbPersonImage.Tag = "2";
            }
            else if (pbPersonImage.Tag?.ToString() == "2")
            {
                pbPersonImage.Image = Resources.Anonymous_Man;
                pbSmallPersonImage.Image = Resources.administrator;
                pbPersonImage.Tag = "1";
            }
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!mskPhone.MaskCompleted)
            {
                ErrorValidating(sender, e, "Phone is Required", true);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Control)sender, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^\w+([-.!#$%&'*+/=?^_`{|}~]\w+)*@\w+([-.!#$%&'*+/=?^_`{|}~]\w+)*\.\w+([-.!#$%&'*+/=?^_`{|}~]\w+)*$");
            if (!regex.IsMatch(txtEmail.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                ErrorValidating(sender, e, "Enter Valid Email to continue Or Remove it", true);
            }
            else
            {
                errorProvider1.SetError((Control)sender, null);
            }
        }

        private void cmbCountries_Validating(object sender, CancelEventArgs e)
        {
            ErrorValidating(sender, e, "Choose Country (required)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            ErrorValidating(sender, e, "Address can't be empty");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @" Images |*.png;*.jpeg; *.jpg;*.gif; *.bmp;";
            ofd.Title = "Adding Person Image";
            ofd.RestoreDirectory = true;
            ofd.FilterIndex =3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                llblRemove.Visible = true;
                pbPersonImage.Load(ofd.FileName);
            }
            else
            {
                MessageBox.Show("Error Has occured while loading image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool _HandlePerosnImage()
        {
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException) { }
                }
            }
            if (pbPersonImage.ImageLocation != null)
            {
                string SourceImage = pbPersonImage.ImageLocation.ToString();
                if (clsManipulateImages.CopyImageToProjectImageFolder(ref SourceImage))
                {
                    pbPersonImage.ImageLocation = SourceImage;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;



            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Anonymous_Man;
            else
                pbPersonImage.Image = Resources.Anonymous_Woman;

            llblRemove.Visible = false;

        }

        private void frmAdd_Update_Load(object sender, EventArgs e)
        {

            _ResetDefualtValues();

            if (_Mode==enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
                if (!_HandlePerosnImage())
                    return;

                _Person.FirstName = mskFirstName.Text;
                _Person.SecondName = mskSecondName.Text;
                _Person.ThirdName = mskThirdName.Text;
                _Person.LastName = mskLastName.Text;
                _Person.NationalNumber = txtNationalNo.Text;

                if (!string.IsNullOrEmpty(txtEmail.Text))
                    _Person.Email = txtEmail.Text;
                else
                    _Person.Email = string.Empty;

                _Person.DateOFBirth = dtpBirth.Value;
                _Person.Phone = mskPhone.Text;
                if (rbFemail.Checked)
                    _Person.Gendor = (int)enGendor.Female;
                else
                    _Person.Gendor = (int)enGendor.Male;

                _Person.NationalCountryID = clsCountry.FindCountry(cmbCountries.Text).ID;

                _Person.Address = txtAddress.Text;

                if (pbPersonImage.ImageLocation != null)
                    _Person.ImagePath = pbPersonImage.ImageLocation;
                else
                    _Person.ImagePath = string.Empty;

                if (_Person.Save())
                {
                    MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblID.Text = _Person.PersonID.ToString();
                    _Mode = enMode.Update;
                    lblTitle.Text = "Update Person";
                    this.Text = lblTitle.Text;

                DataBack?.Invoke(this, _Person.PersonID);
                }
                else
                {
                    MessageBox.Show("Error Happend while saving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           


        private void ValidatebtnSave()
        {
            btnSave.Enabled = 
                   !string.IsNullOrEmpty(mskFirstName.Text) &&
                   !string.IsNullOrEmpty(mskSecondName.Text) &&
                   !string.IsNullOrEmpty(mskLastName.Text) &&
                   !string.IsNullOrEmpty(txtNationalNo.Text) &&
                   cmbCountries.SelectedIndex != -1 &&
                   !string.IsNullOrEmpty(txtAddress.Text) &&
                   !string.IsNullOrEmpty(mskPhone.Text);
        }
    }
}



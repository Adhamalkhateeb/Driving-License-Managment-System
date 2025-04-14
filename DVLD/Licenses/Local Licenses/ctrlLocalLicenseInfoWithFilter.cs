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
    public partial class ctrlLocalLicenseInfoWithFilter : UserControl
    {
        private int _LicenseID;
      
       

        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int licenseId)
        {
            OnLicenseSelected?.Invoke(licenseId);
        }


        public clsDriverLicense DriverLicense { get { return ctrlDriverLicenseInfo1.SelectedLicenseInfo; } }

        public int LicenseId { get { return ctrlDriverLicenseInfo1.LicenseID; } }

        public bool FilterEnabled { get { return gbFilter.Enabled; } set { { gbFilter.Enabled = value; } } }


        public ctrlLocalLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(int LicenseID )
        {
           
            txtFilter.Text = LicenseID.ToString();
            ctrlDriverLicenseInfo1.LoadLicenseInfo( LicenseID );
            _LicenseID = ctrlDriverLicenseInfo1.LicenseID;
         

            if (OnLicenseSelected != null && FilterEnabled)
            {
                OnLicenseSelected( _LicenseID );
            }

            
        }

        public void FilterFocus()
        {
            txtFilter.Focus();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }

            e.Handled =  !char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back);
        }

    

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text.Trim()))
            {
                MessageBox.Show("Please Enter license ID First to start Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFilter.Focus();
                return;
            }

           
            ctrlDriverLicenseInfo1.LoadLicenseInfo(int.Parse(txtFilter.Text.Trim()));

            _LicenseID = ctrlDriverLicenseInfo1.LicenseID ;

            if (OnLicenseSelected != null && FilterEnabled)
            {
                OnLicenseSelected(_LicenseID);
            }
        }


        
    }
}

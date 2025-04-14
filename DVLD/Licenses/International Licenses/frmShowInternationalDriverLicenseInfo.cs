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
    public partial class frmShowInternationalDriverLicenseInfo : Form
    {
        int _InternationalDriverLicenseId;
        public frmShowInternationalDriverLicenseInfo(int InternationalDriverLicenseID)
        {
            InitializeComponent();
            _InternationalDriverLicenseId = InternationalDriverLicenseID;
        }

        private void frmShowInternationalDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlInternationalLicenseInfo1.LoadInfo(_InternationalDriverLicenseId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

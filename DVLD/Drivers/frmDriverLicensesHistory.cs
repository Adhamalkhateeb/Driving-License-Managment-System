using DVLDBussinesLibary;
using PeopleBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmDriverLicensesHistory : Form
    {

        private int _personID = -1;
        public frmDriverLicensesHistory()
        {
            InitializeComponent();
        }

        public frmDriverLicensesHistory(int PersonID)
        {
            InitializeComponent();
           _personID = PersonID;
        }




        private void frmDriverLicensesHistory_Load(object sender, EventArgs e)
        {

            if (_personID != -1) 
            {
                ctrlPersonCardWithFilter1.LoadPersonInfo(_personID);
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                ctrlAllDriverLicenses1.LoadDriverLicenesByPersonID(_personID);
              
            }
            else{
                ctrlPersonCardWithFilter1.FilterEnabled  = true;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _personID = obj;

            if (_personID == -1)
            {
                ctrlAllDriverLicenses1.clear();
            }
            else
                ctrlAllDriverLicenses1.LoadDriverLicenesByPersonID(_personID);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

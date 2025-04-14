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
    public partial class ctrlPersonCardWithFilter : UserControl
    {

        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            OnPersonSelected?.Invoke(PersonID);
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson { get { return _ShowAddPerson; } set { _ShowAddPerson = value; btnAddNew.Visible = _ShowAddPerson; } }

        private bool _FilterEnabled = true;

        public bool FilterEnabled { get { return _FilterEnabled; } set { _FilterEnabled = value; gbFilter.Enabled = _FilterEnabled; } }

        public void FilterFocus()
        {
           txtFind.Focus();
        }
        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPerson; }

        }
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        public void LoadPersonInfo(int PersonID)
        {
            cbFliter.SelectedIndex = 0;
            txtFind.Text = PersonID.ToString();
            FindPerson();
        }
        private void FindPerson()
        {

            switch (cbFliter.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFind.Text));
                    ctrlPersonCard1.ShowUpdatePerson = true;
                    break;
                case "National Number":
                    ctrlPersonCard1.LoadPersonInfo(txtFind.Text);
                    ctrlPersonCard1.ShowUpdatePerson = true;
                    break;
                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
            {
                OnPersonSelected(ctrlPersonCard1.PersonID);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text))
            {
                MessageBox.Show("Some fileds are not valide!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FindPerson();
        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }

            if (cbFliter.SelectedIndex == 0)
                e.Handled = (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back));
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson frmAdd_Update = new frmAdd_UpdatePerson();

            frmAdd_Update.DataBack += FrmAdd_Update_DataBack;

            frmAdd_Update.ShowDialog();
        }

        private void FrmAdd_Update_DataBack(object sender, int PersonID)
        {
            cbFliter.SelectedIndex = 0;
            txtFind.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void cbFliter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFind.Text = string.Empty;
            txtFind.Focus();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFliter.SelectedIndex =0;
            txtFind.Focus();
        }

        private void gbPersonDetails_Enter(object sender, EventArgs e)
        {

        }

        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }
    }
}

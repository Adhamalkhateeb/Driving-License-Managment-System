using DVLDBussinesLayer;
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
    public partial class ctrlUserCard : UserControl
    {
        private int _userID = -1;
        private clsUser _user;
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public int UserID { get { return _userID; } }
        public clsUser SelectedUser { get { return _user; } }

        public void LoadUserInfo(int userID)
        {
           
            _userID = userID;
            _user = clsUser.FindByUserID(userID);

            if (_user == null)
            {
                ResetUserInfo();
                MessageBox.Show($"No User With ID Number {userID} is Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _FillUserInfo();


        }

        private void _FillUserInfo()
        {
            lblUserID.Text = _userID.ToString();
            lblUserName.Text = _user.UserName.ToString();
            if (_user.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
            ctrlPersonCard1.LoadPersonInfo(_user.PersonID);
        }
        public void ResetUserInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            lblUserID.Text = "N/A";
            lblUserName.Text = "[????]";
            lblIsActive.Text = "[????]";
            _userID = -1;
        }

        private void ctrlUserCard_Load(object sender, EventArgs e)
        {

        }
    }
}

using PeopleBusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DVLDBussinesLayer
{
    public class clsUser
    {
        private enum enMode { AddNew = 1, Update = 2 }
        public int UserID { get; set; }

        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public clsPerson Person { get; }

        private enMode _Mode = enMode.AddNew;

        public clsUser()
        {
            this.UserID = -1;
            this.UserName = this.Password = string.Empty;
            this.IsActive = false;
            this.Person = clsPerson.Find(PersonID);
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Person = clsPerson.Find(PersonID);
        }

        static public DataTable GetAllUsers()
        {
            return clsUserDataLayer.GetAllUsers();
        }

        static public clsUser FindByUserID(int UserID)
        {
            string UserName = "", Password = "";
            int PersonID = -1; bool IsActive = false;

            if (clsUserDataLayer.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        static public clsUser FindByPersonD(int PersonID)
        {
            string UserName = "", Password = "";
            int UserID = -1; bool IsActive = false;

            if (clsUserDataLayer.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive))
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {

            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;

            if (clsUserDataLayer.GetUserInfoByUserNameandPassword
                                (UserName, Password, ref PersonID, ref UserID, ref IsActive))
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        static public bool IsUserExistByUserID(int UserID)
        {
            return clsUserDataLayer.IsUserExistByUserID(UserID);
        }

        static public bool IsUserExistByPersonID(int PersonID)
        {
            return clsUserDataLayer.IsUserExistByPersonID(PersonID);
        }

        static public bool IsUserExistByUserName(string UserName)
        {
            return clsUserDataLayer.IsUserExistByUserName(UserName);
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserDataLayer.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return this.UserID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserDataLayer.UpdateUser(this.UserID, this.UserName, this.Password, this.IsActive);
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserDataLayer.DeleteUser(UserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateUser();
                default:
                    return false;

            }

        }

        public bool ChangeUserPassword()
        {
            return clsUserDataLayer.ChangePassword(this.UserID, this.Password);
        }


    }

}

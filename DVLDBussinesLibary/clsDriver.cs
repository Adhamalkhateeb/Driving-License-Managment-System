using DataLayer;
using PeopleBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinesLibary
{
    public class clsDriver
    {
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public clsDriver()
        {
            this.DriverID  = this.PersonID = this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;

            this._Mode = enMode.AddNew;
        }

        private clsDriver(int DriverID,int PersonID,int CreatedByUserID,DateTime CreatedDate)
        {
            this.DriverID =DriverID;
            this.PersonID =PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            _Mode = enMode.Update;
        }

        static public clsDriver FindByID(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriversData.GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }

        static public clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriversData.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }

        static public DataTable GetAllDrivers()
        {
            return clsDriversData.GetAllDrivers();
        }

        private bool _UpdateDriver()
        {
            return clsDriversData.UpdateDriverInfo(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriversData.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return this.DriverID != -1;
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateDriver();
                default:
                    return false;
            }
        }

        static public bool Delete(int DriverID)
        {
           return clsDriversData.DeleteDriver(DriverID);
        }

        public bool Delete()
        {
            return clsDriversData.DeleteDriver(this.DriverID);
        }

       
    }
}

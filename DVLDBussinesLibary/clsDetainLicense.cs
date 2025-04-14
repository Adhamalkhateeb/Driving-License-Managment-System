using DataLayer;
using DVLDBussinesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinesLibary
{
    public class clsDetainLicense
    {
        public enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode = enMode.AddNew;
        public int DetainID {  get; set; }
        public int LicenseID { get; set; }  
        public clsDriverLicense DetainLicenseInfo { get; set; }
        public DateTime DetainDate { get; set; }
        public float FineFees { get; set; }
        public bool IsReleased { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser _CreatedByUserInfo { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        public string Notes { get; set; }

        public clsDetainLicense()
        {

            LicenseID = CreatedByUserID = ReleasedByUserID = ReleaseApplicationID = -1;
            DetainDate = DateTime.Now;
            ReleasedDate = DateTime.MinValue;
            FineFees = 0.00f; 
            IsReleased = false;
            Notes  = string.Empty;

            _Mode = enMode.AddNew;
        }


        private clsDetainLicense(int DetainID,int LicenseID , DateTime DetainDate,float FineFees,bool IsReleased , int CreatedByUserID,DateTime ReleaseDate,
            int ReleasedByUserID,int ReleaseApplicationID,string Notes)
        {
            this.DetainID = DetainID;
            this.LicenseID =  LicenseID;
            this.CreatedByUserID = CreatedByUserID;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this.DetainDate =  DetainDate;
            this.ReleasedDate = ReleaseDate;
            this.FineFees = FineFees;
            this.IsReleased = IsReleased;
            this.Notes = Notes; 
            this._CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);

            _Mode = enMode.Update;
        }

        static public clsDetainLicense FindByDetainID(int DetainID)
        {
             
            int LicenseID = -1, ReleasedByUserID = -1, CreatedByUserID = -1 , ReleaseApplicationID  =1;
            DateTime DetainDate = DateTime.Now,  ReleaseDate = DateTime.Now; float FineFees = 0.00f;  bool IsReleased = false;
            string Notes = string.Empty;

            if (clsDetanedLicenseData.GetDetainedLicenseInfoByDetainID(DetainID , ref LicenseID, ref DetainDate, ref FineFees, ref IsReleased, ref CreatedByUserID,
                ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID,ref Notes))
                return new clsDetainLicense(DetainID, LicenseID, DetainDate, FineFees, IsReleased, CreatedByUserID, ReleaseDate, ReleasedByUserID, ReleaseApplicationID,Notes);
            else
                return null;
          
        }

        static public clsDetainLicense FindByLicenseID(int LicenseID)
        {

            int DetainID = -1, ReleasedByUserID = -1, CreatedByUserID = -1, ReleaseApplicationID = 1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.Now; float FineFees = 0.00f; bool IsReleased = false;
            string Notes = string.Empty;

            if (clsDetanedLicenseData.GetDetainedLicenseInfoByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFees, ref IsReleased, ref CreatedByUserID,
                ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID,ref Notes))
                return new clsDetainLicense(DetainID,LicenseID, DetainDate, FineFees, IsReleased, CreatedByUserID, ReleaseDate, ReleasedByUserID, ReleaseApplicationID,Notes);
            else
                return null;

        }

        static public DataTable GetAllDetainedLicense()
        {
            return clsDetanedLicenseData.GetAllDetainedLicenses();
        }

        private bool _UpdateDetainLicense()
        {
            return  clsDetanedLicenseData.UpdateDetainedLicense(this.DetainID,this.LicenseID,this.DetainDate,this.FineFees,this.IsReleased,this.CreatedByUserID,
                this.ReleasedDate,this.ReleasedByUserID,this.ReleaseApplicationID,this.Notes);
        }
        
        private bool _AddNewDatainLicense()
        {
            this.DetainID = clsDetanedLicenseData.AddNewDetainLicense(LicenseID,DetainDate,FineFees,this.IsReleased,this.CreatedByUserID,ReleasedDate,
                this.ReleasedByUserID,ReleaseApplicationID,this.Notes);

            return this.DetainID != -1;

        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewDatainLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                 case enMode.Update:
                    return _UpdateDetainLicense();
                default:
                    return false;
            }

        }

        static public bool DeleteDetainedLicense(int DetainID)
        {
            return clsDetanedLicenseData.DeleteDetainLicense(DetainID);
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetanedLicenseData.IsLicenseDetained(LicenseID);
        }

        public bool ReleaseDetainedLicense(int ReleasedByUserID, int ReleaseApplicationID)
        {
            return clsDetanedLicenseData.ReleaseDetainedLicense(this.DetainID,
                   ReleasedByUserID, ReleaseApplicationID);
        }

    }
}

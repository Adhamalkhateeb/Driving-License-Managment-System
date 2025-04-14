using DataLayer;
using DVLDBussinesLayer;
using PeopleBusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinesLibary
{
    public class clsApplication
    {
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 }
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode _Mode = enMode.AddNew;
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { set; get; }
        public clsPerson PersonInfo { get; set; }
        public string ApplicantFullName
        {
            get
            {
                return clsPerson.Find(ApplicantPersonID).FullName;
            }
        }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public int ApplicationTypeID { set; get; }

        public clsApplicationTypes ApplicationType;

        public string StatusText
        {
            get
            {

                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUser { get; set; }

        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;

            this._Mode = enMode.AddNew;

        }


        private clsApplication(int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID)

        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.PersonInfo = clsPerson.Find(ApplicantPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationType = clsApplicationTypes.Find(ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUser = clsUser.FindByUserID(CreatedByUserID);
            _Mode = enMode.Update;
        }


        static public clsApplication Find(int ApplicationID)
        {
            int PersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            byte applicationStatus = 0;
            float Paidfees = 0.00f;

            if (clsApplicationData.FindApplicationByID(ApplicationID, ref PersonID, ref ApplicationTypeID, ref CreatedByUserID,
                ref ApplicationDate, ref LastStatusDate, ref applicationStatus, ref Paidfees))
                return new clsApplication(ApplicationID, PersonID, ApplicationDate, ApplicationTypeID, (enApplicationStatus)applicationStatus, LastStatusDate,
                Paidfees, CreatedByUserID);
            else
                return null;
        }

        static public DataTable GetAllApplications()
        {
            return clsApplicationData.GetAllApplications();
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationTypeID, this.CreatedByUserID,
                this.ApplicationDate, this.LastStatusDate, (byte)this.ApplicationStatus, this.PaidFees);
            return (this.ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationType.ApplicationTypeID, this.CreatedByUser.UserID,
                this.ApplicationDate, this.LastStatusDate, (byte) this.ApplicationStatus, this.PaidFees);
        }

        public bool Delete()
        {
            return clsApplicationData.DeleteApplication(this.ApplicationID);
        }

        public bool Save()
        {
            switch(_Mode)
            { 
                case enMode.AddNew:
                if (_AddNewApplication())
                {
                    _Mode = enMode.Update;
                    return true;    
                }
                else
                {
                    return false;
                }
            case enMode.Update:
                return _UpdateApplication();
            default:
                return false;
            }

        }

        public bool Cancel()

        {
            return clsApplicationData.UpdateStatus(ApplicationID, 2);
        }

        public bool SetComplete()

        {
            return clsApplicationData.UpdateStatus(ApplicationID, 3);
        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            return clsApplicationData.IsApplicationExist(ApplicationID);
        }

        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID);
        }

        public bool DoesPersonHaveActiveApplication(int ApplicationTypeID)
        {
            return DoesPersonHaveActiveApplication(this.ApplicantPersonID, ApplicationTypeID);
        }

        public static int GetActiveApplicationID(int PersonID, enApplicationType ApplicationTypeID)
        {
            return clsApplicationData.GetActiveApplicationID(PersonID, (int) ApplicationTypeID);
        }

        public int GetActiveApplicationID(enApplicationType ApplicationTypeID)
        {
            return GetActiveApplicationID(this.ApplicantPersonID, ApplicationTypeID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);
        }

 

    }
}

using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDBussinesLibary
{
    public class clsDriverLicense
    {
        public enum enIssueReason { FirstTime = 1 , Renew = 2 , ReplacementForLostLicense = 3 , ReplacementForDamagedLicense = 4}
        public enum enMode { AddNew =1,Update =2}
        private enMode _Mode = enMode.AddNew;
        public int LicenseID { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo { get; set; }
        public int ApplicationID { get; set; }
        public byte LicenseClassID { get; set; }

        public clsLicenseClasses LicenseClassInfo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }

        public clsDetainLicense DetainedInfo { set; get; }

        public bool IsDetained
        {
            get { return clsDetainLicense.IsLicenseDetained(this.LicenseID); }
        }

        public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText(this.IssueReason);
            }
        }
        public int CreatedByUserID { get; set; }

        public clsDriverLicense()
        {
            LicenseID = ApplicationID = DriverID = CreatedByUserID = -1;
            LicenseClassID = 0;
            IssueReason = enIssueReason.FirstTime;
            IssueDate = ExpirationDate = DateTime.Now;
            PaidFees = 0.00f;
            IsActive = false;
            Notes = string.Empty;

            _Mode = enMode.AddNew;
        }

        private clsDriverLicense(int licenseID, int driverID, int applicationID, byte licenseClassID, DateTime issueDate, 
            string notes, bool isActive, enIssueReason issueReason, int createdByUserID,DateTime ExpirationDate)
        {
            LicenseID=licenseID;
            DriverID=driverID;
            DriverInfo = clsDriver.FindByID(driverID);
            ApplicationID=applicationID;
            LicenseClassID=licenseClassID;
            LicenseClassInfo = clsLicenseClasses.Find(licenseClassID);
            IssueDate=issueDate;
            this.ExpirationDate = ExpirationDate;
            Notes=notes;
            PaidFees = LicenseClassInfo.ClassFees;
            IsActive=isActive;
            IssueReason=issueReason;
            CreatedByUserID=createdByUserID;
            this.DetainedInfo = clsDetainLicense.FindByLicenseID(this.LicenseID);

            _Mode = enMode.Update;
        }

        static public clsDriverLicense FindLicense(int DriverLicenseID)
        {
            int DriverID = -1,ApplicationID = -1,CreatedByUserID = -1;  string Notes = string.Empty;
            byte LicenseClassID = 0, IssuReason = 0;  float PaidFees = 0f;  bool IsActive = false;
            DateTime IssueDate = DateTime.Now , ExpirationDate = DateTime.Now;

            if (clsDriverLicenseData.FindLicenseByID(DriverLicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID,
                ref IssueDate, ref Notes, ref IsActive, ref IssuReason, ref CreatedByUserID,ref ExpirationDate))
                return new clsDriverLicense(DriverLicenseID, DriverID, ApplicationID, LicenseClassID, IssueDate,
                    Notes, IsActive, (enIssueReason)IssuReason, CreatedByUserID,ExpirationDate);
            else
                return null;

        }

        static public DataTable GetAllLicense()
        {
            return clsDriverLicenseData.GetAllLicense();
        }

        static public bool DeleteLicense(int DrivingLicenseID)
        {
            return clsDriverLicenseData.DeleteLicense(DrivingLicenseID);
        }

        private bool _UpdateDrivingLicense()
        {
            return clsDriverLicenseData.UpdateLicense(this.LicenseID, this.LicenseClassID, this.Notes, this.ExpirationDate,
                this.PaidFees, this.IsActive, (byte)this.IssueReason);
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsDriverLicenseData.AddLicense(this.ApplicationID,this.DriverID,this.LicenseClassID,this.IssueDate,
                this.ExpirationDate,this.Notes,this.PaidFees,this.IsActive,(byte)this.IssueReason,this.CreatedByUserID);

            return this.LicenseID != -1;
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }else
                        return false;
                case enMode.Update:
                     return _UpdateDrivingLicense();
                default:
                    return false;
            }
        }

        public static bool IsLicenseExistByPersonID(int PersonID, int LicenseClassID)
        {
            return (GetActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1);
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {

            return clsDriverLicenseData.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);

        }
        static public DataTable GetAllDriverLicense(int DriverID)
        {
            return clsDriverLicenseData.GetAllDriverLicense(DriverID);
        }

        static public DataTable GetAllInternationalLicense(int DriverID)
        {
            return clsInternationalLicense.GetDriverInternationalLicenses(DriverID);
        }

        public bool IsLicenseExpired()
        {
            return (this.ExpirationDate < DateTime.Now);
        }

        public bool DeactivateLicense()
        {
            return clsDriverLicenseData.DeactivateLicense(this.LicenseID);
        }

        private static  string GetIssueReasonText(enIssueReason IssueReason)
        {

            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.ReplacementForLostLicense:
                    return "Replacement for Damaged";
                case enIssueReason.ReplacementForDamagedLicense:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        }

        public clsDriverLicense RenwewLicense(string Notes, int CreatedByUserID)
        {
            clsApplication application = new clsApplication();

            application.ApplicantPersonID = this.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationTypeID = (int)clsApplication.enApplicationType.RenewDrivingLicense;
            application.PaidFees = clsApplicationTypes.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).Fees;
            application.CreatedByUserID = CreatedByUserID;


            if (!application.Save())
            {
                return null;

            }
            clsDriverLicense NewLicense = new clsDriverLicense();

            NewLicense.ApplicationID = application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;


            NewLicense.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = this.LicenseClassInfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = clsDriverLicense.enIssueReason.Renew;
            NewLicense.CreatedByUserID = CreatedByUserID;
            NewLicense.DriverInfo = this.DriverInfo;
            NewLicense.LicenseClassInfo = this.LicenseClassInfo;
           

            if (!NewLicense.Save())
            {
                return null;
            }

            DeactivateLicense();
            return NewLicense;

        }

        public clsDriverLicense Replace(enIssueReason issueReason,string Notes,int CreatedByUserID)
        {
            clsApplication application = new clsApplication();

            application.ApplicantPersonID = this.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationTypeID = (IssueReason == enIssueReason.ReplacementForDamagedLicense) ?
                     (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense :
                     (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;

            application.PaidFees = clsApplicationTypes.Find(application.ApplicationTypeID).Fees;
            application.CreatedByUserID = CreatedByUserID;

            if (!application.Save())
            {
                return null;

            }
            clsDriverLicense NewLicense = new clsDriverLicense();

            NewLicense.ApplicationID = application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;


            NewLicense.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = 0;
            NewLicense.IsActive = true;
            NewLicense.IssueReason  = issueReason;
            NewLicense.CreatedByUserID = CreatedByUserID;
            NewLicense.DriverInfo = this.DriverInfo;
            NewLicense.LicenseClassInfo = this.LicenseClassInfo;


            if (!NewLicense.Save())
            {
                return null;
            }

            DeactivateLicense();

            return NewLicense;

        }

       
        public int Detain(float FineFees, int CreatedByUserID,string Notes)
        {
            clsDetainLicense DetainLicense = new clsDetainLicense();

            DetainLicense.LicenseID = this.LicenseID;
            DetainLicense.DetainDate = DateTime.Now;
            DetainLicense.FineFees = FineFees;
            DetainLicense.IsReleased = false;
            DetainLicense.CreatedByUserID = CreatedByUserID ;
            DetainLicense.Notes = Notes;

            if(DetainLicense.Save())
                return DetainLicense.DetainID;
            else
                return -1;                     
        }
        public bool ReleaseDetainLicense(int ReleasedByUserID,ref int ApplicationID)
        {
            clsApplication application = new clsApplication();

            application.ApplicantPersonID = this.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            application.ApplicationTypeID = (int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense;
            application.PaidFees = clsApplicationTypes.Find(application.ApplicationTypeID).Fees;
            application.CreatedByUserID = ReleasedByUserID;

            if (!application.Save())
            {
                ApplicationID = -1;
                return false;
            }

            ApplicationID = application.ApplicationID;

            return this.DetainedInfo.ReleaseDetainedLicense(ReleasedByUserID, ApplicationID);
        }
    }
}

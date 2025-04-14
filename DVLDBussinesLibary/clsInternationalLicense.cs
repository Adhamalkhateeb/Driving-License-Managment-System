using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinesLibary
{
    public class clsInternationalLicense : clsApplication
    {
        public enum enMode { AddNew  =1 , Update = 2}
        private enMode _Mode = enMode.AddNew;

        public clsDriver DriverInfo;
        public int InternationalLicenseID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }

        public clsInternationalLicense() {

            base.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalLicense;

            IssuedUsingLocalLicenseID = InternationalLicenseID  = DriverID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now.AddYears(1);
            IsActive = true;
            base.ApplicationStatus = enApplicationStatus.Completed;

            _Mode = enMode.AddNew;
        }

        private clsInternationalLicense(int ApplicationID, int ApplicantPersonID,  DateTime ApplicationDate,  enApplicationStatus ApplicationStatus,
            DateTime LastStatusDate,  float PaidFees, int CreatedByUserID,  int InternationalLicenseID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive)
        {
            base.ApplicationID = ApplicationID;
            base.ApplicantPersonID = ApplicantPersonID;
            base.ApplicationDate = ApplicationDate;
            base.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalLicense;
            base.ApplicationStatus = ApplicationStatus;
            base.LastStatusDate = LastStatusDate;
            base.PaidFees = PaidFees;
            base.CreatedByUserID = CreatedByUserID;

            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID=ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            this.DriverInfo = clsDriver.FindByID(this.DriverID);

            _Mode = enMode.Update;

        }

       static public clsInternationalLicense Find(int InternationalLicenseID)
        {
            int applicationId = -1, driverId = -1, issuedUsingLocalLicenseId = -1, createdByUserId = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            bool isActive = false;

            if (clsInternationalLicenseData.FindLicense(InternationalLicenseID, ref applicationId, ref driverId, ref issuedUsingLocalLicenseId, ref issueDate, ref expirationDate, ref isActive, ref createdByUserId))
            {
                clsApplication Application = clsApplication.Find(applicationId);

                    return new clsInternationalLicense(applicationId,Application.ApplicantPersonID,Application.ApplicationDate,Application.ApplicationStatus,
                        Application.LastStatusDate,Application.PaidFees, createdByUserId, InternationalLicenseID,driverId,issuedUsingLocalLicenseId,
                        issueDate,expirationDate,isActive);
            }
            else
                return null;
          
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllLicenses();
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseData.UpdateLicense(this.InternationalLicenseID, this.ApplicationID,
                this.DriverID, this.IssuedUsingLocalLicenseID, this.ApplicationDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddInternationalLicense(this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.ApplicationDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }

        public bool Save()
        {
            base._Mode = (clsApplication.enMode)_Mode;

            if (!base.Save())
                return false;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateInternationalLicense();

                default:
                    return false;
            }
        }

        public bool Delete()
        {
            if (clsInternationalLicenseData.DeleteLicense(this.InternationalLicenseID))
                return base.Delete();
            else
                return false;
        }

        public static int GetActiveLInternationalLicenseByDriverID(int DriverID)
        {
            return clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(DriverID);
        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicenseData.GetAllDriverLicenses(DriverID);
        }


    }
}

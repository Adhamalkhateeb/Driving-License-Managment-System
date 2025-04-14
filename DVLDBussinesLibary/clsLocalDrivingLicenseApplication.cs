using DataLayer;
using DVLDBussinesLayer;
using PeopleBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinesLibary
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode Mode = enMode.AddNew;
        public int LocalDrivingLicenseAppID { get; set; }
        public int LicenseClassID { get; set; }
        public clsLicenseClasses LicenseClass { get; set; }
      
        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseAppID = -1;
            this.LicenseClassID = -1;


            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseAppID, int ApplicationID, int ApplicantPersonID,DateTime ApplicationDate,
            int ApplicationTypeID,enApplicationStatus ApplicationStatus ,DateTime LasrStatusDate,float PaidFess ,int CreatedByUserID,int LicenseClassID,
            clsUser CreatedBy,clsPerson PersonInfo)
        {
            this.LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LasrStatusDate;
            this.PaidFees = PaidFess;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            this.CreatedByUser = CreatedBy;
            this.PersonInfo = PersonInfo;



            this.LicenseClass = clsLicenseClasses.Find(LicenseClassID);
            

            
            Mode = enMode.Update;
        }

        static public DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationData.RetrieveAllLocalDrivingLicenseApplications();
        }

        static public clsLocalDrivingLicenseApplication FindByLocalDrivingLicenseID(int LocalDrivingLicenseAppID)
        {
            int ApplicationID = -1, LicenseClassID = -1;
            if (clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByLDL_AppID(LocalDrivingLicenseAppID, ref ApplicationID, ref LicenseClassID))
            {
                clsApplication application = clsApplication.Find(ApplicationID);
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseAppID,ApplicationID,application.ApplicantPersonID,
                    application.ApplicationDate,application.ApplicationTypeID,application.ApplicationStatus,application.LastStatusDate
                    ,application.PaidFees,application.CreatedByUserID, LicenseClassID,application.CreatedByUser,application.PersonInfo);
            }
            else
                return null;
        }

        public static clsLocalDrivingLicenseApplication FindByApplicationID(int ApplicationID)
        {
            
            int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByLDL_AppID
                (ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                clsApplication Application = clsApplication.Find(ApplicationID);

                
                return new clsLocalDrivingLicenseApplication(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                                     Application.ApplicationDate, Application.ApplicationTypeID,
                                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                     Application.PaidFees, Application.CreatedByUserID, LicenseClassID,Application.CreatedByUser,Application.PersonInfo);
            }
            else
                return null;


        }

        private bool _UpdateLocalDrivingApplication()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivngLicenseApplication(this.LocalDrivingLicenseAppID, 
               ApplicationID, this.LicenseClass.LicenseClassID);
        }

        private bool _AddNewLocalDrivingApplication()
        {
            this.LocalDrivingLicenseAppID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseAppID != -1);
        }
        public bool Save()
        {
            base._Mode = (clsApplication.enMode) Mode;

            if (!base.Save())
                return false;
            switch (Mode)
            { 
                case enMode.AddNew:                   
                        if (_AddNewLocalDrivingApplication())
                       {
                         Mode = enMode.Update;
                         return true;
                       }
                       else
                         return false;
                      
                case enMode.Update:
                    return _UpdateLocalDrivingApplication();
                default:
                    return false;
            }


        }

        public  bool Delete()
        {

            if (clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseAppID))
                return base.Delete();
            else
                return false;


        }

        static public bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public bool IsThereAnActiveScheduledTest(int TestTypeID)
        {

            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(this.LocalDrivingLicenseAppID, TestTypeID);
        }

        public static bool AttendedTest(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.GetNumberOfTrialsForTest(LocalDrivingLicenseApplicationID, TestTypeID) > 0;
        }

        public bool AttendedTest(int TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.GetNumberOfTrialsForTest(this.LocalDrivingLicenseAppID,TestTypeID) > 0;
        }
        public byte TotalTrialsPerTest(int TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.GetNumberOfTrialsForTest(this.LocalDrivingLicenseAppID, TestTypeID);
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.GetNumberOfTrialsForTest(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public bool DoesPassTest(int TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.IsTestPassedBefore(this.LocalDrivingLicenseAppID, TestTypeID);
        }

        public static bool DoesPassTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.IsTestPassedBefore(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public bool DoesAttendTest(int TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.DoesAttendTest(this.LocalDrivingLicenseAppID, TestTypeID);
        }

        public bool DoesPassPreviousTest(clsTestTypes.enTestType CurrentTestType)
        {

            switch (CurrentTestType)
            {
                case clsTestTypes.enTestType.VisionTest:

                    return true;

                case clsTestTypes.enTestType.WrittenTest:

                    return this.DoesPassTest((int)clsTestTypes.enTestType.VisionTest);

                case clsTestTypes.enTestType.PracticalTest:

                    return this.DoesPassTest((int)clsTestTypes.enTestType.PracticalTest);

                default:
                    return false;
            }
        }

        public byte GetPassedTestCount()
        {
            return clsTest.GetPassedTestCount(this.LocalDrivingLicenseAppID);
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTest.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

        public bool PassedAllTests()
        {
            return clsTest.DoesPassedAllTests(this.LocalDrivingLicenseAppID);
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            return clsTest.DoesPassedAllTests(LocalDrivingLicenseApplicationID);
        }

        public int IssueLicenseForTheFirtTime(string Notes, int CreatedByUserID)
        {
            int DriverID = -1;
            
            clsDriver Driver = clsDriver.FindByPersonID(this.ApplicantPersonID);

            if (Driver == null)
            {
                Driver = new clsDriver();

                Driver.PersonID= this.ApplicantPersonID;
                Driver.CreatedByUserID = CreatedByUserID;

                if (Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID= Driver.DriverID;
            }

            clsDriverLicense License = new clsDriverLicense();
            License.ApplicationID = this.ApplicationID;
            License.DriverID= DriverID;
            License.LicenseClassID = (byte)this.LicenseClassID;
            License.IssueDate=DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(this.LicenseClass.DefaultValidityLength);
            License.Notes = Notes;
            License.PaidFees = this.LicenseClass.ClassFees;
            License.IsActive= true;
            License.IssueReason = clsDriverLicense.enIssueReason.FirstTime;
            License.CreatedByUserID= CreatedByUserID;

            if (License.Save())
            {
                this.SetComplete();

                return License.LicenseID;
            }

            else
                return -1;
        }

        public bool IsLicenseIssued()
        {
            return (GetActiveLicenseID() !=-1);
        }

        public int GetActiveLicenseID()
        {
            return clsDriverLicense.GetActiveLicenseIDByPersonID(this.ApplicantPersonID, this.LicenseClassID);
        }
    }
}

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
    public class clsTestAppointments
    {
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public clsTestTypes TestTypeInfo { get; set; }
        public int TestID
        {
            get { return _GetTestID(); }

        }
        public int LocalDrivingLicensesID { get; set; }
        public clsLocalDrivingLicenseApplication localDrivingLicenseApplicationInfo { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public clsApplication RetakeTestApplication { get; set; }


        public clsTestAppointments()
        {
            this.TestAppointmentID = this.TestTypeID = this.LocalDrivingLicensesID = this.CreatedByUserID = this.RetakeTestApplicationID = -1;
            this.PaidFees = 0.0f;
            this.IsLocked = false;
            this.AppointmentDate = DateTime.Now;

        }

        private clsTestAppointments(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, int CreatedByUserID,
            float PaidFees, bool IsLocked, int RetakTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.TestTypeInfo = clsTestTypes.Find(TestTypeID);
            this.LocalDrivingLicensesID = LocalDrivingLicenseApplicationID;
            this.localDrivingLicenseApplicationInfo = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseID(LocalDrivingLicenseApplicationID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
            this.PaidFees = PaidFees;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakTestApplicationID;
            if(RetakTestApplicationID != -1) 
                RetakeTestApplication = clsApplication.Find(RetakTestApplicationID);

            this.AppointmentDate = AppointmentDate;


            _Mode = enMode.Update;
        }

        static public DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentsData.GetAllTestAppointments();
        }

        static public DataTable GetAllTestAppointmentByLocalDrivingLicenseAppAndTestTypeID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsData.GetAllTestAppointmentForLocalDrivingLicense(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public DataTable GetAllTestAppointmentByLocalDrivingLicenseAppAndTestTypeID(int TestTypeID)
        {
            return clsTestAppointmentsData.GetAllTestAppointmentForLocalDrivingLicense(this.LocalDrivingLicensesID, TestTypeID);
        }

        static public clsTestAppointments FindByTestAppointmentID(int TestAppointmentID)
        {
            int TestTypeID = -1, LocalDrivingLicenseApplicationID = -1, CreatedByUserID = -1, RetakeTestApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = 0.0f;
            bool IsLocked = false;
            if (clsTestAppointmentsData.GetTestAppointmentInfoByTestAppointmentID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref CreatedByUserID, ref PaidFees, ref IsLocked, ref RetakeTestApplicationID))
                return new clsTestAppointments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, CreatedByUserID, PaidFees, IsLocked, RetakeTestApplicationID);
            else
                return null;
        }

        static public clsTestAppointments FindLastTestAppointment(int LocalDrivingApplicationID,int TypeID)
        {
            int  CreatedByUserID = -1, RetakeTestApplicationID = -1,TestAppointmentID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = 0.0f;
            bool IsLocked = false;

            if (clsTestAppointmentsData.GetLastTestAppointment(LocalDrivingApplicationID, TypeID, ref TestAppointmentID, ref AppointmentDate
                , ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
                return new clsTestAppointments(TestAppointmentID, TypeID, LocalDrivingApplicationID, AppointmentDate, CreatedByUserID, PaidFees
                    , IsLocked, RetakeTestApplicationID);
            else
                return null;
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentsData.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicensesID, this.AppointmentDate, this.CreatedByUserID, this.PaidFees, this.IsLocked, this.RetakeTestApplicationID);
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentsData.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicensesID, this.AppointmentDate, this.CreatedByUserID, this.PaidFees, this.IsLocked, this.RetakeTestApplicationID);
            return this.TestAppointmentID != -1;
        }

        public bool DeleteTestAppointment()
        {
            return clsTestAppointmentsData.DeleteTestAppointment(this.TestAppointmentID);
        }

        public bool Save()
        {
            switch (_Mode)
            {

                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateTestAppointment();
                default:
                    return false;

            }

        }

        private int _GetTestID()
        {
            return clsTestAppointmentsData.GetTestID(this.TestAppointmentID);
        }
    }
}

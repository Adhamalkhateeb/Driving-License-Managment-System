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
    public class clsTest
    {
        public enum enMode { AddNew = 1 , Update =2}

        private enMode _Mode = enMode.AddNew;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public clsTestAppointments TestAppointmentinfo {  get; set; }
        public bool PassedTest { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTest()
        {
            TestID = TestAppointmentID = CreatedByUserID = -1;
            this.Notes = string.Empty;
            PassedTest = false;

            _Mode = enMode.AddNew;
        }

        private clsTest(int TestID,int TestAppointmentID,int CreatedByUserID,bool PassedTest,string Notes)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestAppointmentinfo = clsTestAppointments.FindByTestAppointmentID(TestAppointmentID);
            this.CreatedByUserID = CreatedByUserID;
            this.Notes = Notes;
            this.PassedTest = PassedTest;

            _Mode= enMode.Update;

        }

        static public clsTest FindTestByTestID(int TestID)
        {
            int TestAppointmentID= -1,CreatedByUSerID = -1;
            bool PassedTest = false; string Notes = string.Empty;

            if (clsTestData.GetTestInfoByID(TestID, ref TestAppointmentID, ref CreatedByUSerID, ref PassedTest, ref Notes))
                return new clsTest(TestID, TestAppointmentID, CreatedByUSerID, PassedTest, Notes);
            else
                return null;
        }

        static public DataTable GetAllTests() { return clsTestData.GetAllTests(); }

        private bool _AddNewTest()
        {
            this.TestID = clsTestData.AddNewTest(this.TestAppointmentID,this.CreatedByUserID,this.PassedTest,this.Notes);

            return this.TestID != -1;
        }

        private bool _UpdateTest()
        {
            return clsTestData.UpdateTestInfo(this.TestID,this.TestAppointmentID,this.CreatedByUserID, this.PassedTest,this.Notes);
        }

        public bool DeleteTest()
        {
            return clsTestData.DeleteTest(this.TestID);

        }

         public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewTest())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return _UpdateTest();
                default:
                    return false;

            }    
        }

        static public byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTestData.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

        static public bool DoesPassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            return clsTestData.GetPassedTestCount(LocalDrivingLicenseApplicationID) == 3;
        }

        
    }
}

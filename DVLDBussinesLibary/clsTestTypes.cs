using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinesLibary
{
    public class clsTestTypes
    {
        public enum enTestType { VisionTest = 1 , WrittenTest , PracticalTest  }
        private enum enMode { AddNew =1, Update =2}
        public int TestID { get; set; }
        public string TestTitle { get; set; }
        public string TestDescription { get; set; }
        public float TestFees { get; set; }

         private enMode _Mode = enMode.AddNew;

        public clsTestTypes()
        {
            TestID = -1;
            TestTitle = TestDescription = string.Empty;
            TestFees = 0.0f;
            _Mode = enMode.AddNew;

        }

        private clsTestTypes(int TestID,string TestTitle,string TestDescription,float TestFees)
        {
            this.TestID = TestID;
            this.TestTitle = TestTitle;
            this.TestDescription = TestDescription;
            this.TestFees = TestFees;
            _Mode = enMode.Update;
        }

        static public DataTable GetAllTestTypes()
        {
            return clsTestTypesData.GetAllTestTypes();
        }

        static public clsTestTypes Find(int TestID)
        {
            string TestTitle = "", TestDescription = "";
            float TestFees = 0.0f;
            if (clsTestTypesData.GetTestTypeInfo(TestID, ref TestTitle, ref TestDescription, ref TestFees))
                return new clsTestTypes(TestID, TestTitle, TestDescription, TestFees);
            else
                return null;
        }

        private bool _UpdateTestInfo()
        {
            return clsTestTypesData.UpdateTestInfo(this.TestID, this.TestTitle, this.TestDescription, this.TestFees);
        }

        private bool _AddNewTestType()
        {
            this.TestID = clsTestTypesData.AddNewTestType(this.TestTitle, this.TestDescription, this.TestFees);

            return this.TestID != -1;
        }

        public bool Save()
        {
            switch(_Mode)
                {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateTestInfo();
                default:
                    return false;


            }
        }


    }
}

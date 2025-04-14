using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsLicenseClasses
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public float ClassFees { get; set; }

        public clsLicenseClasses()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.Description = "";
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = 0.0f;

            _Mode = enMode.AddNew;
        }

        private clsLicenseClasses(int LicenseClassID, string ClassName, string Description, byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.Description = Description;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            _Mode = enMode.Update;
        }

        static public clsLicenseClasses Find(int LicenseClassID)
        {
            string ClassName = "", Description = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            float ClassFees = 0.0f;
            if (clsLicenseClassesData.GetLicenseClassInfo(LicenseClassID, ref ClassName, ref Description, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
                return new clsLicenseClasses(LicenseClassID, ClassName, Description, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }

        static public clsLicenseClasses Find(string LicenseClassName)
        {
            int LicenseClassID = -1;  string  Description = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            float ClassFees = 0.0f;
            if (clsLicenseClassesData.GetLicenseClassInfo(LicenseClassName, ref LicenseClassID, ref Description, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
                return new clsLicenseClasses(LicenseClassID, LicenseClassName, Description, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }

        static public DataTable GetAllClasses()
        {
            return clsLicenseClassesData.GetAllClasses();
        }   

        private bool _UpdateClass()
        {
            return clsLicenseClassesData.UpdateClassInfo(this.LicenseClassID, this.ClassName, this.Description, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }

        private bool _AddNewClass()
        {
            this.LicenseClassID = clsLicenseClassesData.AddNewClass(this.ClassName, this.Description, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);

            return this.LicenseClassID != -1;
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClass())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateClass();
                default:
                    return false;
            }

        }
    }
}

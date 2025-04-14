using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinesLibary
{
    public class clsApplicationTypes
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public float Fees { get; set; }


        public clsApplicationTypes()

        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = "";
            this.Fees = 0f;

        }
        private clsApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle,float Fees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.Fees = Fees; 
        }

        static public clsApplicationTypes Find(int ApplicationTypeID)
        {
            string ApplicationTitle = ""; float ApplicationFees = -1;

            if (clsApplicationTypesData.GetApplicationTypeInfo(ApplicationTypeID, ref ApplicationTitle, ref ApplicationFees))
                return  new clsApplicationTypes(ApplicationTypeID, ApplicationTitle, ApplicationFees);
            else
                return null;
        }
        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesData.GetAllApplicationsTypes();
        }

       public  bool UpdateApplication()
        {
            return clsApplicationTypesData.UpdateApplicationTypeInfo(this.ApplicationTypeID, this.ApplicationTypeTitle, this.Fees);
    
        }
    }
}



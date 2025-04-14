using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace CountriesBussinessLayer
{

    public class clsCountry
    {
        public int ID { get; set; }
        public string CountryName { get; set; }


       public clsCountry()
        {
            ID = -1;
            CountryName = string.Empty;
        }

        private clsCountry(int iD, string countryName)
        {
            this.ID=iD;
            this.CountryName=countryName;
        }

        static public DataTable GetAllCountries()
        {
            return clsCountriesDataLayer.GetAllCountries();
        }

        static public clsCountry FindCountry(int CountryID)
        {
            string countryName = string.Empty;
            if (clsCountriesDataLayer.FindCountry(CountryID, ref countryName))
                return new clsCountry(CountryID, countryName);
            else
                return null;
           
        }

        static public clsCountry FindCountry(string CountryName)
        {
            int CountryID = -1;
            if (clsCountriesDataLayer.FindCountry(CountryName,ref CountryID))
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }
    }
}

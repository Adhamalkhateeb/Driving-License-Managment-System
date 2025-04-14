using System.Data;
using System.Runtime.CompilerServices;
using CountriesBussinessLayer;
using DataLayer;
using Microsoft.Identity.Client;

namespace PeopleBusinessLayer
{
    public class clsPerson
    {
       private enum enMode { AddNew = 1, Update = 2 };
        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        public DateTime DateOFBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalCountryID { get; set; }

        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        private enMode _Mode = enMode.AddNew;
        public clsCountry Country { get; set; }
        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNumber = this.FirstName = this.SecondName = this.ThirdName = this.LastName = this.Address
                = this.Phone = this.Email = this.ImagePath = string.Empty;
            this.DateOFBirth = DateTime.Now;
            this.NationalCountryID = -1;
            this.Gendor = 0;
        }

        private clsPerson(int ID,string NationalNumber,string FirstName,string SecondName,string ThirdName,string lastName,DateTime DateOfBirth,byte Gendor,
            string Address,string Phone,string Email,int NationalCountryID,string ImagePath)
        {
            this.PersonID =ID;
            this.NationalNumber = NationalNumber;
            this.FirstName =FirstName;
            this.SecondName=SecondName;
            this.ThirdName =ThirdName;
            this.LastName = lastName;
            this.DateOFBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone =    Phone;
            this.Email = Email;
            this.NationalCountryID =NationalCountryID;
            this.ImagePath = ImagePath;
            this.Country = clsCountry.FindCountry(NationalCountryID);

            this._Mode = enMode.Update;
        }

        public static clsPerson Find(int ID)
        {
            string FirstName = "", secondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "", NationalNumber = "";
            byte Gendor = 0; DateTime DateOfBirth = DateTime.Now; int CountryID = -1;

            if (clsPeopleDataLayer.GetPersonInfoByID(ID, ref NationalNumber,ref FirstName, ref secondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address ,
                ref Phone, ref Email, ref CountryID, ref ImagePath))
                return new clsPerson(ID,NationalNumber, FirstName, secondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryID, ImagePath);
            else
                return null;
      
        }

        public static clsPerson Find(string NationalNo)
        {
            string FirstName = "", secondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            byte Gendor = 0; DateTime DateOfBirth = DateTime.Now; int CountryID = -1; int PersonID = -1;

            if (clsPeopleDataLayer.GetPersonInfoByNationalNo(NationalNo,ref PersonID, ref FirstName, ref secondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address,
                ref Phone, ref Email, ref CountryID, ref ImagePath))
                return new clsPerson(PersonID, NationalNo, FirstName, secondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryID, ImagePath);
            else
                return null;

        }

        static public DataTable GetAllPeople()
        {
            return clsPeopleDataLayer.GetAllPeople();
        }

        static public bool IsPersonExist(string NationalNo)
        {
            return clsPeopleDataLayer.IsPersonExist(NationalNo);
        }

        static public bool IsPersonExist(int PersonID)
        {
            return clsPeopleDataLayer.IsPersonExist(PersonID);
        }

        private bool _AddNewPerson()
        {
             this.PersonID = clsPeopleDataLayer.AddNewPerson(this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName
                , this.LastName, this.DateOFBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalCountryID, this.ImagePath);
            return this.PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return (clsPeopleDataLayer.UpdatePerson(this.PersonID, this.NationalNumber, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.DateOFBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalCountryID,
                this.ImagePath));
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleDataLayer.DeletePerson(PersonID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                      this._Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdatePerson();

            }

            return false;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessDataLayer;

namespace BussnisLayer
{
    public class clsPerson
    {
       
        public enum enStutes { AddNew , Update}
        public enStutes Stutes = enStutes.AddNew;

        #region Ctors 
        // ctor for update
        private clsPerson
         (int PersonID , string firstName, string secondName, string thirdName, string lastName,
            string email, string address, string gender, string phone,
            string imagePath, string nationalNom, int nationalityCountryID, DateTime dateOfBirth)
        {
            this.Stutes = enStutes.Update;
            this.ID = PersonID;
            this.NationalNom = nationalNom;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
           // this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;
            this.CountryInfo = clsCountry.Find(nationalityCountryID);
        }

        // ctor for AddNew new   
        public clsPerson()
        {
            this.Stutes = enStutes.AddNew;
            this.ID =    -1;
            this.NationalNom = "";
            this.FirstName =   "";
            this.SecondName =  "";
            this.ThirdName =   ""; 
            this.LastName =    "";
            this.DateOfBirth = DateTime.Now.AddYears(-18);
            this.Gender = "";
            this.Address = "";
            this.Phone = "";
            this.Email = "";
         //   this.NationalityCountryID = -1;
            this.ImagePath = "";
            this.CountryInfo = null;

        }

#endregion

        #region Person properties
        public int ID { get; set; }
       public string NationalNom { get; set; }
       public string FirstName  { get; set; }
       public string SecondName { get; set; }
       public string ThirdName  { get; set; }
       public string LastName { get; set; }
       public DateTime DateOfBirth { get; set; }
       public string Gender { get; set; }
       public string Address { get; set; }
       public string Phone { get; set; }
       public string Email { get; set; }
     //  public int NationalityCountryID { get; set; }   
       public string ImagePath { get; set; }
        public string FullName { 
        get
            {
                return this.FirstName + ' ' + this.SecondName + ' ' + this.ThirdName + ' ' + this.LastName;
            }
        }
        public clsCountry CountryInfo= null;
        #endregion


        private bool SaveRecINDB()
        {
            this.ID = AD_People.SaveRec(this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.Email, this.Address, this.Gender, this.Phone, this.ImagePath, this.NationalNom,
                this.CountryInfo.ID, this.DateOfBirth);

            return this.ID != -1;
        }

        private bool UpdateRec()
        {
            return AD_People.UpdateRec(this.ID  , this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.Email, this.Address, this.Gender, this.Phone, this.ImagePath, this.NationalNom,
                this.CountryInfo.ID, this.DateOfBirth);
        }
        public bool Save()
        {

            if (this.Stutes == enStutes.AddNew)
            {
                if (SaveRecINDB())
                {
                    this.Stutes = enStutes.Update;
                    return true;
                }
                return false;

            }

            else
            {
                return UpdateRec();
                   
            }
            return false;


        }

        public int MakeHimDriver()
        {
            if (! clsPerson.IsDriver(this.ID))
              return AD_Drivers.AddNewDriver(this.ID , clsGlobalUser.GlobalUser.ID, DateTime.Now);

            return -1;
        }

        public int HisIdAsDriver()
        {
            return AD_Drivers.GetDriverID(this.ID);
        }

        #region Static Methods

        public static DataTable GetAllPeople()
        {
           return AD_People.GetAllPeople();
          
        }

        public static clsPerson Find(int ID)
        {
            int nationalityCountryID = -1;

            string firstName = "", secondName = "", thirdName = "", lastName = "",
            email = "", address = "", gender = "", phone = "",
            imagePath = "", nationalNom = "";
            DateTime dateOfBirth = DateTime.Now.AddYears(-18); 
                
                if(AD_People.GetPersonByID(ID, ref  firstName, ref  secondName, ref  thirdName, ref  lastName,
                                          ref  email, ref  address, ref  gender,ref  phone,
                                          ref  imagePath, ref  nationalNom,ref  nationalityCountryID,ref  dateOfBirth) == true )
              {

                return new clsPerson(ID, firstName , secondName, thirdName , lastName 
                    ,email , address, gender, phone , imagePath , nationalNom , nationalityCountryID , dateOfBirth);

            }
            else
            {
                return null;
            }
            
                
                

        }
        public static clsPerson Find(string NationalNumber)
        {
            int nationalityCountryID = -1 , ID=-1;

            string firstName = "", secondName = "", thirdName = "", lastName = "",
            email = "", address = "", gender = "", phone = "",
            imagePath = "", nationalNom = NationalNumber;
            DateTime dateOfBirth = DateTime.Now.AddYears(-18); 
                
                if(AD_People.GetPersonByNationalNumber(ref ID, ref  firstName, ref  secondName, ref  thirdName, ref  lastName,
                                          ref  email, ref  address, ref  gender,ref  phone,
                                          ref  imagePath, nationalNom,ref  nationalityCountryID,ref  dateOfBirth) == true )
              {

                return new clsPerson(ID, firstName , secondName, thirdName , lastName 
                    ,email , address, gender, phone , imagePath , nationalNom , nationalityCountryID , dateOfBirth);

            }
            else
            {
                return null;
            }


        }

        public static bool DeleteByID(int personID)
        {
            string crntImgePath = Find(personID).ImagePath;
            if (AD_People.DeleteByID(personID))
            {
                try
                {
                    if(! string.IsNullOrEmpty(crntImgePath))
                    File.Delete(crntImgePath);

                    return true;
                }
                catch (Exception ex) 
                {
                    return false;

                }

            }
            return false;
        }

        public static bool IsPersonExist(string NationalNumber)
        {
            return AD_People.IsPersonHere(NationalNumber);
        } 
        public static bool IsPersonExist(int personID)
        {
            return AD_People.IsPersonHere(personID);
        }

        public static bool IsDriver(int PersonID) => AD_Drivers.PersonIsDriver(PersonID);

        public static int GetDriverIDwithPersonID(int PersonID) => AD_Drivers.GetDriverID(PersonID);

        #endregion
    }
}

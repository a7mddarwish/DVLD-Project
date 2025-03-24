using AccessDataLayer;
using System;
using System.Data;

namespace BussnisLayer
{
    public class clsUser
    {

        public enum Stutes { Addnew, Update }
        public Stutes State = Stutes.Addnew;

        // Person Properties
        #region props
        public clsPerson UPerson = new clsPerson();
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        #endregion

        // Constractors
        #region ctors
        public clsUser()
        {
            this.State = Stutes.Addnew;
            this.ID = -1;
            this.UPerson = null;
            this.UserName = null;
            this.Password = null;
            this.IsActive = false;
        }

        private clsUser(int ID, int PersonID, string UserName, string Password, Boolean IsActive)
        {
            State = Stutes.Update;
            this.ID = ID;
            this.UPerson = clsPerson.Find(PersonID);
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

        }
        #endregion

        public bool Save()
        {
            if (this.State == Stutes.Addnew)
            {

                if (SaveInDB())
                {
                    this.State = Stutes.Update;
                    return true;

                }

            }
            else
                return UpdateUserInfo();

            return false;
        }

        private bool SaveInDB()
        {
            this.ID = AD_Users.SaveUserInDB(this.UPerson.ID, this.UserName, this.Password, this.IsActive);

            return this.ID != -1;
        }
        private bool UpdateUserInfo()
        {
            return AD_Users.UpdateUserInfo(this.ID, this.UPerson.ID, this.UserName, this.Password, this.IsActive);
        }

        #region StaticMethods
        public static bool IsUserNameExists(string UserName)
        {
            return AD_Users.CheckIfUserNameHere(UserName);  
        }
        public static DataTable GetAllUsers()
        {
            DataTable AllUsers = AD_Users.GetAllUsers();
            return PerpareTable(ref AllUsers);
        }
        private static DataTable PerpareTable(ref DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                clsPerson Person = clsPerson.Find(int.Parse(row["PersonID"].ToString()));

                row["FullName"] = Person.FullName;
            }

            return dataTable;
        }
        public static clsUser Find(int userID)
        {
            int UserID = userID, PersonID = -1;

            string UserName = "", Password = "";
            bool IsActive = false;



            return AD_Users.GetByID(userID, ref PersonID, ref UserName, ref Password, ref IsActive) ?
                   new clsUser(userID, PersonID, UserName, Password, IsActive) : null;



        }  
        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;

            string UserName = "", Password = "";
            bool IsActive = false;



            return AD_Users.GetByPersonID(ref UserID,  PersonID, ref UserName, ref Password, ref IsActive) ?
                   new clsUser(UserID, PersonID, UserName, Password, IsActive) : null;



        }
        public static clsUser Find(string UserName)
        {
            int UserID = -1, PersonID = -1;

           string Password = "";
            bool IsActive = false;

            if (AD_Users.GetByUserName(ref UserID, ref PersonID, UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }

            else return null;
        }
        public static clsUser Find(string UN , string Password)
        {
            int UserID = -1, PersonID = -1;

            
            bool IsActive = false;

            if (AD_Users.GetByUserNameAndPass(ref UserID, ref PersonID, UN,  Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UN , Password, IsActive);
            }

            else return null;
        }

        //public static bool HasAccessToLogin(string inUserName, string inPass)
        //{
        //   // (this.IsActive || inUserName == this.UserName || inPass == this.Password);
        //   clsGlobalUser.GlobalUser = clsUser.Find(inUserName);

        //    if (clsGlobalUser.GlobalUser == null || !clsGlobalUser.GlobalUser.IsActive)
        //        return false;

        //    return (inPass == clsGlobalUser.GlobalUser.Password);
        //}

    }
        #endregion
}

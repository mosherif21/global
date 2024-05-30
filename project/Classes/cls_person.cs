using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class cls_person
    {
        #region variable
       
        private int cust_id;
        private string First_name;
        private string last_name;
        private string middle_name;
        private string gender;
        private string email;
        private string nationality;
        private string username;
        private string password;
        
        private string birthdate;
        #endregion

        #region properties
        public string NATIONALITY
        {
            get { return nationality; }
            set
            {
                nationality = value;
            }
        }
        public string BIRTHDATE
        {
            get { return birthdate; }
            set
            {

                birthdate = value;
            }
        }
        public int CUST_ID
        {
            get { return cust_id; }
            set
            {
                
                   cust_id  = value  ;
            }
        }
        private bool check;
        public string FIRST_NAME
        {
            get { return First_name; }
            set
            {
                check = value.All(char.IsLetter);

                if (check == true)
                    First_name = value;
            }
        }
        public string LAST_NAME
        {
            get { return last_name; }
            set
            {
                check = value.All(char.IsLetter);

                if (check == true)
                    last_name = value;
            }
        }
        public string MIDDLE_NAME
        {
            get { return middle_name; }
            set
            {
                check = value.All(char.IsLetter);

                if (check == true)
                    middle_name = value;
            }
        }
        public string GENDER
        {
            get { return gender; }
            set
            {
                check = value.All(char.IsLetter);

                if (check == true)
                    gender = value;
            }
        }
        public string EMAIL
        {
            get { return email; }
            set
            {                
                    email = value;
            }
        }
       
        public string USERNAME
        {
            get { return username; }
            set
            {
                check = value.All(char.IsLetterOrDigit);

                if (check == true)
                    username = value;
            }
        }
        public string PASSWORD
        {
            get { return password; }
            set
            {
                check = value.All(char.IsLetterOrDigit);

                if (check == true)
                    password = value;
            }
        }
      
        #endregion
      
        #region getuser
        public virtual void store_user(int acust_id, string aFirst_name, string alast_name, string amiddle_name, string agender,  string apassword,string aemail, string ausername, int abalance,string anationality,string abirthdate)
        {
          
        }
        #endregion

    }
}

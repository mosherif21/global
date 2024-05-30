using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class cls_customer : cls_person
    {

        private float balance;
        public float BALANCE
        {
            get { return balance; }
            set
            {

                balance = value;
            }
        }

        #region singleton
        private static List<cls_customer> instance = new List<cls_customer> { new cls_customer() };
        
        private static int j=0;
        public static void reset_instance()
        { j++;
            instance.Insert(j, new cls_customer());
           
        }
        public static cls_customer initiatecustomer()
        {
           
            return instance[j];
        }
       
        #endregion

        public override void store_user(int acust_id, string aFirst_name, string alast_name, string amiddle_name, string agender, string apassword, string aemail, string ausername, int abalance, string anationality, string abirthdate)
        {
            CUST_ID = acust_id;
            FIRST_NAME = aFirst_name;
            LAST_NAME = alast_name;
            MIDDLE_NAME = amiddle_name;
            GENDER = agender;
            EMAIL = aemail;
            GENDER = agender;
            EMAIL = aemail;
            USERNAME = ausername;
            BALANCE = abalance;
            NATIONALITY = anationality;
            BIRTHDATE = abirthdate;
        }
    }
}

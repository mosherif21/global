using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class cls_employees : cls_person
    {
        #region singleton
        private static cls_employees instance = new cls_employees();
        public static cls_employees initiateemployee()
        {
            return instance;
        }
        #endregion

        #region variables and properties
        private string job_description;
        public string JOB_DESCRIPTION
        {
            get { return job_description; }
           set {
                job_description = value;
            }

        }
        #endregion
        public void store_user(int acust_id, string aFirst_name, string alast_name, string amiddle_name, string agender, string apassword, string aemail, string ausername, string anationality, string abirthdate,string ajob)
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
            PASSWORD = apassword;
            NATIONALITY = anationality;
            BIRTHDATE = abirthdate;
            JOB_DESCRIPTION=ajob;
        }
    }
}

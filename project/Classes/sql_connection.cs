using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
   public class sql_connection
    { 
        public static String sqlconnection_string()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\global1.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}

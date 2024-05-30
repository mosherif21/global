using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Runtime;


namespace project
{
    public partial class Fr_change_user : Form
    {
        //database connection
        static string connection = sql_connection.sqlconnection_string(); 
        SqlConnection con = new SqlConnection(connection);

        public Fr_change_user()
        {
           
            InitializeComponent();
        }
        public Fr_change_user(int n)
        {
            x = true;
            InitializeComponent();
        }
        private bool x = false;
  
        #region variables and properties
    
        private bool check;      
        private string username;
        public static bool usernameconfirm { get; set; }
        fr_employee emp = fr_employee.getinstance();
        private string USERNAME
        {
            get { return username; }
            set
            {
                check = value.All(char.IsLetterOrDigit);

                if (check == true)
                    username = value;
            }
        }
        #endregion
        
        //function change user
        public bool fn_changecustomer()
        {
            
            USERNAME = txt_cust_user.Text.Trim();
            usernameconfirm = false;
            con.Open();          
            SqlCommand cmd_user = new SqlCommand("select Username from person,customers where person_ID=person_customers_ID and Username='" + USERNAME + "'", con);          
            SqlDataAdapter u = new SqlDataAdapter(cmd_user);        
            DataTable username = new DataTable();       
            u.Fill(username);          
            con.Close();
            if (username.Rows.Count > 0)
            {
                usernameconfirm = true;
            }
            if (usernameconfirm == false)
            
                lbl_wrong_user.Text = "User doesn't exist";               

            if (usernameconfirm == true)
            {

                cls_customer cust = cls_customer.initiatecustomer();
                con.Open();
                SqlCommand fill_cust = new SqlCommand("select Customer_ID, First_Name,Last_Name,Middle_Name,Gender,Email,Username,balance,nationality,birthdate from person,customers where person_ID=person_customers_ID and Username='" + USERNAME + "'", con);
                SqlDataReader cust_reader;
                cust_reader = fill_cust.ExecuteReader();
                while (cust_reader.Read())
                {
                    int a;
                    int.TryParse(cust_reader[8].ToString(), out a);
                    int balance;
                    if (a == 1)
                        balance = int.Parse(cust_reader[8].ToString());
                    else balance = 0;
                    cust.store_user(int.Parse(cust_reader[0].ToString()), cust_reader[1].ToString(), cust_reader[2].ToString()
                         , cust_reader[3].ToString(), cust_reader[4].ToString(), "Null", cust_reader[5].ToString(), cust_reader[6].ToString(),
                          int.Parse(cust_reader[7].ToString()), cust_reader[8].ToString(), cust_reader[9].ToString());
                }
                con.Close();
               
               
            }
            return usernameconfirm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls_customer.reset_instance();
            cls_cart.reset_instance();
            cls_favorites.reset_instance();
            bool confirm = fn_changecustomer();
            if (confirm == true)
            {
                
                lbl_wrong_user.Text = "User Confirmed Successfuly";
                lbl_wrong_user.ForeColor = Color.Green;
                if (x == false)
                {
                    this.Close();
                    emp.launch_products();
                }
            }
            
        }
        cls_cart cart = cls_cart.initiatecart();

        private void Fr_change_user_Load(object sender, EventArgs e)
        {
            if (x == true)
            {
                button2.Visible = false;
            }
      
            this.ActiveControl = txt_cust_user;
            txt_cust_user.Focus();
        }

        //event to press confrim with enter
        private void txt_cust_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btn_confirm_user.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //button cancel
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

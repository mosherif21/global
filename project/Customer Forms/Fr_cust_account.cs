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
using System.IO;
using System.Globalization;

namespace project
{
    public partial class Fr_account : Form
    {
        #region connections and variables
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);
        SqlConnection con2 = new SqlConnection(connection);
        SqlConnection con3= new SqlConnection(connection);

        bool check;
        cls_customer cust = cls_customer.initiatecustomer();
        #endregion

        public Fr_account()
        {
            InitializeComponent();
        }
         public Fr_account(int n)
        {
            x = true;
            InitializeComponent();
        }
        private bool x = false;
      

        #region load data
        public void data_load()
        {
            lbl_cust_name.Text = cust.FIRST_NAME + " " + cust.LAST_NAME;
            lbl_cust_email.Text = cust.EMAIL;
            lbl_cust_nationality.Text = cust.NATIONALITY;
            lbl_cust_name_small.Text = cust.FIRST_NAME + ' ' + cust.LAST_NAME;
            lbl_cust_email_small.Text = cust.EMAIL;
            lbl_cust_gender.Text = cust.GENDER;
            lbl_cust_username.Text = cust.USERNAME;
            lbl_cust_birthdate.Text = cust.BIRTHDATE;
        }
        #endregion
        private void Fr_account_Load(object sender, EventArgs e)
        {
            if (x == true)
                Log_out.Visible = false;
            TXT_NATIONALITY.DataSource = get_country_names();
            data_load();
            set_person_id();
        }

        //load account information
        public void account_data()
        {
            TXT__FIRST_NAME.Text = cust.FIRST_NAME;
            TXT_LASTNAME.Text =cust.LAST_NAME;
            TXT_EMAIL.Text = cust.EMAIL;
            pnl_edit_acc_information.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            check = false;
            account_data();

        }

        private void TXT_PASSWORD_TextChanged(object sender, EventArgs e)
        {
            
        }
        fr_customer f = fr_customer.getinstance();
        fr_employee emp = fr_employee.getinstance();
        //save account info
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_wrong_pass.Visible = false;
                lbl_empty_input.Visible = false;
                lbl_empty_new.Visible = false;
                cls_customer cust = cls_customer.initiatecustomer();
                if (TXT__FIRST_NAME.Text.Trim() != string.Empty && TXT_LASTNAME.Text.Trim() != string.Empty && TXT_PASSWORD.Text.Trim() != string.Empty && TXT_EMAIL.Text.Trim() != string.Empty)
                {
                    con.Open();                                   
                    SqlCommand cmd_pass = new SqlCommand("select * from person where password='" + TXT_PASSWORD.Text.Trim() + "' and person_ID ='" + person_id + "'", con);               
                    SqlDataAdapter p = new SqlDataAdapter(cmd_pass);            
                    DataTable password = new DataTable();                   
                    p.Fill(password);
                    con.Close();
                   
                    if (password.Rows.Count>0)
                    {
                        if (TXT_NEW_PASSWORD.Text == string.Empty)
                        {
                            lbl_empty_input.Visible = true;
                        }
                        else if (TXT_NEW_PASSWORD.Text != string.Empty && check == false)
                        {
                            lbl_empty_new.Visible = true;
                        }
                        else
                        {
                            cust.PASSWORD = TXT_NEW_PASSWORD.Text;
                            cust.FIRST_NAME = TXT__FIRST_NAME.Text.Trim();
                            cust.LAST_NAME = TXT_LASTNAME.Text.Trim();
                            cust.EMAIL = TXT_EMAIL.Text.Trim();
                   
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update person set First_Name = '" + cust.FIRST_NAME + "', Last_Name = '" + cust.LAST_NAME + "', Email = '" + cust.EMAIL + "', password = '" + cust.PASSWORD + "' where person_ID ='" + person_id + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    emp.refresh_Account();
                    f.refresh_Account();
                            pnl_edit_acc_information.Visible = false;
                        }
                    }
                    else
                    {
                        lbl_wrong_pass.Visible = true;
                    }
                  
                }
                else lbl_empty_input.Visible = true;
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
        }
         
       //cancel account info modify
     private void button5_Click(object sender, EventArgs e)
        {
            pnl_edit_acc_information.Refresh();
          
            pnl_edit_acc_information.Visible = false;
            f.refresh_Account(); emp.refresh_Account();
        }
        //cancel personal info modify
        private void button4_Click(object sender, EventArgs e)
        {
            PNL_EDIT_PERSONAL.Refresh();
            PNL_EDIT_PERSONAL.Visible = false;
            f.refresh_Account(); emp.refresh_Account();
        }

        //load personal data
        public void personal_data()
        {
            TXT_USERNAME.Text = cust.USERNAME;
            TXT_NATIONALITY.Text = cust.NATIONALITY;
            TXT_BIRTHDATE.Text = cust.BIRTHDATE;
            TXT_GENDER.Text = cust.GENDER;
            PNL_EDIT_PERSONAL.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            personal_data();
        }

          int person_id=0;
        public void set_person_id()
        {
            con2.Open();
            SqlCommand cm = new SqlCommand("select person_customers_ID from customers where Customer_ID='" + cust.CUST_ID + "'", con2);
            SqlDataReader sql = cm.ExecuteReader();
            while (sql.Read())
            {
                person_id = int.Parse(sql[0].ToString());

            }
            con2.Close();
        }
        //save personal info
        private void button6_Click(object sender, EventArgs e)
        {      lbl_empty_pers.Visible = false;
            try
            {
            
            if (TXT_USERNAME.Text.Trim() != string.Empty && TXT_NATIONALITY.Text != string.Empty && TXT_BIRTHDATE.Text != string.Empty && TXT_GENDER.Text != string.Empty)
            {
                   
                cust.USERNAME = TXT_USERNAME.Text.Trim();
                cust.NATIONALITY = TXT_NATIONALITY.Text;
                cust.BIRTHDATE = TXT_BIRTHDATE.Text;
                cust.GENDER = TXT_GENDER.Text;
                PNL_EDIT_PERSONAL.Visible = false;
                data_load();
                con.Open();
                SqlCommand cmd = new SqlCommand("update person set Username ='"+cust.USERNAME+"' ,Gender='"+cust.GENDER+"' ,nationality='"+cust.NATIONALITY+"',birthdate='"+DateTime.Parse(cust.BIRTHDATE)+"' where person_ID='"+person_id+"'", con);
                cmd.ExecuteNonQuery();
                con.Close();
               
                    f.refresh_Account();
                    emp.refresh_Account();
                }
            else lbl_empty_pers.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        //function country names
        public static List<String> get_country_names()
        {
            List<String> g = new List<string>();
            CultureInfo[] getc = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo f in getc)
            {
                RegionInfo get = new RegionInfo(f.LCID);
                if (!(g.Contains(get.EnglishName)))
                {
                    g.Add(get.EnglishName);
                }
            }
            g.Sort();
            return g;
        }
        private void TXT_PASSWORD_Enter(object sender, EventArgs e)
        {
            TXT_PASSWORD.Text = "please enter your current password";
            pnl_new_password.Visible = true;
        }

        //show and hide pass
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TXT_PASSWORD.UseSystemPasswordChar = false;
                TXT_NEW_PASSWORD.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "hide";
            }
            else
            {
                TXT_PASSWORD.UseSystemPasswordChar = true;
                TXT_NEW_PASSWORD.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "show";
            }
        }

        //current password check
        bool s = false;
        private void TXT_PASSWORD_Enter_1(object sender, EventArgs e)
        {
            if (s == false)
            {
                TXT_PASSWORD.Text = null;
                TXT_PASSWORD.UseSystemPasswordChar = true;
                s = true;
            }
            pnl_new_password.Visible = true;            
        }

        //new password check
        bool m = false;
        private void TXT_NEW_PASSWORD_Enter(object sender, EventArgs e)
        {
             if (m == false)
            {
                TXT_NEW_PASSWORD.Text = null;
                TXT_NEW_PASSWORD.UseSystemPasswordChar = true;
                m = true;
            }
        }

        private void TXT_NEW_PASSWORD_TextChanged(object sender, EventArgs e)
        {
            check = true;
        }

        private void Log_out_Click(object sender, EventArgs e)
        {
          
            fr_customer fr = fr_customer.getinstance();
            fr.Hide();
            fr.Close();
            cls_customer.reset_instance();
            cls_cart.reset_instance();
            cls_favorites.reset_instance();
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "fr_splash")
                    f.Close();
              
            }
            new fr_cust_login().ShowDialog();

        }
    }
}

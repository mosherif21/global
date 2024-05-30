 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Runtime;
using System.Globalization;



namespace project
{
    public partial class fr_cust_login : Form
    {
        //database connection

        static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);
        SqlConnection co= new SqlConnection(connection);
        SqlConnection c= new SqlConnection(connection);

        public fr_cust_login()
        {
            InitializeComponent();
            txt_cust_psswd.UseSystemPasswordChar = true;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //minimize button
        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //exit button
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            fr_start s = new fr_start();
            s.ShowDialog();
        }

        #region show and hide password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txt_cust_psswd.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "hide";
            }
            else
            {
                txt_cust_psswd.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "show";
            }
        }
        #endregion
        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }

        #region variables and properties
        public bool usernameconfirm { get; set; }
        public bool psswdconfirm { get; set; }

        private bool check;
        private string username;
        private string password;
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
                password = value;
            }
        }
        #endregion


        fr_customer cs = new fr_customer();

        private void button1_Click(object sender, EventArgs e)
        {
            #region check login info
            usernameconfirm = false;
            psswdconfirm = false;
            USERNAME = txt_cust_user.Text.Trim();
            PASSWORD = txt_cust_psswd.Text;
            try
            {
                con.Open();
                co.Open();
                SqlCommand cmd_user = new SqlCommand("select * from person,customers where Username='" + USERNAME + "' and person_ID=person_customers_ID", con);
                SqlCommand cmd_pass = new SqlCommand("select * from person,customers where password='" + PASSWORD + "' and Username='" + USERNAME + "' and person_ID=person_customers_ID", co);
                SqlDataAdapter u = new SqlDataAdapter(cmd_user);
                SqlDataAdapter p = new SqlDataAdapter(cmd_pass);
                DataTable username = new DataTable();
                DataTable password = new DataTable();
                u.Fill(username);
                p.Fill(password);
                con.Close();
                co.Close();
                if (username.Rows.Count > 0)
                {

                    usernameconfirm = true;
                }
                else
                {
                    usernameconfirm = false;

                }

                if (password.Rows.Count > 0)
                {
                    psswdconfirm = true;
                }
                else
                {
                    psswdconfirm = false;

                }
                if (usernameconfirm == true && psswdconfirm == false)
                    lbl_login_denied.Text = "Wrong Password";
                if (usernameconfirm == false && psswdconfirm == false)
                    lbl_login_denied.Text = "Wrong Username or Password";
                if (usernameconfirm == true && psswdconfirm == true)
                {
                    cls_person cust = cls_customer.initiatecustomer();
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
                    fr_customer.reset_instance();
                    fr_customer cs =fr_customer.getinstance();
                    this.Hide();
                    cs.ShowDialog();
                
                }
            }

            catch (FormatException d)
            {
                MessageBox.Show(d.Message);
            }
    
            #endregion
        }
        #region drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void mousedown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        
        private void fr_cust_login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_cust_user;
            txt_cust_user.Focus();
        }

        //events to tab to next textbox and login with enter
        private void txt_cust_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_cust_psswd.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
         private void txt_cust_psswd_KeyDown(object sender, KeyEventArgs e )
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_cust_login.PerformClick();

                e.Handled = true;
                e.SuppressKeyPress = true;
                
            }
        }

        private void sign_up_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nationality.DataSource = get_country_names();
            this.Width = 580;
            pnl_signup_1.Visible = true;
            pnl_signup_2.Visible = true;
        }


        public static List<String> get_country_names()
        {
            List<String> g = new List<string>();
            CultureInfo[] getc = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo f in getc)
            {
                RegionInfo get = new RegionInfo(f.LCID);
                if (!(g.Contains(get.EnglishName))){
                    g.Add(get.EnglishName);
                }
            }
            g.Sort();
            return g;
        }
        //show and hide password in signup

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                sign_up_password.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "hide";
            }
            else
            {
                sign_up_password.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "show";
            }
        }

        private void back_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Width = 300;
            pnl_signup_1.Visible = false;
            pnl_signup_2.Visible = false;
        }

        private void confirm_sign_up_Click(object sender, EventArgs e)
        {
            if (sign_up_username.Text.Trim().Length == 0 || sign_up_password.Text.Trim().Length == 0
               || sign_up_email.Text.Trim().Length == 0 || first_name.Text.Trim().Length == 0
               || lastname.Text.Trim().Length == 0 || gender.Text.Trim().Length == 0)
            {
                lbl_signup_empty_field.Text = "All fields with * can't be empty";
                lbl_username_exist.Text = "";
                lbl_email_exists.Text = "";
            }
                else
            {
                lbl_signup_empty_field.Text = "";
            
                #region check login info
                bool usernameconfirm = false;
            bool  emailconfirm = false;
           string USERNAME = sign_up_username.Text.Trim();
           string EMAIL = sign_up_email.Text.Trim();
            try
            {
                con.Open();
                co.Open();
                SqlCommand cmd_user = new SqlCommand("select * from person,customers where Username='" + USERNAME + "' and person_ID=person_customers_ID", con);
                SqlCommand cmd_email = new SqlCommand("select * from person,customers where Email='" + EMAIL + "' and person_ID=person_customers_ID", co);
                SqlDataAdapter u = new SqlDataAdapter(cmd_user);
                SqlDataAdapter p = new SqlDataAdapter(cmd_email);
                DataTable username = new DataTable();
                DataTable email = new DataTable();
                u.Fill(username);
                p.Fill(email);
                con.Close();
                co.Close();
                if (username.Rows.Count > 0)
                {

                    usernameconfirm = false;
                }
                else
                {
                    usernameconfirm = true;

                }

                if (email.Rows.Count > 0)
                {
                    emailconfirm = false;
                }
                else
                {
                    emailconfirm = true;

                }
                if (usernameconfirm == true && emailconfirm == false)
                    {
                        lbl_username_exist.Text = "";
                   lbl_email_exists.Text = "Email already exists";
                    }
               
                                  
                if (usernameconfirm == false && emailconfirm == true)
                    {
                        lbl_email_exists.Text = "";
                        lbl_username_exist.Text = "Username already taken";
                    }
                    
                if (usernameconfirm == false && emailconfirm == false)
                {
                    lbl_username_exist.Text = "Username already taken";
                    lbl_email_exists.Text = "Email already exists";
                }
           


                if (usernameconfirm == true && emailconfirm == true)
                {
                    con.Open();
                        SqlCommand cmd = 
           new SqlCommand("insert into person (First_Name,Last_Name,Middle_Name,Gender,password,Email,Username,nationality,birthdate)" +
           "values('" + first_name.Text.Trim() + "','" + lastname.Text.Trim() + "','"+ middlename.Text.Trim() + "','"+ gender.Text + "','"+ sign_up_password.Text.Trim() + 
           "','"+ sign_up_email.Text.Trim() + "','"+ sign_up_username.Text.Trim() + "','" + nationality.Text.Trim()  +  "','"+ DateTime.Parse(birthdate.Text)  +  "')", con);
                        cmd.ExecuteNonQuery();
                        SqlCommand c = new SqlCommand("select SCOPE_IDENTITY()", con);
                        int person_id = int.Parse(c.ExecuteScalar().ToString());

                        SqlCommand cmd2 = new SqlCommand("insert into customers (person_customers_ID,balance)values('" + person_id + "','0')", con);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        fr_cust_login login = new fr_cust_login();
                       this.Close();
                        this.Hide();
                        login.ShowDialog();
                    }
            }

            catch (FormatException d)
            {
                MessageBox.Show(d.Message);
            }

                #endregion
            }
            }

  
    }
}

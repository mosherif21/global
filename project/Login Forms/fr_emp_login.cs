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
namespace project
{
    public partial class fr_emp_login : Form
    {
        //database connection
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);
        SqlConnection co = new SqlConnection(connection);

        public fr_emp_login()
        {
            InitializeComponent();
            txt_emp_psswd.UseSystemPasswordChar = true;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }


        #region show and hide
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_emp_psswd.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "hide";
            }
            else
            {
                txt_emp_psswd.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "show";
            }
        }
        #endregion

        private void emp_login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_emp_username;
            txt_emp_username.Focus();
        }

        //button minimize
        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        //button exit
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            fr_start s = new fr_start();
            s.ShowDialog();


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
        fr_employee user = fr_employee.getinstance();

        private void btn_emp_login_Click(object sender, EventArgs e)
        {
            #region check login info
            usernameconfirm = false;
            psswdconfirm = false;
            USERNAME = txt_emp_username.Text;
            PASSWORD = txt_emp_psswd.Text;
            try
            {
                con.Open();
                co.Open();
                SqlCommand cmd_user = new SqlCommand("select * from person,employee where Username='" + USERNAME + "' and person.person_ID=Employee.person_id", con);
                SqlCommand cmd_pass = new SqlCommand("select * from person,employee where password='" + PASSWORD + "' and person.person_ID=Employee.person_id  and Username='" + USERNAME + "'", co);
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
                    cls_employees empl = cls_employees.initiateemployee();

                    con.Open();
                    SqlCommand fill_c = new SqlCommand("select * from person,Employee where  person.person_ID=Employee.person_id and Username='" + USERNAME + "'", con);
                    SqlDataReader cust_reader;
                    cust_reader = fill_c.ExecuteReader();
                    while (cust_reader.Read())
                    {
                 
           
                        empl.store_user(int.Parse(cust_reader[0].ToString()), cust_reader[1].ToString(), cust_reader[2].ToString()
                        , cust_reader[3].ToString(), cust_reader[4].ToString(), cust_reader[5].ToString(), cust_reader[6].ToString(), cust_reader[7].ToString()
                         , cust_reader[9].ToString(), cust_reader[10].ToString(), cust_reader[12].ToString());

                    }
                    this.Hide();
                    user.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            #endregion
       
        }

        private void txt_emp_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_emp_psswd.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
  
        private void txt_emp_psswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_emp_login.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }
    }
}

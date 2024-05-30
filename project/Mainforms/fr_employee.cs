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
using System.IO;
using project.Properties;

namespace project
{
    public partial class fr_employee : Form
    {
        //database connection
        static string connection = sql_connection.sqlconnection_string(); 
        SqlConnection c = new SqlConnection(connection);
        SqlConnection co = new SqlConnection(connection);

        public fr_employee()
        {
            InitializeComponent();
            r = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        //singleton for refresh from outside
        #region
        private static fr_employee instance = new fr_employee();
        public static fr_employee getinstance()
        {
            return instance;
        }
        #endregion

        #region gui themes for button and forms launch 
        private Random r;
        private Button current;
        private int temp;
        private Form launched = new Form();
     
        private Color randomtheme()
        {
            int i = r.Next(cls_UIcolor.theme.Count);
            while (temp == i)
            {
               i= r.Next(cls_UIcolor.theme.Count);
            }
            temp = i;
            string color = cls_UIcolor.theme[i];
            return ColorTranslator.FromHtml(color);

        }
        private void buttonaddtheme(object btnsender)
        {
            if (btnsender != null)
            {
                if (current != (Button)btnsender)
                {
                    buttonremovetheme();
                    Color color = randomtheme();
                    usc_cart_products.COLOR = color;
                    usc_favorites.COLOR = color;
                    usc_products.COLOR = color;
                    usc_order_checkout.COLOR = color;
                    btn_cart.BackColor = color;
                    current = (Button)btnsender;
                    current.BackColor = color;
                    current.ForeColor = Color.White;
                    current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnl_title.BackColor = color;
                    pnl_logo.BackColor = cls_UIcolor.ChangeColorBrightness(color, -0.3);

                }

            }
        }
       

        private void buttonremovetheme()
        {
            foreach (Control previousbtn in MENU.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {   
                    previousbtn.BackColor = Color.FromArgb(56, 56, 56);
                    previousbtn.ForeColor = Color.Gainsboro;
                    previousbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
                
            }
        }
    

        private void launchform(Form choosenform,object btnsender)
        {   if( launched != null)
            {
                launched.Close();
            }

            buttonaddtheme(btnsender);
            launched = choosenform;
            choosenform.TopLevel = false;
            choosenform.FormBorderStyle = FormBorderStyle.None;
            choosenform.Dock = DockStyle.Fill;
            this.pnl_chosen.Controls.Add(choosenform);
            this.pnl_chosen.Tag = choosenform;
            choosenform.BringToFront();
            choosenform.Show();
        }

    
        private void launchform2(Form choosenform, object btnsender)
        {
            if (launched != null)
            {
                launched.Close();
            }
           
            launched = choosenform;
            choosenform.TopLevel = false;
            choosenform.FormBorderStyle = FormBorderStyle.None;
            choosenform.Dock = DockStyle.Fill;
            this.pnl_chosen.Controls.Add(choosenform);
            this.pnl_chosen.Tag = choosenform;
            choosenform.BringToFront();
            choosenform.Show();
        }
        private void launchform3(Form choosenform)
        {
            if (launched != null)
            {
                launched.Close();
            }

            
            launched = choosenform;
            choosenform.TopLevel = false;
            choosenform.FormBorderStyle = FormBorderStyle.None;
            choosenform.Dock = DockStyle.Fill;
            this.pnl_chosen.Controls.Add(choosenform);
            this.pnl_chosen.Tag = choosenform;
            choosenform.BringToFront();
            choosenform.Show();
        }
        private void launchform4(Form choosenform)
        {
            if (launched != null)
            {
                launched.Close();
            }
          
            launched = choosenform;
            choosenform.TopLevel = false;
            choosenform.FormBorderStyle = FormBorderStyle.None;
            choosenform.Dock = DockStyle.Fill;
            this.pnl_chosen.Controls.Add(choosenform);
            this.pnl_chosen.Tag = choosenform;
            choosenform.Show();
        }

       private void Reset()
        {
            buttonremovetheme();
            pnl_title.BackColor = Color.FromArgb(156, 93, 94);
            btn_cart.BackColor = Color.FromArgb(156, 93, 94);
            usc_cart_products.COLOR = Color.FromArgb(156, 93, 94); ;
            usc_favorites.COLOR = Color.FromArgb(156, 93, 94); ;
            usc_products.COLOR = Color.FromArgb(156, 93, 94); ;
            usc_order_checkout.COLOR = Color.FromArgb(156, 93, 94); ;
            pnl_logo.BackColor = Color.FromArgb(43, 40, 40);
            current = null;

        }
        private void launchform5(Form choosenform)
        {

            if (launched != null)
            {
                launched.Close();
            }
            launched = choosenform;
            choosenform.TopLevel = false;
            choosenform.FormBorderStyle = FormBorderStyle.None;
            choosenform.Dock = DockStyle.Fill;
            this.pnl_chosen.Controls.Add(choosenform);
            this.pnl_chosen.Tag = choosenform;
            choosenform.BringToFront();
            choosenform.Show();
        }


        #endregion

        //button launch products
        private void btn_products_Click(object sender, EventArgs e)
        {

            if (Fr_change_user.usernameconfirm == true) {   launchform(new fr_products(), sender);}
          
        }

        //button launch orders
        private void btn_orders_Click(object sender, EventArgs e)
        {

            if (Fr_change_user.usernameconfirm == true) {  launchform(new Fr_Return(), sender);}
           

        }

        //button launch balance
        private void btn_balance_Click(object sender, EventArgs e)
        {

            if (Fr_change_user.usernameconfirm == true) {  launchform(new Fr_balance(), sender);}

           
        }

        //button account
        private void btn_account_Click(object sender, EventArgs e)
        {

            if (Fr_change_user.usernameconfirm == true) {launchform(new Fr_account(1), sender); }
            
        }
        //function refresh account
        public void refresh_Account()
        {
            launchform5(new Fr_account(1));
        }
        public void launch_products()
        {
            launchform5(new fr_products());
        }
        //button home
        private void btn_home_Click(object sender, EventArgs e)
        {

            if (Fr_change_user.usernameconfirm == true) {
                btn_cart.BackColor = Color.FromArgb(156, 93, 94);
                if (launched != null)
            {
                launched.Close();
            }
            Reset();
                
                launchform2(new fr_products(), sender);}
           
        }
        

        //drag
        #region drag
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pnl_title_mousedown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        //button minimize
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //button exit
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //button maximize or minimize
        private void btn_maxmin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        //function launch checkout
        public void fn_launch_Checkout()
        {
            launchform5(new fr_checkout());
        }
        //function launch thanks after ordering
        public void thanks()
        {
            launchform5(new fr_thanks());
        }
        //function refresh orders 
        public void refresh_orders()
        {
            launchform5(new Fr_orders());
        }
        //button launch return form
        private void btn_return_Click(object sender, EventArgs e)
        {

            if (Fr_change_user.usernameconfirm == true) {launchform(new Fr_orders(), sender); }

            
        }

        //button launch stock
        private void btn_stock_Click(object sender, EventArgs e)
        {

            if (Fr_change_user.usernameconfirm == true) {launchform(new Fr_warehouse(), sender); }
            
        }

        //button change user
        private void btn_change_client_Click(object sender, EventArgs e)
        {

            if (Fr_change_user.usernameconfirm == true) { 

            if (launched != null)
            {
                launched.Close();
            }
            Reset();
                Fr_change_user fr_changing = new Fr_change_user();

                fr_changing.StartPosition = FormStartPosition.CenterParent;
                fr_changing.FormBorderStyle = FormBorderStyle.None;
                fr_changing.ShowDialog();
            }
            
                    
            }

        //button launch cart
      
       private void btn_cart_Click(object sender, EventArgs e)
        {

            if (Fr_change_user.usernameconfirm == true) {   launchform(new fr_favorites(), sender);}
          
        }


        //refresh cart
        public void cart_refresh()
        {
            launchform5(new fr_favorites());
        }

        //load favorites from database
        cls_customer cust = cls_customer.initiatecustomer();
        private void initiate_favorites()
        {
            cls_favorites fav = cls_favorites.initiatefavorites();

            int i = 0;

            c.Open();
            SqlCommand cmd_fav = new SqlCommand("select Product_ID,Product_Name,shipping,condition,price,Supplier_Name,photo from products ,favorites,Suppliers where favorites.customer_favorites_id ='" + cust.CUST_ID + "'" + "and favorites.products_favorites_id=products.Product_ID and Supplier_ID=Supplier_products_ID", c);
            SqlDataReader cust_fav;
            cust_fav = cmd_fav.ExecuteReader();
            while (cust_fav.Read())
            {
                fav.fill_favorite_products(i, int.Parse(cust_fav[0].ToString()), cust_fav[1].ToString(), cust_fav[2].ToString(), cust_fav[3].ToString(), int.Parse(cust_fav[4].ToString()), cust_fav[5].ToString());
                i++;
            }
            c.Close();
        }
        private void fr_employee_Load(object sender, EventArgs e)
        {
            initiate_favorites();
            launchform3(new Fr_change_user(1));
        }

        private void pnl_title_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


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
    public partial class fr_customer : Form
    {
        //database connection
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection c = new SqlConnection(connection);
        SqlConnection co = new SqlConnection(connection);

        //singleton for refresh from outside
        #region  
        private static List<fr_customer> instance = new List<fr_customer> { new fr_customer() };
        private static int j = 0;
        public static void reset_instance()
        {   j++;
            instance.Insert(j, new fr_customer());
            
        }
        public static fr_customer  getinstance()
        {
            
            return instance[j];
        }

       
      
        #endregion


        public fr_customer()
        {
            InitializeComponent();
            r = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        #region gui theme
        private Random r;
        private Button current;
        private int temp;
        Form launched = new Form();
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
        {
        
            if (launched != null)
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
            pnl_logo.BackColor = Color.FromArgb(43, 40, 40);
            btn_cart.BackColor = Color.FromArgb(156, 93, 94);
            usc_products.COLOR = Color.FromArgb(156, 93, 94);
            current = null;
           

        }
        #endregion

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
        cls_cart cart = cls_cart.initiatecart();
        private void customer_Load(object sender, EventArgs e)
        {
            fn_cart_number();
            usc_products.COLOR = Color.FromArgb(156, 93, 94);
            initiate_favorites();         
            launchform3(new fr_products());         
        }
        public  void fn_cart_number()
        {
             lbl_cart_number.Text = cart.items.Count.ToString().Trim();
        }
        public  void fn_Reset()
        {
            lbl_cart_number.Text = 0.ToString();
        }
        //load favorites from database
        cls_customer cust = cls_customer.initiatecustomer();    
        private void initiate_favorites()
        {
            cls_favorites fav = cls_favorites.initiatefavorites();
           
            int i = 0;
            
            c.Open();
            SqlCommand cmd_fav = new SqlCommand("select Product_ID,Product_Name,shipping" +
                ",Supplier_Name,price,condition from products ,favorites,Suppliers where favorites.customer_favorites_id ='" + cust.CUST_ID + "'" + "and favorites.products_favorites_id=products.Product_ID and Supplier_ID=Supplier_products_ID", c);
            SqlDataReader cust_fav;
            cust_fav = cmd_fav.ExecuteReader();
            while (cust_fav.Read())
            {
                fav.fill_favorite_products(i, int.Parse(cust_fav[0].ToString()), cust_fav[1].ToString(), 
                    cust_fav[2].ToString(), cust_fav[3].ToString(), int.Parse(cust_fav[4].ToString()), cust_fav[5].ToString());
                i++;
            }
            c.Close();
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
        //button launch products form
        private void btn_products_Click(object sender, EventArgs e)
        {
       
            launchform(new fr_products(), sender);
        }

        //button launch orders form
        private void btn_orders_Click(object sender, EventArgs e)
        {
           
         
            launchform(new Fr_orders(), sender);
        }

        //button launch balance form
        private void btn_balance_Click(object sender, EventArgs e)
        {
            
         
            launchform(new Fr_balance(), sender);
        }

        //button launch account
        private void btn_account_Click(object sender, EventArgs e)
        {
          
            launchform(new Fr_account(), sender);
        }
        public void refresh_Account()
        {
            launchform5(new Fr_account());
        }
        //button home
        private void btn_home_Click(object sender, EventArgs e)
        {
            Form launched = new Form();

            if (launched != null)
            {
                launched.Close();
            }
            Reset();
          
            launchform2(new fr_products(), sender);
            
        }
     

        
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

        //button maximize and minimize
        private void btn_maxmin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        //button launch favorites form
        private void btn_favor_Click(object sender, EventArgs e)
        {
                   
      
            launchform( new Fr_cust_favorites(),sender);
        }
        //refresh favorites
        public void fav_refresh()
        {
            
            launchform5(new Fr_cust_favorites());
        }
    

        //refresh cart
        public void cart_refresh()
        {
            launchform5(new fr_favorites());
        }
        //button launch cart
        private void btn_cart_Click(object sender, EventArgs e)
        {
            launchform(new fr_favorites(), sender);
        }

        private void lbl_cart_number_Click(object sender, EventArgs e)
        {

        }
    }
}

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
namespace project
{
    public partial class fr_favorites : Form
    {
        #region sql connection
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);
        SqlConnection cn = new SqlConnection(connection);
        #endregion

       

        public fr_favorites()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
          
        }

      
        #region getphoto from database
        public MemoryStream getphoto(string product_id)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select photo from products where Product_ID='"+product_id+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            MemoryStream ms = new MemoryStream { };
           byte[] P = (byte[])(ds.Tables[0].Rows[0]["photo"]);
            ms = new MemoryStream(P);
            return ms;
        }

        #endregion
        private void fr_favorites_Load(object sender, EventArgs e)
        {
            cart_done = false;
            carts.Gesubtotal();
            cart();
        }
    
        #region fill cart

        cls_cart carts = cls_cart.initiatecart();
        

        public static bool cart_done = false;
        public void cart()
        {
          
            lbl_no_of_items1.Text = carts.items.Count.ToString();
            lbl_total.Text = String.Format("{0:#,###,###.##}", carts.SUBTOTAL);
           

            if (carts.items.Count == 0)
            {
                panel1.Visible = true;
               pnl_checkout.Visible = false;
            }
            else
            {
                usc_cart_products[] items = new usc_cart_products[carts.items.Count];
                for (int j = 0; j < carts.items.Count; j++)
                {

                    items[j] = new usc_cart_products();
                    items[j].PRODUCT_ID = carts.items[j].PRODUCT_ID;
                    items[j].pr_image = Image.FromStream(getphoto(carts.items[j].PRODUCT_ID.ToString()));
                    items[j].pr_name = carts.items[j].PRODUCT_NAME;
                    items[j].pr_shipping = carts.items[j].SHIPPING;
                    items[j].pr_price = String.Format("{0:#,###,###.##}", carts.items[j].UNIT_PRICE);
                    items[j].pr_soldby = carts.items[j].SUPPLIER_NAME;
                    items[j].PR_QUANTITY = carts.items[j].QUANTITY;                   
                    items[j].pr_condition = carts.items[j].CONDITION;                   
                    items[j].CURRENT_INDEX = j;               
                    if (j == carts.items.Count - 1)
                        cart_done = true;

                    if (flpnl_cart_items.Controls.Count < 0)
                    {
                        flpnl_cart_items.Controls.Clear();
                    }
                    else
                        flpnl_cart_items.Controls.Add(items[j]);
                }
            }
            
            
        }
        #endregion
       

        #region checkout
        private void btn_checkout_Click(object sender, EventArgs e)
        {
            fr_customer f = fr_customer.getinstance();
            f.fn_launch_Checkout();
           fr_employee emp = fr_employee.getinstance();
            emp.fn_launch_Checkout();
         
        }
        #endregion

        
        #region confirm coupon
        bool check = false;
        bool exist = false;
       
        private void BTN_CONFIRM_COUPON_Click(object sender, EventArgs e)
        {
            cls_customer customer = cls_customer.initiatecustomer();
            cn.Open();
            SqlCommand cmd = new SqlCommand("select coupon_code,discount_percent from coupons where coupon_code='"+TXT_COUPON.Text+"' and customer_coupon_ID= '"+customer.CUST_ID+"'", cn);
       
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
        
            if (dr.Read())
            {
                exist = true; }

            cn.Close();
            if (exist == true)
            {
                cn.Open();
                SqlDataReader dr2;
                dr2 = cmd.ExecuteReader();
                coupons c = new coupons();
                while (dr2.Read())
                {

                    c.COUPON = dr2[0].ToString();
                    c.PERCENT = int.Parse(dr2[1].ToString());

                }

                cn.Close();


                if (check == false)
                {


                    carts.SUBTOTAL = (carts.SUBTOTAL - (c.PERCENT * carts.SUBTOTAL / 100));
                   
                    lbl_total.Text = String.Format("{0:#,###,###.##}", carts.SUBTOTAL);
                    check = true;

                    PNL_COUPON_ENTRY.Visible = false;
                    BTN_CONFIRM_COUPON.Visible = false;
                    lbl_coupon.Visible = false;
                    btn_coupon.Visible = false;
                    btn_remove_coupon.Visible = true;

                }
                else
                {
                    lbl_coupon.Text = "Coupon already added";
                    lbl_coupon.Visible = true;
                }
            }
            else
            {
                lbl_coupon.Visible = true;
                lbl_coupon.Text = "Coupon doesn't exist";
            }
            cn.Close();
        }
               
                
  
        
        #endregion

        private void btn_coupon_Click(object sender, EventArgs e)
        {
            BTN_CONFIRM_COUPON.Visible = true;
            PNL_COUPON_ENTRY.Visible = true;
        }

        private void TXT_COUPON_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                BTN_CONFIRM_COUPON.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        fr_customer f = fr_customer.getinstance();
        private void btn_remove_coupon_Click(object sender, EventArgs e)
        {
            f.cart_refresh();
        }
    }
}

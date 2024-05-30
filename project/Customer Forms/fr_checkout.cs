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
using System.Runtime.InteropServices;

namespace project
{
    public partial class fr_checkout : Form
    {
        //database connection
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection cn = new SqlConnection(connection);

        #region instances and variables
        cls_customer cust = cls_customer.initiatecustomer();
        cls_cart cart = cls_cart.initiatecart();
        cls_orders order = new cls_orders();
        #endregion

        string payment;

        #region get photo from database
        public MemoryStream getphoto(string product_id, int j)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select photo from products where Product_ID='" + product_id + "'";
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
        public static int order_ID;
       
           
      
        public fr_checkout()
        {
           
            InitializeComponent();
        }

        #region load checkout items
        public void load_data()
        {
            
            pnl_choose_payment.Visible = true;
            pnl_choose_payment.BringToFront();
            
            lbl_total.Text = String.Format("{0:#,###,###.##}", cart.TOTAL);
            int x = cart.items.Count;
            usc_order_checkout[] items = new usc_order_checkout[x];
            for (int i = 0; i < x; i++)
            {
                items[i] = new usc_order_checkout();
                items[i].PR_QUANTITY = cart.items[i].QUANTITY.ToString();
                items[i].pr_name = cart.items[i].PRODUCT_NAME;
                items[i].pr_price = String.Format("{0:#,###,###.##}", cart.items[i].UNIT_PRICE);
                items[i].pr_image = Image.FromStream(getphoto(cart.items[i].PRODUCT_ID.ToString(), i));
                items[i].pr_shipping = cart.items[i].SHIPPING;
                items[i].pr_soldby = cart.items[i].SUPPLIER_NAME;
                items[i].pr_condition = cart.items[i].CONDITION;

                if (fnl_order.Controls.Count < 0)
                {
                    fnl_order.Controls.Clear();

                }
                else
                    fnl_order.Controls.Add(items[i]);
            }
        }
        #endregion
        private void fr_checkout_Load(object sender, EventArgs e)
        {
         
            cart.Getotal();
            lbl_subtotal.Text = String.Format("{0:#,###,###.##}", cart.SUBTOTAL);
            
            load_data();
            fill_shipping();

        }
        List<string> suppliers = new List<string>();

        public void fill_shipping()
        {


            shipping[] items = new shipping[cart.items.Count];
            for (int j = 0; j < cart.items.Count; j++)
            {
                if (j > 0 && j < 6)
                {
                    pnl_all_total.Height += 32;
                    pnl_total.Location = new System.Drawing.Point(pnl_total.Location.X, pnl_total.Location.Y + 32);
                    BTN_PLACE_ORDER.Location = new System.Drawing.Point(BTN_PLACE_ORDER.Location.X, BTN_PLACE_ORDER.Location.Y + 32);
                    BTN_BACK_TO_CART.Location = new System.Drawing.Point(BTN_BACK_TO_CART.Location.X, BTN_BACK_TO_CART.Location.Y + 32);
                    fnl_shipping.Height += 32;
                }
                bool exist = suppliers.Contains(cart.items[j].SUPPLIER_NAME.Trim());
               if (!exist)
                {
                    suppliers.Add(cart.items[j].SUPPLIER_NAME.Trim());

                    items[j] = new shipping();
                    items[j].fill(cart.items[j].SUPPLIER_NAME.Trim(), cart.items[j].SHIPPING);


                    if (fnl_shipping.Controls.Count < 0)
                    {
                        fnl_shipping.Controls.Clear();
                    }
                    else
                        fnl_shipping.Controls.Add(items[j]);
                }
            }
        }
        private void BTN_BACK_TO_CART_Click(object sender, EventArgs e)
        {
            fr_customer f = fr_customer.getinstance();
            f.cart_refresh();
            fr_employee emp = fr_employee.getinstance();
            emp.cart_refresh();
        }
        
        #region drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void fr_checkout_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void rbtn_my_balance_Click(object sender, EventArgs e)
        {
            payment = "Balance";

            lbl_total.Text =  String.Format("{0:#,###,###.##}", order.getorder_total(payment));
        }

        private void rbtn_cod_Click(object sender, EventArgs e)
        {
            payment = "Cash on Delivery";
            lbl_total.Text = String.Format("{0:#,###,###.##}", order.getorder_total(payment));
        }
        fr_customer f = fr_customer.getinstance();
        fr_employee emp = fr_employee.getinstance();
        #region place order
        private void BTN_PLACE_ORDER_Click(object sender, EventArgs e)
        { if(rbtn_cod.Checked==false && rbtn_my_balance.Checked == false)
            {
                lbl_payment_empty.Visible = true;
            }
            else
            {
                lbl_payment_empty.Visible = false;
                if (rbtn_my_balance.Checked == true)
                {
                    if (order.getorder_total("Balance") > cust.BALANCE)
                    {
                        lbl_payment_empty.Visible = true;
                        lbl_payment_empty.Text = "Balance is not enough";
                        
                    }
                    else
                    {
                        place_order("Balance");
                        cust.BALANCE = cust.BALANCE - int.Parse(order.getorder_total("Balance").ToString());
                        balance_update();
                        this.Close();
                        f.thanks();
                        cart.items.Clear();
                        f.fn_Reset();
                    }
                }
                else
                {
                    place_order("Cash on Delivery");
                    this.Close();

                    f.thanks();
                    emp.thanks();
                    cart.items.Clear();
                    f.fn_Reset();

                }
            }
            
        }

        #endregion

        //balance update function
        public void balance_update()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("update customers set Balance ='"+cust.BALANCE+ "' where Customer_ID='"+cust.CUST_ID+"'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //place order function
        public void place_order(string payment)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into orders (Customer_orders_ID,Order_Date,Total,status,payment)values('"+cust.CUST_ID+"','"+DateTime.Now+"','"+order.getorder_total(payment)+"','Pending','"+payment+"')", cn);
            cmd.ExecuteNonQuery();


            SqlCommand c = new SqlCommand("select SCOPE_IDENTITY()", cn);
            int order_id = int.Parse(c.ExecuteScalar().ToString());
            order_ID = order_id;
            for(int i = 0; i < cart.items.Count; i++)
            {
                SqlCommand d = new SqlCommand("insert into Order_Item (Order_order_items_ID,Product_order_item_ID,Quantity)values('" + order_id+ "','" + cart.items[i].PRODUCT_ID+ "','" + cart.items[i].QUANTITY + "')", cn);
                d.ExecuteNonQuery();
            }
            cn.Close();
        }

        
    }
}

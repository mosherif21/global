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
    public partial class Fr_orders : Form
    {
        //sql connection
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection cn = new SqlConnection(connection);
        SqlConnection cn2 = new SqlConnection(connection);
        SqlConnection cn3 = new SqlConnection(connection);
        
        #region get photo from database
        public MemoryStream getphoto(string product_id, int j)
        {
            cn3.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn3;
            cmd.CommandText = "select photo from products where Product_ID='" + product_id + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn3.Close();
            MemoryStream ms = new MemoryStream { };
            byte[] P = (byte[])(ds.Tables[0].Rows[0]["photo"]);
            ms = new MemoryStream(P);
            return ms;
        }
        #endregion
        public Fr_orders()
        {
            InitializeComponent();
        }
        #region display orders
        cls_customer cust = cls_customer.initiatecustomer();
        private void initiate_orders()
        {
            int f;
            int j = 0;
            int i = 0;
            cn.Open();
            cn2.Open();
            SqlCommand cmd = new SqlCommand("select * from orders where Customer_orders_ID ='" + cust.CUST_ID + "'", cn);
            SqlDataReader cust_reader;
            cust_reader = cmd.ExecuteReader();
            List<int> order_ids = new List<int>();
            while (cust_reader.Read())
            {
                order_ids.Add(int.Parse(cust_reader[0].ToString()));
            }
            
        
            usc_orders[] usc_My_Orders = new usc_orders[order_ids.Count];
            cls_orders orders = new cls_orders();
            if (order_ids.Count == 0)
                pnl_empty_orders.Visible = true;
            else { 
                
            for (f = 0; f < order_ids.Count; f++)
            {
                SqlDataAdapter data = new SqlDataAdapter("select Product_ID,Product_Name , shipping,condition , Supplier_Name,price , Quantity,status,Order_Date,Total,payment ,Order_ID from  Orders,Order_Item , customers , Products , Suppliers where Product_ID = Product_order_item_ID  and Supplier_ID = Supplier_products_ID and Order_order_items_ID=Order_ID and Customer_ID ='" + cust.CUST_ID + "' and order_id='" + order_ids[j] + "'", cn2);
                DataTable da2 = new DataTable();
                data.Fill(da2);
                usc_My_Orders[f] = new usc_orders();
                for (i = 0; i < da2.Rows.Count; i++)
                {

                    orders.order_Items.Insert(i, new cls_order_item
                    {
                        PRODUCT_ID = int.Parse(da2.Rows[i][0].ToString()),
                        PRODUCT_NAME = da2.Rows[i][1].ToString(),
                        SHIPPING = da2.Rows[i][2].ToString(),
                        CONDITION = da2.Rows[i][3].ToString(),
                        SUPPLIER_NAME = da2.Rows[i][4].ToString(),
                        UNIT_PRICE = int.Parse(da2.Rows[i][5].ToString()),
                        QUANTITY = int.Parse(da2.Rows[i][6].ToString())
                    });

                }
                usc_order_checkout[] _Checkout = new usc_order_checkout[orders.order_Items.Count];
                for (int k = 0; k < orders.order_Items.Count; k++)
                {
                    _Checkout[k] = new usc_order_checkout();
                    _Checkout[k].PR_QUANTITY = orders.order_Items[k].QUANTITY.ToString();
                    _Checkout[k].pr_image = Image.FromStream(getphoto(orders.order_Items[k].PRODUCT_ID.ToString(), k));
                    _Checkout[k].pr_name = orders.order_Items[k].PRODUCT_NAME;
                    _Checkout[k].pr_price = String.Format("{0:#,###,###.##}", orders.order_Items[k].UNIT_PRICE);
                    _Checkout[k].pr_condition = orders.order_Items[k].CONDITION;
                    _Checkout[k].PR_QUANTITY = orders.order_Items[k].QUANTITY.ToString();
                    _Checkout[k].pr_shipping = orders.order_Items[k].SHIPPING;
                    _Checkout[k].pr_soldby = orders.order_Items[k].SUPPLIER_NAME;
                }
                usc_My_Orders[f].add_order_items(_Checkout);
                usc_My_Orders[f].STATUS = da2.Rows[0][7].ToString();
                usc_My_Orders[f].ORDER_DATE = DateTime.Parse(da2.Rows[0][8].ToString());
                usc_My_Orders[f].TOTAL = double.Parse(da2.Rows[0][9].ToString());
                usc_My_Orders[f].PAYMENT = da2.Rows[0][10].ToString();
                usc_My_Orders[f].ORDER_ID = int.Parse(da2.Rows[0][11].ToString());
                usc_My_Orders[f].RECEPIENT = cust.FIRST_NAME + " " + cust.LAST_NAME;
                orders.order_Items.Clear();
                if (fnl_orders.Controls.Count < 0)
                {
                    fnl_orders.Controls.Clear();

                }
                else
                    fnl_orders.Controls.Add(usc_My_Orders[f]);

                j++;

            }
        }
            cn.Close();
            cn2.Close();

        }
#endregion
        private void Fr_orders_Load(object sender, EventArgs e)
        {
            initiate_orders();

        }
    }

    internal class Dataview
    {
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.Properties;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Runtime;
using System.IO;

namespace project
{
    public partial class usc_products : UserControl
    {
        //database connection
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);

        #region variables and properties
        private int product_id;
        private string product_name;
        private string supplier_name;
        private string price;
        private string shipping;
        private string condition;
        private Image pic;
        private string quantity;
        private int current_index;
        private static Color current_theme_color;
      public static Color COLOR
        {
            get { return current_theme_color; }
            set { current_theme_color = value; }
        }
        public int CURRENT_INDEX
        {
            get { return current_index; }
            set { current_index = value; }
        } 
        public int PRODUCT_ID
        {
            get { return product_id; }
            set { product_id = value; }
        }
        public Image PIC
        {
            get { return pic; }
            set { pic = value; pic_product.Image = value; }
        }
        public string PRODUCT_NAME
        {
            get { return product_name; }
            set { product_name = value; lbl_product_name.Text = value; }
        }
        public string QUANTITY
        {
            get { return quantity; }
            set { quantity = value; cmb_quantity.Text = value; }
        }
        public string SUPPLIER_NAME
        {
            get { return supplier_name; }
            set { supplier_name = value; lbl_sold_by.Text = value; }
        }
        public string PRICE
        {
            get { return price; }
            set { price = value; lbl_product_price.Text = lbl_product_price.Text = String.Format("{0:#,###,###.##}", value);
                lbl_product_price.ForeColor = current_theme_color;
                lbl_unit.ForeColor = current_theme_color;
            }
            
        }
        public string SHIPPING
        {
            get { return shipping; }
            set { shipping = value; lbl_shipping.Text = value; }
        }
        public string CONDITION
        {
            get { return condition; }
            set { condition = value; lbl_condition.Text = value; }
        }
        #endregion

        public usc_products()
        {
            InitializeComponent();
        }
        //button add to cart
        fr_customer f = fr_customer.getinstance();
        private void btn_add_to_cart_Click_1(object sender, EventArgs e)
        {
           
            cls_cart cart = cls_cart.initiatecart();
          
            int x = cart.items.Count;
            bool exist = false;

            int i = 0;
            x = cart.items.Count;
            while (i < x) {
                if (cart.items[i].PRODUCT_NAME == lbl_product_name.Text)
                {
                    int f = int.Parse(cmb_quantity.Text);

                    cart.items[i].QUANTITY += f;

                    if (cart.items[i].QUANTITY > 10)
                        cart.items[i].QUANTITY = 10;

                    exist = true;

                }

                i++;
            }

            if (exist == false)
            {
                con.Open();
                SqlCommand cmd_prod = new SqlCommand("select Product_ID,Product_Name,shipping,condition,Supplier_Name,price from Products,Suppliers where Supplier_ID=Supplier_products_ID and Product_Name='"+lbl_product_name.Text+"'", con);
                SqlDataReader prods;
                prods = cmd_prod.ExecuteReader();
                while (prods.Read())
                {
                    cart.items.Insert(x, new cls_order_item
                    {
                        PRODUCT_ID = int.Parse(prods[0].ToString()),
                        PRODUCT_NAME = prods[1].ToString(),
                        SHIPPING = prods[2].ToString(),
                        SUPPLIER_NAME = prods[4].ToString(),
                        UNIT_PRICE = int.Parse(prods[5].ToString()),
                        CONDITION = prods[3].ToString(),
                        QUANTITY = int.Parse(cmb_quantity.Text)
                        
                    });
                    
                }
                con.Close();
            }
            f.fn_cart_number();
        }
    

        //button add to favorites
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            cls_favorites fav = cls_favorites.initiatefavorites();
           
            bool exist = false;
       
            int i = 0;
           int x = fav.pro.Count;
            while (i < x)
            {
                if (fav.pro[i].PRODUCT_NAME == lbl_product_name.Text)
                {
                    exist = true;
                }
                i++;
            }
            if (exist == false)
            {
                con.Open();
                SqlCommand cmd_prod = new SqlCommand("select Product_ID,Product_Name,shipping,condition,Supplier_Name,price from Products,Suppliers where Supplier_ID=Supplier_products_ID and Product_Name='" + lbl_product_name.Text + "'", con);
                SqlDataReader prods;
                prods = cmd_prod.ExecuteReader();
                while (prods.Read())
                {
                    fav.fill_favorite_products(x,

                   int.Parse(prods[0].ToString()),
                       prods[1].ToString(),
                  prods[2].ToString(),
                   prods[3].ToString(),
                    int.Parse(prods[5].ToString()),
                   prods[4].ToString()
         );
                }
               
                cls_customer customer = cls_customer.initiatecustomer();
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into favorites ( customer_favorites_id,products_favorites_id) values('" + customer.CUST_ID + "' ,'" + PRODUCT_ID + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //button add to favorites events for gui
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icon_heart;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icons8_heart_24;
        }
       
    }
}

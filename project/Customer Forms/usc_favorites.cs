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
using System.Runtime;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

namespace project
{
    public partial class usc_favorites : UserControl
    {
        //database connection
     
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);

        public usc_favorites()
        {
            InitializeComponent();
        }

        #region variables and properties
        private int product_id;
        private string product_name;
        private string supplier_name;
        private string price;
        private string shipping;
        private string condition;
        private Image pic;
        private int current_index;
        private static Color current_theme_color;
        public static Color COLOR
        {
            get { return current_theme_color; }
            set { current_theme_color = value; }
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
        public string SUPPLIER_NAME
        {
            get { return supplier_name; }
            set { supplier_name = value; lbl_sold_by.Text = value; }
        }
        public string PRICE
        {
            get { return price; }
            set { price= value; lbl_product_price.Text = lbl_product_price.Text = String.Format("{0:#,###,###.##}", value);
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
        fr_customer f = fr_customer.getinstance();

        //btn add to cart
        cls_favorites fav = cls_favorites.initiatefavorites();
        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {
          
            cls_cart cart = cls_cart.initiatecart();
          
            
            bool check = false;
        
            int i = 0;
            int x = cart.items.Count;
            while (i < x)
            {
                if (cart.items[i].PRODUCT_NAME == lbl_product_name.Text)
                {
                    
                    check = true;
                }
                i++;
            }
            if (check == false)
                cart.items.Insert(x, new cls_order_item
                {
                    PRODUCT_ID = fav.pro[CURRENT_INDEX].PRODUCT_ID,
                    PRODUCT_NAME =
                          fav.pro[CURRENT_INDEX].PRODUCT_NAME,
                    SHIPPING = fav.pro[CURRENT_INDEX].SHIPPING,
                    CONDITION = fav.pro[CURRENT_INDEX].CONDITION,
                    UNIT_PRICE
                          = fav.pro[CURRENT_INDEX].UNIT_PRICE,
                    SUPPLIER_NAME = fav.pro[CURRENT_INDEX].SUPPLIER_NAME,
                    QUANTITY = 1
                });
            f.fn_cart_number();
        }

        private void usc_favorites_Load(object sender, EventArgs e)
        { 
        }

        
        //delete from favorites
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cls_customer customer = cls_customer.initiatecustomer();
            if(CURRENT_INDEX>=0 && fav.pro.Count!= 0 && CURRENT_INDEX < fav.pro.Count)
            fav.pro.RemoveAt(CURRENT_INDEX);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from favorites where customer_favorites_id='" +customer.CUST_ID  + "' and products_favorites_id='"+ PRODUCT_ID +"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fr_customer f = fr_customer.getinstance();
            f.fav_refresh();
        }
        
        
        
        //delete from favorite events for gui
       private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icon_bin;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icons8_trash_can_24;
        }

    }
}

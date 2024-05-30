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
    public partial class usc_cart_products : UserControl
    {
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);

        public usc_cart_products()
        {
            InitializeComponent();
        }

        #region properties and variables
        private int product_id;
        private string product_name;
        private string shipping;
        private Image image;
        private string product_price;
        private string sold_by;
        private string condition;
        private int pr_quantity;
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
        public string pr_name

        {
            get { return product_name; }
            set { product_name = value; lbl_product_name.Text = value; }
        }


        public string pr_price

        {
            get { return product_price; }
            set { product_price = value; lbl_product_price.Text = value;
                lbl_product_price.ForeColor = current_theme_color;
                lbl_unit.ForeColor = current_theme_color;
            }
        }
        public int PR_QUANTITY

        {
            get { return pr_quantity; }
            set { pr_quantity = value; cmb_quantity.Text = value.ToString(); }
        }

        public string pr_soldby

        {
            get { return sold_by; }
            set { sold_by = value; lbl_sold_by.Text = value; }
        }



        public string pr_condition
        {
            get { return condition; }
            set { condition = value; lbl_condition.Text = value; }
        }



        public string pr_shipping
        {
            get { return shipping; }
            set { shipping = value; lbl_shipping.Text = value; }
        }


        public Image pr_image
        {
            get { return image; }
            set { image = value; pic_product.Image = value; }
        }


        #endregion

        #region buttons color change
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.icon_heart;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.icons8_heart_24;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icon_bin;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icons8_trash_can_24;
        }

        #endregion
       fr_customer f = fr_customer.getinstance();
       fr_employee emp = fr_employee.getinstance();
        cls_cart cart = cls_cart.initiatecart();
        //delete this product from cart
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (CURRENT_INDEX >= 0 && cart.items.Count != 0 && CURRENT_INDEX < cart.items.Count)
            {
                cart.items.RemoveAt(CURRENT_INDEX);
                emp.cart_refresh();
                f.cart_refresh();
                f.fn_cart_number();
            }
        }


        //add this product to favorites
       
        private void pictureBox2_Click(object sender, EventArgs e)
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
                fav.fill_favorite_products(x,

                   cart.items[CURRENT_INDEX].PRODUCT_ID,
                       cart.items[CURRENT_INDEX].PRODUCT_NAME,
                  cart.items[CURRENT_INDEX].SHIPPING,
                  cart.items[CURRENT_INDEX].CONDITION,
                    cart.items[CURRENT_INDEX].UNIT_PRICE,
                    cart.items[CURRENT_INDEX].SUPPLIER_NAME
            );
                cls_customer customer = cls_customer.initiatecustomer();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into favorites ( customer_favorites_id,products_favorites_id) values('" + customer.CUST_ID + "' ,'" + PRODUCT_ID + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }




        private void pnl_cart_products_Paint(object sender, PaintEventArgs e)
        {

        }
        //change quantity from cart event
        private void cmb_quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                

            
            
        }

        private void cmb_quantity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cls_cart carts = cls_cart.initiatecart();
     
                cart.items[CURRENT_INDEX].QUANTITY = int.Parse(cmb_quantity.Text);


            if (fr_favorites.cart_done == true)
            {
              
                f.cart_refresh();

            }
        }
    }
}

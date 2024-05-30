using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class usc_order_checkout : UserControl
    {
        #region fields
        private string product_name;
        private string shipping;
        private Image image;
        private string product_price;
        private string sold_by;
        private string condition;
        private string pr_quantity;
        #endregion

        #region properties
        private static Color current_theme_color;
        public static Color COLOR
        {
            get { return current_theme_color; }
            set { current_theme_color = value; }
        }
        public string pr_name

        {
            get { return product_name; }
            set { product_name = value; lbl_product_name.Text = value; }
        }


        public string pr_price

        {
            get { return product_price; }
            set { product_price = value; lbl_product_price.Text = lbl_product_price.Text = String.Format("{0:#,###,###.##}", value);
                lbl_product_price.ForeColor = current_theme_color;
                lbl_unit.ForeColor = current_theme_color;

            }
        }
        public string PR_QUANTITY

        {
            get { return pr_quantity; }
            set { pr_quantity = value; lbl_quantity.Text = value; }
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
        public usc_order_checkout()
        {
            InitializeComponent();
        }

        private void pnl_cart_products_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

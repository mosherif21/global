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
    public partial class shipping : UserControl
    {
        
        public void fill(string supp_name, string shipping)
        {
             lbl_supplier.Text = supp_name + ": ";

                if (shipping == "Free")
                {

                    lbl_price.Text = "Free";
                    lbl_currency.Visible = false;
                }
                else
                {
                    lbl_price.Text = " 30";
                }
                fn();

            
        }
    public void fn()
        {
            if (lbl_supplier.Width > 90)
            {
                int n = lbl_supplier.Width - 80;
                this.Width += n;
                lbl_price.Location = new System.Drawing.Point(lbl_price.Location.X + n, lbl_price.Location.Y);
                lbl_currency.Location = new System.Drawing.Point(lbl_currency.Location.X + n-10, lbl_currency.Location.Y);
            }

        }

        public shipping()
        {
            
       
            
            InitializeComponent();
        }
    }
}

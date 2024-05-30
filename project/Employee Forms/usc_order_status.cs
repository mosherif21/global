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
    public partial class usc_order_status : UserControl
    {
        #region variables and properties
        private DateTime order_date;
        private string recepient;
        private int order_id;
        private string status;
        private string payment;
        private double total;
        public void add_order_items(usc_order_checkout[] s)
        {
            for (int l = 0; l < s.Length; l++)
            {
                fnl_order_order_items.Controls.Add(s[l]);
            }
        }
        public double TOTAL
        {
            get { return total; }
            set { total = value; lbl_order_total.Text = String.Format("{0:#,###,###.##}", value); }
        }
        public DateTime ORDER_DATE
        {
            get { return order_date; }
            set { order_date = value; lbl_order_date.Text = value.ToString(); }
        }
        public string RECEPIENT
        {
            get { return recepient; }
            set { recepient = value; lbl_customer_name.Text = value.ToString(); }
        }

        public string PAYMENT
        {
            get { return payment; }
            set { payment = value; lbl_payment_method.Text = value.ToString(); }
        }

        public string STATUS
        {
            get { return status; }
            set
            {
                status = value;
                lbl_order_status.Text = value.ToString();

                if (lbl_order_status.Text.Trim() == "Delivered")
                {

                    lbl_order_status.ForeColor = Color.Green;


                }

                else if (lbl_order_status.Text.Trim() == "Pending")
                {

                    lbl_order_status.ForeColor = Color.DarkGoldenrod;


                }
                else
                    lbl_order_status.ForeColor = Color.Red;
            }
        }
        public int ORDER_ID
        {
            get { return order_id; }
            set { order_id = value; lbl_order_id.Text = value.ToString(); }
        }
        #endregion

        public usc_order_status()
        {
            InitializeComponent();
        }
    }
}

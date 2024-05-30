using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class usc_orders : UserControl
    {   //database connection
        
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);

        #region variables and properties
        private DateTime order_date;
        private string recepient;
        private int order_id;
        private string status;
        private string payment;
        private double total;
        private bool ret=false;

        public void add_order_items(usc_order_checkout[] s)
        {
            for (int l = 0; l < s.Length; l++)
            {
                fnl_order_order_items.Controls.Add(s[l]);
            }
        }
        public bool RET
        {
            get { return ret; }
            set { ret = value; }
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
        public usc_orders()
        {
            InitializeComponent();
        }
 

        private void usc_orders_Load(object sender, EventArgs e)
        {
            btn_return.Visible = false;
            btn_cancel.Visible = false;

            if (lbl_order_status.Text.Trim() == "Delivered")
                btn_return.Visible = true;
            if (lbl_order_status.Text.Trim() == "Pending")
                btn_cancel.Visible = true;
        }
        fr_customer f = fr_customer.getinstance();
        fr_employee emp = fr_employee.getinstance();
        //button return order
        private void btn_return_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Orders set status ='Returned' where Order_ID='" + ORDER_ID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
           
            f.refresh_orders();
            emp.refresh_orders();
        }

        //button cancel order
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Orders set status ='Canceled' where Order_ID='" + ORDER_ID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            f.refresh_orders();
           emp.refresh_orders();
        }
    }
}

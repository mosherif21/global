using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Fr_balance : Form
    {
        public Fr_balance()
        {
            InitializeComponent();
        }

        private void Fr_balance_Load(object sender, EventArgs e)
        {
            cls_customer cust = cls_customer.initiatecustomer();
            if (cust.BALANCE == 0)
                lbl_balance.Text = 0.ToString();
            else
            lbl_balance.Text = String.Format("{0:#,###,###.##}", cust.BALANCE);
        }
    }
}

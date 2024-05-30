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
    public partial class fr_thanks : Form
    {
        public fr_thanks()
        {
            InitializeComponent();
        }

        private void fr_thanks_Load(object sender, EventArgs e)
        {
            lbl_order_id.Text = fr_checkout.order_ID.ToString();
        }
    }
}

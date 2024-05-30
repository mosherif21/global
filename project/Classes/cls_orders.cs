using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace project
{
    class cls_orders
    {

      
        public List<cls_order_item> order_Items = new List<cls_order_item> { };
        
        public cls_cart cart = cls_cart.initiatecart();

        #region variables and properties
        private double order_total;
        private DateTime date;
        private double ordr_total;
        private string status;
        private string payment;
        private int order_id;
        public int ORDER_ID
        {
            get { return order_id; }
            set
            {
                order_id = value;
            }
        }

     
        public double ORDER_TOTAL
        {
            get { return ordr_total; }
            set
            {
                ordr_total = value;
            }
        }
        public string STATUS
        {
            get { return status; }
            set
            {
                status = value;
            }
        }
        public string PAYMENT
        {
            get { return payment; }
            set
            {
                payment = value;
            }
        }
        public DateTime DATE
        {
            get { return date; }
            set
            {
                date = value;
            }
        }
         #endregion
        

        #region get total
        public double getorder_total(string payment)
        {
          
            if (string.Compare(payment, "Balance") == 0)
                order_total = cart.TOTAL;
            else
                order_total = cart.TOTAL + 5;
            return order_total;
        }
        #endregion
    }
}


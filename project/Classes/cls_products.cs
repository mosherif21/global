using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace project
{
    class cls_products
    {
       public cls_products()
        {

        }

        #region variables
        private int product_id;
        private string product_name;
        private string shipping;
        private string condition;
        private string supplier_name;
        private float unitprice;
        #endregion
       
        #region properties
        public int PRODUCT_ID
        {
            get { return product_id; }
            set
            {
                product_id = value;
            }
        }
        public float UNIT_PRICE
        {
            get { return unitprice; }
            set
            {
                unitprice = value;
            }
        }
        public string SUPPLIER_NAME
        {
            get { return supplier_name; }
            set
            {
                supplier_name = value;
            }
        }
        public string PRODUCT_NAME
        {
            get { return product_name; }
            set
            {
                product_name = value;
            }
        }
        public string SHIPPING
        {
            get { return shipping; }
            set
            {
                shipping = value;
            }
        }
        public string CONDITION
        {
            get { return condition; }
            set
            {
                condition = value;
            }
        }

        #endregion

    }
}

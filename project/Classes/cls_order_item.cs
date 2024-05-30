using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class cls_order_item : cls_products
    {
        public cls_order_item()
        {

        }

        #region variables and properties

        private int quantity=0;
      
        public int QUANTITY
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class cls_cart
    {

        #region singleton
        private static List<cls_cart> instance = new List<cls_cart> { new cls_cart() };
        private static int j = 0;
        public static void reset_instance()
        {   j++;
            instance.Insert(j, new cls_cart());
           
        }
        public static cls_cart initiatecart()
        {
            
            return instance[j];
        }

      
        #endregion

        public List<cls_order_item> items = new List<cls_order_item> { };


        #region variables and properties
        private double total;
        private double subtotal;
        public double TOTAL
        {
            get { return total; }
            set {
                total = value;
            }
        }
        public double SUBTOTAL
        {
            get { return subtotal; }
            set {
               subtotal = value;
            }
        }
        #endregion


        #region get total
         List<string> suppliers;


        public void Getotal()
        {

            suppliers = new List<string>();
            TOTAL = SUBTOTAL;
            for (int i = 0; i < items.Count; i++)
            {

                
                bool exist = suppliers.Contains(items[i].SUPPLIER_NAME.Trim());
           
                if (!exist)
                {


                    suppliers.Add(items[i].SUPPLIER_NAME.Trim());

                    if (string.Compare(items[i].SHIPPING, "Paid") == 0)
                        TOTAL += 30;
                }
            }

               
            
          
        }
        #endregion

           #region get subtotal


        public void Gesubtotal()
        {
            SUBTOTAL = 0;
            for (int i = 0; i < items.Count; i++)
            {
            
                  SUBTOTAL += (items[i].QUANTITY * items[i].UNIT_PRICE);
            }
            
        
        }
        #endregion 
     


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class cls_favorites
    {
        #region singleton
        private static List<cls_favorites> instance = new List<cls_favorites> { new cls_favorites() };
        private static int j = 0;
        public static void reset_instance()
        { j++;
            instance.Insert(j, new cls_favorites());
           
        }
        public static cls_favorites initiatefavorites()
        {
            
            return instance[j];
        }

      
        #endregion

        public List<cls_products> pro = new List<cls_products> { };

        #region fill favorites
        public void fill_favorite_products(int i,int aid,string aname,string ashipp,string asupp_n,float price,string cond)
        {
            pro.Insert(i, new cls_products { PRODUCT_ID = aid, PRODUCT_NAME = aname, SHIPPING = ashipp, SUPPLIER_NAME = asupp_n, UNIT_PRICE = price, CONDITION = cond });         
        }
        #endregion
    }
}

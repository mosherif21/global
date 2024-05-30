using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class coupons
    {
     
        #region variables and propeties
        private string coupon_code;
        private int percent;
        public string COUPON
        {
            get { return coupon_code; }
            set
            {
                coupon_code = value;
            }
        }
        public int PERCENT
        {
            get { return percent; }
            set
            {
                percent = value;
            }
        }
        #endregion

      
    }
}

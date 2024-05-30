using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Fr_cust_favorites : Form
    {

        //sql connection
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);
        SqlConnection cn = new SqlConnection(connection);

        public Fr_cust_favorites()
        {
            InitializeComponent();
            
         }
        #region get photo from database
        public MemoryStream getphoto(string product_id, int j)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select photo from products where Product_ID='" + product_id + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            MemoryStream ms = new MemoryStream { };
            byte[] P = (byte[])(ds.Tables[0].Rows[0]["photo"]);
            ms = new MemoryStream(P);
            return ms;
        }
        #endregion


        public void Fr_cust_favorites_Load(object sender, EventArgs e)
        {
            pnl_favorites_empty.Visible = false;
            data_load(); 
        }
        #region load favorites
        public void data_load()
        {
         
            cls_favorites fav = cls_favorites.initiatefavorites();
            usc_favorites[] items = new usc_favorites[fav.pro.Count];
            if(fav.pro.Count==0)
            pnl_favorites_empty.Visible = true;

            if (fav.pro.Count > 0)
            {
                pnl_favorites_empty.Visible = false;
                for (int j = 0; j < fav.pro.Count; j++)
                {
                    items[j] = new usc_favorites();
                    items[j].PRODUCT_ID = fav.pro[j].PRODUCT_ID;
                    items[j].PIC = Image.FromStream(getphoto(fav.pro[j].PRODUCT_ID.ToString(), j));
                    items[j].PRODUCT_NAME = fav.pro[j].PRODUCT_NAME;
                    items[j].SUPPLIER_NAME = fav.pro[j].SUPPLIER_NAME;
                    items[j].PRICE = String.Format("{0:#,###,###.##}", fav.pro[j].UNIT_PRICE);
                    items[j].SHIPPING = fav.pro[j].SHIPPING;
                    items[j].CONDITION = fav.pro[j].CONDITION;
                    items[j].CURRENT_INDEX = j;

                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else
                        flowLayoutPanel1.Controls.Add(items[j]);
                }
            }
        }
        #endregion
    }
}

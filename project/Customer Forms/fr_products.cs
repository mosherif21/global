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
    public partial class fr_products : Form
    {
        //sql connection
        static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);
        SqlConnection cn = new SqlConnection(connection);

        public fr_products()
        {
            InitializeComponent();
        }

        #region products load
        private void fr_products_Load(object sender, EventArgs e)
        {
            int i = 0;
            con.Open();
            SqlCommand cmd_prod = new SqlCommand("select Product_ID,Product_Name,shipping,condition,Supplier_Name,price from Products,Suppliers where Supplier_ID=Supplier_products_ID", con);
            SqlDataReader prod;
            prod = cmd_prod.ExecuteReader();
            #region
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;           
            cmd.CommandText = "select photo from products";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            MemoryStream ms = new MemoryStream { };
            #endregion


           
             List<cls_products> pr = new List<cls_products> { };
            while (prod.Read())
            {
             pr.Insert(i, new cls_products { PRODUCT_ID = int.Parse(prod[0].ToString()), PRODUCT_NAME = prod[1].ToString(), SHIPPING = prod[2].ToString(), SUPPLIER_NAME = prod[4].ToString(), UNIT_PRICE = int.Parse(prod[5].ToString()), CONDITION = prod[3].ToString()
             });

                i++;
            }
            
           usc_products[] items = new usc_products[i];
            for (int j = 0; j < i; j++)
            {           
                items[j] = new usc_products();               
                byte[] P = (byte[])(ds.Tables[0].Rows[j]["photo"]);
                ms = new MemoryStream(P);
                items[j].PRODUCT_ID = pr[j].PRODUCT_ID;
                items[j].PIC = Image.FromStream(ms);
                items[j].PRODUCT_NAME = pr[j].PRODUCT_NAME;
                items[j].SUPPLIER_NAME = pr[j].SUPPLIER_NAME;
                items[j].PRICE = String.Format("{0:#,###,###.##}",pr[j].UNIT_PRICE);
                items[j].SHIPPING = pr[j].SHIPPING;
                items[j].CONDITION = pr[j].CONDITION;
                items[j].CURRENT_INDEX = j;
                items[j].QUANTITY = 1.ToString();

                if (flpnl_products.Controls.Count < 0)
                {
                    flpnl_products.Controls.Clear();

                }
                else
                    flpnl_products.Controls.Add(items[j]);

            }
            ms.Close();

        }
        #endregion

        private void usc_products1_Load(object sender, EventArgs e)
        {

        }
    }
}

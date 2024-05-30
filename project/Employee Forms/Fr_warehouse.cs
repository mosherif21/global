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
    public partial class Fr_warehouse : Form
    {
        //database connection
       static string connection = sql_connection.sqlconnection_string();
        SqlConnection con = new SqlConnection(connection);
        SqlConnection cn = new SqlConnection(connection);

        public Fr_warehouse()
        {
            InitializeComponent();
        }
        private bool productconfirm;
        private void Fr_warehouse_Load(object sender, EventArgs e)
        {
            pnl_product.Visible = false;
            lbl_wrong.Visible = false;
          
        }

        //button search
        private void btn_cust_login_Click(object sender, EventArgs e)
        {
            #region get photo from database

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select photo from products where Product_Name='" + txt_product_name.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            MemoryStream ms = new MemoryStream { };
            #endregion
            productconfirm = false;
            con.Open();
            SqlCommand cmd_ = new SqlCommand("select * from Products where Product_Name='" + txt_product_name.Text + "'", con);
            SqlDataAdapter u = new SqlDataAdapter(cmd_);

            DataTable pro = new DataTable();

            u.Fill(pro);
            con.Close();
            if (pro.Rows.Count > 0)
            {

                productconfirm = true;
            }

            if (productconfirm == true)
            {
               
                lbl_wrong.Visible = false;
               
                con.Open();
                SqlCommand cmd_prod = new SqlCommand("select shipping,condition,Supplier_Name,price,available from Products,Suppliers,warehouse where Supplier_ID=Supplier_products_ID and Product_ID=product_warehouse_ID and Product_Name='" + txt_product_name.Text.Trim()+"'", con);
                SqlDataReader prod;
                prod = cmd_prod.ExecuteReader();
               
                while (prod.Read())
                {
                    lbl_product_name.Text = txt_product_name.Text.Trim();
                    lbl_shipping.Text = prod[0].ToString();
                    lbl_condition.Text = prod[1].ToString();
                    lbl_sold_by.Text= prod[2].ToString();
                    lbl_product_price.Text= String.Format("{0:#,###,###.##}", prod[3].ToString());
                    string ava= prod[4].ToString(); ;


                    if (ava.Trim() == "yes")
                    {

                        lbl_stock.ForeColor = Color.Green;
                        lbl_stock.Text = "In Stock";

                    }

                    else if (ava.Trim() == "no")
                    {

                        lbl_stock.ForeColor = Color.DarkGoldenrod;
                        lbl_stock.Text = "Out of Stock";

                    }

                }
                byte[] P = (byte[])(ds.Tables[0].Rows[0]["photo"]);
                ms = new MemoryStream(P);
                pic_product.Image = Image.FromStream(ms);
                ms.Close();
                con.Close();
                pnl_product.Visible = true;
            }
            else
            {
                lbl_wrong.Visible = true;
                pnl_product.Visible = false;
            }
        }
    }
}

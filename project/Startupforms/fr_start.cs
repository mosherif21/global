using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project
{
    public partial class fr_start : Form
    {
        public fr_start()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            fr_emp_login emp = new fr_emp_login();
            this.Hide();
            emp.ShowDialog();
        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void circle_button1_Click(object sender, EventArgs e)
        {
            fr_emp_login emp = new fr_emp_login();
            this.Hide();
            this.Close();
            emp.ShowDialog();
        }

        private void circle_button2_Click(object sender, EventArgs e)
        {
            fr_cust_login cust = new fr_cust_login();
            this.Hide();
            this.Close();
            cust.ShowDialog(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mouse(object sender, MouseEventArgs e)
        {
            if ((e.X >= 228 && e.X <= 323) && (e.Y >= 358 && e.Y <= 434))
            {

                label1.Text = "Employee";
            }
            else if ((e.X >= 465 && e.X <= 564) && (e.Y >= 358 && e.Y <= 434))
            {

                label2.Text = "Customer";
            }

            else
            {
                label1.Text = null;
                label2.Text = null;
            }
        }
        //drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void mousedown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_drag_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

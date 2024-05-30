namespace project
{
    partial class usc_orders
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_return = new System.Windows.Forms.Panel();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_order_status = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbl_order_total = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_payment_method = new System.Windows.Forms.Label();
            this.lbl_customer_name = new System.Windows.Forms.Label();
            this.lbl_order_id = new System.Windows.Forms.Label();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.fnl_order_order_items = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4.SuspendLayout();
            this.pnl_return.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnl_return);
            this.panel4.Controls.Add(this.lbl_order_status);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.lbl_order_total);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.lbl_payment_method);
            this.panel4.Controls.Add(this.lbl_customer_name);
            this.panel4.Controls.Add(this.lbl_order_id);
            this.panel4.Controls.Add(this.lbl_order_date);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.label31);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1012, 121);
            this.panel4.TabIndex = 16;
            // 
            // pnl_return
            // 
            this.pnl_return.Controls.Add(this.btn_return);
            this.pnl_return.Controls.Add(this.btn_cancel);
            this.pnl_return.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_return.Location = new System.Drawing.Point(844, 0);
            this.pnl_return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_return.Name = "pnl_return";
            this.pnl_return.Size = new System.Drawing.Size(168, 121);
            this.pnl_return.TabIndex = 16;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.DarkRed;
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.FlatAppearance.BorderSize = 0;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.Location = new System.Drawing.Point(28, 43);
            this.btn_return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(119, 50);
            this.btn_return.TabIndex = 14;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(28, 43);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(119, 50);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_order_status
            // 
            this.lbl_order_status.AutoSize = true;
            this.lbl_order_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_status.Location = new System.Drawing.Point(141, 73);
            this.lbl_order_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_status.Name = "lbl_order_status";
            this.lbl_order_status.Size = new System.Drawing.Size(59, 20);
            this.lbl_order_status.TabIndex = 13;
            this.lbl_order_status.Text = "label5";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(19, 74);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 20);
            this.label22.TabIndex = 11;
            this.label22.Text = "Order Status: ";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Location = new System.Drawing.Point(620, 79);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 15);
            this.label23.TabIndex = 10;
            this.label23.Text = "EGP";
            // 
            // lbl_order_total
            // 
            this.lbl_order_total.AutoSize = true;
            this.lbl_order_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_total.Location = new System.Drawing.Point(512, 75);
            this.lbl_order_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_total.Name = "lbl_order_total";
            this.lbl_order_total.Size = new System.Drawing.Size(53, 20);
            this.lbl_order_total.TabIndex = 9;
            this.lbl_order_total.Text = "label5";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(440, 75);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 20);
            this.label25.TabIndex = 8;
            this.label25.Text = "Total: ";
            // 
            // lbl_payment_method
            // 
            this.lbl_payment_method.AutoSize = true;
            this.lbl_payment_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment_method.Location = new System.Drawing.Point(597, 43);
            this.lbl_payment_method.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_payment_method.Name = "lbl_payment_method";
            this.lbl_payment_method.Size = new System.Drawing.Size(53, 20);
            this.lbl_payment_method.TabIndex = 7;
            this.lbl_payment_method.Text = "label5";
            // 
            // lbl_customer_name
            // 
            this.lbl_customer_name.AutoSize = true;
            this.lbl_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_name.Location = new System.Drawing.Point(541, 12);
            this.lbl_customer_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customer_name.Name = "lbl_customer_name";
            this.lbl_customer_name.Size = new System.Drawing.Size(53, 20);
            this.lbl_customer_name.TabIndex = 6;
            this.lbl_customer_name.Text = "label5";
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.AutoSize = true;
            this.lbl_order_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_id.Location = new System.Drawing.Point(108, 43);
            this.lbl_order_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(53, 20);
            this.lbl_order_id.TabIndex = 5;
            this.lbl_order_id.Text = "label6";
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.AutoSize = true;
            this.lbl_order_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.Location = new System.Drawing.Point(168, 11);
            this.lbl_order_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(59, 20);
            this.lbl_order_date.TabIndex = 4;
            this.lbl_order_date.Text = "label5";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(440, 11);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(89, 20);
            this.label30.TabIndex = 3;
            this.label30.Text = "Recepient:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(440, 43);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(144, 20);
            this.label31.TabIndex = 2;
            this.label31.Text = "Payment method: ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(19, 43);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(84, 20);
            this.label32.TabIndex = 1;
            this.label32.Text = "Order ID: ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(19, 11);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(139, 20);
            this.label33.TabIndex = 0;
            this.label33.Text = "Order placed on: ";
            // 
            // fnl_order_order_items
            // 
            this.fnl_order_order_items.AutoScroll = true;
            this.fnl_order_order_items.Dock = System.Windows.Forms.DockStyle.Top;
            this.fnl_order_order_items.Location = new System.Drawing.Point(0, 121);
            this.fnl_order_order_items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fnl_order_order_items.Name = "fnl_order_order_items";
            this.fnl_order_order_items.Size = new System.Drawing.Size(1012, 321);
            this.fnl_order_order_items.TabIndex = 17;
            // 
            // usc_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fnl_order_order_items);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "usc_orders";
            this.Size = new System.Drawing.Size(1012, 442);
            this.Load += new System.EventHandler(this.usc_orders_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnl_return.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_order_status;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbl_order_total;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbl_payment_method;
        private System.Windows.Forms.Label lbl_customer_name;
        private System.Windows.Forms.Label lbl_order_id;
        private System.Windows.Forms.Label lbl_order_date;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.FlowLayoutPanel fnl_order_order_items;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Panel pnl_return;
    }
}

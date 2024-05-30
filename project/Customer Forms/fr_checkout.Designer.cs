namespace project
{
    partial class fr_checkout
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_check = new System.Windows.Forms.Panel();
            this.pnl_all_total = new System.Windows.Forms.Panel();
            this.fnl_shipping = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_payment_empty = new System.Windows.Forms.Label();
            this.BTN_BACK_TO_CART = new System.Windows.Forms.Button();
            this.BTN_PLACE_ORDER = new System.Windows.Forms.Button();
            this.pnl_choose_payment = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtn_cod = new System.Windows.Forms.RadioButton();
            this.rbtn_my_balance = new System.Windows.Forms.RadioButton();
            this.fnl_order = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_total = new System.Windows.Forms.Panel();
            this.pnl_check.SuspendLayout();
            this.pnl_all_total.SuspendLayout();
            this.pnl_choose_payment.SuspendLayout();
            this.pnl_total.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_check
            // 
            this.pnl_check.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_check.Controls.Add(this.pnl_all_total);
            this.pnl_check.Controls.Add(this.lbl_payment_empty);
            this.pnl_check.Controls.Add(this.BTN_BACK_TO_CART);
            this.pnl_check.Controls.Add(this.BTN_PLACE_ORDER);
            this.pnl_check.Controls.Add(this.pnl_choose_payment);
            this.pnl_check.Controls.Add(this.fnl_order);
            this.pnl_check.Location = new System.Drawing.Point(0, 15);
            this.pnl_check.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_check.Name = "pnl_check";
            this.pnl_check.Size = new System.Drawing.Size(1271, 701);
            this.pnl_check.TabIndex = 9;
            // 
            // pnl_all_total
            // 
            this.pnl_all_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_all_total.Controls.Add(this.pnl_total);
            this.pnl_all_total.Controls.Add(this.fnl_shipping);
            this.pnl_all_total.Controls.Add(this.label4);
            this.pnl_all_total.Controls.Add(this.label6);
            this.pnl_all_total.Controls.Add(this.lbl_subtotal);
            this.pnl_all_total.Location = new System.Drawing.Point(867, 187);
            this.pnl_all_total.Name = "pnl_all_total";
            this.pnl_all_total.Size = new System.Drawing.Size(393, 200);
            this.pnl_all_total.TabIndex = 16;
            // 
            // fnl_shipping
            // 
            this.fnl_shipping.AutoScroll = true;
            this.fnl_shipping.Location = new System.Drawing.Point(4, 73);
            this.fnl_shipping.Margin = new System.Windows.Forms.Padding(4);
            this.fnl_shipping.Name = "fnl_shipping";
            this.fnl_shipping.Size = new System.Drawing.Size(383, 32);
            this.fnl_shipping.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(218, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "EGP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(22, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Subtotal:";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(111, 6);
            this.lbl_subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(92, 33);
            this.lbl_subtotal.TabIndex = 14;
            this.lbl_subtotal.Text = "117.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(30, 27);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(92, 33);
            this.lbl_total.TabIndex = 9;
            this.lbl_total.Text = "117.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(147, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "EGP";
            // 
            // lbl_payment_empty
            // 
            this.lbl_payment_empty.AutoSize = true;
            this.lbl_payment_empty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment_empty.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_payment_empty.Location = new System.Drawing.Point(898, 156);
            this.lbl_payment_empty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_payment_empty.Name = "lbl_payment_empty";
            this.lbl_payment_empty.Size = new System.Drawing.Size(249, 21);
            this.lbl_payment_empty.TabIndex = 11;
            this.lbl_payment_empty.Text = "Please choose a payment method";
            this.lbl_payment_empty.Visible = false;
            // 
            // BTN_BACK_TO_CART
            // 
            this.BTN_BACK_TO_CART.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_BACK_TO_CART.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_BACK_TO_CART.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BTN_BACK_TO_CART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BACK_TO_CART.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BACK_TO_CART.ForeColor = System.Drawing.Color.DimGray;
            this.BTN_BACK_TO_CART.Location = new System.Drawing.Point(939, 463);
            this.BTN_BACK_TO_CART.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_BACK_TO_CART.Name = "BTN_BACK_TO_CART";
            this.BTN_BACK_TO_CART.Size = new System.Drawing.Size(243, 27);
            this.BTN_BACK_TO_CART.TabIndex = 7;
            this.BTN_BACK_TO_CART.Text = "BACK TO CART";
            this.BTN_BACK_TO_CART.UseVisualStyleBackColor = false;
            this.BTN_BACK_TO_CART.Click += new System.EventHandler(this.BTN_BACK_TO_CART_Click);
            // 
            // BTN_PLACE_ORDER
            // 
            this.BTN_PLACE_ORDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(193)))), ((int)(((byte)(63)))));
            this.BTN_PLACE_ORDER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_PLACE_ORDER.FlatAppearance.BorderSize = 0;
            this.BTN_PLACE_ORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PLACE_ORDER.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PLACE_ORDER.ForeColor = System.Drawing.Color.White;
            this.BTN_PLACE_ORDER.Location = new System.Drawing.Point(939, 405);
            this.BTN_PLACE_ORDER.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_PLACE_ORDER.Name = "BTN_PLACE_ORDER";
            this.BTN_PLACE_ORDER.Size = new System.Drawing.Size(243, 50);
            this.BTN_PLACE_ORDER.TabIndex = 6;
            this.BTN_PLACE_ORDER.Text = "PLACE ORDER";
            this.BTN_PLACE_ORDER.UseVisualStyleBackColor = false;
            this.BTN_PLACE_ORDER.Click += new System.EventHandler(this.BTN_PLACE_ORDER_Click);
            // 
            // pnl_choose_payment
            // 
            this.pnl_choose_payment.Controls.Add(this.label3);
            this.pnl_choose_payment.Controls.Add(this.rbtn_cod);
            this.pnl_choose_payment.Controls.Add(this.rbtn_my_balance);
            this.pnl_choose_payment.Location = new System.Drawing.Point(902, 21);
            this.pnl_choose_payment.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_choose_payment.Name = "pnl_choose_payment";
            this.pnl_choose_payment.Size = new System.Drawing.Size(213, 126);
            this.pnl_choose_payment.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(53, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "(Additional 5 EGP)";
            // 
            // rbtn_cod
            // 
            this.rbtn_cod.AutoSize = true;
            this.rbtn_cod.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_cod.ForeColor = System.Drawing.Color.Black;
            this.rbtn_cod.Location = new System.Drawing.Point(25, 70);
            this.rbtn_cod.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_cod.Name = "rbtn_cod";
            this.rbtn_cod.Size = new System.Drawing.Size(168, 25);
            this.rbtn_cod.TabIndex = 1;
            this.rbtn_cod.TabStop = true;
            this.rbtn_cod.Text = "CASH ON DELIVERY";
            this.rbtn_cod.UseVisualStyleBackColor = true;
            this.rbtn_cod.Click += new System.EventHandler(this.rbtn_cod_Click);
            // 
            // rbtn_my_balance
            // 
            this.rbtn_my_balance.AutoSize = true;
            this.rbtn_my_balance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_my_balance.ForeColor = System.Drawing.Color.Black;
            this.rbtn_my_balance.Location = new System.Drawing.Point(25, 23);
            this.rbtn_my_balance.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_my_balance.Name = "rbtn_my_balance";
            this.rbtn_my_balance.Size = new System.Drawing.Size(124, 25);
            this.rbtn_my_balance.TabIndex = 0;
            this.rbtn_my_balance.TabStop = true;
            this.rbtn_my_balance.Text = "MY BALANCE";
            this.rbtn_my_balance.UseVisualStyleBackColor = true;
            this.rbtn_my_balance.Click += new System.EventHandler(this.rbtn_my_balance_Click);
            // 
            // fnl_order
            // 
            this.fnl_order.AutoScroll = true;
            this.fnl_order.Location = new System.Drawing.Point(12, 7);
            this.fnl_order.Margin = new System.Windows.Forms.Padding(4);
            this.fnl_order.Name = "fnl_order";
            this.fnl_order.Size = new System.Drawing.Size(837, 688);
            this.fnl_order.TabIndex = 0;
            // 
            // pnl_total
            // 
            this.pnl_total.Controls.Add(this.label2);
            this.pnl_total.Controls.Add(this.lbl_total);
            this.pnl_total.Controls.Add(this.label1);
            this.pnl_total.Location = new System.Drawing.Point(32, 122);
            this.pnl_total.Name = "pnl_total";
            this.pnl_total.Size = new System.Drawing.Size(200, 66);
            this.pnl_total.TabIndex = 17;
            // 
            // fr_checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1272, 720);
            this.Controls.Add(this.pnl_check);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fr_checkout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fr_checkout_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fr_checkout_MouseDown);
            this.pnl_check.ResumeLayout(false);
            this.pnl_check.PerformLayout();
            this.pnl_all_total.ResumeLayout(false);
            this.pnl_all_total.PerformLayout();
            this.pnl_choose_payment.ResumeLayout(false);
            this.pnl_choose_payment.PerformLayout();
            this.pnl_total.ResumeLayout(false);
            this.pnl_total.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_check;
        private System.Windows.Forms.Panel pnl_choose_payment;
        private System.Windows.Forms.RadioButton rbtn_cod;
        private System.Windows.Forms.RadioButton rbtn_my_balance;
        private System.Windows.Forms.FlowLayoutPanel fnl_order;
        private System.Windows.Forms.Button BTN_PLACE_ORDER;
        private System.Windows.Forms.Button BTN_BACK_TO_CART;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_payment_empty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_all_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.FlowLayoutPanel fnl_shipping;
        private System.Windows.Forms.Panel pnl_total;
    }
}
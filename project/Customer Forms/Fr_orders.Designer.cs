namespace project
{
    partial class Fr_orders
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
            this.fnl_orders = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_empty_orders = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fnl_orders.SuspendLayout();
            this.pnl_empty_orders.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // fnl_orders
            // 
            this.fnl_orders.AutoScroll = true;
            this.fnl_orders.Controls.Add(this.pnl_empty_orders);
            this.fnl_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fnl_orders.Location = new System.Drawing.Point(0, 0);
            this.fnl_orders.Margin = new System.Windows.Forms.Padding(4);
            this.fnl_orders.Name = "fnl_orders";
            this.fnl_orders.Size = new System.Drawing.Size(1067, 554);
            this.fnl_orders.TabIndex = 0;
            // 
            // pnl_empty_orders
            // 
            this.pnl_empty_orders.Controls.Add(this.panel4);
            this.pnl_empty_orders.Location = new System.Drawing.Point(3, 3);
            this.pnl_empty_orders.Name = "pnl_empty_orders";
            this.pnl_empty_orders.Size = new System.Drawing.Size(758, 173);
            this.pnl_empty_orders.TabIndex = 1;
            this.pnl_empty_orders.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(162)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(20, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 76);
            this.panel4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(13, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(419, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Add items to your cart and make your first order.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(14, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "You have no orders yet.";
            // 
            // Fr_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.fnl_orders);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fr_orders";
            this.Text = "Fr_orders";
            this.Load += new System.EventHandler(this.Fr_orders_Load);
            this.fnl_orders.ResumeLayout(false);
            this.pnl_empty_orders.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fnl_orders;
        private System.Windows.Forms.Panel pnl_empty_orders;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
namespace project
{
    partial class fr_products
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
            this.flpnl_products = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpnl_products
            // 
            this.flpnl_products.AutoScroll = true;
            this.flpnl_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnl_products.Location = new System.Drawing.Point(0, 0);
            this.flpnl_products.Name = "flpnl_products";
            this.flpnl_products.Size = new System.Drawing.Size(800, 450);
            this.flpnl_products.TabIndex = 0;
            // 
            // fr_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpnl_products);
            this.Name = "fr_products";
            this.Text = "fr_products";
            this.Load += new System.EventHandler(this.fr_products_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnl_products;
    }
}
namespace project
{
    partial class Fr_change_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_change_user));
            this.btn_confirm_user = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_cust_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_wrong_user = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_confirm_user
            // 
            this.btn_confirm_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(193)))), ((int)(((byte)(63)))));
            this.btn_confirm_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_confirm_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm_user.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn_confirm_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_confirm_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm_user.Location = new System.Drawing.Point(83, 217);
            this.btn_confirm_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_confirm_user.Name = "btn_confirm_user";
            this.btn_confirm_user.Size = new System.Drawing.Size(100, 28);
            this.btn_confirm_user.TabIndex = 1;
            this.btn_confirm_user.Text = " Confirm";
            this.btn_confirm_user.UseVisualStyleBackColor = false;
            this.btn_confirm_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(48, 151);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 1);
            this.panel2.TabIndex = 10;
            // 
            // txt_cust_user
            // 
            this.txt_cust_user.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cust_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cust_user.ForeColor = System.Drawing.Color.Black;
            this.txt_cust_user.Location = new System.Drawing.Point(48, 128);
            this.txt_cust_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cust_user.Name = "txt_cust_user";
            this.txt_cust_user.Size = new System.Drawing.Size(287, 15);
            this.txt_cust_user.TabIndex = 9;
            this.txt_cust_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cust_user_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(44, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer Username";
            // 
            // lbl_wrong_user
            // 
            this.lbl_wrong_user.AutoSize = true;
            this.lbl_wrong_user.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_wrong_user.Location = new System.Drawing.Point(44, 167);
            this.lbl_wrong_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_wrong_user.Name = "lbl_wrong_user";
            this.lbl_wrong_user.Size = new System.Drawing.Size(0, 17);
            this.lbl_wrong_user.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(191, 217);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = " Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fr_change_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(379, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_wrong_user);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_cust_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_confirm_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fr_change_user";
            this.Text = "Fr_change_user";
            this.Load += new System.EventHandler(this.Fr_change_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_confirm_user;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_cust_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_wrong_user;
        private System.Windows.Forms.Button button2;
    }
}
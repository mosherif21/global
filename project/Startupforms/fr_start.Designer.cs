namespace project
{
    partial class fr_start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_start));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_drag = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.circle_button2 = new project.circle_button();
            this.circle_button1 = new project.circle_button();
            this.panel1.SuspendLayout();
            this.panel_drag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel_drag);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 357);
            this.panel1.TabIndex = 0;
            // 
            // panel_drag
            // 
            this.panel_drag.BackColor = System.Drawing.Color.Transparent;
            this.panel_drag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_drag.BackgroundImage")));
            this.panel_drag.Controls.Add(this.exit);
            this.panel_drag.Location = new System.Drawing.Point(0, 3);
            this.panel_drag.Name = "panel_drag";
            this.panel_drag.Size = new System.Drawing.Size(803, 32);
            this.panel_drag.TabIndex = 9;
            this.panel_drag.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_drag_Paint);
            this.panel_drag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedown);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.exit.Image = global::project.Properties.Resources.icon_close;
            this.exit.Location = new System.Drawing.Point(766, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(37, 32);
            this.exit.TabIndex = 2;
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(-20, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 110);
            this.panel2.TabIndex = 2;
            // 
            // circle_button2
            // 
            this.circle_button2.BackColor = System.Drawing.Color.Transparent;
            this.circle_button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle_button2.BackgroundImage")));
            this.circle_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circle_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circle_button2.FlatAppearance.BorderSize = 0;
            this.circle_button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.circle_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_button2.Location = new System.Drawing.Point(465, 358);
            this.circle_button2.Name = "circle_button2";
            this.circle_button2.Size = new System.Drawing.Size(99, 76);
            this.circle_button2.TabIndex = 2;
            this.circle_button2.UseVisualStyleBackColor = false;
            this.circle_button2.Click += new System.EventHandler(this.circle_button2_Click);
            // 
            // circle_button1
            // 
            this.circle_button1.BackColor = System.Drawing.Color.Transparent;
            this.circle_button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle_button1.BackgroundImage")));
            this.circle_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circle_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circle_button1.FlatAppearance.BorderSize = 0;
            this.circle_button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.circle_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_button1.ForeColor = System.Drawing.Color.Transparent;
            this.circle_button1.Location = new System.Drawing.Point(228, 358);
            this.circle_button1.Name = "circle_button1";
            this.circle_button1.Size = new System.Drawing.Size(95, 76);
            this.circle_button1.TabIndex = 1;
            this.circle_button1.UseVisualStyleBackColor = false;
            this.circle_button1.Click += new System.EventHandler(this.circle_button1_Click);
            // 
            // fr_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 452);
            this.Controls.Add(this.circle_button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.circle_button1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_start";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.start_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_drag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private circle_button circle_button1;
        private System.Windows.Forms.Panel panel2;
        private circle_button circle_button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_drag;
        private System.Windows.Forms.Button exit;
    }
}


namespace Ui_Layer.User_controll
{
    partial class Customer_home
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.home_slide_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.order_now_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.home_slide_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Elephant", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(102, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 83);
            this.label1.TabIndex = 1;
            this.label1.Text = "220৳";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(111, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chesse Burger";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(136, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 80);
            this.label4.TabIndex = 4;
            this.label4.Text = "With onion and Tomadto souce";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // home_slide_panel
            // 
            this.home_slide_panel.Controls.Add(this.label5);
            this.home_slide_panel.Controls.Add(this.order_now_btn);
            this.home_slide_panel.Controls.Add(this.pictureBox1);
            this.home_slide_panel.Controls.Add(this.label4);
            this.home_slide_panel.Controls.Add(this.label1);
            this.home_slide_panel.Controls.Add(this.label3);
            this.home_slide_panel.Location = new System.Drawing.Point(131, 18);
            this.home_slide_panel.Name = "home_slide_panel";
            this.home_slide_panel.Size = new System.Drawing.Size(977, 566);
            this.home_slide_panel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(113, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "only";
            // 
            // order_now_btn
            // 
            this.order_now_btn.BackColor = System.Drawing.Color.Tomato;
            this.order_now_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_now_btn.ForeColor = System.Drawing.Color.White;
            this.order_now_btn.Location = new System.Drawing.Point(317, 355);
            this.order_now_btn.Name = "order_now_btn";
            this.order_now_btn.Size = new System.Drawing.Size(192, 41);
            this.order_now_btn.TabIndex = 5;
            this.order_now_btn.Text = "Order Now";
            this.order_now_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ui_Layer.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(410, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Customer_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.home_slide_panel);
            this.Name = "Customer_home";
            this.Size = new System.Drawing.Size(1247, 587);
            this.Load += new System.EventHandler(this.Customer_home_Load);
            this.home_slide_panel.ResumeLayout(false);
            this.home_slide_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel home_slide_panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button order_now_btn;
        private System.Windows.Forms.Label label5;
    }
}

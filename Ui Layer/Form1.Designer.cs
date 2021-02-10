namespace Ui_Layer
{
    partial class Customer_ui
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.time_pass_btn = new System.Windows.Forms.Button();
            this.about_us_btn = new System.Windows.Forms.Button();
            this.cart_btn = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.customer_About_us1 = new Ui_Layer.User_controll.Customer_About_us();
            this.customer_game1 = new Ui_Layer.User_controll.Customer_game();
            this.customer_cart1 = new Ui_Layer.User_controll.Customer_cart();
            this.customer_menu1 = new Ui_Layer.User_controll.Customer_menu();
            this.customer_home1 = new Ui_Layer.User_controll.Customer_home();
            this.top_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Maroon;
            this.top_panel.Controls.Add(this.exit);
            this.top_panel.Controls.Add(this.time_pass_btn);
            this.top_panel.Controls.Add(this.about_us_btn);
            this.top_panel.Controls.Add(this.cart_btn);
            this.top_panel.Controls.Add(this.menu_btn);
            this.top_panel.Controls.Add(this.home_btn);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1247, 77);
            this.top_panel.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Orange;
            this.exit.Location = new System.Drawing.Point(1119, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 32);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // time_pass_btn
            // 
            this.time_pass_btn.FlatAppearance.BorderSize = 0;
            this.time_pass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time_pass_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_pass_btn.ForeColor = System.Drawing.Color.Orange;
            this.time_pass_btn.Location = new System.Drawing.Point(755, 17);
            this.time_pass_btn.Name = "time_pass_btn";
            this.time_pass_btn.Size = new System.Drawing.Size(116, 32);
            this.time_pass_btn.TabIndex = 4;
            this.time_pass_btn.Text = "Time Pass";
            this.time_pass_btn.UseVisualStyleBackColor = true;
            this.time_pass_btn.Click += new System.EventHandler(this.time_pass_btn_Click);
            // 
            // about_us_btn
            // 
            this.about_us_btn.FlatAppearance.BorderSize = 0;
            this.about_us_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_us_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_us_btn.ForeColor = System.Drawing.Color.Orange;
            this.about_us_btn.Location = new System.Drawing.Point(960, 17);
            this.about_us_btn.Name = "about_us_btn";
            this.about_us_btn.Size = new System.Drawing.Size(116, 32);
            this.about_us_btn.TabIndex = 3;
            this.about_us_btn.Text = "About us";
            this.about_us_btn.UseVisualStyleBackColor = true;
            this.about_us_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // cart_btn
            // 
            this.cart_btn.FlatAppearance.BorderSize = 0;
            this.cart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cart_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_btn.ForeColor = System.Drawing.Color.Orange;
            this.cart_btn.Location = new System.Drawing.Point(574, 17);
            this.cart_btn.Name = "cart_btn";
            this.cart_btn.Size = new System.Drawing.Size(116, 32);
            this.cart_btn.TabIndex = 2;
            this.cart_btn.Text = "Cart";
            this.cart_btn.UseVisualStyleBackColor = true;
            this.cart_btn.Click += new System.EventHandler(this.cart_btn_Click);
            // 
            // menu_btn
            // 
            this.menu_btn.FlatAppearance.BorderSize = 0;
            this.menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btn.ForeColor = System.Drawing.Color.Orange;
            this.menu_btn.Location = new System.Drawing.Point(376, 17);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(148, 34);
            this.menu_btn.TabIndex = 1;
            this.menu_btn.Text = "Food Menu";
            this.menu_btn.UseVisualStyleBackColor = true;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.Orange;
            this.home_btn.Location = new System.Drawing.Point(215, 19);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(116, 32);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.customer_About_us1);
            this.main_panel.Controls.Add(this.customer_game1);
            this.main_panel.Controls.Add(this.customer_cart1);
            this.main_panel.Controls.Add(this.customer_menu1);
            this.main_panel.Controls.Add(this.customer_home1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.main_panel.Location = new System.Drawing.Point(0, 83);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1247, 668);
            this.main_panel.TabIndex = 1;
            // 
            // customer_About_us1
            // 
            this.customer_About_us1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_About_us1.Location = new System.Drawing.Point(3, -10);
            this.customer_About_us1.Name = "customer_About_us1";
            this.customer_About_us1.Size = new System.Drawing.Size(1244, 675);
            this.customer_About_us1.TabIndex = 4;
            // 
            // customer_game1
            // 
            this.customer_game1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_game1.Location = new System.Drawing.Point(0, 0);
            this.customer_game1.Name = "customer_game1";
            this.customer_game1.Size = new System.Drawing.Size(1244, 668);
            this.customer_game1.TabIndex = 3;
            // 
            // customer_cart1
            // 
            this.customer_cart1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_cart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer_cart1.Location = new System.Drawing.Point(0, 0);
            this.customer_cart1.Name = "customer_cart1";
            this.customer_cart1.Size = new System.Drawing.Size(1247, 668);
            this.customer_cart1.TabIndex = 2;
            // 
            // customer_menu1
            // 
            this.customer_menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer_menu1.Location = new System.Drawing.Point(0, 0);
            this.customer_menu1.Name = "customer_menu1";
            this.customer_menu1.Size = new System.Drawing.Size(1247, 668);
            this.customer_menu1.TabIndex = 1;
            // 
            // customer_home1
            // 
            this.customer_home1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer_home1.Location = new System.Drawing.Point(0, 0);
            this.customer_home1.Name = "customer_home1";
            this.customer_home1.Size = new System.Drawing.Size(1247, 668);
            this.customer_home1.TabIndex = 0;
            // 
            // Customer_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 751);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_ui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.home_btn_Click);
            this.top_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button about_us_btn;
        private System.Windows.Forms.Button cart_btn;
        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button time_pass_btn;
        private System.Windows.Forms.Panel main_panel;
        private User_controll.Customer_menu customer_menu1;
        private User_controll.Customer_home customer_home1;
        private System.Windows.Forms.Button exit;
        private User_controll.Customer_cart customer_cart1;
        private User_controll.Customer_game customer_game1;
        private User_controll.Customer_About_us customer_About_us1;
    }
}


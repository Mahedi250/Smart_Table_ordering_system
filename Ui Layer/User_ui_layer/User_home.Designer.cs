namespace Ui_Layer.User_ui_layer
{
    partial class User_home
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
            this.enter_cus_btn = new System.Windows.Forms.Button();
            this.enter_chef_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter_cus_btn
            // 
            this.enter_cus_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.enter_cus_btn.ForeColor = System.Drawing.Color.White;
            this.enter_cus_btn.Location = new System.Drawing.Point(177, 232);
            this.enter_cus_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.enter_cus_btn.Name = "enter_cus_btn";
            this.enter_cus_btn.Size = new System.Drawing.Size(214, 44);
            this.enter_cus_btn.TabIndex = 0;
            this.enter_cus_btn.Text = "Enter Customer Ui";
            this.enter_cus_btn.UseVisualStyleBackColor = false;
            this.enter_cus_btn.Click += new System.EventHandler(this.enter_cus_btn_Click);
            // 
            // enter_chef_btn
            // 
            this.enter_chef_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.enter_chef_btn.ForeColor = System.Drawing.Color.White;
            this.enter_chef_btn.Location = new System.Drawing.Point(477, 232);
            this.enter_chef_btn.Margin = new System.Windows.Forms.Padding(5);
            this.enter_chef_btn.Name = "enter_chef_btn";
            this.enter_chef_btn.Size = new System.Drawing.Size(203, 44);
            this.enter_chef_btn.TabIndex = 0;
            this.enter_chef_btn.Text = "Enter Chef Ui";
            this.enter_chef_btn.UseVisualStyleBackColor = false;
            this.enter_chef_btn.Click += new System.EventHandler(this.enter_chef_btn_Click_1);
            // 
            // User_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.enter_chef_btn);
            this.Controls.Add(this.enter_cus_btn);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "User_home";
            this.Size = new System.Drawing.Size(967, 661);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enter_cus_btn;
        private System.Windows.Forms.Button enter_chef_btn;
    }
}

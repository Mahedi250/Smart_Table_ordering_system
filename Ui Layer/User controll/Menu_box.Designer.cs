namespace Ui_Layer.User_controll
{
    partial class Menu_box
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.food_name_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sold_out = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sold_out.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // food_name_lbl
            // 
            this.food_name_lbl.AutoSize = true;
            this.food_name_lbl.BackColor = System.Drawing.Color.OrangeRed;
            this.food_name_lbl.Font = new System.Drawing.Font("Charlemagne Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food_name_lbl.Location = new System.Drawing.Point(3, 12);
            this.food_name_lbl.Name = "food_name_lbl";
            this.food_name_lbl.Size = new System.Drawing.Size(85, 24);
            this.food_name_lbl.TabIndex = 1;
            this.food_name_lbl.Text = "label1";
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.BackColor = System.Drawing.Color.OrangeRed;
            this.price_lbl.Font = new System.Drawing.Font("Charlemagne Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lbl.Location = new System.Drawing.Point(3, 372);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(101, 29);
            this.price_lbl.TabIndex = 2;
            this.price_lbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sold_out
            // 
            this.sold_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sold_out.Controls.Add(this.label2);
            this.sold_out.Location = new System.Drawing.Point(0, 118);
            this.sold_out.Name = "sold_out";
            this.sold_out.Size = new System.Drawing.Size(256, 48);
            this.sold_out.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sold OUT";
            // 
            // Menu_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::Ui_Layer.Properties.Resources.main_background1;
            this.Controls.Add(this.sold_out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.food_name_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu_box";
            this.Size = new System.Drawing.Size(256, 411);
            this.Load += new System.EventHandler(this.Menu_box_Load);
            this.Click += new System.EventHandler(this.Menu_box_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sold_out.ResumeLayout(false);
            this.sold_out.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label food_name_lbl;
        public System.Windows.Forms.Label price_lbl;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel sold_out;
        private System.Windows.Forms.Label label2;
    }
}

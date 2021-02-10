namespace Ui_Layer
{
    partial class Add_food
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.food_name_txb = new System.Windows.Forms.TextBox();
            this.food_price_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.food_details_txb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.food_cooking_txb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.food_pic = new System.Windows.Forms.PictureBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.foodcatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tOSDataSet = new Ui_Layer.TOSDataSet();
            this.foodcatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adsoningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOSDataSet2 = new Ui_Layer.TOSDataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.photo_bro_btn = new System.Windows.Forms.Button();
            this.food_catTableAdapter = new Ui_Layer.TOSDataSetTableAdapters.Food_catTableAdapter();
            this.food_cat_cmb = new System.Windows.Forms.ComboBox();
            this.foodcatBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tOSDataSet1 = new Ui_Layer.TOSDataSet1();
            this.food_catTableAdapter1 = new Ui_Layer.TOSDataSet1TableAdapters.Food_catTableAdapter();
            this.tOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ads_on_ingTableAdapter = new Ui_Layer.TOSDataSet2TableAdapters.Ads_on_ingTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.add_ing1 = new Ui_Layer.add_ing();
            this.Update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.food_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adsoningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Name";
            // 
            // food_name_txb
            // 
            this.food_name_txb.Location = new System.Drawing.Point(458, 22);
            this.food_name_txb.Name = "food_name_txb";
            this.food_name_txb.Size = new System.Drawing.Size(229, 22);
            this.food_name_txb.TabIndex = 0;
            this.food_name_txb.TabStop = false;
            // 
            // food_price_txb
            // 
            this.food_price_txb.Location = new System.Drawing.Point(458, 67);
            this.food_price_txb.Name = "food_price_txb";
            this.food_price_txb.Size = new System.Drawing.Size(229, 22);
            this.food_price_txb.TabIndex = 1;
            this.food_price_txb.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Food Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Food Catagory";
            // 
            // food_details_txb
            // 
            this.food_details_txb.Location = new System.Drawing.Point(458, 115);
            this.food_details_txb.Multiline = true;
            this.food_details_txb.Name = "food_details_txb";
            this.food_details_txb.Size = new System.Drawing.Size(229, 110);
            this.food_details_txb.TabIndex = 2;
            this.food_details_txb.TabStop = false;
            this.food_details_txb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cooking Time";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // food_cooking_txb
            // 
            this.food_cooking_txb.Location = new System.Drawing.Point(458, 322);
            this.food_cooking_txb.Name = "food_cooking_txb";
            this.food_cooking_txb.Size = new System.Drawing.Size(229, 22);
            this.food_cooking_txb.TabIndex = 4;
            this.food_cooking_txb.TabStop = false;
            this.food_cooking_txb.TextChanged += new System.EventHandler(this.food_cooking_txb_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Food Ingradiants";
            // 
            // food_pic
            // 
            this.food_pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.food_pic.Location = new System.Drawing.Point(458, 378);
            this.food_pic.Name = "food_pic";
            this.food_pic.Size = new System.Drawing.Size(229, 115);
            this.food_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.food_pic.TabIndex = 2;
            this.food_pic.TabStop = false;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(515, 723);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(117, 27);
            this.submit_btn.TabIndex = 3;
            this.submit_btn.TabStop = false;
            this.submit_btn.Text = "submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // foodcatBindingSource1
            // 
            this.foodcatBindingSource1.DataMember = "Food_cat";
            this.foodcatBindingSource1.DataSource = this.tOSDataSet;
            // 
            // tOSDataSet
            // 
            this.tOSDataSet.DataSetName = "TOSDataSet";
            this.tOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodcatBindingSource
            // 
            this.foodcatBindingSource.DataMember = "Food_cat";
            this.foodcatBindingSource.DataSource = this.tOSDataSet;
            // 
            // adsoningBindingSource
            // 
            this.adsoningBindingSource.DataMember = "Ads_on_ing";
            this.adsoningBindingSource.DataSource = this.tOSDataSet2;
            // 
            // tOSDataSet2
            // 
            this.tOSDataSet2.DataSetName = "TOSDataSet2";
            this.tOSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Food Details";
            // 
            // photo_bro_btn
            // 
            this.photo_bro_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photo_bro_btn.Location = new System.Drawing.Point(716, 419);
            this.photo_bro_btn.Name = "photo_bro_btn";
            this.photo_bro_btn.Size = new System.Drawing.Size(92, 27);
            this.photo_bro_btn.TabIndex = 5;
            this.photo_bro_btn.TabStop = false;
            this.photo_bro_btn.Text = "Browse";
            this.photo_bro_btn.UseVisualStyleBackColor = true;
            this.photo_bro_btn.Click += new System.EventHandler(this.photo_bro_btn_Click);
            // 
            // food_catTableAdapter
            // 
            this.food_catTableAdapter.ClearBeforeFill = true;
            // 
            // food_cat_cmb
            // 
            this.food_cat_cmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.foodcatBindingSource1, "cat_id", true));
            this.food_cat_cmb.DataSource = this.foodcatBindingSource2;
            this.food_cat_cmb.DisplayMember = "cat_name";
            this.food_cat_cmb.FormattingEnabled = true;
            this.food_cat_cmb.Location = new System.Drawing.Point(458, 254);
            this.food_cat_cmb.Name = "food_cat_cmb";
            this.food_cat_cmb.Size = new System.Drawing.Size(229, 24);
            this.food_cat_cmb.TabIndex = 6;
            this.food_cat_cmb.SelectedIndexChanged += new System.EventHandler(this.food_cat_cmb_SelectedIndexChanged);
            // 
            // foodcatBindingSource2
            // 
            this.foodcatBindingSource2.DataMember = "Food_cat";
            this.foodcatBindingSource2.DataSource = this.tOSDataSet1;
            // 
            // tOSDataSet1
            // 
            this.tOSDataSet1.DataSetName = "TOSDataSet1";
            this.tOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // food_catTableAdapter1
            // 
            this.food_catTableAdapter1.ClearBeforeFill = true;
            // 
            // tOSDataSetBindingSource
            // 
            this.tOSDataSetBindingSource.DataSource = this.tOSDataSet;
            this.tOSDataSetBindingSource.Position = 0;
            // 
            // ads_on_ingTableAdapter
            // 
            this.ads_on_ingTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 515);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(388, 172);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(814, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_ing1
            // 
            this.add_ing1.Location = new System.Drawing.Point(814, 547);
            this.add_ing1.Name = "add_ing1";
            this.add_ing1.Size = new System.Drawing.Size(267, 223);
            this.add_ing1.TabIndex = 9;
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(515, 723);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(117, 27);
            this.Update_btn.TabIndex = 10;
            this.Update_btn.TabStop = false;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Add_food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 782);
            this.Controls.Add(this.add_ing1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.food_cat_cmb);
            this.Controls.Add(this.photo_bro_btn);
            this.Controls.Add(this.food_pic);
            this.Controls.Add(this.food_cooking_txb);
            this.Controls.Add(this.food_details_txb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.food_price_txb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.food_name_txb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.submit_btn);
            this.MaximizeBox = false;
            this.Name = "Add_food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_food";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_food_FormClosing);
            this.Load += new System.EventHandler(this.Add_food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.food_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adsoningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox food_name_txb;
        private System.Windows.Forms.TextBox food_price_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox food_details_txb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox food_cooking_txb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox food_pic;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button photo_bro_btn;
        private TOSDataSet tOSDataSet;
        private System.Windows.Forms.BindingSource foodcatBindingSource;
        private TOSDataSetTableAdapters.Food_catTableAdapter food_catTableAdapter;
        private System.Windows.Forms.BindingSource foodcatBindingSource1;
        private System.Windows.Forms.ComboBox food_cat_cmb;
        private TOSDataSet1 tOSDataSet1;
        private System.Windows.Forms.BindingSource foodcatBindingSource2;
        private TOSDataSet1TableAdapters.Food_catTableAdapter food_catTableAdapter1;
        private System.Windows.Forms.BindingSource tOSDataSetBindingSource;
        private TOSDataSet2 tOSDataSet2;
        private System.Windows.Forms.BindingSource adsoningBindingSource;
        private TOSDataSet2TableAdapters.Ads_on_ingTableAdapter ads_on_ingTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private add_ing add_ing1;
        private System.Windows.Forms.Button Update_btn;
    }
}
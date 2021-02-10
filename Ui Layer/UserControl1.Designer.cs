namespace Ui_Layer
{
    partial class add_ing
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
            this.ing_name_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ing_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tOSDataSet = new Ui_Layer.TOSDataSet();
            this.tOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOSDataSet3 = new Ui_Layer.TOSDataSet3();
            this.foodcatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_catTableAdapter = new Ui_Layer.TOSDataSet3TableAdapters.Food_catTableAdapter();
            this.tOSDataSet4 = new Ui_Layer.TOSDataSet4();
            this.foodcatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.food_catTableAdapter1 = new Ui_Layer.TOSDataSet4TableAdapters.Food_catTableAdapter();
            this.cat_id_ing_cmb = new System.Windows.Forms.ComboBox();
            this.foodcatBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tOSDataSet1 = new Ui_Layer.TOSDataSet1();
            this.tOSDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_catTableAdapter2 = new Ui_Layer.TOSDataSetTableAdapters.Food_catTableAdapter();
            this.foodcatBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // ing_name_txb
            // 
            this.ing_name_txb.Location = new System.Drawing.Point(67, 43);
            this.ing_name_txb.Name = "ing_name_txb";
            this.ing_name_txb.Size = new System.Drawing.Size(163, 22);
            this.ing_name_txb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New ingradiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // ing_price
            // 
            this.ing_price.Location = new System.Drawing.Point(67, 85);
            this.ing_price.Name = "ing_price";
            this.ing_price.Size = new System.Drawing.Size(163, 22);
            this.ing_price.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Food Catagory";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Ingradiant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tOSDataSet
            // 
            this.tOSDataSet.DataSetName = "TOSDataSet";
            this.tOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOSDataSetBindingSource
            // 
            this.tOSDataSetBindingSource.DataSource = this.tOSDataSet;
            this.tOSDataSetBindingSource.Position = 0;
            // 
            // tOSDataSet3
            // 
            this.tOSDataSet3.DataSetName = "TOSDataSet3";
            this.tOSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodcatBindingSource
            // 
            this.foodcatBindingSource.DataMember = "Food_cat";
            this.foodcatBindingSource.DataSource = this.tOSDataSet3;
            // 
            // food_catTableAdapter
            // 
            this.food_catTableAdapter.ClearBeforeFill = true;
            // 
            // tOSDataSet4
            // 
            this.tOSDataSet4.DataSetName = "TOSDataSet4";
            this.tOSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodcatBindingSource1
            // 
            this.foodcatBindingSource1.DataMember = "Food_cat";
            this.foodcatBindingSource1.DataSource = this.tOSDataSet4;
            // 
            // food_catTableAdapter1
            // 
            this.food_catTableAdapter1.ClearBeforeFill = true;
            // 
            // cat_id_ing_cmb
            // 
            this.cat_id_ing_cmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.foodcatBindingSource, "cat_id", true));
            this.cat_id_ing_cmb.FormattingEnabled = true;
            this.cat_id_ing_cmb.Items.AddRange(new object[] {
            "starter",
            "Pizza",
            "Burger",
            "Drinks"});
            this.cat_id_ing_cmb.Location = new System.Drawing.Point(62, 130);
            this.cat_id_ing_cmb.Name = "cat_id_ing_cmb";
            this.cat_id_ing_cmb.Size = new System.Drawing.Size(168, 24);
            this.cat_id_ing_cmb.TabIndex = 8;
            // 
            // foodcatBindingSource2
            // 
            this.foodcatBindingSource2.DataMember = "Food_cat";
            this.foodcatBindingSource2.DataSource = this.tOSDataSetBindingSource;
            // 
            // tOSDataSet1
            // 
            this.tOSDataSet1.DataSetName = "TOSDataSet1";
            this.tOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOSDataSet1BindingSource
            // 
            this.tOSDataSet1BindingSource.DataSource = this.tOSDataSet1;
            this.tOSDataSet1BindingSource.Position = 0;
            // 
            // food_catTableAdapter2
            // 
            this.food_catTableAdapter2.ClearBeforeFill = true;
            // 
            // foodcatBindingSource3
            // 
            this.foodcatBindingSource3.DataMember = "Food_cat";
            this.foodcatBindingSource3.DataSource = this.tOSDataSetBindingSource;
            // 
            // add_ing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cat_id_ing_cmb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ing_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ing_name_txb);
            this.Name = "add_ing";
            this.Size = new System.Drawing.Size(261, 238);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOSDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcatBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ing_name_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ing_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private TOSDataSet tOSDataSet;
        private System.Windows.Forms.BindingSource tOSDataSetBindingSource;
        private TOSDataSet3 tOSDataSet3;
        private System.Windows.Forms.BindingSource foodcatBindingSource;
        private TOSDataSet3TableAdapters.Food_catTableAdapter food_catTableAdapter;
        private System.Windows.Forms.BindingSource foodcatBindingSource1;
        private TOSDataSet4 tOSDataSet4;
        private TOSDataSet4TableAdapters.Food_catTableAdapter food_catTableAdapter1;
        private System.Windows.Forms.ComboBox cat_id_ing_cmb;
        private System.Windows.Forms.BindingSource foodcatBindingSource2;
        private TOSDataSet1 tOSDataSet1;
        private System.Windows.Forms.BindingSource tOSDataSet1BindingSource;
        private TOSDataSetTableAdapters.Food_catTableAdapter food_catTableAdapter2;
        private System.Windows.Forms.BindingSource foodcatBindingSource3;
    }
}

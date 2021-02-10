namespace Ui_Layer.User_ui_layer
{
   public partial class User_menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_iten_btn = new System.Windows.Forms.Button();
            this.update_item_btn = new System.Windows.Forms.Button();
            this.remove_item_btn = new System.Windows.Forms.Button();
            this.add_sold_out_btn = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add_iten_btn
            // 
            this.add_iten_btn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_iten_btn.Location = new System.Drawing.Point(177, 564);
            this.add_iten_btn.Name = "add_iten_btn";
            this.add_iten_btn.Size = new System.Drawing.Size(118, 45);
            this.add_iten_btn.TabIndex = 1;
            this.add_iten_btn.Text = "ADD Item";
            this.add_iten_btn.UseVisualStyleBackColor = true;
            this.add_iten_btn.Click += new System.EventHandler(this.add_iten_btn_Click);
            // 
            // update_item_btn
            // 
            this.update_item_btn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_item_btn.Location = new System.Drawing.Point(376, 564);
            this.update_item_btn.Name = "update_item_btn";
            this.update_item_btn.Size = new System.Drawing.Size(146, 45);
            this.update_item_btn.TabIndex = 2;
            this.update_item_btn.Text = "Update Item";
            this.update_item_btn.UseVisualStyleBackColor = true;
            this.update_item_btn.Click += new System.EventHandler(this.update_item_btn_Click);
            // 
            // remove_item_btn
            // 
            this.remove_item_btn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_item_btn.Location = new System.Drawing.Point(595, 564);
            this.remove_item_btn.Name = "remove_item_btn";
            this.remove_item_btn.Size = new System.Drawing.Size(146, 45);
            this.remove_item_btn.TabIndex = 3;
            this.remove_item_btn.Text = "Remove_item";
            this.remove_item_btn.UseVisualStyleBackColor = true;
            this.remove_item_btn.Click += new System.EventHandler(this.remove_item_btn_Click);
            // 
            // add_sold_out_btn
            // 
            this.add_sold_out_btn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_sold_out_btn.Location = new System.Drawing.Point(862, 564);
            this.add_sold_out_btn.Name = "add_sold_out_btn";
            this.add_sold_out_btn.Size = new System.Drawing.Size(188, 59);
            this.add_sold_out_btn.TabIndex = 4;
            this.add_sold_out_btn.Text = "Add Sold-Out/AVA Tag";
            this.add_sold_out_btn.UseVisualStyleBackColor = true;
            this.add_sold_out_btn.Click += new System.EventHandler(this.add_sold_out_btn_Click);
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_button.Location = new System.Drawing.Point(964, 29);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(118, 45);
            this.load_button.TabIndex = 5;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // User_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.add_sold_out_btn);
            this.Controls.Add(this.remove_item_btn);
            this.Controls.Add(this.update_item_btn);
            this.Controls.Add(this.add_iten_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "User_menu";
            this.Size = new System.Drawing.Size(1139, 670);
            this.Load += new System.EventHandler(this.User_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_iten_btn;
        private System.Windows.Forms.Button update_item_btn;
        private System.Windows.Forms.Button remove_item_btn;
        private System.Windows.Forms.Button add_sold_out_btn;
        private System.Windows.Forms.Button load_button;
    }
}

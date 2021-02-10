namespace Ui_Layer.User_ui_layer
{
    partial class Sell
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
            this.Selltable = new System.Windows.Forms.DataGridView();
            this.top_sell_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Selltable)).BeginInit();
            this.SuspendLayout();
            // 
            // Selltable
            // 
            this.Selltable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Selltable.Location = new System.Drawing.Point(253, 26);
            this.Selltable.Name = "Selltable";
            this.Selltable.RowTemplate.Height = 24;
            this.Selltable.Size = new System.Drawing.Size(853, 487);
            this.Selltable.TabIndex = 0;
            // 
            // top_sell_btn
            // 
            this.top_sell_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_sell_btn.Location = new System.Drawing.Point(557, 555);
            this.top_sell_btn.Name = "top_sell_btn";
            this.top_sell_btn.Size = new System.Drawing.Size(161, 59);
            this.top_sell_btn.TabIndex = 1;
            this.top_sell_btn.Text = "Top sell";
            this.top_sell_btn.UseVisualStyleBackColor = true;
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.top_sell_btn);
            this.Controls.Add(this.Selltable);
            this.Name = "Sell";
            this.Size = new System.Drawing.Size(1151, 728);
            ((System.ComponentModel.ISupportInitialize)(this.Selltable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Selltable;
        private System.Windows.Forms.Button top_sell_btn;
    }
}

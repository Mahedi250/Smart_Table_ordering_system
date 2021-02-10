namespace Ui_Layer
{
    partial class Forget_pass
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
            this.confirmation1 = new Ui_Layer.Fpc.Confirmation();
            this.setpass1 = new Ui_Layer.Fpc.Setpass();
            this.SuspendLayout();
            // 
            // confirmation1
            // 
            this.confirmation1.Location = new System.Drawing.Point(2, 3);
            this.confirmation1.Name = "confirmation1";
            this.confirmation1.Size = new System.Drawing.Size(628, 532);
            this.confirmation1.TabIndex = 0;
            this.confirmation1.Load += new System.EventHandler(this.confirmation1_Load);
            // 
            // setpass1
            // 
            this.setpass1.Location = new System.Drawing.Point(2, 3);
            this.setpass1.Name = "setpass1";
            this.setpass1.Size = new System.Drawing.Size(628, 532);
            this.setpass1.TabIndex = 1;
            // 
            // Forget_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 534);
            this.Controls.Add(this.confirmation1);
            this.Controls.Add(this.setpass1);
            this.Name = "Forget_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget_pass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Forget_pass_FormClosing);
            this.Load += new System.EventHandler(this.Forget_pass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Fpc.Confirmation confirmation1;
        private Fpc.Setpass setpass1;
    }
}
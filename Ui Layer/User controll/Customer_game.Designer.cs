namespace Ui_Layer.User_controll
{
    partial class Customer_game
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
            this.label1 = new System.Windows.Forms.Label();
            this.two_player1 = new Ui_Layer.Two_player();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gsme Corner";
            // 
            // two_player1
            // 
            this.two_player1.Location = new System.Drawing.Point(402, 152);
            this.two_player1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.two_player1.Name = "two_player1";
            this.two_player1.Size = new System.Drawing.Size(357, 471);
            this.two_player1.TabIndex = 1;
            // 
            // Customer_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.two_player1);
            this.Controls.Add(this.label1);
            this.Name = "Customer_game";
            this.Size = new System.Drawing.Size(1247, 668);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Two_player two_player1;
    }
}

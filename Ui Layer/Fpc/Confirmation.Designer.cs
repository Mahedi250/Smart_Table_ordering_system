namespace Ui_Layer.Fpc
{
    partial class Confirmation
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
            this.email_id_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enter_email_btn = new System.Windows.Forms.Button();
            this.confirm_txb = new System.Windows.Forms.TextBox();
            this.vc_label = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.e4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.e4)).BeginInit();
            this.SuspendLayout();
            // 
            // email_id_txb
            // 
            this.email_id_txb.Location = new System.Drawing.Point(173, 108);
            this.email_id_txb.Name = "email_id_txb";
            this.email_id_txb.Size = new System.Drawing.Size(216, 22);
            this.email_id_txb.TabIndex = 0;
            this.email_id_txb.Leave += new System.EventHandler(this.email_id_txb_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // enter_email_btn
            // 
            this.enter_email_btn.Location = new System.Drawing.Point(214, 166);
            this.enter_email_btn.Name = "enter_email_btn";
            this.enter_email_btn.Size = new System.Drawing.Size(109, 30);
            this.enter_email_btn.TabIndex = 2;
            this.enter_email_btn.Text = "Enter";
            this.enter_email_btn.UseVisualStyleBackColor = true;
            this.enter_email_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirm_txb
            // 
            this.confirm_txb.Location = new System.Drawing.Point(173, 257);
            this.confirm_txb.Name = "confirm_txb";
            this.confirm_txb.Size = new System.Drawing.Size(216, 22);
            this.confirm_txb.TabIndex = 0;
            this.confirm_txb.Visible = false;
            // 
            // vc_label
            // 
            this.vc_label.AutoSize = true;
            this.vc_label.Location = new System.Drawing.Point(45, 257);
            this.vc_label.Name = "vc_label";
            this.vc_label.Size = new System.Drawing.Size(112, 17);
            this.vc_label.TabIndex = 1;
            this.vc_label.Text = "Varifaction Code";
            this.vc_label.Visible = false;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(214, 327);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(109, 30);
            this.confirm_btn.TabIndex = 2;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Visible = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // e4
            // 
            this.e4.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please enter your Email for varification";
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.enter_email_btn);
            this.Controls.Add(this.vc_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm_txb);
            this.Controls.Add(this.email_id_txb);
            this.Name = "Confirmation";
            this.Size = new System.Drawing.Size(601, 550);
            this.Load += new System.EventHandler(this.Confirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_id_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter_email_btn;
        private System.Windows.Forms.TextBox confirm_txb;
        private System.Windows.Forms.Label vc_label;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.ErrorProvider e4;
        private System.Windows.Forms.Label label2;
    }
}

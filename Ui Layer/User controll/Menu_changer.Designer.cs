namespace Ui_Layer.User_controll
{
    partial class Menu_changer
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
            this.menu_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.AutoScroll = true;
            this.menu_panel.Location = new System.Drawing.Point(3, 3);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Padding = new System.Windows.Forms.Padding(5, 0, 100, 5);
            this.menu_panel.Size = new System.Drawing.Size(1070, 623);
            this.menu_panel.TabIndex = 0;
            this.menu_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_panel_Paint);
            // 
            // Menu_changer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menu_panel);
            this.Name = "Menu_changer";
            this.Size = new System.Drawing.Size(1088, 643);
            this.Load += new System.EventHandler(this.Menu_changer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menu_panel;
    }
}

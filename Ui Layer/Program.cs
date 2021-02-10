using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ui_Layer;

namespace Ui_Layer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
      

     public  static User_ui_layer.User_ui ui;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Customer_ui());

            ui = new User_ui_layer.User_ui();

          
            
            Application.Run(new Login());
        }
    }
}

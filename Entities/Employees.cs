using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entities
{
    public abstract class Employees
    {
        public int emp_id { get; set; }
        public string emp_name;  public String Emp_name { get; set; }
        public string emp_gender { get; set; }
        public DateTime emp_dob { get; set; }
        public string emp_number { get; set; }

        public string emp_email { get; set; }
        public string emp_address { get; set; }
        public int emp_usertype { get; set; }
        public byte[] emp_photo { get; set; }
        public string emp_username; public String Emp_username { get; set; }
        public string emp_password { get; set; }


    }

    public class LeadEmp : Employees { }

    public class Manager : Employees { }
    public class chef : Employees { }
}

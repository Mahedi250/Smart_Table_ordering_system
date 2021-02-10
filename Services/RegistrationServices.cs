using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repository;
using System.Drawing;

namespace Services
{
    public class RegistrationServices
    {
        RegistrationRepository rp;

        public RegistrationServices() {

            rp = new RegistrationRepository();

        }

        public int LeadRegistration(string name, string gender, DateTime date, string phone, string email, string adress, int usertype, byte[] img, string username, string password)
        {

            int result = rp.Register(new LeadEmp() { emp_name = name, emp_gender = gender, emp_dob = date, emp_number = phone, emp_email = email, emp_address = adress, emp_usertype = usertype, emp_photo = img, emp_username = username, emp_password = password });

            return result;
        }

        public int ChefRegistration(string name, string gender, DateTime date, string phone, string email, string adress, int usertype, byte[] img) {

            int result = rp.Register(new LeadEmp() { emp_name = name, emp_gender = gender, emp_dob = date, emp_number = phone, emp_email = email, emp_address = adress, emp_usertype = usertype, emp_photo = img });

            return result;
        }

        public int IsemailAva(string email) {

            int result = rp.Emailcheacker(email);

            return result;

        }

        public int IseusernameAva(string username)
        {

            int result = rp.Usernamecheaker(username);

            return result;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Entities;
namespace Services
{
   public class ForgetServices
    {
        ForgetRepo fr;
        public ForgetServices() {


            fr = new ForgetRepo();
        }

        public int GetAdminemal(string email) {


            int result=fr.IsAdminemail(email);
            return result;

        }

        public LeadEmp Getusername(string email) {


         LeadEmp le = fr.Getdata(email);

            return le;

        }

        public int updateLogindata(string email, string username, string password) {


            int result = fr.Updateup(email, username, password);

            return result;


        }


        public int IseusernameAva(string username)
        {

            int result = fr.Usernamecheaker(username);

            return result;

        }
    }
}

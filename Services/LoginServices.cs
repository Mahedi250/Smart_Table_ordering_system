using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Services
{
  public  class LoginServices
    {
        LoginRepository lr;

        public LoginServices() {

            lr = new LoginRepository();
        }
        public int Login(string username,string password) {



            int result = lr.Validation(username, password);

            return result;


        }

    }
}

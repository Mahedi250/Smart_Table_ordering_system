using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repository
{
   public class LoginRepository
    {
        DataAccess dbc;

        public LoginRepository() {


            dbc = new DataAccess();
            
        }

        public int Validation(string u, string pas) {

            dbc = new DataAccess();
            string sql = "select *  from credentials where emp_username='" + u + "' and emp_password='" + pas + "'";

            SqlDataReader reader = dbc.GetData(sql);
           
            if (reader.Read())
            {
                
                int ut = (int)reader["emp_usertype"];
                dbc.Dispose();

                if (ut == 0)
                {
                   
                    return 1;
                }
                else
                {
                  
                    return 2;
                }






            }


            else {
              
                return 0; }


           



        }
    }
}

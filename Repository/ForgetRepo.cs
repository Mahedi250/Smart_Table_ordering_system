using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;

namespace Repository
{
   public class ForgetRepo
    {
        DataAccess dbc;

        public ForgetRepo() {


            dbc = new DataAccess();

       }

        public int Usernamecheaker(string username)
        {
            dbc = new DataAccess();
            string sql = "select emp_username from credentials where emp_username='" + username + "'";
            SqlDataReader reader = dbc.GetData(sql);

            if (reader.Read())
            {

                dbc.Dispose();
                return 1;
            }
            else
            {
                dbc.Dispose();
                return 0;
            }



        }

        public int IsAdminemail(string email) {

            dbc = new DataAccess();
            string sql = "select emp_email,emp_user_type from Employees where emp_email='" + email + "'";
            SqlDataReader reader = dbc.GetData(sql);

            if (reader.Read())
            {

                if ((int)reader["emp_user_type"] == 0) { return 1; }
                else { return 0; }
            }
            else { return 0; }

        }

        public LeadEmp Getdata(string email)
        {


            dbc = new DataAccess();
            string sql = " select Employees.emp_name,Credentials.emp_username from Employees,credentials where Credentials.emp_email='"+email+"' and Employees.emp_id=Credentials.emp_id";
            SqlDataReader reader = dbc.GetData(sql);
            if (reader.Read())
            {
                LeadEmp le = new LeadEmp();

                le.Emp_name = reader["emp_name"].ToString();
                le.Emp_username = reader["emp_username"].ToString();

                dbc.Dispose();
                return le;
            }

            else { return null; }

            
        }




      public  int Updateup(string email,string username,string password) {

            dbc = new DataAccess();
            string sql = "UPDATE credentials SET emp_username = '"+username+"', emp_password = '"+password+"' WHERE emp_email='" + email + "'";
            int result = dbc.ExecuteQuery(sql);
            dbc.Dispose();

            return result;





        }

    }



}

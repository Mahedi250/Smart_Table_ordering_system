using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;

namespace Repository
{
   public class RegistrationRepository
    {
        DataAccess dbc;
       
        int id;
        int ut;

        public RegistrationRepository() {

           dbc=new DataAccess();

        }


        public int Usernamecheaker(string username)
        {
            dbc = new DataAccess();
            string sql = "select emp_username from credentials where emp_username='" +username + "'";
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

        public int Emailcheacker(string email) {
            dbc = new DataAccess();
            string sql = "select emp_email from employees where emp_email='" + email + "'";
            SqlDataReader reader = dbc.GetData(sql);
            
            if (reader.Read()) {

                dbc.Dispose();
                return 1; }
            else {
                dbc.Dispose();
                return 0; }



        }
       

        public int Register(LeadEmp em)
        {
            dbc = new DataAccess();
            string sql = "INSERT INTO Employees(emp_name,emp_gender,emp_dob,emp_number,emp_email,emp_address,emp_user_type,emp_photo) " +
                "VALUES('" +em.emp_name + "','" +em.emp_gender + "','" + em.emp_dob + "','"+em.emp_number+ "','" + em.emp_email + "','" + em.emp_address + "','" + em.emp_usertype + "','" + em.emp_photo + "')";
            int result = dbc.ExecuteQuery(sql);
            dbc.Dispose();
            if (result > 0)
            {
                dbc = new DataAccess();
                sql = "SELECT *  FROM Employees where emp_id=(select max(emp_id) from Employees)";
                SqlDataReader reader = dbc.GetData(sql);
                dbc.Dispose();
                reader.Read();
                ut = (int)reader["emp_user_type"];
                id = (int)reader["emp_id"];
                
                if (ut < 2)
                {

                    dbc = new DataAccess();
                    sql = "INSERT INTO Credentials(emp_username,emp_password,emp_usertype,emp_email,emp_id) VALUES('" + em.emp_username + "','" + em.emp_password + "'," + em.emp_usertype
                        + ",'" + em.emp_email + "'," + id + ")";
                    result = dbc.ExecuteQuery(sql);
                    dbc.Dispose();
                    if (result > 0)
                    {
                        return 3;

                    }
                    else { return 2; }



                }
                else { return 1; }


            }

            else { return 0; }
        }

    }
}

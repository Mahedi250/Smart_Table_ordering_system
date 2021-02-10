using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace Repository
{
    public class DataAccess : IDisposable
    {
        private SqlConnection connection;
        
       
        private SqlCommand command;
        public DataAccess()
        {
            this.connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TOS;Integrated Security=True");
            //this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SuperShop"].ConnectionString);
            this.connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            return this.command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            return this.command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}

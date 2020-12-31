using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement1.DataAccessLayer
{
    class DataAccess
    {
        SqlConnection connection;
        SqlCommand command;
        public DataAccess()
        {
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OP2"].ConnectionString);
            this.connection.Open();

        }
        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql,this.connection);
            SqlDataReader reader = this.command.ExecuteReader();
            this.connection.Close();
            return reader;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LMS_UI
{
    class SqlHelper
    {
        SqlConnection connection;

        public SqlHelper(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public bool IsConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return true;
        }
    }
}

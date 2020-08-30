using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace LMS_DAL
{
    public class MyConnection
    {
        protected SqlConnection connection;
        protected SqlCommand command;
        protected string sqlString;

        public MyConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ServerConnection"].ConnectionString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using LMS_INFO;
using System.Data;
using System.Data.SqlClient;

namespace LMS_DAL
{
    public class AuthorType_DataAccess:MyConnection
    {
        public IDataReader Select_AuthorType()
        {
            sqlString = "spdAuthorTypeSelect";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void Insert_AuthorType(AuthorType_Info info)
        {
            sqlString = "spdAuthorTypeInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@authortype", info.Authortype);
            command.Parameters.AddWithValue("@desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_AuthorType(AuthorType_Info info)
        {
            sqlString = "spdAuthorTypeUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@authortypeid", info.Authortypeid);
            command.Parameters.AddWithValue("@authortype", info.Authortype);
            command.Parameters.AddWithValue("@desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

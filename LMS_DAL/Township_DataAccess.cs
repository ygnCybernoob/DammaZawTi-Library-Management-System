using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LMS_INFO;

namespace LMS_DAL
{
    public class Township_DataAccess:MyConnection
    {
        public void Insert_Township(Township_Info info)
        {
            sqlString = "spdTownshipInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@stateid", info.Stateid);
            command.Parameters.AddWithValue("@township", info.Township);
            command.Parameters.AddWithValue("@desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_Township(Township_Info info)
        {
            sqlString = "spdTownshipUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@townshipid", info.Townshipid);
            command.Parameters.AddWithValue("@stateid", info.Stateid);
            command.Parameters.AddWithValue("@township", info.Township);
            command.Parameters.AddWithValue("@desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader Select_Township(int type, int stateid, string township)
        {
            sqlString = "spdTownshipSelect";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@stateid", stateid);
            command.Parameters.AddWithValue("@township", "%" + township +"%");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

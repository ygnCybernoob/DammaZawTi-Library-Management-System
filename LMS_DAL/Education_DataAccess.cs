using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LMS_INFO;

namespace LMS_DAL
{
    public class Education_DataAccess : MyConnection
    {
        public void Insert_Education(Education_Info info)
        {
            sqlString = "spdEducationInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Education", info.Education);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_Education(Education_Info info)
        {
            sqlString = "spdEducationUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Educationid", info.Educationid);
            command.Parameters.AddWithValue("@Education", info.Education);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader Select_Education(int type, string education)
        {
            sqlString = "spdEducationSelect";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@education", "%" + education + "%");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

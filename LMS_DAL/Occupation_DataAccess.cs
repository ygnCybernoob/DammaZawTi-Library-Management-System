using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LMS_INFO;

namespace LMS_DAL
{
    public class Occupation_DataAccess : MyConnection
    {
        public void Insert_Occupation(Occupation_Info info)
        {
            sqlString = "spdOccupationInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Occupation", info.Occupation);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        
        }

        public void Update_Occupation(Occupation_Info info)
        {
            sqlString = "spdOccupationUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Occupationid", info.Occupationid);
            command.Parameters.AddWithValue("@Occupation", info.Occupation);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        public IDataReader Select_Occupation(int type, string occupation)
        {
            sqlString = "spdOccupationSelect";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@occupation", "%"+occupation+"%");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

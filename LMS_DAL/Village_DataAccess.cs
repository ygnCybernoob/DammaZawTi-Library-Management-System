using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LMS_INFO;

namespace LMS_DAL
{
    public class Village_DataAccess:MyConnection
    {
        public void Insert_Village(Village_Info info)
        {
            sqlString = "spdVillageInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@townshipid", info.Townshipid);
            command.Parameters.AddWithValue("@village", info.Village);
            command.Parameters.AddWithValue("@desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_Village(Village_Info info)
        {
            sqlString = "spdVillageUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Villageid", info.Villageid);
            command.Parameters.AddWithValue("@townshipid", info.Townshipid);
            command.Parameters.AddWithValue("@Village", info.Village);
            command.Parameters.AddWithValue("@desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader Select_Village(int type, int townshipid, int stateid, string village) 
        {
            sqlString = "spdVillageSelect";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@townshipid", townshipid);
            command.Parameters.AddWithValue("@stateid", stateid);
            command.Parameters.AddWithValue("@village", "%"+village+"%");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

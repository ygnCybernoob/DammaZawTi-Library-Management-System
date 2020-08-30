using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LMS_INFO;

namespace LMS_DAL
{
    public class MemberType_DataAccess : MyConnection
    {
        public void Insert_MemberType(MemberType_Info info)
        {
            sqlString = "spdMemberTypeInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MemberType", info.Membertype);
            command.Parameters.AddWithValue("@allowbook", info.Allowbook);
            command.Parameters.AddWithValue("@allowday", info.Allowday);
            command.Parameters.AddWithValue("@expiredate", info.Expiredate);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_MemberType(MemberType_Info info)
        {
            sqlString = "spdMemberTypeUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MemberTypeid", info.Membertypeid);
            command.Parameters.AddWithValue("@MemberType", info.Membertype);
            command.Parameters.AddWithValue("@allowbook", info.Allowbook);
            command.Parameters.AddWithValue("@allowday", info.Allowday);
            command.Parameters.AddWithValue("@expiredate", info.Expiredate);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader Select_MemberType()
        {
            sqlString = "spdMemberTypeSelect";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

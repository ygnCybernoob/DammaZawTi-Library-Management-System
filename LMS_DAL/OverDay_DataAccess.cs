using System;
using System.Collections.Generic;
using System.Text;
using LMS_INFO;
using System.Data;
using System.Data.SqlClient;

namespace LMS_DAL
{
    public class OverDay_DataAccess : MyConnection
    {

        public IDataReader Select_OverdayMember_Qty()
        {
            sqlString = "spdOverdayMember_Qty";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_OverdayMember_List()
        {
            sqlString = "spdOverdayMember_List";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

    }
}

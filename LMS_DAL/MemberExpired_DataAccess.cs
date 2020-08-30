using System;
using System.Collections.Generic;
using System.Text;
using LMS_INFO;
using System.Data;
using System.Data.SqlClient;

namespace LMS_DAL
{
    public class MemberExpired_DataAccess : MyConnection
    {

        public void Update_Expired(int memberid)
        {
            sqlString = @"UPDATE tblMember SET MemberStatus='expired'
            WHERE Memberid=@memberid";
            command = new SqlCommand(sqlString, connection);
            command.Parameters.AddWithValue("@memberid", memberid);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

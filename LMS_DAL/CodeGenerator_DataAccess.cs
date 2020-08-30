using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LMS_DAL
{
    public class CodeGenerator_DataAccess: MyConnection
    {
        public long Select_MemberCode()
        {
            long memberCode = 0;
            sqlString = "SELECT MemberCode FROM tblCodeGenerate";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                memberCode= Convert.ToInt64(reader["MemberCode"]);
            }

            reader.Close();
            connection.Close();

            return memberCode;
        }

        public long Select_BookCode(int CategoryId)
        {
            long bookcode = 0;
            sqlString = "SELECT BookCode FROM tblBookCodeGenerate WHERE Categoryid=@categoryid";
            command = new SqlCommand(sqlString, connection);
            command.Parameters.AddWithValue("@Categoryid", CategoryId);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                bookcode = Convert.ToInt64(reader["BookCode"]);
            }

            reader.Close();
            connection.Close();

            return bookcode;
        }

        public void UpdateMemberCode()
        {
            sqlString = @"UPDATE tblCodeGenerate SET MemberCode=(MemberCode+1)";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateBookCode()
        {
            sqlString = @"UPDATE tblCodeGenerate SET BookCode=(BookCode+1)";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using LMS_INFO;
using System.Data;
using System.Data.SqlClient;

namespace LMS_DAL
{
    public class Account_DataAccess : MyConnection
    {
        public IDataReader SelectAccount()
        {
            sqlString = "SELECT AccountId, UserName FROM tblAccount ORDER BY UserName";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader CheckAccount(string accountid, string password)
        {
            sqlString = "SELECT AccountType, AccountStatus FROM tblAccount WHERE AccountId=@accountid AND Password=@password";
            command = new SqlCommand(sqlString, connection);
            command.Parameters.AddWithValue("@accountid", accountid);
            command.Parameters.AddWithValue("@password", password);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader SelectAccountInfo(string accountid)
        {
            sqlString = "SELECT * FROM tblAccount WHERE AccountId=@accountid";
            command = new SqlCommand(sqlString, connection);
            command.Parameters.AddWithValue("@accountid", accountid);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void UpdatePassword(string accountid, string password)
        {
            sqlString = @"UPDATE tblAccount SET Password=@password, AccountStatus='yes' WHERE AccountId=@accountid";
            command = new SqlCommand(sqlString, connection);
            command.Parameters.AddWithValue("@accountid", accountid);
            command.Parameters.AddWithValue("@password", password);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

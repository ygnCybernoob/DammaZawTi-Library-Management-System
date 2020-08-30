using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LMS_INFO;

namespace LMS_DAL
{
    public class BookCategory_DataAccess : MyConnection
    {
        public void Insert_Category(BookCategory_Info info)
        {
            sqlString = "spdBookCategoryInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@categorycode", info.Categorycode);
            command.Parameters.AddWithValue("@Category", info.Category);
            command.Parameters.AddWithValue("@desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_Category(BookCategory_Info info)
        {
            sqlString = "spdBookCategoryUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Categoryid", info.Categoryid);
            command.Parameters.AddWithValue("@categorycode", info.Categorycode);
            command.Parameters.AddWithValue("@Category", info.Category);
            command.Parameters.AddWithValue("@desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader Select_BookTypeCode(int typeid)
        {
            sqlString = "SELECT CategoryCode FROM tblBookCategory WHERE CategoryId=@typeid";
            command = new SqlCommand(sqlString, connection);
            command.Parameters.AddWithValue("@typeid", typeid);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_Category()
        {
            sqlString = "spdBookCategorySelect";
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

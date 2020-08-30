using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LMS_INFO;

namespace LMS_DAL
{
    public class Feedback_DataAccess : MyConnection
    {

        public IDataReader Select_Fine(int type, int month, int year)
        {
            sqlString = "spdFeedbackSelect";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@month", month);
            command.Parameters.AddWithValue("@year", year);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }


        public void Insert_Feedback(Feedback_Info info)
        {
            sqlString = "spdFeedbackInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@memberbarcode", info.Memberbarcode);
            command.Parameters.AddWithValue("@subject", info.Subject);
            command.Parameters.AddWithValue("@feedback", info.Feedback);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_Feedback(int feedbackid)
        {
            sqlString = "spdFeedbackCheckUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@feedbackid",feedbackid);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

    }
}

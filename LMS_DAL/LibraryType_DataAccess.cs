using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LMS_DAL
{
    public class LibraryType_DataAccess : MyConnection
    {
        public void InsertLibraryType(string type)
        {
            sqlString = "spdLibraryType";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@librarytype", type);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader SelectLibraryType()
        {
            sqlString = "SELECT LibraryType FROM tblLibraryType";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

    }
}

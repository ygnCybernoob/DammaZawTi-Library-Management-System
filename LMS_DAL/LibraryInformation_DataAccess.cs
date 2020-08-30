using System;
using System.Collections.Generic;
using System.Text;
using LMS_INFO;
using System.Data;
using System.Data.SqlClient;

namespace LMS_DAL
{
    public class LibraryInformation_DataAccess:MyConnection
    {
        public void Update_LibraryInformation(LibraryInfomation_Info info)
        {
            sqlString = "spdLibraryInformationUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@librarylogo", info.Librarylogo);
            command.Parameters.AddWithValue("@libraryname", info.Libraryname);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader Select_LibraryInformation()
        {
            sqlString = "spdLibraryInformationSelect";
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

using System;
using System.Collections.Generic;
using System.Text;
using LMS_INFO;
using System.Data;
using System.Data.SqlClient;

namespace LMS_DAL
{
    public class Librarian_DataAccess : MyConnection
    {
        public IDataReader Select_Librarian()
        {
            sqlString = "spdLibrarianSelect";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void Insert_Librarian(Librarian_Info info)
        {
            sqlString = "spdLibrarianInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@LibrarianImage", info.Imagebyte);
            command.Parameters.AddWithValue("@LibrarianName", info.Librarianname);
            command.Parameters.AddWithValue("@UserName", info.Username);
            command.Parameters.AddWithValue("@Password", info.Password);
            command.Parameters.AddWithValue("@AccountType", info.Accounttype);
            command.Parameters.AddWithValue("@Gender", info.Gender);
            command.Parameters.AddWithValue("@NRC", info.Nrc);
            command.Parameters.AddWithValue("@Street", info.Street);
            command.Parameters.AddWithValue("@HomeNo", info.Homeno);
            command.Parameters.AddWithValue("@VillageId", info.Villageid);
            command.Parameters.AddWithValue("@PhoneNo", info.Phoneno);
            command.Parameters.AddWithValue("@DateAdded", info.Dateadded);
            command.Parameters.AddWithValue("@AddedBy", info.Addedby);
            command.Parameters.AddWithValue("@Desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_Librarian(Librarian_Info info)
        {
            sqlString = "spdLibrarianUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@LibrarianId", info.Librarianid);
            command.Parameters.AddWithValue("@LibrarianImage", info.Imagebyte);
            command.Parameters.AddWithValue("@LibrarianName", info.Librarianname);
            command.Parameters.AddWithValue("@UserName", info.Username);
            command.Parameters.AddWithValue("@Password", info.Password);
            command.Parameters.AddWithValue("@AccountType", info.Accounttype);
            command.Parameters.AddWithValue("@AccountStatus", info.Accountstatus);
            command.Parameters.AddWithValue("@Gender", info.Gender);
            command.Parameters.AddWithValue("@NRC", info.Nrc);
            command.Parameters.AddWithValue("@Street", info.Street);
            command.Parameters.AddWithValue("@HomeNo", info.Homeno);
            command.Parameters.AddWithValue("@VillageId", info.Villageid);
            command.Parameters.AddWithValue("@PhoneNo", info.Phoneno);
            command.Parameters.AddWithValue("@Status", info.Status);
            command.Parameters.AddWithValue("@AddedBy", info.Addedby);
            command.Parameters.AddWithValue("@Desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete_Librarian(int librarianid)
        {

        }

    }
}

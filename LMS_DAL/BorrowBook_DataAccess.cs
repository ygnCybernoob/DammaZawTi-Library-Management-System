using System;
using System.Collections.Generic;
using System.Text;
using LMS_INFO;
using System.Data;
using System.Data.SqlClient;

namespace LMS_DAL
{
    public class BorrowBook_DataAccess : MyConnection
    {
        public void Insert_ReturnBook(BorrowBook_Info info)
        {
            sqlString = "spdReturn";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@borrowbookid", info.Borrowbookid);
            command.Parameters.AddWithValue("@ReturnDate", info.Returndate);
            command.Parameters.AddWithValue("@Fine", info.Fine);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Insert_BorrowBook(BorrowBook_Info info)
        {
            sqlString = "spdBorrowBookInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@memberid", info.Memberid);
            command.Parameters.AddWithValue("@bookid", info.Bookid);
            command.Parameters.AddWithValue("@Librarianid", info.Librarianid);
            command.Parameters.AddWithValue("@dateborrowed", info.Dateborrowed);
            command.Parameters.AddWithValue("@duedate", info.Duedate);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader Select_BorrowedBook_Qty(BorrowBook_Info info)
        {
            sqlString = "spdBorrowedBookAmount";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@librarytype", info.Librarytype);
            command.Parameters.AddWithValue("@memberid", info.Memberid);
            command.Parameters.AddWithValue("@today", info.Dateborrowed);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_BorrowedBook(int memberid)
        {
            sqlString = "spdBorrowedBookSelect";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@memberid",memberid);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_RentingList()
        {
            sqlString = "spdRentingList";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_ReturnedList(int type, string memberbarcode, int month, int year)
        {
            sqlString = "spdReturnedList";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@memberbarcode", memberbarcode);
            command.Parameters.AddWithValue("@month", month);
            command.Parameters.AddWithValue("@year", year);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_BorrowedReport(int type, int month, int year, DateTime start, DateTime end, int qty)
        {
            sqlString = "spdBorrowedReport";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@month", month);
            command.Parameters.AddWithValue("@year", year);
            command.Parameters.AddWithValue("@startdate", start);
            command.Parameters.AddWithValue("@enddate", end);
            command.Parameters.AddWithValue("@qtyofbook", qty);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

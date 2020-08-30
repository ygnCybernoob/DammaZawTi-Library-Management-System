using System;
using System.Collections.Generic;
using System.Text;
using LMS_INFO;
using System.Data;
using System.Data.SqlClient;

namespace LMS_DAL
{
    public class Book_DataAccess : MyConnection
    {
        public void Insert_Book(Book_Info info)
        {
            sqlString = "spdBookInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@categoryid", info.Categoryid);
            command.Parameters.AddWithValue("@booktitle", info.Booktitle);
            command.Parameters.AddWithValue("@bookcover", info.CoverByte);
            command.Parameters.AddWithValue("@bookbarcode", info.Bookbarcode);
            command.Parameters.AddWithValue("@author1id", info.Author1id);
            command.Parameters.AddWithValue("@author2id", info.Author2id);
            command.Parameters.AddWithValue("@bookcopy", info.Bookcopy);
            command.Parameters.AddWithValue("@price", info.Price);
            command.Parameters.AddWithValue("@publisher", info.Publisher);
            command.Parameters.AddWithValue("@publishdate", info.Publishdate);
            command.Parameters.AddWithValue("@dateadded", info.Dateadded);
            command.Parameters.AddWithValue("@adultchild", info.Adultchild);
            command.Parameters.AddWithValue("@desp", info.Desp);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_Book(Book_Info info)
        {
            sqlString = "spdBookUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@bookid", info.Bookid);
            command.Parameters.AddWithValue("@categoryid", info.Categoryid);
            command.Parameters.AddWithValue("@bookbarcode", info.Bookbarcode);
            command.Parameters.AddWithValue("@booktitle", info.Booktitle);
            command.Parameters.AddWithValue("@bookcover", info.CoverByte);
            command.Parameters.AddWithValue("@author1id", info.Author1id);
            command.Parameters.AddWithValue("@author2id", info.Author2id);
            command.Parameters.AddWithValue("@bookcopy", info.Bookcopy);
            command.Parameters.AddWithValue("@price", info.Price);
            command.Parameters.AddWithValue("@publisher", info.Publisher);
            command.Parameters.AddWithValue("@publishdate", info.Publishdate);
            command.Parameters.AddWithValue("@dateadded", info.Dateadded);
            command.Parameters.AddWithValue("@adultchild", info.Adultchild);
            command.Parameters.AddWithValue("@desp", info.Desp);
            command.Parameters.AddWithValue("@status", info.Status);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader Select_Book(Book_Info info)
        {
            sqlString = "spdBookSelect";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@selecttype", info.Selecttype);
            command.Parameters.AddWithValue("@categoryid", info.Categoryid);
            command.Parameters.AddWithValue("@bookbarcode", info.Bookbarcode);
            command.Parameters.AddWithValue("@booktitle", "%" + info.Booktitle + "%");
            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Search_Book(Book_Info info)
        {
            sqlString = "spdBookSearch";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@selecttype", info.Selecttype);
            command.Parameters.AddWithValue("@categoryid", info.Categoryid);
            command.Parameters.AddWithValue("@bookbarcode", info.Bookbarcode);
            command.Parameters.AddWithValue("@booktitle", "%" + info.Booktitle + "%");
            command.Parameters.AddWithValue("@authorid", info.Authorid);
            command.Parameters.AddWithValue("@AdultChild", info.Adultchild);
            command.Parameters.AddWithValue("@dateadded", info.Dateadded);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_BookBasicInfo(string bookbarcode)
        {
            sqlString = "spdBookBasicInfo";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@bookbarcode", bookbarcode);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void Insert_LostorDamage(int bookid, int qty)
        {
            sqlString = "spdLostorDamageInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@bookid", bookid);
            command.Parameters.AddWithValue("@qty", qty);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader Select_TopRent()
        {
            sqlString = "spdSelectTopRent";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }


        public IDataReader Select_QtyAndEarlyDueDate(int bookid)
        {
            sqlString = "spdSelectQtyAndEarlyDueDate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@bookid", bookid);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_BookQty()
        {
            sqlString = "spdBookQty";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_BookQtyByAuthor()
        {
            sqlString = @"SELECT     TOP (100) PERCENT tblAuthor.Author, SUM(tblBook.BookCopy) AS qtyOfBook
FROM         tblAuthor LEFT OUTER JOIN
                      tblBook ON tblAuthor.AuthorId = tblBook.Author1Id
GROUP BY tblAuthor.Author
ORDER BY tblAuthor.Author";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_BookQtyByCategory()
        {
            sqlString = @"SELECT     TOP (100) PERCENT tblBookCategory.Category, SUM(tblBook.BookCopy) AS qtyOfBook
FROM         tblBookCategory LEFT OUTER JOIN
                      tblBook ON tblBookCategory.CategoryId = tblBook.CategoryId
GROUP BY tblBookCategory.Category
ORDER BY tblBookCategory.Category";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_LostBook()
        {
            sqlString = @"SELECT     TOP (100) PERCENT tblBook.BookId, tblBook.BookTitle, tblBook.BookBarcode, SUM(tblLostorDamage.Qty) AS Qty
FROM         tblBook INNER JOIN
                      tblLostorDamage ON tblBook.BookId = tblLostorDamage.Bookid
GROUP BY tblBook.BookId, tblBook.BookTitle, tblBook.BookBarcode
ORDER BY tblBook.BookTitle";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

    }
}

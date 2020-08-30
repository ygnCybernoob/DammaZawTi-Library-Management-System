using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;
using System.IO;
using System.Drawing;

namespace LMS_BLL
{
    public class BorrowBook_Controller
    {
        DateTime today;
        TimeSpan timespan;
        BorrowBook_DataAccess data_access;
        private int no;

        public BorrowBook_Controller()
        {
            data_access = new BorrowBook_DataAccess();
            today = System.DateTime.Today;
        }

        public void Insert_BorrwedBook(BorrowBook_Info info)
        {
            data_access.Insert_BorrowBook(info);
        }

        public void Insert_ReturnBook(BorrowBook_Info info)
        {
            data_access.Insert_ReturnBook(info);
        }

        public int Select_BorrwedBook_Qty(BorrowBook_Info info) //by memberid, date, librarytype
        {
            IDataReader reader = data_access.Select_BorrowedBook_Qty(info);
            int borrowedbook = 0;

            if (reader.Read())
            {
                borrowedbook = Convert.ToInt32(reader["BorrowedBook"]);
            }

            reader.Close();

            return borrowedbook ;// qty of book
        }

        public BorrowBook_Collection Select_BorrowedBook(int memberId, float fine)
        {
            BorrowBook_Info info;
            BorrowBook_Collection collection = new BorrowBook_Collection();
            IDataReader reader = data_access.Select_BorrowedBook(memberId);

            while (reader.Read())
            {
                info = new BorrowBook_Info();

                info.Borrowbookid = Convert.ToInt32(reader["borrowbookid"]);
                info.Dateborrowed = Convert.ToDateTime(reader["dateborrowed"]);
                info.Duedate = Convert.ToDateTime(reader["duedate"]);

                info.Booktitle = Convert.ToString(reader["booktitle"]);
                info.CoverByte = (byte[])reader["bookcover"];
                info.Bookbarcode = Convert.ToString(reader["bookbarcode"]);

                if (info.CoverByte.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(info.CoverByte);
                    info.BookCover = Image.FromStream(ms);
                }
                else
                {
                    info.BookCover = null;
                }

                timespan = today - info.Duedate;

                if (timespan.TotalDays <= 0)
                {
                    info.Overday = 0;
                    info.Fine = 0;
                }
                else
                {
                    info.Overday = Convert.ToInt32(timespan.TotalDays);
                    info.Fine = (info.Overday * fine);// calculate fine
                }
                //info.Fine = 

                collection.Add(info);
            }
            reader.Close();

            return collection;
        }

        public BorrowBook_Collection Select_RentingList()
        {
            BorrowBook_Collection collection = new BorrowBook_Collection();
            BorrowBook_Info info;
            IDataReader reader = data_access.Select_RentingList();

            while (reader.Read())
            {
                info = new BorrowBook_Info();

                info.No = ++no;
                info.Memberid = Convert.ToInt32(reader["memberid"]);
                info.Bookid = Convert.ToInt32(reader["bookid"]);
                info.Borrowbookid = Convert.ToInt32(reader["borrowbookid"]);
                info.Membername = Convert.ToString(reader["Membername"]);
                info.Booktitle = Convert.ToString(reader["booktitle"]);
                info.Bookbarcode = Convert.ToString(reader["bookbarcode"]);
                info.Memberbarcode = Convert.ToString(reader["memberbarcode"]);
                info.Phoneno = Convert.ToString(reader["phoneno"]);
                info.Dateborrowed = Convert.ToDateTime(reader["dateborrowed"]);
                info.Duedate = Convert.ToDateTime(reader["duedate"]);
                info.Librarianname = Convert.ToString(reader["LibrarianName"]);

                timespan = today - info.Duedate;

                if (timespan.TotalDays <= 0)
                {
                    info.Overday = 0;
                }
                else
                {
                    info.Overday = Convert.ToInt32(timespan.TotalDays);
                }

                collection.Add(info);
            }
            reader.Close();

            return collection;
        }

        public BorrowBook_Collection Select_BorrowedReport(int type, int month, int year, DateTime start, DateTime end, int qty)
        {
            BorrowBook_Collection collection = new BorrowBook_Collection();
            BorrowBook_Info info;
            IDataReader reader = data_access.Select_BorrowedReport(type, month, year, start, end, qty);

            while (reader.Read())
            {
                info = new BorrowBook_Info();

                info.No = ++no;
                info.Memberid = Convert.ToInt32(reader["Memberid"]);
                info.Memberbarcode = Convert.ToString(reader["MemberBarcode"]);
                info.Membername = Convert.ToString(reader["MemberName"]);
                info.Borrowedqty = Convert.ToInt32(reader["Borrowedqty"]);

                collection.Add(info);
            }

            reader.Close();
            return collection;
        }

        public BorrowBook_Collection Select_ReturnedList(int type, string memberbarcode, int month, int year)
        {
            BorrowBook_Collection collection = new BorrowBook_Collection();
            BorrowBook_Info info;
            IDataReader reader = data_access.Select_ReturnedList(type, memberbarcode, month, year);

            while (reader.Read())
            {
                info = new BorrowBook_Info();

                info.No = ++no;
                info.Membername = Convert.ToString(reader["Membername"]);
                info.Booktitle = Convert.ToString(reader["booktitle"]);
                info.Bookbarcode = Convert.ToString(reader["bookbarcode"]);
                info.Memberbarcode = Convert.ToString(reader["memberbarcode"]);
                info.Dateborrowed = Convert.ToDateTime(reader["dateborrowed"]);
                info.Returndate = Convert.ToDateTime(reader["returndate"]);
                info.Duedate = Convert.ToDateTime(reader["duedate"]);
                info.Fine = Convert.ToInt64(reader["fine"]);
                info.Librarianname = Convert.ToString(reader["LibrarianName"]);

                timespan = today - info.Duedate;

                if (timespan.TotalDays <= 0)
                {
                    info.Overday = 0;
                }
                else
                {
                    info.Overday = Convert.ToInt32(timespan.TotalDays);
                }

                collection.Add(info);
            }
            reader.Close();

            return collection;
        }

    }

    public class BorrowBook_Collection : Collection<BorrowBook_Info>
    {

    }
}

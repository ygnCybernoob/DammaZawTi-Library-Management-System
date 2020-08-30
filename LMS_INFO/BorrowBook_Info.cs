using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LMS_INFO
{
    public class BorrowBook_Info
    {
        private byte[] coverByte;

        public byte[] CoverByte
        {
            get { return coverByte; }
            set { coverByte = value; }
        }

        private Image bookCover;

        public Image BookCover
        {
            get { return bookCover; }
            set { bookCover = value; }
        }


        private int borrowbookid,
            memberid,
            bookid,
            librarianid,
            overday,
            no,
            borrowedqty;

        public int Borrowedqty
        {
            get { return borrowedqty; }
            set { borrowedqty = value; }
        }

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Overday
        {
            get { return overday; }
            set { overday = value; }
        }

        public int Borrowbookid
        {
            get { return borrowbookid; }
            set { borrowbookid = value; }
        }

        public int Memberid
        {
            get { return memberid; }
            set { memberid = value; }
        }

        public int Bookid
        {
            get { return bookid; }
            set { bookid = value; }
        }

        public int Librarianid
        {
            get { return librarianid; }
            set { librarianid = value; }
        }
        private DateTime dateborrowed,
            duedate,
            returndate;

        public DateTime Dateborrowed
        {
            get { return dateborrowed; }
            set { dateborrowed = value; }
        }

        public DateTime Duedate
        {
            get { return duedate; }
            set { duedate = value; }
        }

        public DateTime Returndate
        {
            get { return returndate; }
            set { returndate = value; }
        }
        private float fine;

        public float Fine
        {
            get { return fine; }
            set { fine = value; }
        }
        private string borrowstatus,
            librarytype,
            booktitle,
            bookbarcode,
            membername,
            memberbarcode,
            phoneno,
            librarianname;

        public string Librarianname
        {
            get { return librarianname; }
            set { librarianname = value; }
        }

        public string Phoneno
        {
            get { return phoneno; }
            set { phoneno = value; }
        }

        public string Memberbarcode
        {
            get { return memberbarcode; }
            set { memberbarcode = value; }
        }

        public string Membername
        {
            get { return membername; }
            set { membername = value; }
        }

        public string Bookbarcode
        {
            get { return bookbarcode; }
            set { bookbarcode = value; }
        }

        public string Booktitle
        {
            get { return booktitle; }
            set { booktitle = value; }
        }

        public string Librarytype
        {
            get { return librarytype; }
            set { librarytype = value; }
        }

        public string Borrowstatus
        {
            get { return borrowstatus; }
            set { borrowstatus = value; }
        }
    }
}

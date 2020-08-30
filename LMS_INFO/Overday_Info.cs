using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class Overday_Info
    {
        private int memberid,
            bookid,
            borrowbookid,
            overday,
            no;

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

        public int Bookid
        {
            get { return bookid; }
            set { bookid = value; }
        }

        public int Memberid
        {
            get { return memberid; }
            set { memberid = value; }
        }

        private DateTime dateborrowed,
            duedate;

        public DateTime Duedate
        {
            get { return duedate; }
            set { duedate = value; }
        }

        public DateTime Dateborrowed
        {
            get { return dateborrowed; }
            set { dateborrowed = value; }
        }

        private string memberbarcode,
            membername,
            bookbarcode,
            booktitle,
            phoneno;

        public string Phoneno
        {
            get { return phoneno; }
            set { phoneno = value; }
        }

        public string Booktitle
        {
            get { return booktitle; }
            set { booktitle = value; }
        }

        public string Bookbarcode
        {
            get { return bookbarcode; }
            set { bookbarcode = value; }
        }

        public string Membername
        {
            get { return membername; }
            set { membername = value; }
        }

        public string Memberbarcode
        {
            get { return memberbarcode; }
            set { memberbarcode = value; }
        }
    }
}

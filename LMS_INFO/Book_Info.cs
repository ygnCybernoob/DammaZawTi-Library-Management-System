using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LMS_INFO
{
    public class Book_Info
    {
        private byte[] coverByte;
        private int bookid,
            categoryid,
            author1id,
            author2id,
            bookcopy,
            no,
            selecttype,
            authorid,
            authortypeid;

        private int qtyofbook,
            lost,
            remain,
            adult,
            child,
            renting;

        public int Renting
        {
            get { return renting; }
            set { renting = value; }
        }

        public int Child
        {
            get { return child; }
            set { child = value; }
        }

        public int Adult
        {
            get { return adult; }
            set { adult = value; }
        }

        public int Remain
        {
            get { return remain; }
            set { remain = value; }
        }

        public int Lost
        {
            get { return lost; }
            set { lost = value; }
        }

        public int Qtyofbook
        {
            get { return qtyofbook; }
            set { qtyofbook = value; }
        }

        public int Authortypeid
        {
            get { return authortypeid; }
            set { authortypeid = value; }
        }

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



        public int Authorid
        {
            get { return authorid; }
            set { authorid = value; }
        }

        public int Selecttype
        {
            get { return selecttype; }
            set { selecttype = value; }
        }

        public int Author1id
        {
            get { return author1id; }
            set { author1id = value; }
        }

        public int Author2id
        {
            get { return author2id; }
            set { author2id = value; }
        }

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Bookcopy
        {
            get { return bookcopy; }
            set { bookcopy = value; }
        }

        public int Categoryid
        {
            get { return categoryid; }
            set { categoryid = value; }
        }

        public int Bookid
        {
            get { return bookid; }
            set { bookid = value; }
        }

        private string booktitle,
            bookbarcode,
            publisher,
            adultchild,
            desp,
            status,
            author1,
            author2,
            category,
            earlyduedate;

        public string Earlyduedate
        {
            get { return earlyduedate; }
            set { earlyduedate = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Author2
        {
            get { return author2; }
            set { author2 = value; }
        }

        public string Author1
        {
            get { return author1; }
            set { author1 = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Desp
        {
            get { return desp; }
            set { desp = value; }
        }

        public string Adultchild
        {
            get { return adultchild; }
            set { adultchild = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
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

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private DateTime publishdate,
            dateadded;

        public DateTime Dateadded
        {
            get { return dateadded; }
            set { dateadded = value; }
        }

        public DateTime Publishdate
        {
            get { return publishdate; }
            set { publishdate = value; }
        }

    }
}

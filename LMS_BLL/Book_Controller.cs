using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class Book_Controller
    {
        Book_DataAccess data_access;
        private int no = 0;

        public Book_Controller()
        {
            data_access = new Book_DataAccess();
        }

        public void Insert_Book(Book_Info info)
        {
            data_access.Insert_Book(info);
        }

        public void Update_Book(Book_Info info)
        {
            data_access.Update_Book(info);
        }

        public Book_Collection Select_Book(Book_Info info1)
        {
            Book_Info info;
            Book_Collection collection = new Book_Collection();
            IDataReader reader = data_access.Select_Book(info1);

            while (reader.Read())
            {
                info = new Book_Info();
                info.No = ++no;

                info.Adultchild = Convert.ToString(reader["adultchild"]);
                info.Bookbarcode = Convert.ToString(reader["bookbarcode"]);
                info.Bookcopy = Convert.ToInt32(reader["bookcopy"]);

                info.CoverByte = (byte[])reader["bookcover"];

                if (info.CoverByte.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(info.CoverByte);
                    info.BookCover = Image.FromStream(ms);
                }
                else
                {
                    info.BookCover = null;
                }

                info.Author1id = Convert.ToInt32(reader["author1id"]);

                if (string.IsNullOrEmpty(Convert.ToString(reader["author2id"])))
                {
                    info.Author2id = -1;
                }
                else
                {
                    info.Author2id = Convert.ToInt32(reader["author2id"]);
                }

                info.Author1 = Convert.ToString(reader["author"]);
                info.Bookid = Convert.ToInt32(reader["Bookid"]);
                info.Booktitle = Convert.ToString(reader["booktitle"]);
                info.Category = Convert.ToString(reader["category"]);
                info.Categoryid = Convert.ToInt32(reader["categoryid"]);
                info.Dateadded = Convert.ToDateTime(reader["dateadded"]);
                info.Desp = Convert.ToString(reader["desp"]);
                info.Price = Convert.ToInt64(reader["price"]);
                info.Publishdate = Convert.ToDateTime(reader["publishdate"]);
                info.Publisher = Convert.ToString(reader["publisher"]);
                info.Status = Convert.ToString(reader["status"]);

                collection.Add(info);
            }
            reader.Close();
            return collection;
        }

        public Book_Collection Search_Book(Book_Info info1)
        {
            Book_Info info;
            Book_Collection collection = new Book_Collection();
            IDataReader reader = data_access.Search_Book(info1);

            while (reader.Read())
            {
                info = new Book_Info();
                info.No = ++no;
                info.Adultchild = Convert.ToString(reader["adultchild"]);
                if (info.Adultchild.Equals("adult"))
                {
                    info.Adultchild = "လူၾကီးစာေပ";
                }
                else
                {
                    info.Adultchild = "ကေလးစာေပ";
                }

                info.Bookbarcode = Convert.ToString(reader["bookbarcode"]);
                info.Author1 = Convert.ToString(reader["author"]);
                info.Bookid = Convert.ToInt32(reader["Bookid"]);
                info.Booktitle = Convert.ToString(reader["booktitle"]);
                info.Category = Convert.ToString(reader["category"]);
                info.Categoryid = Convert.ToInt32(reader["categoryid"]);
                info.Dateadded = Convert.ToDateTime(reader["dateadded"]);
                info.Desp = Convert.ToString(reader["desp"]);
                info.Publishdate = Convert.ToDateTime(reader["publishdate"]);
                collection.Add(info);
            }
            reader.Close();
            return collection;
        }

        public Book_Info Select_BookBasicInfo(string bookbarcode)
        {
            Book_Info info = new Book_Info();
            Book_Collection collection = new Book_Collection();
            IDataReader reader = data_access.Select_BookBasicInfo(bookbarcode);

            if (reader.Read())
            {
                info.Bookbarcode = Convert.ToString(reader["bookbarcode"]);

                info.CoverByte = (byte[])reader["bookcover"];

                if (info.CoverByte.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(info.CoverByte);
                    info.BookCover = Image.FromStream(ms);
                }
                else
                {
                    info.BookCover = null;
                }

                info.Bookid = Convert.ToInt32(reader["Bookid"]);
                info.Booktitle = Convert.ToString(reader["booktitle"]);
            }

            reader.Close();
            return info;
        }

        public void Insert_LostorDamage(int Bookid, int Qty)
        {
            data_access.Insert_LostorDamage(Bookid, Qty);
        }

        public Book_Collection Select_TopRent()
        {
            Book_Collection collection = new Book_Collection();
            Book_Info info;
            IDataReader reader = data_access.Select_TopRent();

            while (reader.Read())
            {
                info = new Book_Info();

                info.No = ++no;
                info.Categoryid = Convert.ToInt32(reader["categoryid"]);
                info.Category = Convert.ToString(reader["category"]);
                info.Bookid = Convert.ToInt32(reader["bookid"]);
                info.Author1 = Convert.ToString(reader["author"]);
                info.Bookbarcode = Convert.ToString(reader["bookbarcode"]);
                info.Booktitle = Convert.ToString(reader["booktitle"]);
                info.Publisher = Convert.ToString(reader["publisher"]);
                info.Publishdate = Convert.ToDateTime(reader["publishdate"]);
                info.Adultchild = Convert.ToString(reader["adultchild"]);
                if (info.Adultchild.Equals("adult"))
                {
                    info.Adultchild = "လူၾကီးစာေပ";
                }
                else
                {
                    info.Adultchild = "ကေလးစာေပ";
                }

                collection.Add(info);
            }
            reader.Close();
            return collection;
        }

        public Book_Info Select_QtyAndEarlyDueDate(int pbookid)
        {
            Book_Info info = new Book_Info();
            IDataReader reader = data_access.Select_QtyAndEarlyDueDate(pbookid);

            if (reader.Read())
            {
                info.Bookcopy = Convert.ToInt32(reader["bookcopy"]);

                if (info.Bookcopy <= 0 && string.IsNullOrEmpty(Convert.ToString(reader["duedate"])))
                {
                    info.Bookcopy = 0;
                    info.Earlyduedate = "ေပ်ာက္ဆုံး/ ပ်က္စီးသြားပါသျဖင့္ ငွား၍မရေသးပါ ခင္ဗ်ာ";
                }
                else if (info.Bookcopy > 0)
                {
                    info.Earlyduedate = "ငွားရမ္းနိုင္ပါသည္...";
                }
                else if (info.Bookcopy == 0)
                {
                    info.Earlyduedate = Convert.ToString(reader["duedate"]) + " တြင္\nျပန္လည္ေရာက္ရွိပါမည္";
                }
            }
            reader.Close();

            return info;
        }

        public Book_Info Select_BookQty()
        {
            Book_Info info = new Book_Info();
            IDataReader reader = data_access.Select_BookQty();

            if (reader.Read())
            {
                if (string.IsNullOrEmpty(Convert.ToString(reader["total"])))
                {
                    info.Qtyofbook = 0;
                }
                else
                {
                    info.Qtyofbook = Convert.ToInt32(reader["total"]);
                }

                if (string.IsNullOrEmpty(Convert.ToString(reader["lost"])))
                {
                    info.Lost = 0;
                }
                else
                {
                    info.Lost = Convert.ToInt32(reader["lost"]);
                }


                if (string.IsNullOrEmpty(Convert.ToString(reader["renting"])))
                {
                    info.Renting = 0;
                }
                else
                {
                    info.Renting = Convert.ToInt32(reader["renting"]);
                }

                if (string.IsNullOrEmpty(Convert.ToString(reader["remain"])))
                {
                    info.Remain = 0;
                }
                else
                {
                    info.Remain = Convert.ToInt32(reader["remain"]);
                }

                if (string.IsNullOrEmpty(Convert.ToString(reader["adult"])))
                {
                    info.Adult = 0;
                }
                else
                {
                    info.Adult = Convert.ToInt32(reader["adult"]);
                }

                if (string.IsNullOrEmpty(Convert.ToString(reader["child"])))
                {
                    info.Child = 0;
                }
                else
                {
                    info.Child = Convert.ToInt32(reader["child"]);
                }

            }
            reader.Close();

            return info;
        }

        public Book_Collection Select_BookQtyByAuthor()
        {
            Book_Info info;
            Book_Collection collection = new Book_Collection();
            IDataReader reader = data_access.Select_BookQtyByAuthor();

            while (reader.Read())
            {
                info = new Book_Info();

                info.Author1 = Convert.ToString(reader["author"]);

                if (string.IsNullOrEmpty(Convert.ToString(reader["qtyOfbook"])))
                {
                    info.Qtyofbook = 0;
                }
                else
                {
                    info.Qtyofbook = Convert.ToInt32(reader["qtyofbook"]);
                }


                collection.Add(info);
            }

            reader.Close();
            return collection;
        }

        public Book_Collection Select_BookQtyByCategory()
        {
            Book_Info info;
            Book_Collection collection = new Book_Collection();
            IDataReader reader = data_access.Select_BookQtyByCategory();

            while (reader.Read())
            {
                info = new Book_Info();

                info.Category = Convert.ToString(reader["category"]);

                if (string.IsNullOrEmpty(Convert.ToString(reader["qtyOfbook"])))
                {
                    info.Qtyofbook = 0;
                }
                else
                {
                    info.Qtyofbook = Convert.ToInt32(reader["qtyofbook"]);
                }

                collection.Add(info);
            }

            reader.Close();
            return collection;
        }

        public Book_Collection Select_LostBook()
        {
            Book_Info info;
            Book_Collection collection = new Book_Collection();
            IDataReader reader = data_access.Select_LostBook();

            while (reader.Read())
            {
                info = new Book_Info();

                info.No = ++no;
                info.Bookid = Convert.ToInt32(reader["bookid"]);
                info.Bookbarcode = Convert.ToString(reader["bookbarcode"]);
                info.Booktitle = Convert.ToString(reader["booktitle"]);
                info.Qtyofbook = Convert.ToInt32(reader["qty"]);

                collection.Add(info);
            }

            return collection;
        }

    }

    public class Book_Collection : Collection<Book_Info>
    {

    }
}

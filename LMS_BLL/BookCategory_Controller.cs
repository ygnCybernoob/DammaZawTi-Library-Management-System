using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class BookCategory_Controller
    {
        BookCategory_DataAccess data_access;
        private int no = 0;

        public BookCategory_Controller()
        {
            data_access = new BookCategory_DataAccess();
        }

        public void Insert_Category(BookCategory_Info info)
        {
            data_access.Insert_Category(info);
        }

        public void Update_Category(BookCategory_Info info)
        {
            data_access.Update_Category(info);
        }

        public string Select_BookTypeCode(int typeid)
        {
            IDataReader reader = data_access.Select_BookTypeCode(typeid);
            string code = "";

            if (reader.Read())
            {
                code = Convert.ToString(reader["CategoryCode"]);
            }
            reader.Close();
            return code;
        }

        public BookCategory_Collection Select_Category()
        {
            BookCategory_Info info;
            BookCategory_Collection collection = new BookCategory_Collection();
            IDataReader reader = data_access.Select_Category();

            while (reader.Read())
            {
                info = new BookCategory_Info();
                info.No = ++no;
                info.Categoryid = Convert.ToInt32(reader["Categoryid"]);
                info.Categorycode = Convert.ToString(reader["categorycode"]);
                info.Category = Convert.ToString(reader["Category"]);
                info.Desp = Convert.ToString(reader["desp"]);
                collection.Add(info);
            }
            reader.Close();
            return collection;
        }

    }

    public class BookCategory_Collection : Collection<BookCategory_Info>
    {

    }
}

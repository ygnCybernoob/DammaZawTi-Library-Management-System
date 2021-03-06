using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class Author_Controller
    {
        Author_DataAccess data_access;
        private int no=0;

        public Author_Controller()
        {
            data_access = new Author_DataAccess();
        }

        public void Insert_Author(Author_Info info)
        {
            data_access.Insert_Author(info);
        }

        public void Update_Author(Author_Info info)
        {
            data_access.Update_Author(info);
        }

        public Author_Collection Select_Author(int type, string author)
        {
            Author_Info info;
            Author_Collection collection = new Author_Collection();
            IDataReader reader = data_access.Select_Author(type, author);

            while (reader.Read())
            {
                info = new Author_Info();
                info.No = ++no;
                info.Authorid = Convert.ToInt32(reader["authorid"]);
                info.Author = Convert.ToString(reader["author"]);
                info.Gender = (Convert.ToString(reader["gender"]).Equals("male"))?"က်ား":"မ";
                info.Desp = Convert.ToString(reader["desp"]);
                collection.Add(info);
            }
            reader.Close();
            return collection;
        }
    }

    public class Author_Collection : Collection<Author_Info>
    {

    }
}

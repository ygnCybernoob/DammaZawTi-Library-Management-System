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
    public class Librarian_Controller
    {
        Librarian_DataAccess data_access;
        private int no=0;

        public Librarian_Controller()
        {
            data_access = new Librarian_DataAccess();
        }

        public Librarian_Collection Select_Librarian()
        {
            Librarian_Collection collection = new Librarian_Collection();
            Librarian_Info info;
            IDataReader reader = data_access.Select_Librarian();

            while (reader.Read())
            {
                info = new Librarian_Info();

                info.No = ++no;
                info.Stateid = Convert.ToInt32(reader["stateid"]);
                info.State = Convert.ToString(reader["statedivision"]);
                info.Townshipid = Convert.ToInt32(reader["townshipid"]);
                info.Township = Convert.ToString(reader["township"]);
                info.Villageid = Convert.ToInt32(reader["villageid"]);
                info.Village = Convert.ToString(reader["village"]);
                info.Librarianid = Convert.ToInt32(reader["librarianid"]);
                info.Imagebyte = (byte[]) reader["librarianimage"];

                if (info.Imagebyte.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(info.Imagebyte);
                    info.Librarianimage = Image.FromStream(ms);
                }
                else
                {
                    info.Librarianimage = null;
                }

                info.Librarianname = Convert.ToString(reader["librarianname"]);
                info.Gender = Convert.ToString(reader["gender"]);
                info.Nrc = Convert.ToString(reader["nrc"]);
                info.Phoneno = Convert.ToString(reader["phoneno"]);
                info.Street = Convert.ToString(reader["street"]);
                info.Homeno = Convert.ToString(reader["homeno"]);
                info.Dateadded = Convert.ToDateTime(reader["dateadded"]);
                info.Addedby = Convert.ToString(reader["addedby"]);
                info.Desp = Convert.ToString(reader["desp"]);
                info.Username = Convert.ToString(reader["username"]);
                info.Password = Convert.ToString(reader["password"]);
                info.Accounttype = Convert.ToString(reader["accounttype"]);
                
                collection.Add(info);
            }
            reader.Close();

            return collection;
        }

        public void Insert_Librarian(Librarian_Info info)
        {
            data_access.Insert_Librarian(info);
        }

        public void Update_Librarian(Librarian_Info info)
        {
            data_access.Update_Librarian(info);
        }

        public void Delete_Librarian(int librarianid)
        {
            data_access.Delete_Librarian(librarianid);
        }
    }

    public class Librarian_Collection : Collection<Librarian_Info>
    {

    }
}

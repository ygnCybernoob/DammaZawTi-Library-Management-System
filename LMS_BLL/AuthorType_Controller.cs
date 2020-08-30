using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class AuthorType_Controller
    {
        AuthorType_DataAccess data_access;
        private int no = 0;

        public AuthorType_Controller()
        {
            data_access = new AuthorType_DataAccess();
        }

        public AuthorType_Collection Select_AuthorType()
        {
            AuthorType_Info info;
            AuthorType_Collection collection = new AuthorType_Collection();
            IDataReader reader = data_access.Select_AuthorType();

            while (reader.Read())
            {
                info = new AuthorType_Info();
                info.No = ++no;
                info.Authortypeid = Convert.ToInt32(reader["authortypeid"]);
                info.Authortype = Convert.ToString(reader["authortype"]);
                info.Desp = Convert.ToString(reader["desp"]);
                collection.Add(info);
            }
            reader.Close();
            return collection;
        }

        public void Insert_AuthorType(AuthorType_Info info)
        {
            data_access.Insert_AuthorType(info);
        }

        public void Update_AuthorType(AuthorType_Info info)
        {
            data_access.Update_AuthorType(info);
        }


    }

    public class AuthorType_Collection : Collection<AuthorType_Info>
    {

    }
}

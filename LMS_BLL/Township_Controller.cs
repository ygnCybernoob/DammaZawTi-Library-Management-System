using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class Township_Controller
    {
        Township_DataAccess data_access;
        private int no = 0;

        public Township_Controller()
        {
            data_access = new Township_DataAccess();
        }

        public void Insert_Township(Township_Info info)
        {
            data_access.Insert_Township(info);
        }

        public void Update_Township(Township_Info info)
        {
            data_access.Update_Township(info);
        }

        public Township_Collection Select_Township(int type, int stateid, string township) //if null -1
        {
            Township_Collection collection = new Township_Collection();
            Township_Info info;
            IDataReader reader = data_access.Select_Township(type, stateid, township);

            while (reader.Read())
            {
                info = new Township_Info();

                info.No = ++no;
                info.Townshipid = Convert.ToInt32(reader["townshipid"]);
                info.Stateid = Convert.ToInt32(reader["stateid"]);
                info.State = Convert.ToString(reader["statedivision"]);
                info.Township = Convert.ToString(reader["township"]);
                info.Desp = Convert.ToString(reader["desp"]);

                collection.Add(info);
            }
            reader.Close();

            return collection;
        }
    }

    public class Township_Collection : Collection<Township_Info>
    {

    }
}

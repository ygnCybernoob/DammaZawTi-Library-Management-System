using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class Village_Controller
    {
        Village_DataAccess data_access;
        private int no = 0;

        public Village_Controller()
        {
            data_access = new Village_DataAccess();
        }

        public void Insert_Village(Village_Info info)
        {
            data_access.Insert_Village(info);
        }

        public void Update_Village(Village_Info info)
        {
            data_access.Update_Village(info);
        }

        public Village_Collection Select_Village(int type, int townshipid, int stateid, string village) 
        {
            Village_Collection collection = new Village_Collection();
            Village_Info info;
            IDataReader reader = data_access.Select_Village(type, townshipid, stateid, village);

            while (reader.Read())
            {
                info = new Village_Info();

                info.No = ++no;
                info.Villageid = Convert.ToInt32(reader["villageid"]);
                info.Townshipid = Convert.ToInt32(reader["townshipid"]);
                info.Stateid = Convert.ToInt32(reader["stateid"]);
                info.State = Convert.ToString(reader["statedivision"]);
                info.Township = Convert.ToString(reader["township"]);
                info.Village = Convert.ToString(reader["village"]);
                info.Desp = Convert.ToString(reader["desp"]);

                collection.Add(info);
            }
            reader.Close();

            return collection;
        }
    }

    public class Village_Collection : Collection<Village_Info>
    {

    }
}

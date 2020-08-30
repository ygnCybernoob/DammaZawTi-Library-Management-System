using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class StateDivision_Controller
    {
        StateDivision_DataAccess data_access;

        public StateDivision_Controller()
        {
            data_access = new StateDivision_DataAccess();
        }

        public StateDivision_Collection Select_StateDivision()
        {
            StateDivision_Info info;
            StateDivision_Collection collection = new StateDivision_Collection();
            IDataReader reader = data_access.Select_StateDivision();

            while (reader.Read())
            {
                info = new StateDivision_Info();
                info.Stateid = Convert.ToInt32(reader["stateid"]);
                info.State = Convert.ToString(reader["statedivision"]);
                info.Desp = Convert.ToString(reader["desp"]);
                collection.Add(info);
            }
            reader.Close();
            return collection;
        }
    }

    public class StateDivision_Collection : Collection<StateDivision_Info>
    {

    }
}

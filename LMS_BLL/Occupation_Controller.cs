using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class Occupation_Controller
    {
        Occupation_DataAccess data_access;
        private int no = 0;

        public Occupation_Controller()
        {
            data_access = new Occupation_DataAccess();
        }

        public void Insert_Occupation(Occupation_Info info)
        {
            data_access.Insert_Occupation(info);
        }

        public void Update_Occupation(Occupation_Info info)
        {
            data_access.Update_Occupation(info);
        }

        public Occupation_Collection Select_Occupation(int type, string occupation)
        {
            Occupation_Info info;
            Occupation_Collection collection = new Occupation_Collection();
            IDataReader reader = data_access.Select_Occupation(type, occupation);

            while (reader.Read())
            {
                info = new Occupation_Info();
                info.No = ++no;
                info.Occupationid = Convert.ToInt32(reader["Occupationid"]);
                info.Occupation = Convert.ToString(reader["Occupation"]);
                collection.Add(info);
            }
            reader.Close();
            return collection;
        }

    }

    public class Occupation_Collection: Collection<Occupation_Info>
    {
    }
}

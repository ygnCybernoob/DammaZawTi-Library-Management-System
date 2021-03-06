using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class Education_Controller
    {
        Education_DataAccess data_access;
        private int no = 0;

        public Education_Controller()
        {
            data_access = new Education_DataAccess();
        }

        public void Insert_Education(Education_Info info)
        {
            data_access.Insert_Education(info);   
        }

        public void Update_Education(Education_Info info)
        {
            data_access.Update_Education(info);
        }

        public Education_Collection Select_Education(int type, string education)
        {
            Education_Info info;
            Education_Collection collection = new Education_Collection();
            IDataReader reader = data_access.Select_Education(type, education);

            while (reader.Read())
            {
                info = new Education_Info();
                info.No = ++no;
                info.Educationid = Convert.ToInt32(reader["Educationid"]);
                info.Education = Convert.ToString(reader["Education"]);
                collection.Add(info);
            }
            reader.Close();
            return collection;
        }
    
    }

    public class Education_Collection : Collection<Education_Info>
    {

    }
}

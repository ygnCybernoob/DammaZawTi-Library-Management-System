using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class Feedback_Controller
    {
        Feedback_DataAccess data_access;
        private int no;

        public Feedback_Controller()
        {
            data_access = new Feedback_DataAccess();
        }

        public void Insert_Feedback(Feedback_Info info)
        {
            data_access.Insert_Feedback(info);
        }

        public void Update_Feedback(int feedbackid)
        {
            data_access.Update_Feedback(feedbackid);
        }

        public Feedback_Collection Select_Feedback(int type, int month, int year)
        {
            IDataReader reader =  data_access.Select_Fine(type, month, year);
            Feedback_Collection collection = new Feedback_Collection();
            Feedback_Info info;

            while (reader.Read())
            {
                info = new Feedback_Info();

                info.No = ++no;
                info.Feedbackid = Convert.ToInt32(reader["feedbackid"]);
                info.Memberbarcode = Convert.ToString(reader["memberbarcode"]);
                info.Membername = Convert.ToString(reader["membername"]);
                info.Subject = Convert.ToString(reader["subject"]);
                info.Feedback = Convert.ToString(reader["feedback"]);
                info.Feedbackdate = Convert.ToDateTime(reader["feedbackdate"]);

                collection.Add(info);
            }
            reader.Close();

            return collection;
        }

    }

    public class Feedback_Collection : Collection<Feedback_Info>
    {

    }
}

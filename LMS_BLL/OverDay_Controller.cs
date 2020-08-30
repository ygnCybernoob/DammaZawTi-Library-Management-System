using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class OverDay_Controller
    {
        OverDay_DataAccess data_access;
        private int no;
        DateTime today;
        TimeSpan timespan;

        public OverDay_Controller()
        {
            data_access = new OverDay_DataAccess();
            today = System.DateTime.Today;
        }

        public int Select_OverdayMember_Qty()
        {
            IDataReader reader = data_access.Select_OverdayMember_Qty();
            int qty = 0;

            if (reader.Read())
            {
                qty = Convert.ToInt32(reader["Qty"]);
            }

            reader.Close();
            return qty;
        }

        public OverDay_Collection Select_OverDay_List()
        {
            OverDay_Collection collection = new OverDay_Collection();
            Overday_Info info;
            IDataReader reader = data_access.Select_OverdayMember_List();

            while (reader.Read())
            {
                info = new Overday_Info();

                info.No = ++no;
                info.Memberid = Convert.ToInt32(reader["memberid"]);
                info.Bookid = Convert.ToInt32(reader["bookid"]);
                info.Borrowbookid = Convert.ToInt32(reader["borrowbookid"]);
                info.Membername = Convert.ToString(reader["Membername"]);
                info.Booktitle = Convert.ToString(reader["booktitle"]);
                info.Bookbarcode = Convert.ToString(reader["bookbarcode"]);
                info.Memberbarcode = Convert.ToString(reader["memberbarcode"]);
                info.Phoneno = Convert.ToString(reader["phoneno"]);
                info.Dateborrowed = Convert.ToDateTime(reader["dateborrowed"]);
                info.Duedate = Convert.ToDateTime(reader["duedate"]);

                timespan = today - info.Duedate;

                if (timespan.TotalDays <= 0)
                {
                    info.Overday = 0;
                }
                else
                {
                    info.Overday = Convert.ToInt32(timespan.TotalDays);
                }

                collection.Add(info);
            }
            reader.Close();

            return collection;
        }

    }

    public class OverDay_Collection : Collection<Overday_Info>
    {

    }
}

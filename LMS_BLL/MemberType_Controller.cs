using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class MemberType_Controller
    {
        MemberType_DataAccess data_access;
        private int no = 0;

        public MemberType_Controller()
        {
            data_access = new MemberType_DataAccess();
        }

        public void Insert_MemberType(MemberType_Info info)
        {
            data_access.Insert_MemberType(info);
        }

        public void Update_MemberType(MemberType_Info info)
        {
            data_access.Update_MemberType(info);
        }

        public MemberType_Collection Select_MemberType()
        {
            MemberType_Collection collection = new MemberType_Collection();
            MemberType_Info info;
            IDataReader reader = data_access.Select_MemberType();

            while (reader.Read())
            {
                info = new MemberType_Info();

                info.No = ++no;
                info.Membertypeid = Convert.ToInt32(reader["MemberTypeid"]);
                info.Membertype = Convert.ToString(reader["membertype"]);
                info.Allowbook = Convert.ToInt32(reader["allowbook"]);
                info.Allowday = Convert.ToInt32(reader["allowday"]);
                info.Expiredate = Convert.ToString(reader["expiredate"]);

                collection.Add(info);
            }
            reader.Close();

            return collection;
        }
    }

    public class MemberType_Collection : Collection<MemberType_Info>
    {

    }
}

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
    public class Member_Controller
    {
        Member_DataAccess data_access;
        MemberExpired_DataAccess expired_dataaccess;
        private int no = 0;
        DateTime today;

        public Member_Controller()
        {
            data_access = new Member_DataAccess();
            expired_dataaccess = new MemberExpired_DataAccess();
            today = System.DateTime.Today;
        }

        public void Insert_Member(Member_Info info)
        {
            data_access.Insert_Member(info);
        }

        public void Update_Member(Member_Info info)
        {
            data_access.Update_Member(info);
        }

        public Member_Collection Select_Member(int selectType, string barcode, string name)
        {
            Member_Collection collection = new Member_Collection();
            Member_Info info;
            IDataReader reader = data_access.Select_Member(selectType, barcode, name);

            while (reader.Read())
            {
                info = new Member_Info();

                info.No = ++no;
                info.Memberid = Convert.ToInt32(reader["memberid"]);
                info.Membertypeid = Convert.ToInt32(reader["membertypeid"]);
                info.Educationid = Convert.ToInt32(reader["educationid"]);
                info.Occupationid = Convert.ToInt32(reader["occupationid"]);
                info.Stateid = Convert.ToInt32(reader["stateid"]);
                info.Townshipid = Convert.ToInt32(reader["townshipid"]);
                info.Villageid = Convert.ToInt32(reader["villageid"]);
                info.Membername = Convert.ToString(reader["Membername"]);
                info.Memberbarcode = Convert.ToString(reader["memberbarcode"]);

                info.Memberimagebyte =(byte[])(reader["memberimage"]);

                if (info.Memberimagebyte.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(info.Memberimagebyte);
                    info.Memberimage = Image.FromStream(ms);
                }
                else
                {
                    info.Memberimage = null;
                }

                info.Membertype = Convert.ToString(reader["membertype"]);
                info.Allowbook = Convert.ToInt32(reader["allowbook"]);
                info.Allowday = Convert.ToInt32(reader["allowday"]);
                info.Expiredate = Convert.ToString(reader["expiredate"]);
                info.Nrc = Convert.ToString(reader["nrc"]);
                info.Homeno = Convert.ToString(reader["homeno"]);
                info.Street = Convert.ToString(reader["street"]);
                info.Village = Convert.ToString(reader["village"]);
                info.Township = Convert.ToString(reader["township"]);
                info.State = Convert.ToString(reader["statedivision"]);
                info.Phoneno = Convert.ToString(reader["phoneno"]);
                info.Education = Convert.ToString(reader["education"]);
                info.Occupation = Convert.ToString(reader["occupation"]);
                info.Gender = Convert.ToString(reader["gender"]);
                info.Guarantor = Convert.ToString(reader["guarantor"]);
                info.Guarantornrc = Convert.ToString(reader["guarantornrc"]);
                info.Guarantoroccupation = Convert.ToString(reader["guarantoroccupation"]);
                info.Guarantoraddress = Convert.ToString(reader["guarantoraddress"]);
                info.Addedby = Convert.ToString(reader["addedby"]);
                info.Memberstatus = Convert.ToString(reader["memberstatus"]);
                info.Dateofbirth = Convert.ToDateTime(reader["dateofbirth"]);
                info.Addeddate = Convert.ToDateTime(reader["addeddate"]);

                collection.Add(info);
            }
            reader.Close();

            return collection;
        }

        public Member_Info Select_MemberBasicInfo(string barcode, int selectType)
        {
            Member_Info info = new Member_Info() ; 
            IDataReader reader = data_access.Select_MemberBasicInfo(barcode, selectType);

            if (reader.Read())
            {
                info.Memberid = Convert.ToInt32(reader["memberid"]);
                info.Membername = Convert.ToString(reader["Membername"]);
                info.Memberbarcode = Convert.ToString(reader["memberbarcode"]);

                info.Memberimagebyte = (byte[])(reader["memberimage"]);

                if (info.Memberimagebyte.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(info.Memberimagebyte);
                    info.Memberimage = Image.FromStream(ms);
                }
                else
                {
                    info.Memberimage = null;
                }

                info.Membertype = Convert.ToString(reader["membertype"]);
                info.Allowbook = Convert.ToInt32(reader["allowbook"]);
                info.Allowday = Convert.ToInt32(reader["allowday"]);
                info.Expiredate = Convert.ToString(reader["expiredate"]);
            }
            reader.Close();

            return info;
        }

        public int Check_Expired()
        {
            Member_Controller controller = new Member_Controller();
            IDataReader reader = data_access.Select_MemberForExpired();
            Member_Info info;
            int count = 0;
            int year;

            while (reader.Read())
            {
                info = new Member_Info();
                info.Memberid = Convert.ToInt32(reader["memberid"]);
                info.Expiredate = Convert.ToString(reader["expiredate"]);
                info.Addeddate = Convert.ToDateTime(reader["addeddate"]);

                if (info.Expiredate.Equals("Life Time"))
                {
                    continue;
                }
                else
                {
                    year = Convert.ToInt32(info.Expiredate);

                    if (info.Addeddate.AddYears(year) <= today)
                    {
                        Update_Expired(info.Memberid);
                        count++;
                    }

                }

            }
            reader.Close();

            return count ;
        }

        public void Update_Expired(int memberid)
        {
            expired_dataaccess.Update_Expired(memberid);
        }

        public Member_Info Select_QtyOfMember()
        {
            Member_Info info = new Member_Info();
            IDataReader reader = data_access.Select_QtyOfMember();

            if (reader.Read())
            {
                info.Active = Convert.ToInt32(reader["active"]);
                info.Ban = Convert.ToInt32(reader["ban"]);
                info.Expired = Convert.ToInt32(reader["expired"]);
                info.Male = Convert.ToInt32(reader["male"]);
                info.Female = Convert.ToInt32(reader["female"]);
            }
            reader.Close();

            return info;
        }

        public Member_Info Select_QtyOfMemberByAge()
        {
            Member_Info info = new Member_Info();
            IDataReader reader = data_access.Select_QtyOfMemberByAge();
            DateTime today = System.DateTime.Today;
            TimeSpan timespan;
            int year;

            while (reader.Read())
            {
                info.Dateofbirth = Convert.ToDateTime(reader["dateofbirth"]);
                timespan = today.Subtract(info.Dateofbirth);
                year = (int)(timespan.TotalDays / 365);

                if ( year< 18)
                {
                    info.Lower18++;
                }
                else if (year >= 18 && year < 30)
                {
                    info.F18to30++;
                }
                else if (year >= 30 && year < 50)
                {
                    info.F30to50++;
                }
                else if (year > 50)
                {
                    info.Above50++;
                }
            }
            reader.Close();

            return info;
        }

        public int Select_QtyMemberByState(int stateid)
        {
            int qtyOfmember = 0;
            IDataReader reader = data_access.Select_QtyMemberByState(stateid);

            if (reader.Read())
            {
                qtyOfmember = Convert.ToInt32(reader["qtyofmember"]);
            }
            reader.Close();

            return qtyOfmember;
        }

        public Member_Collection Select_QtyMemberByTownship(int stateid)
        {
            Member_Collection collection = new Member_Collection();
            Member_Info info;
            IDataReader reader = data_access.Select_QtyMemberByTownship(stateid);

            while (reader.Read())
            {
                info = new Member_Info();

                info.Township = Convert.ToString(reader["Township"]);
                info.Qtyofmember = Convert.ToInt32(reader["QtyOfMember"]);

                collection.Add(info);
            }

            reader.Close();

            return collection;
        }

        public Member_Collection Select_QtyMemberByVillage(int township)
        {
            Member_Collection collection = new Member_Collection();
            Member_Info info;
            IDataReader reader = data_access.Select_QtyMemberByVillage(township);

            while (reader.Read())
            {
                info = new Member_Info();

                info.Village = Convert.ToString(reader["Village"]);
                info.Qtyofmember = Convert.ToInt32(reader["QtyOfMember"]);

                collection.Add(info);
            }

            reader.Close();

            return collection;
        }

        public Member_Collection Select_QtyMemberByOccupation()
        {
            Member_Collection collection = new Member_Collection();
            Member_Info info;
            IDataReader reader = data_access.Select_QtyOfMemberByOccupation();

            while (reader.Read())
            {
                info = new Member_Info();

                info.Occupation = Convert.ToString(reader["Occupation"]);
                info.Qtyofmember = Convert.ToInt32(reader["QtyOfMember"]);

                collection.Add(info);
            }

            reader.Close();

            return collection;
        }

        public Member_Collection Select_QtyMemberByEducation()
        {
            Member_Collection collection = new Member_Collection();
            Member_Info info;
            IDataReader reader = data_access.Select_QtyOfMemberByEducation();

            while (reader.Read())
            {
                info = new Member_Info();

                info.Education = Convert.ToString(reader["Education"]);
                info.Qtyofmember = Convert.ToInt32(reader["QtyOfMember"]);

                collection.Add(info);
            }

            reader.Close();

            return collection;
        }

        public Member_Collection Select_QtyMemberByType()
        {
            Member_Collection collection = new Member_Collection();
            Member_Info info;
            IDataReader reader = data_access.Select_QtyMemberByType();

            while (reader.Read())
            {
                info = new Member_Info();

                info.Membertype = Convert.ToString(reader["MemberType"]);
                info.Qtyofmember = Convert.ToInt32(reader["QtyOfMember"]);

                collection.Add(info);
            }

            reader.Close();

            return collection;
        }

    }

    public class Member_Collection : Collection<Member_Info>
    {

    }
}

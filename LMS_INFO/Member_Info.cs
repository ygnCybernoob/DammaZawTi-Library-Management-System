using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LMS_INFO
{
    public class Member_Info
    {
        private int active,
            expired,
            ban,
            male,
            female,
            lower18,
            f18to30,
            f30to50,
            above50,
            qtyofmember;

        public int Qtyofmember
        {
            get { return qtyofmember; }
            set { qtyofmember = value; }
        }

        public int Above50
        {
            get { return above50; }
            set { above50 = value; }
        }

        public int F30to50
        {
            get { return f30to50; }
            set { f30to50 = value; }
        }

        public int F18to30
        {
            get { return f18to30; }
            set { f18to30 = value; }
        }

        public int Lower18
        {
            get { return lower18; }
            set { lower18 = value; }
        }

        public int Female
        {
            get { return female; }
            set { female = value; }
        }

        public int Male
        {
            get { return male; }
            set { male = value; }
        }

        public int Ban
        {
            get { return ban; }
            set { ban = value; }
        }

        public int Expired
        {
            get { return expired; }
            set { expired = value; }
        }

        public int Active
        {
            get { return active; }
            set { active = value; }
        }

        private int memberid,
            occupationid,
            villageid,
            educationid,
            stateid,
            townshipid;

        private int membertypeid,
           allowbook,
           allowday,
           no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Allowday
        {
            get { return allowday; }
            set { allowday = value; }
        }

        public int Allowbook
        {
            get { return allowbook; }
            set { allowbook = value; }
        }

        public int Membertypeid
        {
            get { return membertypeid; }
            set { membertypeid = value; }
        }
        private string membertype,
            typecode,
            expiredate;

        public string Typecode
        {
            get { return typecode; }
            set { typecode = value; }
        }

        public string Expiredate
        {
            get { return expiredate; }
            set { expiredate = value; }
        }

        public string Membertype
        {
            get { return membertype; }
            set { membertype = value; }
        }

        public int Townshipid
        {
            get { return townshipid; }
            set { townshipid = value; }
        }

        public int Stateid
        {
            get { return stateid; }
            set { stateid = value; }
        }

        //public int No
        //{
        //    get { return No; }
        //    set { No = value; }
        //}

        public int Educationid
        {
            get { return educationid; }
            set { educationid = value; }
        }

        public int Villageid
        {
            get { return villageid; }
            set { villageid = value; }
        }

        public int Occupationid
        {
            get { return occupationid; }
            set { occupationid = value; }
        }

        public int Memberid
        {
            get { return memberid; }
            set { memberid = value; }
        }
        private byte[] memberimagebyte;
        private Image memberimage;

        public Image Memberimage
        {
            get { return memberimage; }
            set { memberimage = value; }
        }

        public byte[] Memberimagebyte
        {
            get { return memberimagebyte; }
            set { memberimagebyte = value; }
        }

        private DateTime dateofbirth,
            addeddate;

        public DateTime Addeddate
        {
            get { return addeddate; }
            set { addeddate = value; }
        }

        public DateTime Dateofbirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }
        private string memberbarcode,
            membername,
            occupation,
            nrc,
            street,
            homeno,
            state,
            township,
            village,
            phoneno,
            education,
            gender,
            guarantor,
            guarantornrc,
            guarantoroccupation,
            guarantoraddress,
            addedby,
            memberstatus;


        public string Township
        {
            get { return township; }
            set { township = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Memberstatus
        {
            get { return memberstatus; }
            set { memberstatus = value; }
        }

        public string Addedby
        {
            get { return addedby; }
            set { addedby = value; }
        }

        public string Guarantoraddress
        {
            get { return guarantoraddress; }
            set { guarantoraddress = value; }
        }

        public string Guarantoroccupation
        {
            get { return guarantoroccupation; }
            set { guarantoroccupation = value; }
        }

        public string Guarantornrc
        {
            get { return guarantornrc; }
            set { guarantornrc = value; }
        }

        public string Guarantor
        {
            get { return guarantor; }
            set { guarantor = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Education
        {
            get { return education; }
            set { education = value; }
        }

        public string Phoneno
        {
            get { return phoneno; }
            set { phoneno = value; }
        }

        public string Village
        {
            get { return village; }
            set { village = value; }
        }

        public string Homeno
        {
            get { return homeno; }
            set { homeno = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string Nrc
        {
            get { return nrc; }
            set { nrc = value; }
        }

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public string Membername
        {
            get { return membername; }
            set { membername = value; }
        }

        public string Memberbarcode
        {
            get { return memberbarcode; }
            set { memberbarcode = value; }
        }
            

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class MemberType_Info
    {
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
            expiredate;

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
    }
}

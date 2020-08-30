using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class AuthorType_Info
    {
        private int authortypeid,
            no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Authortypeid
        {
            get { return authortypeid; }
            set { authortypeid = value; }
        }
        private string authortype,
            desp;

        public string Desp
        {
            get { return desp; }
            set { desp = value; }
        }

        public string Authortype
        {
            get { return authortype; }
            set { authortype = value; }
        }
    }
}

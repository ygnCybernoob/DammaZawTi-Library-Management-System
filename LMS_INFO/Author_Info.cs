using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class Author_Info
    {
        private int authorid,
            authortypeid,
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

        public int Authorid
        {
            get { return authorid; }
            set { authorid = value; }
        }
        private string author,
            gender,
            desp,
            authortype;

        public string Authortype
        {
            get { return authortype; }
            set { authortype = value; }
        }

        public string Desp
        {
            get { return desp; }
            set { desp = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class Account_Info
    {
        private int librarianid;
        private string accountid;

        public int Librarianid
        {
            get { return librarianid; }
            set { librarianid = value; }
        }

        public string Accountid
        {
            get { return accountid; }
            set { accountid = value; }
        }

        private string username,
            password,
            accounttype,
            accountstatus;

        public string Accountstatus
        {
            get { return accountstatus; }
            set { accountstatus = value; }
        }

        public string Accounttype
        {
            get { return accounttype; }
            set { accounttype = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}

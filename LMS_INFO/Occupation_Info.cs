using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class Occupation_Info
    {
        private int occupationid,
            no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Occupationid
        {
            get { return occupationid; }
            set { occupationid = value; }
        }
        private string occupation;

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class Education_Info
    {
        private int educationid,
            no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Educationid
        {
            get { return educationid; }
            set { educationid = value; }
        }
        private string education;

        public string Education
        {
            get { return education; }
            set { education = value; }
        }
    }
}

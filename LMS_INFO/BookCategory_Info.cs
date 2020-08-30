using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class BookCategory_Info
    {
        private int categoryid,
            no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Categoryid
        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        private string category,
            categorycode,
            desp;

        public string Categorycode
        {
            get { return categorycode; }
            set { categorycode = value; }
        }

        public string Desp
        {
            get { return desp; }
            set { desp = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
    }
}

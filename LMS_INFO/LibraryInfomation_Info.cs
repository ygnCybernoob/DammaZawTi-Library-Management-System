using System;
using System.Collections.Generic;
using System.Text;    

namespace LMS_INFO
{
    public class LibraryInfomation_Info
    {
        private byte[] librarylogo;

        public byte[] Librarylogo
        {
            get { return librarylogo; }
            set { librarylogo = value; }
        }


        private string libraryname;

        public string Libraryname
        {
            get { return libraryname; }
            set { libraryname = value; }
        }
    }
}

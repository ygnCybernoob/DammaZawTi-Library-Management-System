using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LMS_INFO
{
    public class Librarian_Info
    {
        private int librarianid,
            villageid,
            no,
            stateid,
            townshipid;

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

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Villageid
        {
            get { return villageid; }
            set { villageid = value; }
        }

        public int Librarianid
        {
            get { return librarianid; }
            set { librarianid = value; }
        }

        private Image librarianimage;
        private byte[] imagebyte;

        public byte[] Imagebyte
        {
            get { return imagebyte; }
            set { imagebyte = value; }
        }

        public Image Librarianimage
        {
            get { return librarianimage; }
            set { librarianimage = value; }
        }

        private string librarianname,
            username,
            password,
            accounttype,
            accountstatus,
            gender,
            nrc,
            street,
            homeno,
            phoneno,
            addedby,
            desp,
            state,
            township,
            village,
            status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Village
        {
            get { return village; }
            set { village = value; }
        }

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

        public string Desp
        {
            get { return desp; }
            set { desp = value; }
        }

        public string Addedby
        {
            get { return addedby; }
            set { addedby = value; }
        }

        public string Phoneno
        {
            get { return phoneno; }
            set { phoneno = value; }
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

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

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

        public string Librarianname
        {
            get { return librarianname; }
            set { librarianname = value; }
        }

        private DateTime dateadded;

        public DateTime Dateadded
        {
            get { return dateadded; }
            set { dateadded = value; }
        }
    }
}

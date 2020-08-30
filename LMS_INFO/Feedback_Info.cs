using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class Feedback_Info
    {
        private int feedbackid, 
            memberid,
            no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Memberid
        {
            get { return memberid; }
            set { memberid = value; }
        }

        public int Feedbackid
        {
            get { return feedbackid; }
            set { feedbackid = value; }
        }
        private DateTime feedbackdate;

        public DateTime Feedbackdate
        {
            get { return feedbackdate; }
            set { feedbackdate = value; }
        }
        private string subject,
            feedback,
            memberbarcode,
            membername;

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

        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}

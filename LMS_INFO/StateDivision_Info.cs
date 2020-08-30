using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class StateDivision_Info
    {
        private int stateid;

        public int Stateid
        {
            get { return stateid; }
            set { stateid = value; }
        }
        private string state,
            desp;

        public string Desp
        {
            get { return desp; }
            set { desp = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}

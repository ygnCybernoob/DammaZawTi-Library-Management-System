using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_INFO
{
    public class Village_Info
    {
        private int townshipid,
            stateid,
            no,
            villageid;

        public int Villageid
        {
            get { return villageid; }
            set { villageid = value; }
        }

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Stateid
        {
            get { return stateid; }
            set { stateid = value; }
        }

        public int Townshipid
        {
            get { return townshipid; }
            set { townshipid = value; }
        }
        private string township,
            state,
            desp,
            village;

        public string Village
        {
            get { return village; }
            set { village = value; }
        }

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

        public string Township
        {
            get { return township; }
            set { township = value; }
        }

    }
}

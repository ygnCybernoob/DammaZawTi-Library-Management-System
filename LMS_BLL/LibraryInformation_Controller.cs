using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class LibraryInformation_Controller
    {
        LibraryInformation_DataAccess data_access;

        public LibraryInformation_Controller()
        {
            data_access = new LibraryInformation_DataAccess();
        }

        public void Update_LibraryInformation(LibraryInfomation_Info info)
        {
            data_access.Update_LibraryInformation(info);
        }

        public LibraryInfomation_Info Select_LibraryInformation()
        {
            LibraryInfomation_Info info = new LibraryInfomation_Info();
            IDataReader reader = data_access.Select_LibraryInformation();

            if (reader.Read())
            {
                info.Librarylogo = (byte[])reader["librarylogo"];
                info.Libraryname = Convert.ToString(reader["libraryname"]);
            }
            else
            {
                info.Librarylogo = new byte[0];
            }
            reader.Close();
            return info;
        }
    }
}

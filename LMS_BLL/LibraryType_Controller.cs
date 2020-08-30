using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LMS_DAL;

namespace LMS_BLL
{
    public class LibraryType_Controller
    {
        LibraryType_DataAccess data_access;

        public LibraryType_Controller()
        {
            data_access = new LibraryType_DataAccess();
        }

        public void InsertLibraryType(string type)
        {
            data_access.InsertLibraryType(type);
        }

        public string SelectLibraryType()
        {
            string libraryType = "";
            IDataReader reader = data_access.SelectLibraryType();
            if (reader.Read())
            {
                libraryType = Convert.ToString(reader["librarytype"]);
            }
            reader.Close();
            return libraryType;
        }

    }
}

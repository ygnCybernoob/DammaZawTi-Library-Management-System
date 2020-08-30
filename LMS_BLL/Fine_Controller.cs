using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;

namespace LMS_BLL
{
    public class Fine_Controller
    {
        Fine_DataAccess data_access;

        public Fine_Controller()
        {
            data_access = new Fine_DataAccess();
        }

        public float Select_Fine()
        {
            IDataReader reader = data_access.Select_Fine();
            float fine = 0;

            if (reader.Read())
            {
                fine = Convert.ToInt64(reader["fine"]);
            }
            
            reader.Close();

            return fine;
        }

        public void Update_Fine(float fine)
        {
            data_access.Update_Fine(fine);
        }

    }
}

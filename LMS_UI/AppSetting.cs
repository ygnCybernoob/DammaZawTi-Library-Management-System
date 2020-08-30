using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace LMS_UI
{
    class AppSetting
    {
        Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        //public string GetConnectionString(string key)
        //{
        //    return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        //}

        public void SaveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}

using System;
using System.Configuration;

namespace Shared
{
    public static class AppSettingsConfigurationReader 
    {
       public static Config GetMaxStudents()
        {
            var config = new Config();
            
           // to:do get help here this is confusing
            var appSettings = ConfigurationManager.AppSettings;
            config.MaxStudentId = Convert.ToInt32(appSettings.Get("MaxStudentId"));
            
            return config;
        }
    }
}

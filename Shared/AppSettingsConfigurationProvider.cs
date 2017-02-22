using System;
using System.Configuration;

namespace Shared
{
    public static class AppSettingsConfigurationProvider 
    {
       public static Config GetData()
        {
            var config = new Config();

            var appSettings = ConfigurationManager.AppSettings;
            config.MaxStudentId = Convert.ToInt32(appSettings.Get("MaxStudentId"));
            
            return config;
        }
    }
}

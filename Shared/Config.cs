using System;
using System.Configuration;

namespace Shared
{
    public class Config : IConfig
    {
        private string _maxStudentId;

        public string MaxStudentId
        {
            get
            {
                return ConfigurationManager.AppSettings["MaxStudentId"];
            }
        }
    }
}

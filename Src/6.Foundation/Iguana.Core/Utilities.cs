using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iguana.Core
{
    public class Utilities
    {
        public static string GetValueFromAppConfigAppSettings(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }

        public static string GetValueFromAppConfigConnectionStrings(string key)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

        public static string GetValueFromWebConfigConnectionStrings(string key)
        {
            return System.Web.Configuration.WebConfigurationManager.ConnectionStrings[key].ConnectionString;
        }
    }
}
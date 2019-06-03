using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iguana.Tools.ORMClass.Helper
{
    internal class DataHelper
    {
        public static string AppSettingFactory(string key)
        {
            string value = "";
            if (ConfigurationManager.AppSettings.AllKeys.Any(x => x == key))
            {
                value = ConfigurationManager.AppSettings[key];
            }
            return value;
        }

        public static IDbConnection ConnectionFactory(string connectionConfig)
        {
            if (string.IsNullOrWhiteSpace(connectionConfig))
            {
                throw new Exception("必须提供数据库连接字符串");
            }
            var connectionString = connectionConfig.Split('|');
            if (connectionString.Length == 2)
            {
                switch (connectionString[0])
                {
                    case "SQLSERVER":
                        return new SqlConnection(connectionString[1]);
                    default:
                        throw new Exception("未识别的数据库连接字符串");
                }
            }
            else
            {
                throw new Exception("未识别的数据库连接字符串");
            }
        }

        public static T CalssFactory<T>(string fullName)
            where T : class
        {
            var type = Type.GetType(fullName);
            T obj = Activator.CreateInstance(type) as T;
            return obj;
        }
    }
}
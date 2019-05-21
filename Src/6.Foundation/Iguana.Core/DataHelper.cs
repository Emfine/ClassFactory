using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Iguana.Core
{
    public class DataHelper
    {
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
    }
}
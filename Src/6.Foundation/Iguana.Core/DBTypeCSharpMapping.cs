using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iguana.Core
{
    public class DBTypeCSharpMapping
    {
        private static Dictionary<string, string> sqlserverMap;
        public static Dictionary<string, string> SQLServerMap
        {
            get
            {
                if (sqlserverMap == null)
                {
                    sqlserverMap = new Dictionary<string, string>
                    {
                        ["int"] = "int",
                        ["smallint"] = "short",
                        ["float"] = "double",
                        ["decimal"] = "decimal",
                        ["varchar"] = "string",
                        ["nvarchar"] = "string",
                        ["datetime"] = "DateTime",
                        ["uniqueidentifier"] = "Guid",
                        ["text"] = "string"
                    };
                }
                return sqlserverMap;
            }
        }
    }
}
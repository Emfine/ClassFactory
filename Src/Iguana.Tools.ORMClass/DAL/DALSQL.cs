using Dapper;
using Iguana.Tools.ORMClass.Helper;
using Iguana.Tools.ORMClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iguana.Tools.ORMClass.DAL
{
    internal class DALSQL : IDAL
    {
        public List<TableFieldDTO> GetTableFieldList(TableFieldCDT condition)
        {
            string sql = @"SELECT a.name AS Name,
                                               TYPE_NAME(a.user_type_id) AS Type,
	                                           b.value AS Note,
                                               a.max_length AS Length,
                                               a.is_nullable AS IsNullable,
                                               a.is_identity AS IsIdentity
                                        FROM sys.all_columns AS a
                                        LEFT JOIN sys.extended_properties AS b ON b.major_id = a.object_id AND b.minor_id = a.column_id
                                        WHERE a.object_id = OBJECT_ID(@Table)
                                        ORDER BY a.column_id;";
            var list = DataHelper.ConnectionFactory(condition.ConnectionString).Query<TableFieldDTO>(sql, condition).ToList();
            return list;
        }
        public Dictionary<string, string> GetDBTypeCSharpDic()
        {
            var dic = new Dictionary<string, string>
            {
                ["bit"] = "bool",
                ["smallint"] = "short",
                ["tinyint"] = "byte",
                ["int"] = "int",
                ["bigint"] = "long",
                ["real"] = "float",
                ["float"] = "double",
                ["money"] = "decimal",
                ["decimal"] = "decimal",
                ["char"] = "string",
                ["varchar"] = "string",
                ["nvarchar"] = "string",
                ["datetime"] = "DateTime",
                ["uniqueidentifier"] = "Guid",
                ["text"] = "string",
                ["image"] = "byte[]",
                ["binary"] = "byte[]"
            };
            return dic;
        }
    }
}
using Dapper;
using Iguana.Core;
using Iguana.Tools.DTO;
using Iguana.Tools.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iguana.Tools.DAL
{
    public class TableFieldDAL : BaseDAL, ITableFieldDAL
    {
        public List<TableFieldDTO> GetTableFieldList(TableFieldCDT condition)
        {
            string sql = @"SELECT name AS Name,
                                               TYPE_NAME(user_type_id) AS Type,
                                               max_length AS Length,
                                               is_nullable AS IsNullable,
                                               is_identity AS IsIdentity
                                        FROM sys.all_columns
                                        WHERE object_id = OBJECT_ID(@Table); ";
            var list = DataHelper.ConnectionFactory(condition.ConnectionString).Query<TableFieldDTO>(sql, condition).ToList();
            return list;
        }
    }
}
using Iguana.Core;
using Iguana.Tools.DTO;
using Iguana.Tools.IBLL;
using Iguana.Tools.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iguana.Tools.BLL
{
    public class BasicBLL : BaseBLL, IBasicBLL
    {
        public string GenerateORMClass(GenerateCDT condition)
        {
            var txt = new StringBuilder();
            var dal = IOCHelper.Resolve<ITableFieldDAL>();
            var fieldList = dal.GetTableFieldList(new TableFieldCDT
            {
                ConnectionString = $"{condition.DBType}|{condition.ConnectionString}",
                Table = condition.Table
            });
            if (fieldList != null && fieldList.Any())
            {
                foreach (var field in fieldList)
                {
                    if (!DBTypeCSharpMapping.SQLServerMap.ContainsKey(field.Type))
                    {
                        return $"未映射类型{field.Type}";
                    }
                    var fieldType = DBTypeCSharpMapping.SQLServerMap[field.Type];
                    if (fieldType != "string")
                    {
                        if (field.IsNuallable) fieldType += "?";
                    }
                    if (!string.IsNullOrWhiteSpace(field.Note))
                    {
                        txt.AppendLine("/// <summary>");
                        txt.AppendLine($"/// {field.Note.Replace("\n", "/// ")}");
                        txt.AppendLine("/// <summary>");
                    }
                    txt.AppendLine(condition.Prefix);
                    txt.Append($"public {fieldType} {field.Name}");
                    txt.AppendLine("{get; set;}");
                }
            }
            else
            {
                txt.Append("该表不存在");
            }
            return txt.ToString();
        }
    }
}
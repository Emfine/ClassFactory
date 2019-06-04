using Iguana.Tools.ORMClass.DAL;
using Iguana.Tools.ORMClass.Helper;
using Iguana.Tools.ORMClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iguana.Tools.ORMClass.BLL
{
    internal class BLL : IBLL
    {
        public string GenerateORMClass(GenerateCDT condition)
        {
            var txt = new StringBuilder();
            string dalConfig = DataHelper.AppSettingFactory(condition.DBType);
            if (string.IsNullOrWhiteSpace(dalConfig))
            {
                txt.Append("配置不正确");
                return txt.ToString();
            }
            var dal = DataHelper.CalssFactory<IDAL>(dalConfig);
            var fieldList = dal.GetTableFieldList(new TableFieldCDT
            {
                ConnectionString = $"{condition.DBType}|{condition.ConnectionString}",
                Table = condition.Table
            });
            if (fieldList != null && fieldList.Any())
            {
                var dic = dal.GetDBTypeCSharpDic();
                foreach (var field in fieldList)
                {
                    if (!dic.ContainsKey(field.Type))
                    {
                        return $"未映射类型{field.Type}";
                    }
                    var fieldType = dic[field.Type];
                    if (fieldType != "string")
                    {
                        if (field.IsNullable) fieldType += "?";
                    }
                    if (condition.ShowMemo && !string.IsNullOrWhiteSpace(field.Note))
                    {
                        txt.AppendLine("/// <summary>");
                        txt.AppendLine($"/// {field.Note.Replace("\n", "\n/// ")}");
                        txt.AppendLine("/// <summary>");
                    }
                    if (!string.IsNullOrWhiteSpace(condition.Prefix))
                    {
                        txt.AppendLine(condition.Prefix);
                    }
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
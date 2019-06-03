using Iguana.Tools.ORMClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iguana.Tools.ORMClass.DAL
{
    internal interface IDAL
    {
        List<TableFieldDTO> GetTableFieldList(TableFieldCDT condition);
        Dictionary<string, string> GetDBTypeCSharpDic();
    }
}
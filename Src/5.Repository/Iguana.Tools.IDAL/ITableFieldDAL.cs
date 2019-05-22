using Iguana.Tools.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iguana.Tools.IDAL
{
    public interface ITableFieldDAL : IBaseDAL
    {
        List<TableFieldDTO> GetTableFieldList(TableFieldCDT condition);
    }
}
using Iguana.Tools.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iguana.Tools.IBLL
{
    public interface IBasicBLL : IBaseBLL
    {
        List<TableFieldDTO> GetTableFieldList(TableFieldCDT condition);
    }
}
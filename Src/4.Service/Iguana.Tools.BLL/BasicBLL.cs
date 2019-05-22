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
        public List<TableFieldDTO> GetTableFieldList(TableFieldCDT condition)
        {
            var dal = IOCHelper.Resolve<ITableFieldDAL>();
            var list = dal.GetTableFieldList(condition);
            return list;
        }
    }
}
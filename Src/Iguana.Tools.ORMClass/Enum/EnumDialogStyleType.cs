using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iguana.Tools.ORMClass.Model
{
    internal enum EnumDialogStyleType
    {
        [Description("提示")]
        Info,
        [Description("选择")]
        Option,
        [Description("提问")]
        Question
    }
}
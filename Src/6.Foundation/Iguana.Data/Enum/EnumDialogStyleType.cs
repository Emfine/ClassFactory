using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Iguana.Data.Enum
{
    public enum EnumDialogStyleType
    {
        [Description("提示")]
        Info,
        [Description("选择")]
        Option,
        [Description("提问")]
        Question
    }
}
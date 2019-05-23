using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Iguana.Winform.Common
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
    public class MessageHelper
    {
        public static DialogResult Show(EnumDialogStyleType dialogStyle, string content, string title = null, Form owner = null)
        {
            var dialog = new UFMessage(dialogStyle, content, title);
            return dialog.ShowDialog(owner);
        }
    }
}
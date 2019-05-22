using Iguana.Winform.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Iguana.Winform.UserControls
{
    [ToolboxBitmap(typeof(DevExpress.XtraEditors.MemoEdit))]
    [ToolboxItem(true)]
    public class UCMemoEdit : DevExpress.XtraEditors.MemoEdit
    {
        public UCMemoEdit()
        {
            this.Cursor = Cursors.Hand;
            this.Font = GlobalSetting.DefaultFont;
        }
    }
}
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
    [ToolboxBitmap(typeof(DevExpress.XtraEditors.ComboBoxEdit))]
    [ToolboxItem(true)]
    public class UCComboBoxEdit : DevExpress.XtraEditors.ComboBoxEdit
    {
        public UCComboBoxEdit()
        {
            this.Cursor = Cursors.Hand;
            this.Font = GlobalSetting.DefaultFont;
        }
    }
}
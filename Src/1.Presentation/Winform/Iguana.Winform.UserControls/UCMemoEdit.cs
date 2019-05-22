using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Iguana.Winform.Common;

namespace Iguana.Winform.UserControls
{
    [ToolboxBitmap(typeof(DevExpress.XtraEditors.MemoEdit))]
    [ToolboxItem(true)]
    public partial class UCMemoEdit : DevExpress.XtraEditors.MemoEdit
    {
        public UCMemoEdit()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
            this.Font = GlobalSetting.DefaultFont;
        }
    }
}
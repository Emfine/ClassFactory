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
    [ToolboxBitmap(typeof(DevExpress.XtraEditors.TextEdit))]
    [ToolboxItem(true)]
    public partial class UCTextEdit : DevExpress.XtraEditors.TextEdit
    {
        public UCTextEdit()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
            this.Font = GlobalSetting.DefaultFont;
        }
    }
}
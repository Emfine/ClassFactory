using Iguana.Winform.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Iguana.Winform.UserControls
{
    [ToolboxBitmap(typeof(DevExpress.XtraEditors.PanelControl))]
    [ToolboxItem(true)]
    public class UCPanelContainer : DevExpress.XtraEditors.PanelControl
    {
        public UCPanelContainer()
        {
            this.BackColor = GlobalSetting.DefaultBackgroundColor;
            this.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Font = GlobalSetting.DefaultFont;
        }
    }
}
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
    [ToolboxBitmap(typeof(DevExpress.XtraEditors.SimpleButton))]
    [ToolboxItem(true)]
    public class UCSimpleButton : DevExpress.XtraEditors.SimpleButton
    {
        public UCSimpleButton()
        {
            this.Appearance.BackColor = Color.FromArgb(0, 176, 240);
            this.Appearance.BorderColor = Color.FromArgb(0, 176, 240);
            this.AppearanceDisabled.BackColor = Color.Gainsboro;
            this.AppearanceDisabled.BorderColor = Color.Gainsboro;
            this.AppearanceHovered.BackColor = Color.FromArgb(51, 102, 204);
            this.AppearanceHovered.BorderColor = Color.FromArgb(51, 102, 204);
            this.AppearancePressed.BackColor = Color.FromArgb(51, 102, 204);
            this.AppearancePressed.BorderColor = Color.FromArgb(51, 102, 204);
            this.Cursor = Cursors.Hand;
            this.Font = GlobalSetting.DefaultFont;
        }
    }
}
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
    public partial class UCPanelContainer : DevExpress.XtraEditors.PanelControl
    {
        public UCPanelContainer()
        {
            InitializeComponent();
            this.BackColor = GlobalSetting.DefaultBackgroundColor;
            this.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Font = GlobalSetting.DefaultFont;
        }
    }
}
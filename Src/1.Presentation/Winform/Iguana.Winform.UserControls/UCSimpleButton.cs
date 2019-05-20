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
    public partial class UCSimpleButton : DevExpress.XtraEditors.SimpleButton
    {
        public UCSimpleButton()
        {
            InitializeComponent();
            this.Font = GlobalSetting.DefaultFont;
        }
    }
}
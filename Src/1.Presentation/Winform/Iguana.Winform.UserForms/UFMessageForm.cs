using Iguana.Winform.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Iguana.Winform.UserForms
{
    public partial class UFMessageForm : DevExpress.XtraEditors.XtraForm
    {
        public UFMessageForm()
        {
            InitializeComponent();
            this.Font = GlobalSetting.DefaultFont;
        }
    }
}
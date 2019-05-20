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
    public partial class UFContentOKForm : DevExpress.XtraEditors.XtraForm
    {
        public UFContentOKForm()
        {
            InitializeComponent();
            this.BackColor = GlobalSetting.DefaultBackgroundColor;
            this.Font = GlobalSetting.DefaultFont;
            pnlTitle.BackColor = GlobalSetting.DefaultTitleColor;
            lblClose.Font = new Font(GlobalSetting.PicIconFontCollection.Families[1], GlobalSetting.DefaultFontSize);
            lblClose.Text = "\uf12a";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
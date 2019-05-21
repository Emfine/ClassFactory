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
    public partial class UFContentOK : DevExpress.XtraEditors.XtraForm
    {
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                lblTitle.Text = value;
            }
        }

        public UFContentOK()
        {
            InitializeComponent();
            this.BackColor = GlobalSetting.DefaultBackgroundColor;
            this.Font = GlobalSetting.DefaultFont;
            pnlTitle.BackColor = GlobalSetting.DefaultTitleColor;
            if (GlobalSetting.PicIconFontCollection != null && GlobalSetting.PicIconFontCollection.Families.Any(x => x.Name == "Ionicons"))
            {
                lblClose.Font = new Font(GlobalSetting.PicIconFontCollection.Families.First(x => x.Name == "Ionicons"), GlobalSetting.DefaultFontSize);
            }
            lblClose.Text = "\uf12a";
        }

        protected virtual void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected virtual void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
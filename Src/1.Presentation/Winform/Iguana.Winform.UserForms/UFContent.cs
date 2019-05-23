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
    public partial class UFContent : DevExpress.XtraEditors.XtraForm
    {
        [Browsable(true)]
        [Description("是否允许最大化")]
        public bool AllowMaximized { get; set; }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                lblTitle.Text = value;
            }
        }

        public UFContent()
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

        private void UFContent_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.Silver, 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        private void pnlTitle_DoubleClick(object sender, EventArgs e)
        {
            if (this.AllowMaximized)
            {
                WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            }
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            WindowsAPI.ReleaseCapture();
            WindowsAPI.SendMessage(this.Handle, WindowsAPI.WM_SYSCOMMAND, WindowsAPI.SC_MOVE + WindowsAPI.HTCAPTION, 0);
        }

        private void lblTitle_DoubleClick(object sender, EventArgs e)
        {
            if (this.AllowMaximized)
            {
                WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            }
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            WindowsAPI.ReleaseCapture();
            WindowsAPI.SendMessage(this.Handle, WindowsAPI.WM_SYSCOMMAND, WindowsAPI.SC_MOVE + WindowsAPI.HTCAPTION, 0);
        }

        protected virtual void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
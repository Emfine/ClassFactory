using Iguana.Core;
using Iguana.Data.Enum;
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
    public sealed partial class UFMessage : UFContent
    {
        public UFMessage()
        {
            InitializeComponent();
        }

        public UFMessage(EnumDialogStyleType dialogStyle, string content, string title)
        {
            InitializeComponent();
            this.Text = string.IsNullOrWhiteSpace(title) ? EnumHelper.GetEnumDescription(dialogStyle) : title;
            txtMessage.BackColor = GlobalSetting.DefaultBackgroundColor;
            txtMessage.Text = content;
            txtMessage.Select(0, 0);
            RefreshStyle(dialogStyle);
        }

        private void RefreshStyle(EnumDialogStyleType dialogStyle)
        {
            switch (dialogStyle)
            {
                case EnumDialogStyleType.Info:
                    btnOK.Visible = true;
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    btnCancel.Visible = false;
                    break;
                case EnumDialogStyleType.Option:
                    btnOK.Visible = false;
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnCancel.Visible = false;
                    break;
                case EnumDialogStyleType.Question:
                    btnOK.Visible = false;
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnCancel.Visible = true;
                    break;
            }
        }

        public static DialogResult Show(EnumDialogStyleType dialogStyle, string content, string title = null, Form owner = null)
        {
            var dialog = new UFMessage(dialogStyle, content, title);
            return dialog.ShowDialog(owner);
        }
    }
}
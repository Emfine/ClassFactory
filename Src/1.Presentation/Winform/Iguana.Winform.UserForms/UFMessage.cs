using Iguana.Core;
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
            txtMessage.Text = content;
        }

        private void RefreshStyle(EnumDialogStyleType dialogStyle)
        {
            switch (dialogStyle)
            {
                case EnumDialogStyleType.Info:
                    break;
                case EnumDialogStyleType.Option:
                    break;
                case EnumDialogStyleType.Question:
                    break;
            }
        }
    }
}
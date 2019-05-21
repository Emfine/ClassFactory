using Iguana.Winform.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iguana.Tools.GenerateClass
{
    public partial class MainForm : UFContentOK
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
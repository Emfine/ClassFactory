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
    public partial class MainForm : UFContent
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
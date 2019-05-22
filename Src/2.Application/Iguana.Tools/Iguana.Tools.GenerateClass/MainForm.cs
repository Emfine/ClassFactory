using Iguana.Core;
using Iguana.Tools.DTO;
using Iguana.Tools.IBLL;
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
        private List<string> dbTypeList;

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
            dbTypeList = new List<string>();
            dbTypeList.Add("SQLSERVER");

            cbxDBType.Properties.Items.Clear();
            cbxDBType.Properties.Items.AddRange(dbTypeList);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var bll = IOCHelper.Resolve<IBasicBLL>();
            string classText = bll.GenerateORMClass(new GenerateCDT
            {
                DBType = cbxDBType.Text,
                ConnectionString = txtDBString.Text,
                Prefix = txtPrefix.Text,
                Table = txtTable.Text
            });
            txtClass.Text = classText;
        }
    }
}
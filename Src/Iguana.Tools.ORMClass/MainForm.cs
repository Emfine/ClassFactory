using Iguana.Tools.ORMClass.BLL;
using Iguana.Tools.ORMClass.Helper;
using Iguana.Tools.ORMClass.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iguana.Tools.ORMClass
{
    internal partial class MainForm : Form
    {
        private List<string> dbTypeList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dbTypeList = new List<string>();
            dbTypeList.Add("SQLSERVER");

            cbxDBType.DataSource = dbTypeList;
            cbxDBType.SelectedIndex = 0;

            string dbString = DataHelper.AppSettingFactory("DefaultDBString");
            if (string.IsNullOrWhiteSpace(dbString)) dbString = "Server=xxx.xxx.xxx.xxx;Database=xxx;user id=xxx;password=xxx;Connect Timeout=300;";
            txtDBString.Text = dbString;

            cbxShowMemo.Checked = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtClass.Clear();
            var bll = DataHelper.CalssFactory<IBLL>("Iguana.Tools.ORMClass.BLL.BLL");
            string classText = bll.GenerateORMClass(new GenerateCDT
            {
                DBType = cbxDBType.Text,
                ConnectionString = txtDBString.Text,
                Prefix = txtPrefix.Text,
                Table = txtTable.Text,
                ShowMemo = cbxShowMemo.Checked
            });
            txtClass.Text = classText;
        }
    }
}
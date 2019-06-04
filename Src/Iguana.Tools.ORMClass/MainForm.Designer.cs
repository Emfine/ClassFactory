namespace Iguana.Tools.ORMClass
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtDBString = new System.Windows.Forms.TextBox();
            this.cbxDBType = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.lblDBString = new System.Windows.Forms.Label();
            this.lblDBType = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.cbxShowMemo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Margin = new System.Windows.Forms.Padding(0);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.cbxShowMemo);
            this.spcMain.Panel1.Controls.Add(this.btnGenerate);
            this.spcMain.Panel1.Controls.Add(this.txtTable);
            this.spcMain.Panel1.Controls.Add(this.txtPrefix);
            this.spcMain.Panel1.Controls.Add(this.txtDBString);
            this.spcMain.Panel1.Controls.Add(this.cbxDBType);
            this.spcMain.Panel1.Controls.Add(this.lblTable);
            this.spcMain.Panel1.Controls.Add(this.lblPrefix);
            this.spcMain.Panel1.Controls.Add(this.lblDBString);
            this.spcMain.Panel1.Controls.Add(this.lblDBType);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.txtClass);
            this.spcMain.Size = new System.Drawing.Size(1067, 625);
            this.spcMain.SplitterDistance = 533;
            this.spcMain.SplitterWidth = 5;
            this.spcMain.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(140)))));
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(425, 122);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 29);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(95, 92);
            this.txtTable.Margin = new System.Windows.Forms.Padding(0);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(429, 25);
            this.txtTable.TabIndex = 4;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(95, 62);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(429, 25);
            this.txtPrefix.TabIndex = 3;
            // 
            // txtDBString
            // 
            this.txtDBString.Location = new System.Drawing.Point(95, 32);
            this.txtDBString.Margin = new System.Windows.Forms.Padding(0);
            this.txtDBString.Name = "txtDBString";
            this.txtDBString.Size = new System.Drawing.Size(429, 25);
            this.txtDBString.TabIndex = 2;
            // 
            // cbxDBType
            // 
            this.cbxDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDBType.FormattingEnabled = true;
            this.cbxDBType.Location = new System.Drawing.Point(95, 4);
            this.cbxDBType.Margin = new System.Windows.Forms.Padding(0);
            this.cbxDBType.Name = "cbxDBType";
            this.cbxDBType.Size = new System.Drawing.Size(429, 23);
            this.cbxDBType.TabIndex = 1;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(52, 98);
            this.lblTable.Margin = new System.Windows.Forms.Padding(0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(37, 15);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "表名";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(20, 68);
            this.lblPrefix.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(67, 15);
            this.lblPrefix.TabIndex = 0;
            this.lblPrefix.Text = "字段前缀";
            // 
            // lblDBString
            // 
            this.lblDBString.AutoSize = true;
            this.lblDBString.Location = new System.Drawing.Point(4, 38);
            this.lblDBString.Margin = new System.Windows.Forms.Padding(0);
            this.lblDBString.Name = "lblDBString";
            this.lblDBString.Size = new System.Drawing.Size(82, 15);
            this.lblDBString.TabIndex = 0;
            this.lblDBString.Text = "数据库链接";
            // 
            // lblDBType
            // 
            this.lblDBType.AutoSize = true;
            this.lblDBType.Location = new System.Drawing.Point(4, 9);
            this.lblDBType.Margin = new System.Windows.Forms.Padding(0);
            this.lblDBType.Name = "lblDBType";
            this.lblDBType.Size = new System.Drawing.Size(82, 15);
            this.lblDBType.TabIndex = 0;
            this.lblDBType.Text = "数据库类型";
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.White;
            this.txtClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClass.Location = new System.Drawing.Point(0, 0);
            this.txtClass.Margin = new System.Windows.Forms.Padding(0);
            this.txtClass.Multiline = true;
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClass.Size = new System.Drawing.Size(525, 621);
            this.txtClass.TabIndex = 0;
            // 
            // cbxShowMemo
            // 
            this.cbxShowMemo.AutoSize = true;
            this.cbxShowMemo.Location = new System.Drawing.Point(95, 127);
            this.cbxShowMemo.Name = "cbxShowMemo";
            this.cbxShowMemo.Size = new System.Drawing.Size(89, 19);
            this.cbxShowMemo.TabIndex = 5;
            this.cbxShowMemo.Text = "显示备注";
            this.cbxShowMemo.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 625);
            this.Controls.Add(this.spcMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORM Auto Generate";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel1.PerformLayout();
            this.spcMain.Panel2.ResumeLayout(false);
            this.spcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.Label lblDBType;
        private System.Windows.Forms.ComboBox cbxDBType;
        private System.Windows.Forms.Label lblDBString;
        private System.Windows.Forms.TextBox txtDBString;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.CheckBox cbxShowMemo;
    }
}


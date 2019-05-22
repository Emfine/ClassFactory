namespace Iguana.Tools.GenerateClass
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
            this.spcMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnGenerate = new Iguana.Winform.UserControls.UCSimpleButton();
            this.txtDBString = new Iguana.Winform.UserControls.UCTextEdit();
            this.cbxDBType = new Iguana.Winform.UserControls.UCComboBoxEdit();
            this.lblDBString = new Iguana.Winform.UserControls.UCLabelEdit();
            this.lblDBType = new Iguana.Winform.UserControls.UCLabelEdit();
            this.txtClass = new Iguana.Winform.UserControls.UCMemoEdit();
            this.lblPrefix = new Iguana.Winform.UserControls.UCLabelEdit();
            this.txtPrefix = new Iguana.Winform.UserControls.UCTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDBString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDBType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefix.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.pnlContent.Appearance.Options.UseBackColor = true;
            this.pnlContent.Controls.Add(this.spcMain);
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            this.spcMain.Panel1.Controls.Add(this.btnGenerate);
            this.spcMain.Panel1.Controls.Add(this.txtPrefix);
            this.spcMain.Panel1.Controls.Add(this.txtDBString);
            this.spcMain.Panel1.Controls.Add(this.cbxDBType);
            this.spcMain.Panel1.Controls.Add(this.lblPrefix);
            this.spcMain.Panel1.Controls.Add(this.lblDBString);
            this.spcMain.Panel1.Controls.Add(this.lblDBType);
            this.spcMain.Panel1.Text = "Panel1";
            this.spcMain.Panel2.Controls.Add(this.txtClass);
            this.spcMain.Panel2.Text = "Panel2";
            this.spcMain.Size = new System.Drawing.Size(800, 465);
            this.spcMain.SplitterPosition = 400;
            this.spcMain.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnGenerate.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnGenerate.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnGenerate.Appearance.Options.UseBackColor = true;
            this.btnGenerate.Appearance.Options.UseBorderColor = true;
            this.btnGenerate.Appearance.Options.UseFont = true;
            this.btnGenerate.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGenerate.AppearanceDisabled.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGenerate.AppearanceDisabled.Options.UseBackColor = true;
            this.btnGenerate.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnGenerate.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGenerate.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGenerate.AppearanceHovered.Options.UseBackColor = true;
            this.btnGenerate.AppearanceHovered.Options.UseBorderColor = true;
            this.btnGenerate.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGenerate.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGenerate.AppearancePressed.Options.UseBackColor = true;
            this.btnGenerate.AppearancePressed.Options.UseBorderColor = true;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Location = new System.Drawing.Point(321, 87);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            // 
            // txtDBString
            // 
            this.txtDBString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDBString.Location = new System.Drawing.Point(66, 30);
            this.txtDBString.Name = "txtDBString";
            this.txtDBString.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtDBString.Properties.Appearance.Options.UseFont = true;
            this.txtDBString.Size = new System.Drawing.Size(330, 24);
            this.txtDBString.TabIndex = 2;
            // 
            // cbxDBType
            // 
            this.cbxDBType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxDBType.Location = new System.Drawing.Point(66, 3);
            this.cbxDBType.Name = "cbxDBType";
            this.cbxDBType.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbxDBType.Properties.Appearance.Options.UseFont = true;
            this.cbxDBType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDBType.Size = new System.Drawing.Size(330, 24);
            this.cbxDBType.TabIndex = 1;
            // 
            // lblDBString
            // 
            this.lblDBString.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblDBString.Appearance.Options.UseFont = true;
            this.lblDBString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDBString.Location = new System.Drawing.Point(3, 33);
            this.lblDBString.Name = "lblDBString";
            this.lblDBString.Size = new System.Drawing.Size(60, 17);
            this.lblDBString.TabIndex = 0;
            this.lblDBString.Text = "数据库链接";
            // 
            // lblDBType
            // 
            this.lblDBType.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblDBType.Appearance.Options.UseFont = true;
            this.lblDBType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDBType.Location = new System.Drawing.Point(3, 6);
            this.lblDBType.Name = "lblDBType";
            this.lblDBType.Size = new System.Drawing.Size(60, 17);
            this.lblDBType.TabIndex = 0;
            this.lblDBType.Text = "数据库类型";
            // 
            // txtClass
            // 
            this.txtClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClass.Location = new System.Drawing.Point(0, 0);
            this.txtClass.Name = "txtClass";
            this.txtClass.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtClass.Properties.Appearance.Options.UseFont = true;
            this.txtClass.Size = new System.Drawing.Size(395, 465);
            this.txtClass.TabIndex = 0;
            // 
            // lblPrefix
            // 
            this.lblPrefix.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblPrefix.Appearance.Options.UseFont = true;
            this.lblPrefix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrefix.Location = new System.Drawing.Point(15, 60);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(48, 17);
            this.lblPrefix.TabIndex = 0;
            this.lblPrefix.Text = "字段前缀";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPrefix.Location = new System.Drawing.Point(66, 57);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtPrefix.Properties.Appearance.Options.UseFont = true;
            this.txtPrefix.Size = new System.Drawing.Size(330, 24);
            this.txtPrefix.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AllowMaximized = true;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建ORM类";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDBString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDBType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefix.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl spcMain;
        private Winform.UserControls.UCComboBoxEdit cbxDBType;
        private Winform.UserControls.UCLabelEdit lblDBType;
        private Winform.UserControls.UCMemoEdit txtClass;
        private Winform.UserControls.UCTextEdit txtDBString;
        private Winform.UserControls.UCLabelEdit lblDBString;
        private Winform.UserControls.UCSimpleButton btnGenerate;
        private Winform.UserControls.UCTextEdit txtPrefix;
        private Winform.UserControls.UCLabelEdit lblPrefix;
    }
}


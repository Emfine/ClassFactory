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
            this.lblDatabaseType = new Iguana.Winform.UserControls.UCLabelEdit();
            this.btnBuild = new Iguana.Winform.UserControls.UCSimpleButton();
            this.txtConn = new Iguana.Winform.UserControls.UCTextEdit();
            this.txtClass = new Iguana.Winform.UserControls.UCMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).BeginInit();
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
            this.spcMain.Panel1.Controls.Add(this.lblDatabaseType);
            this.spcMain.Panel1.Controls.Add(this.btnBuild);
            this.spcMain.Panel1.Controls.Add(this.txtConn);
            this.spcMain.Panel1.Text = "Panel1";
            this.spcMain.Panel2.Controls.Add(this.txtClass);
            this.spcMain.Panel2.Text = "Panel2";
            this.spcMain.Size = new System.Drawing.Size(800, 465);
            this.spcMain.SplitterPosition = 400;
            this.spcMain.TabIndex = 0;
            // 
            // lblDatabaseType
            // 
            this.lblDatabaseType.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblDatabaseType.Appearance.Options.UseFont = true;
            this.lblDatabaseType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDatabaseType.Location = new System.Drawing.Point(3, 3);
            this.lblDatabaseType.Name = "lblDatabaseType";
            this.lblDatabaseType.Size = new System.Drawing.Size(60, 17);
            this.lblDatabaseType.TabIndex = 0;
            this.lblDatabaseType.Text = "数据库链接";
            // 
            // btnBuild
            // 
            this.btnBuild.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnBuild.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnBuild.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnBuild.Appearance.Options.UseBackColor = true;
            this.btnBuild.Appearance.Options.UseBorderColor = true;
            this.btnBuild.Appearance.Options.UseFont = true;
            this.btnBuild.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuild.AppearanceDisabled.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBuild.AppearanceDisabled.Options.UseBackColor = true;
            this.btnBuild.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnBuild.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBuild.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBuild.AppearanceHovered.Options.UseBackColor = true;
            this.btnBuild.AppearanceHovered.Options.UseBorderColor = true;
            this.btnBuild.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBuild.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBuild.AppearancePressed.Options.UseBackColor = true;
            this.btnBuild.AppearancePressed.Options.UseBorderColor = true;
            this.btnBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuild.Location = new System.Drawing.Point(322, 439);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 2;
            this.btnBuild.Text = "Build(&B)";
            // 
            // txtConn
            // 
            this.txtConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtConn.Location = new System.Drawing.Point(87, 58);
            this.txtConn.Name = "txtConn";
            this.txtConn.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtConn.Properties.Appearance.Options.UseFont = true;
            this.txtConn.Size = new System.Drawing.Size(264, 24);
            this.txtConn.TabIndex = 1;
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
            // MainForm
            // 
            this.AllowMaximized = true;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建ORM类";
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl spcMain;
        private Winform.UserControls.UCMemoEdit txtClass;
        private Winform.UserControls.UCTextEdit txtConn;
        private Winform.UserControls.UCSimpleButton btnBuild;
        private Winform.UserControls.UCLabelEdit lblDatabaseType;
    }
}


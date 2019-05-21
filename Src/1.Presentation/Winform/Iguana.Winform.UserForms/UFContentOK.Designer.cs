namespace Iguana.Winform.UserForms
{
    partial class UFContentOK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitle = new Iguana.Winform.UserControls.UCPanelContainer();
            this.lblClose = new Iguana.Winform.UserControls.UCLabelEdit();
            this.lblTitle = new Iguana.Winform.UserControls.UCLabelEdit();
            this.pnlContent = new Iguana.Winform.UserControls.UCPanelContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.pnlTitle.Appearance.Options.UseBackColor = true;
            this.pnlTitle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlTitle.Controls.Add(this.lblClose);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(800, 30);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblClose.Appearance.Options.UseFont = true;
            this.lblClose.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblClose.Location = new System.Drawing.Point(780, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 22);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "关";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(774, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "标题";
            // 
            // pnlContent
            // 
            this.pnlContent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.pnlContent.Appearance.Options.UseBackColor = true;
            this.pnlContent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 30);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 470);
            this.pnlContent.TabIndex = 1;
            // 
            // UFContentOK
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UFContentOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UFContentOKForm";
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCPanelContainer pnlTitle;
        private UserControls.UCLabelEdit lblTitle;
        private UserControls.UCLabelEdit lblClose;
        private UserControls.UCPanelContainer pnlContent;
    }
}
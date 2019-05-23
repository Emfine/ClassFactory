namespace Iguana.Winform.UserForms
{
    partial class UFMessage
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
            this.txtMessage = new Iguana.Winform.UserControls.UCMemoEdit();
            this.flpButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new Iguana.Winform.UserControls.UCSimpleButton();
            this.btnNo = new Iguana.Winform.UserControls.UCSimpleButton();
            this.btnYes = new Iguana.Winform.UserControls.UCSimpleButton();
            this.btnOK = new Iguana.Winform.UserControls.UCSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            this.flpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.pnlContent.Appearance.Options.UseBackColor = true;
            this.pnlContent.Controls.Add(this.flpButton);
            this.pnlContent.Controls.Add(this.txtMessage);
            this.pnlContent.Size = new System.Drawing.Size(400, 215);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMessage.Location = new System.Drawing.Point(10, 10);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtMessage.Properties.Appearance.Options.UseFont = true;
            this.txtMessage.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtMessage.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtMessage.Properties.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(380, 165);
            this.txtMessage.TabIndex = 1;
            // 
            // flpButton
            // 
            this.flpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpButton.Controls.Add(this.btnCancel);
            this.flpButton.Controls.Add(this.btnNo);
            this.flpButton.Controls.Add(this.btnYes);
            this.flpButton.Controls.Add(this.btnOK);
            this.flpButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButton.Location = new System.Drawing.Point(7, 183);
            this.flpButton.Name = "flpButton";
            this.flpButton.Size = new System.Drawing.Size(386, 29);
            this.flpButton.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnCancel.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseBorderColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.AppearanceDisabled.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.AppearanceDisabled.Options.UseBackColor = true;
            this.btnCancel.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnCancel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancel.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancel.AppearanceHovered.Options.UseBackColor = true;
            this.btnCancel.AppearanceHovered.Options.UseBorderColor = true;
            this.btnCancel.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancel.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancel.AppearancePressed.Options.UseBackColor = true;
            this.btnCancel.AppearancePressed.Options.UseBorderColor = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(308, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            // 
            // btnNo
            // 
            this.btnNo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnNo.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnNo.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnNo.Appearance.Options.UseBackColor = true;
            this.btnNo.Appearance.Options.UseBorderColor = true;
            this.btnNo.Appearance.Options.UseFont = true;
            this.btnNo.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNo.AppearanceDisabled.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnNo.AppearanceDisabled.Options.UseBackColor = true;
            this.btnNo.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnNo.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNo.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNo.AppearanceHovered.Options.UseBackColor = true;
            this.btnNo.AppearanceHovered.Options.UseBorderColor = true;
            this.btnNo.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNo.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNo.AppearancePressed.Options.UseBackColor = true;
            this.btnNo.AppearancePressed.Options.UseBorderColor = true;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Location = new System.Drawing.Point(227, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "否(&N)";
            // 
            // btnYes
            // 
            this.btnYes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnYes.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnYes.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnYes.Appearance.Options.UseBackColor = true;
            this.btnYes.Appearance.Options.UseBorderColor = true;
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.btnYes.AppearanceDisabled.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnYes.AppearanceDisabled.Options.UseBackColor = true;
            this.btnYes.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnYes.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnYes.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnYes.AppearanceHovered.Options.UseBackColor = true;
            this.btnYes.AppearanceHovered.Options.UseBorderColor = true;
            this.btnYes.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnYes.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnYes.AppearancePressed.Options.UseBackColor = true;
            this.btnYes.AppearancePressed.Options.UseBorderColor = true;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(146, 3);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "是(&Y)";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnOK.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnOK.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseBorderColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOK.AppearanceDisabled.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOK.AppearanceDisabled.Options.UseBackColor = true;
            this.btnOK.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnOK.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnOK.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnOK.AppearanceHovered.Options.UseBackColor = true;
            this.btnOK.AppearanceHovered.Options.UseBorderColor = true;
            this.btnOK.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnOK.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnOK.AppearancePressed.Options.UseBackColor = true;
            this.btnOK.AppearancePressed.Options.UseBorderColor = true;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(65, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确认(&O)";
            // 
            // UFMessage
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Name = "UFMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UFMessageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            this.flpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCMemoEdit txtMessage;
        private System.Windows.Forms.FlowLayoutPanel flpButton;
        private UserControls.UCSimpleButton btnCancel;
        private UserControls.UCSimpleButton btnNo;
        private UserControls.UCSimpleButton btnYes;
        private UserControls.UCSimpleButton btnOK;
    }
}
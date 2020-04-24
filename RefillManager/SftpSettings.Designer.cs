namespace RefillManager
{
    partial class SftpSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SftpSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAuthenticationType = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPrivateKey = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPublicKey = new System.Windows.Forms.RichTextBox();
            this.txtPassword = new UBTStandardLibrary.UBTTextBox();
            this.txtUsername = new UBTStandardLibrary.UBTTextBox();
            this.txtPort = new UBTStandardLibrary.UBTTextBox();
            this.txtHostName = new UBTStandardLibrary.UBTTextBox();
            this.pnlWindow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindow
            // 
            this.pnlWindow.Controls.Add(this.panel1);
            this.pnlWindow.Size = new System.Drawing.Size(683, 471);
            this.pnlWindow.Controls.SetChildIndex(this.panel1, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtHostName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(680, 471);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cbAuthenticationType);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 349);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(670, 48);
            this.panel5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authentication Type";
            // 
            // cbAuthenticationType
            // 
            this.cbAuthenticationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAuthenticationType.FormattingEnabled = true;
            this.cbAuthenticationType.Location = new System.Drawing.Point(117, 14);
            this.cbAuthenticationType.Name = "cbAuthenticationType";
            this.cbAuthenticationType.Size = new System.Drawing.Size(543, 21);
            this.cbAuthenticationType.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 418);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(670, 48);
            this.panel4.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Active = false;
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = false;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = false;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(519, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(144, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtPrivateKey);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 249);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(670, 100);
            this.panel3.TabIndex = 6;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrivateKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtPrivateKey.Location = new System.Drawing.Point(1, 1);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(666, 96);
            this.txtPrivateKey.TabIndex = 0;
            this.txtPrivateKey.Text = "Private Key";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPublicKey);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 149);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(670, 100);
            this.panel2.TabIndex = 5;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublicKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublicKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtPublicKey.Location = new System.Drawing.Point(1, 1);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(666, 96);
            this.txtPublicKey.TabIndex = 0;
            this.txtPublicKey.Text = "Public Key";
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleName = "sr";
            this.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtPassword.Hint = "Port";
            this.txtPassword.Index = -1;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(5, 113);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(670, 36);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleName = "sr";
            this.txtUsername.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtUsername.Hint = "Port";
            this.txtUsername.Index = -1;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(5, 77);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(670, 36);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPort
            // 
            this.txtPort.AccessibleName = "sr";
            this.txtPort.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtPort.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtPort.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtPort.BorderThickness = 2;
            this.txtPort.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPort.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtPort.Hint = "Port";
            this.txtPort.Index = -1;
            this.txtPort.isPassword = false;
            this.txtPort.Location = new System.Drawing.Point(5, 41);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(670, 36);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "Port";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHostName
            // 
            this.txtHostName.AccessibleName = "sr";
            this.txtHostName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtHostName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtHostName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtHostName.BorderThickness = 2;
            this.txtHostName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHostName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHostName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHostName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHostName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtHostName.Hint = "Hostname";
            this.txtHostName.Index = -1;
            this.txtHostName.isPassword = false;
            this.txtHostName.Location = new System.Drawing.Point(5, 5);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostName.MaxLength = 32767;
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(670, 36);
            this.txtHostName.TabIndex = 1;
            this.txtHostName.Text = "Hostname";
            this.txtHostName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SftpSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(686, 511);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.LogoImage = ((System.Drawing.Image)(resources.GetObject("$this.LogoImage")));
            this.Name = "SftpSettings";
            this.Text = "Sftp Settings";
            this.TitleText = "Sftp Settings";
            this.pnlWindow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UBTStandardLibrary.UBTTextBox txtHostName;
        private UBTStandardLibrary.UBTTextBox txtPort;
        private UBTStandardLibrary.UBTTextBox txtPassword;
        private UBTStandardLibrary.UBTTextBox txtUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtPublicKey;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txtPrivateKey;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAuthenticationType;
    }
}
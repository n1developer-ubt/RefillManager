namespace RefillManager
{
    partial class DmeInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DmeInput));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtFirstName = new UBTStandardLibrary.UBTTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLastName = new UBTStandardLibrary.UBTTextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlWindow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindow
            // 
            this.pnlWindow.Controls.Add(this.panel1);
            this.pnlWindow.Size = new System.Drawing.Size(522, 314);
            this.pnlWindow.Controls.SetChildIndex(this.panel1, 0);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter the full name of the agent authorizing refills. This information is " +
    "required by CMS.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 314);
            this.panel1.TabIndex = 6;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txtFirstName);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 60);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(5);
            this.panel13.Size = new System.Drawing.Size(519, 48);
            this.panel13.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AccessibleName = "rd";
            this.txtFirstName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtFirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtFirstName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtFirstName.BorderThickness = 3;
            this.txtFirstName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtFirstName.Hint = "First Name";
            this.txtFirstName.Index = -1;
            this.txtFirstName.isPassword = false;
            this.txtFirstName.Location = new System.Drawing.Point(5, 5);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(507, 36);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(519, 48);
            this.panel2.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.AccessibleName = "rd";
            this.txtLastName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtLastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtLastName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtLastName.BorderThickness = 3;
            this.txtLastName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtLastName.Hint = "Last Name";
            this.txtLastName.Index = -1;
            this.txtLastName.isPassword = false;
            this.txtLastName.Location = new System.Drawing.Point(5, 5);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(507, 36);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.btnSubmit);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 266);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(5);
            this.panel14.Size = new System.Drawing.Size(519, 48);
            this.panel14.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Active = false;
            this.btnSubmit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.BorderRadius = 0;
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Iconimage")));
            this.btnSubmit.Iconimage_right = null;
            this.btnSubmit.Iconimage_right_Selected = null;
            this.btnSubmit.Iconimage_Selected = null;
            this.btnSubmit.IconMarginLeft = 0;
            this.btnSubmit.IconMarginRight = 0;
            this.btnSubmit.IconRightVisible = false;
            this.btnSubmit.IconRightZoom = 0D;
            this.btnSubmit.IconVisible = false;
            this.btnSubmit.IconZoom = 90D;
            this.btnSubmit.IsTab = false;
            this.btnSubmit.Location = new System.Drawing.Point(391, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmit.selected = false;
            this.btnSubmit.Size = new System.Drawing.Size(121, 36);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.Textcolor = System.Drawing.Color.White;
            this.btnSubmit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DmeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(525, 354);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.LogoImage = ((System.Drawing.Image)(resources.GetObject("$this.LogoImage")));
            this.Name = "DmeInput";
            this.Text = "DmeInput";
            this.Load += new System.EventHandler(this.DmeInput_Load);
            this.pnlWindow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private UBTStandardLibrary.UBTTextBox txtLastName;
        private System.Windows.Forms.Panel panel13;
        private UBTStandardLibrary.UBTTextBox txtFirstName;
        private System.Windows.Forms.Panel panel14;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmit;
    }
}
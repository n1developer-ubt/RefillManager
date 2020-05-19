namespace RefillManager
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSubmitRefillsData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRxNumbers = new UBTStandardLibrary.UBTTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSubmitRefills = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvRequestExtraDoseData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtRxNumbersRED = new UBTStandardLibrary.UBTTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnRED = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dgvRefillDME = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtEnterRxNumberRD = new UBTStandardLibrary.UBTTextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnSubmitRefillDME = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlWindow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmitRefillsData)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestExtraDoseData)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefillDME)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindow
            // 
            this.pnlWindow.Controls.Add(this.tabControl1);
            this.pnlWindow.Size = new System.Drawing.Size(767, 447);
            this.pnlWindow.Controls.SetChildIndex(this.tabControl1, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 447);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Submit Refills";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 415);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgvSubmitRefillsData);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(748, 317);
            this.panel4.TabIndex = 1;
            // 
            // dgvSubmitRefillsData
            // 
            this.dgvSubmitRefillsData.AllowUserToAddRows = false;
            this.dgvSubmitRefillsData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.dgvSubmitRefillsData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubmitRefillsData.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubmitRefillsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubmitRefillsData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmitRefillsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubmitRefillsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubmitRefillsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNumbers,
            this.clAction});
            this.dgvSubmitRefillsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubmitRefillsData.DoubleBuffered = true;
            this.dgvSubmitRefillsData.EnableHeadersVisualStyles = false;
            this.dgvSubmitRefillsData.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.dgvSubmitRefillsData.HeaderForeColor = System.Drawing.Color.White;
            this.dgvSubmitRefillsData.Location = new System.Drawing.Point(5, 5);
            this.dgvSubmitRefillsData.Name = "dgvSubmitRefillsData";
            this.dgvSubmitRefillsData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSubmitRefillsData.RowHeadersVisible = false;
            this.dgvSubmitRefillsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubmitRefillsData.Size = new System.Drawing.Size(736, 305);
            this.dgvSubmitRefillsData.TabIndex = 0;
            this.dgvSubmitRefillsData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubmitRefillsData_CellContentClick);
            // 
            // clNumbers
            // 
            this.clNumbers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNumbers.HeaderText = "RX Numbers";
            this.clNumbers.Name = "clNumbers";
            // 
            // clAction
            // 
            this.clAction.HeaderText = "Actions";
            this.clAction.Name = "clAction";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtRxNumbers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(748, 48);
            this.panel3.TabIndex = 1;
            // 
            // txtRxNumbers
            // 
            this.txtRxNumbers.AccessibleName = "sr";
            this.txtRxNumbers.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtRxNumbers.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtRxNumbers.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtRxNumbers.BorderThickness = 3;
            this.txtRxNumbers.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRxNumbers.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtRxNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRxNumbers.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRxNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtRxNumbers.Hint = "Enter RX Numbers";
            this.txtRxNumbers.Index = -1;
            this.txtRxNumbers.isPassword = false;
            this.txtRxNumbers.Location = new System.Drawing.Point(5, 5);
            this.txtRxNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.txtRxNumbers.MaxLength = 32767;
            this.txtRxNumbers.Name = "txtRxNumbers";
            this.txtRxNumbers.Size = new System.Drawing.Size(736, 36);
            this.txtRxNumbers.TabIndex = 0;
            this.txtRxNumbers.Text = "Enter RX Numbers";
            this.txtRxNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRxNumbers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRxNumbers_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSubmitRefills);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(748, 48);
            this.panel2.TabIndex = 1;
            // 
            // btnSubmitRefills
            // 
            this.btnSubmitRefills.Active = false;
            this.btnSubmitRefills.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmitRefills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmitRefills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitRefills.BorderRadius = 0;
            this.btnSubmitRefills.ButtonText = "Submit";
            this.btnSubmitRefills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitRefills.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmitRefills.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmitRefills.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmitRefills.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubmitRefills.Iconimage")));
            this.btnSubmitRefills.Iconimage_right = null;
            this.btnSubmitRefills.Iconimage_right_Selected = null;
            this.btnSubmitRefills.Iconimage_Selected = null;
            this.btnSubmitRefills.IconMarginLeft = 0;
            this.btnSubmitRefills.IconMarginRight = 0;
            this.btnSubmitRefills.IconRightVisible = false;
            this.btnSubmitRefills.IconRightZoom = 0D;
            this.btnSubmitRefills.IconVisible = false;
            this.btnSubmitRefills.IconZoom = 90D;
            this.btnSubmitRefills.IsTab = false;
            this.btnSubmitRefills.Location = new System.Drawing.Point(576, 5);
            this.btnSubmitRefills.Name = "btnSubmitRefills";
            this.btnSubmitRefills.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmitRefills.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmitRefills.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmitRefills.selected = false;
            this.btnSubmitRefills.Size = new System.Drawing.Size(165, 36);
            this.btnSubmitRefills.TabIndex = 0;
            this.btnSubmitRefills.Text = "Submit";
            this.btnSubmitRefills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmitRefills.Textcolor = System.Drawing.Color.White;
            this.btnSubmitRefills.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRefills.Click += new System.EventHandler(this.btnSubmitRefills_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Request Extra Dose";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 415);
            this.panel5.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.dgvRequestExtraDoseData);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 48);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(748, 317);
            this.panel8.TabIndex = 1;
            // 
            // dgvRequestExtraDoseData
            // 
            this.dgvRequestExtraDoseData.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.dgvRequestExtraDoseData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRequestExtraDoseData.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequestExtraDoseData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequestExtraDoseData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequestExtraDoseData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRequestExtraDoseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestExtraDoseData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clQuantity,
            this.dataGridViewButtonColumn1});
            this.dgvRequestExtraDoseData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequestExtraDoseData.DoubleBuffered = true;
            this.dgvRequestExtraDoseData.EnableHeadersVisualStyles = false;
            this.dgvRequestExtraDoseData.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.dgvRequestExtraDoseData.HeaderForeColor = System.Drawing.Color.White;
            this.dgvRequestExtraDoseData.Location = new System.Drawing.Point(5, 5);
            this.dgvRequestExtraDoseData.Name = "dgvRequestExtraDoseData";
            this.dgvRequestExtraDoseData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRequestExtraDoseData.RowHeadersVisible = false;
            this.dgvRequestExtraDoseData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequestExtraDoseData.Size = new System.Drawing.Size(736, 305);
            this.dgvRequestExtraDoseData.TabIndex = 0;
            this.dgvRequestExtraDoseData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubmitRefillsData_CellContentClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.txtRxNumbersRED);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5);
            this.panel9.Size = new System.Drawing.Size(748, 48);
            this.panel9.TabIndex = 1;
            // 
            // txtRxNumbersRED
            // 
            this.txtRxNumbersRED.AccessibleName = "red";
            this.txtRxNumbersRED.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtRxNumbersRED.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtRxNumbersRED.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtRxNumbersRED.BorderThickness = 3;
            this.txtRxNumbersRED.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRxNumbersRED.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtRxNumbersRED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRxNumbersRED.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRxNumbersRED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtRxNumbersRED.Hint = "Enter RX Numbers";
            this.txtRxNumbersRED.Index = -1;
            this.txtRxNumbersRED.isPassword = false;
            this.txtRxNumbersRED.Location = new System.Drawing.Point(5, 5);
            this.txtRxNumbersRED.Margin = new System.Windows.Forms.Padding(4);
            this.txtRxNumbersRED.MaxLength = 32767;
            this.txtRxNumbersRED.Name = "txtRxNumbersRED";
            this.txtRxNumbersRED.Size = new System.Drawing.Size(736, 36);
            this.txtRxNumbersRED.TabIndex = 0;
            this.txtRxNumbersRED.Text = "Enter RX Numbers";
            this.txtRxNumbersRED.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRxNumbersRED.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRxNumbers_KeyDown);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btnRED);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 365);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(5);
            this.panel10.Size = new System.Drawing.Size(748, 48);
            this.panel10.TabIndex = 1;
            // 
            // btnRED
            // 
            this.btnRED.Active = false;
            this.btnRED.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnRED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnRED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRED.BorderRadius = 0;
            this.btnRED.ButtonText = "Submit";
            this.btnRED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRED.DisabledColor = System.Drawing.Color.Gray;
            this.btnRED.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRED.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRED.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRED.Iconimage")));
            this.btnRED.Iconimage_right = null;
            this.btnRED.Iconimage_right_Selected = null;
            this.btnRED.Iconimage_Selected = null;
            this.btnRED.IconMarginLeft = 0;
            this.btnRED.IconMarginRight = 0;
            this.btnRED.IconRightVisible = false;
            this.btnRED.IconRightZoom = 0D;
            this.btnRED.IconVisible = false;
            this.btnRED.IconZoom = 90D;
            this.btnRED.IsTab = false;
            this.btnRED.Location = new System.Drawing.Point(576, 5);
            this.btnRED.Name = "btnRED";
            this.btnRED.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnRED.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnRED.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRED.selected = false;
            this.btnRED.Size = new System.Drawing.Size(165, 36);
            this.btnRED.TabIndex = 0;
            this.btnRED.Text = "Submit";
            this.btnRED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRED.Textcolor = System.Drawing.Color.White;
            this.btnRED.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRED.Click += new System.EventHandler(this.btnRED_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Refill Diabetic Supplies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.AccessibleName = "rd";
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(750, 415);
            this.panel11.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.dgvRefillDME);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 48);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(5);
            this.panel12.Size = new System.Drawing.Size(748, 317);
            this.panel12.TabIndex = 1;
            // 
            // dgvRefillDME
            // 
            this.dgvRefillDME.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.dgvRefillDME.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRefillDME.BackgroundColor = System.Drawing.Color.White;
            this.dgvRefillDME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRefillDME.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRefillDME.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRefillDME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefillDME.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.clDescription,
            this.dataGridViewButtonColumn2});
            this.dgvRefillDME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRefillDME.DoubleBuffered = true;
            this.dgvRefillDME.EnableHeadersVisualStyles = false;
            this.dgvRefillDME.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.dgvRefillDME.HeaderForeColor = System.Drawing.Color.White;
            this.dgvRefillDME.Location = new System.Drawing.Point(5, 5);
            this.dgvRefillDME.Name = "dgvRefillDME";
            this.dgvRefillDME.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRefillDME.RowHeadersVisible = false;
            this.dgvRefillDME.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefillDME.Size = new System.Drawing.Size(736, 305);
            this.dgvRefillDME.TabIndex = 0;
            this.dgvRefillDME.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubmitRefillsData_CellContentClick);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txtEnterRxNumberRD);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(5);
            this.panel13.Size = new System.Drawing.Size(748, 48);
            this.panel13.TabIndex = 1;
            // 
            // txtEnterRxNumberRD
            // 
            this.txtEnterRxNumberRD.AccessibleName = "rd";
            this.txtEnterRxNumberRD.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtEnterRxNumberRD.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtEnterRxNumberRD.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtEnterRxNumberRD.BorderThickness = 3;
            this.txtEnterRxNumberRD.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEnterRxNumberRD.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEnterRxNumberRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEnterRxNumberRD.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEnterRxNumberRD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.txtEnterRxNumberRD.Hint = "Enter RX Numbers";
            this.txtEnterRxNumberRD.Index = -1;
            this.txtEnterRxNumberRD.isPassword = false;
            this.txtEnterRxNumberRD.Location = new System.Drawing.Point(5, 5);
            this.txtEnterRxNumberRD.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterRxNumberRD.MaxLength = 32767;
            this.txtEnterRxNumberRD.Name = "txtEnterRxNumberRD";
            this.txtEnterRxNumberRD.Size = new System.Drawing.Size(736, 36);
            this.txtEnterRxNumberRD.TabIndex = 0;
            this.txtEnterRxNumberRD.Text = "Enter RX Numbers";
            this.txtEnterRxNumberRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEnterRxNumberRD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRxNumbers_KeyDown);
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.btnSubmitRefillDME);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 365);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(5);
            this.panel14.Size = new System.Drawing.Size(748, 48);
            this.panel14.TabIndex = 1;
            // 
            // btnSubmitRefillDME
            // 
            this.btnSubmitRefillDME.Active = false;
            this.btnSubmitRefillDME.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmitRefillDME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmitRefillDME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitRefillDME.BorderRadius = 0;
            this.btnSubmitRefillDME.ButtonText = "Submit";
            this.btnSubmitRefillDME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitRefillDME.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmitRefillDME.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmitRefillDME.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmitRefillDME.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubmitRefillDME.Iconimage")));
            this.btnSubmitRefillDME.Iconimage_right = null;
            this.btnSubmitRefillDME.Iconimage_right_Selected = null;
            this.btnSubmitRefillDME.Iconimage_Selected = null;
            this.btnSubmitRefillDME.IconMarginLeft = 0;
            this.btnSubmitRefillDME.IconMarginRight = 0;
            this.btnSubmitRefillDME.IconRightVisible = false;
            this.btnSubmitRefillDME.IconRightZoom = 0D;
            this.btnSubmitRefillDME.IconVisible = false;
            this.btnSubmitRefillDME.IconZoom = 90D;
            this.btnSubmitRefillDME.IsTab = false;
            this.btnSubmitRefillDME.Location = new System.Drawing.Point(576, 5);
            this.btnSubmitRefillDME.Name = "btnSubmitRefillDME";
            this.btnSubmitRefillDME.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmitRefillDME.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.btnSubmitRefillDME.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmitRefillDME.selected = false;
            this.btnSubmitRefillDME.Size = new System.Drawing.Size(165, 36);
            this.btnSubmitRefillDME.TabIndex = 0;
            this.btnSubmitRefillDME.Text = "Submit";
            this.btnSubmitRefillDME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmitRefillDME.Textcolor = System.Drawing.Color.White;
            this.btnSubmitRefillDME.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRefillDME.Click += new System.EventHandler(this.btnSubmitRefillDME_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "RX Numbers";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity Remaining";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // clDescription
            // 
            this.clDescription.HeaderText = "Description";
            this.clDescription.Name = "clDescription";
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Actions";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "RX Numbers";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // clQuantity
            // 
            this.clQuantity.HeaderText = "Quantity";
            this.clQuantity.Name = "clQuantity";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Actions";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(770, 487);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.LogoImage = ((System.Drawing.Image)(resources.GetObject("$this.LogoImage")));
            this.Name = "MainWindow";
            this.Text = "Wellness Concepts Refill Manager";
            this.TitleText = "Wellness Concepts Refill Manager";
            this.pnlWindow.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmitRefillsData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestExtraDoseData)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefillDME)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private UBTStandardLibrary.UBTTextBox txtRxNumbers;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSubmitRefillsData;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmitRefills;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumbers;
        private System.Windows.Forms.DataGridViewButtonColumn clAction;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRequestExtraDoseData;
        private System.Windows.Forms.Panel panel9;
        private UBTStandardLibrary.UBTTextBox txtRxNumbersRED;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuFlatButton btnRED;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRefillDME;
        private System.Windows.Forms.Panel panel13;
        private UBTStandardLibrary.UBTTextBox txtEnterRxNumberRD;
        private System.Windows.Forms.Panel panel14;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmitRefillDME;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn clDescription;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}


namespace LMS_UI
{
    partial class FrmBorrowReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorrowReturn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabctrlBorrwReturn = new System.Windows.Forms.TabControl();
            this.tpgBorrow = new System.Windows.Forms.TabPage();
            this.dgvToBorrow = new System.Windows.Forms.DataGridView();
            this.colbookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmemberid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookcover = new System.Windows.Forms.DataGridViewImageColumn();
            this.colbooktitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtMemberInfo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBookbarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.tpgReturn = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gBoxBasicInfo2 = new System.Windows.Forms.GroupBox();
            this.picImage2 = new System.Windows.Forms.PictureBox();
            this.txtMemberInfo2 = new System.Windows.Forms.TextBox();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberBarcode = new System.Windows.Forms.TextBox();
            this.dgvToReturn = new System.Windows.Forms.DataGridView();
            this.colBorrowBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookbarcode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookcover2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBooktitle2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOverday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkboxBarcodeSystem = new System.Windows.Forms.CheckBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMoto = new System.Windows.Forms.Label();
            this.tabctrlBorrwReturn.SuspendLayout();
            this.tpgBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToBorrow)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.gBoxBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.tpgReturn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gBoxBasicInfo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToReturn)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrlBorrwReturn
            // 
            this.tabctrlBorrwReturn.Controls.Add(this.tpgBorrow);
            this.tabctrlBorrwReturn.Controls.Add(this.tpgReturn);
            this.tabctrlBorrwReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlBorrwReturn.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrlBorrwReturn.Location = new System.Drawing.Point(0, 50);
            this.tabctrlBorrwReturn.Name = "tabctrlBorrwReturn";
            this.tabctrlBorrwReturn.SelectedIndex = 0;
            this.tabctrlBorrwReturn.Size = new System.Drawing.Size(1184, 613);
            this.tabctrlBorrwReturn.TabIndex = 0;
            this.tabctrlBorrwReturn.SelectedIndexChanged += new System.EventHandler(this.tabctrlBorrwReturn_SelectedIndexChanged);
            // 
            // tpgBorrow
            // 
            this.tpgBorrow.AutoScroll = true;
            this.tpgBorrow.Controls.Add(this.dgvToBorrow);
            this.tpgBorrow.Controls.Add(this.pnlContent);
            this.tpgBorrow.Location = new System.Drawing.Point(4, 30);
            this.tpgBorrow.Name = "tpgBorrow";
            this.tpgBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tpgBorrow.Size = new System.Drawing.Size(1176, 579);
            this.tpgBorrow.TabIndex = 0;
            this.tpgBorrow.Text = "စာအုပ္ ငွားရန္";
            this.tpgBorrow.UseVisualStyleBackColor = true;
            // 
            // dgvToBorrow
            // 
            this.dgvToBorrow.AllowUserToAddRows = false;
            this.dgvToBorrow.AllowUserToDeleteRows = false;
            this.dgvToBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvToBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvToBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbookid,
            this.colmemberid,
            this.colbookbarcode,
            this.colbookcover,
            this.colbooktitle,
            this.colDelete});
            this.dgvToBorrow.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvToBorrow.Location = new System.Drawing.Point(0, 310);
            this.dgvToBorrow.Name = "dgvToBorrow";
            this.dgvToBorrow.ReadOnly = true;
            this.dgvToBorrow.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvToBorrow.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvToBorrow.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvToBorrow.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvToBorrow.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvToBorrow.RowTemplate.Height = 75;
            this.dgvToBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvToBorrow.Size = new System.Drawing.Size(1176, 260);
            this.dgvToBorrow.TabIndex = 55;
            this.dgvToBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToBorrow_CellContentClick);
            // 
            // colbookid
            // 
            this.colbookid.DataPropertyName = "bookid";
            this.colbookid.HeaderText = "BookId";
            this.colbookid.Name = "colbookid";
            this.colbookid.ReadOnly = true;
            this.colbookid.Visible = false;
            // 
            // colmemberid
            // 
            this.colmemberid.DataPropertyName = "memberid";
            this.colmemberid.HeaderText = "MemberId";
            this.colmemberid.Name = "colmemberid";
            this.colmemberid.ReadOnly = true;
            this.colmemberid.Visible = false;
            // 
            // colbookbarcode
            // 
            this.colbookbarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colbookbarcode.DataPropertyName = "bookbarcode";
            this.colbookbarcode.HeaderText = "စာအုပ္ ဘားကုဒ္";
            this.colbookbarcode.Name = "colbookbarcode";
            this.colbookbarcode.ReadOnly = true;
            // 
            // colbookcover
            // 
            this.colbookcover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colbookcover.DataPropertyName = "bookcover";
            this.colbookcover.HeaderText = "စာအုပ္မ်က္နွာဖုံး";
            this.colbookcover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colbookcover.Name = "colbookcover";
            this.colbookcover.ReadOnly = true;
            // 
            // colbooktitle
            // 
            this.colbooktitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colbooktitle.DataPropertyName = "booktitle";
            this.colbooktitle.HeaderText = "စာအုပ္အမည္";
            this.colbooktitle.Name = "colbooktitle";
            this.colbooktitle.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "ဖ်က္ရန္";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "ဖ်က္ရန္";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.label7);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.label6);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Controls.Add(this.gBoxBasicInfo);
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.btnSave);
            this.pnlContent.Controls.Add(this.txtBookbarcode);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.txtBarcode);
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1176, 299);
            this.pnlContent.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(34, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 26);
            this.label7.TabIndex = 54;
            this.label7.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 26);
            this.label3.TabIndex = 53;
            this.label3.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label6.Location = new System.Drawing.Point(79, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 26);
            this.label6.TabIndex = 51;
            this.label6.Text = " - လိုအပ္သည္";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(64, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 26);
            this.label5.TabIndex = 50;
            this.label5.Text = "*";
            // 
            // gBoxBasicInfo
            // 
            this.gBoxBasicInfo.Controls.Add(this.picImage);
            this.gBoxBasicInfo.Controls.Add(this.txtMemberInfo);
            this.gBoxBasicInfo.Location = new System.Drawing.Point(583, 17);
            this.gBoxBasicInfo.Name = "gBoxBasicInfo";
            this.gBoxBasicInfo.Size = new System.Drawing.Size(531, 268);
            this.gBoxBasicInfo.TabIndex = 52;
            this.gBoxBasicInfo.TabStop = false;
            this.gBoxBasicInfo.Text = "အသင္း၀င္၏ အခ်က္အလက္";
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(10, 56);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(150, 150);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 52;
            this.picImage.TabStop = false;
            // 
            // txtMemberInfo
            // 
            this.txtMemberInfo.BackColor = System.Drawing.Color.White;
            this.txtMemberInfo.Location = new System.Drawing.Point(190, 56);
            this.txtMemberInfo.Multiline = true;
            this.txtMemberInfo.Name = "txtMemberInfo";
            this.txtMemberInfo.ReadOnly = true;
            this.txtMemberInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMemberInfo.Size = new System.Drawing.Size(330, 156);
            this.txtMemberInfo.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnCancel.Location = new System.Drawing.Point(347, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "ရွင္းလင္းရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnSave.Location = new System.Drawing.Point(190, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "ငွားရန္";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBookbarcode
            // 
            this.txtBookbarcode.Enabled = false;
            this.txtBookbarcode.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBookbarcode.Location = new System.Drawing.Point(190, 142);
            this.txtBookbarcode.Name = "txtBookbarcode";
            this.txtBookbarcode.Size = new System.Drawing.Size(300, 34);
            this.txtBookbarcode.TabIndex = 1;
            this.txtBookbarcode.TextChanged += new System.EventHandler(this.txtBookbarcode_TextChanged);
            this.txtBookbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookbarcode_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.Location = new System.Drawing.Point(34, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 46;
            this.label4.Text = "အသင္း၀င္ ဘားကုဒ္ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.Location = new System.Drawing.Point(57, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 48;
            this.label1.Text = "စာအုပ္ ဘားကုဒ္ :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBarcode.Location = new System.Drawing.Point(190, 92);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(300, 34);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // tpgReturn
            // 
            this.tpgReturn.AutoScroll = true;
            this.tpgReturn.Controls.Add(this.panel1);
            this.tpgReturn.Controls.Add(this.dgvToReturn);
            this.tpgReturn.Location = new System.Drawing.Point(4, 30);
            this.tpgReturn.Name = "tpgReturn";
            this.tpgReturn.Padding = new System.Windows.Forms.Padding(3);
            this.tpgReturn.Size = new System.Drawing.Size(1176, 579);
            this.tpgReturn.TabIndex = 1;
            this.tpgReturn.Text = "စာအုပ္ ျပန္အပ္ရန္";
            this.tpgReturn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.gBoxBasicInfo2);
            this.panel1.Controls.Add(this.btnClear2);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMemberBarcode);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 299);
            this.panel1.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(8, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 26);
            this.label10.TabIndex = 55;
            this.label10.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label8.Location = new System.Drawing.Point(79, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 26);
            this.label8.TabIndex = 54;
            this.label8.Text = " - လိုအပ္သည္";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(64, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 26);
            this.label9.TabIndex = 53;
            this.label9.Text = "*";
            // 
            // gBoxBasicInfo2
            // 
            this.gBoxBasicInfo2.Controls.Add(this.picImage2);
            this.gBoxBasicInfo2.Controls.Add(this.txtMemberInfo2);
            this.gBoxBasicInfo2.Location = new System.Drawing.Point(583, 17);
            this.gBoxBasicInfo2.Name = "gBoxBasicInfo2";
            this.gBoxBasicInfo2.Size = new System.Drawing.Size(531, 268);
            this.gBoxBasicInfo2.TabIndex = 52;
            this.gBoxBasicInfo2.TabStop = false;
            this.gBoxBasicInfo2.Text = "အသင္း၀င္၏ အခ်က္အလက္";
            // 
            // picImage2
            // 
            this.picImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage2.Image = ((System.Drawing.Image)(resources.GetObject("picImage2.Image")));
            this.picImage2.Location = new System.Drawing.Point(10, 56);
            this.picImage2.Name = "picImage2";
            this.picImage2.Size = new System.Drawing.Size(150, 150);
            this.picImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage2.TabIndex = 52;
            this.picImage2.TabStop = false;
            // 
            // txtMemberInfo2
            // 
            this.txtMemberInfo2.BackColor = System.Drawing.Color.White;
            this.txtMemberInfo2.Location = new System.Drawing.Point(190, 56);
            this.txtMemberInfo2.Multiline = true;
            this.txtMemberInfo2.Name = "txtMemberInfo2";
            this.txtMemberInfo2.ReadOnly = true;
            this.txtMemberInfo2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMemberInfo2.Size = new System.Drawing.Size(330, 156);
            this.txtMemberInfo2.TabIndex = 0;
            // 
            // btnClear2
            // 
            this.btnClear2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnClear2.Location = new System.Drawing.Point(347, 154);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(143, 40);
            this.btnClear2.TabIndex = 2;
            this.btnClear2.Text = "ရွင္းလင္းရန္";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnReturn.Location = new System.Drawing.Point(190, 154);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 40);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "အပ္ရန္";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "အသင္း၀င္ ဘားကုဒ္ :";
            // 
            // txtMemberBarcode
            // 
            this.txtMemberBarcode.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtMemberBarcode.Location = new System.Drawing.Point(190, 92);
            this.txtMemberBarcode.Name = "txtMemberBarcode";
            this.txtMemberBarcode.Size = new System.Drawing.Size(300, 34);
            this.txtMemberBarcode.TabIndex = 0;
            this.txtMemberBarcode.TextChanged += new System.EventHandler(this.txtMemberBarcode_TextChanged);
            this.txtMemberBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemberBarcode_KeyDown);
            // 
            // dgvToReturn
            // 
            this.dgvToReturn.AllowUserToAddRows = false;
            this.dgvToReturn.AllowUserToDeleteRows = false;
            this.dgvToReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvToReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvToReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBorrowBookId,
            this.colBookbarcode2,
            this.colBookcover2,
            this.colBooktitle2,
            this.colDateBorrowed,
            this.colDueDate,
            this.colOverday,
            this.colFine,
            this.colReturn});
            this.dgvToReturn.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvToReturn.Location = new System.Drawing.Point(0, 310);
            this.dgvToReturn.Name = "dgvToReturn";
            this.dgvToReturn.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvToReturn.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvToReturn.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvToReturn.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvToReturn.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvToReturn.RowTemplate.Height = 75;
            this.dgvToReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvToReturn.Size = new System.Drawing.Size(1176, 260);
            this.dgvToReturn.TabIndex = 0;
            this.dgvToReturn.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToReturn_CellValueChanged);
            // 
            // colBorrowBookId
            // 
            this.colBorrowBookId.DataPropertyName = "Borrowbookid";
            this.colBorrowBookId.HeaderText = "BorrowBookId";
            this.colBorrowBookId.Name = "colBorrowBookId";
            this.colBorrowBookId.Visible = false;
            // 
            // colBookbarcode2
            // 
            this.colBookbarcode2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBookbarcode2.DataPropertyName = "bookbarcode";
            this.colBookbarcode2.HeaderText = "စာအုပ္ ဘားကုဒ္";
            this.colBookbarcode2.Name = "colBookbarcode2";
            this.colBookbarcode2.ReadOnly = true;
            // 
            // colBookcover2
            // 
            this.colBookcover2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBookcover2.DataPropertyName = "bookcover";
            this.colBookcover2.HeaderText = "စာအုပ္မ်က္နွာဖုံး";
            this.colBookcover2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colBookcover2.Name = "colBookcover2";
            this.colBookcover2.ReadOnly = true;
            // 
            // colBooktitle2
            // 
            this.colBooktitle2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBooktitle2.DataPropertyName = "booktitle";
            this.colBooktitle2.HeaderText = "စာအုပ္အမည္";
            this.colBooktitle2.Name = "colBooktitle2";
            this.colBooktitle2.ReadOnly = true;
            // 
            // colDateBorrowed
            // 
            this.colDateBorrowed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDateBorrowed.DataPropertyName = "dateborrowed";
            this.colDateBorrowed.HeaderText = "ငွားခဲ့သည့္ရက္စြဲ";
            this.colDateBorrowed.Name = "colDateBorrowed";
            this.colDateBorrowed.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDueDate.DataPropertyName = "duedate";
            this.colDueDate.HeaderText = "ျပန္အပ္ရမည့္ရက္စြဲ";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colOverday
            // 
            this.colOverday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOverday.DataPropertyName = "overday";
            this.colOverday.HeaderText = "ေက်ာ္လြန္ရက္";
            this.colOverday.Name = "colOverday";
            this.colOverday.ReadOnly = true;
            // 
            // colFine
            // 
            this.colFine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFine.DataPropertyName = "fine";
            this.colFine.HeaderText = "ရက္လြန္ေၾကး";
            this.colFine.Name = "colFine";
            this.colFine.ReadOnly = true;
            // 
            // colReturn
            // 
            this.colReturn.HeaderText = "အပ္ရန္";
            this.colReturn.Name = "colReturn";
            // 
            // chkboxBarcodeSystem
            // 
            this.chkboxBarcodeSystem.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.chkboxBarcodeSystem.ForeColor = System.Drawing.Color.White;
            this.chkboxBarcodeSystem.Location = new System.Drawing.Point(12, 12);
            this.chkboxBarcodeSystem.Name = "chkboxBarcodeSystem";
            this.chkboxBarcodeSystem.Size = new System.Drawing.Size(156, 30);
            this.chkboxBarcodeSystem.TabIndex = 0;
            this.chkboxBarcodeSystem.Text = "Bar Code Scanner";
            this.chkboxBarcodeSystem.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.lblMoto);
            this.pnlHeader.Controls.Add(this.chkboxBarcodeSystem);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 50);
            this.pnlHeader.TabIndex = 49;
            // 
            // lblMoto
            // 
            this.lblMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoto.AutoSize = true;
            this.lblMoto.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblMoto.ForeColor = System.Drawing.Color.White;
            this.lblMoto.Location = new System.Drawing.Point(730, 12);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(443, 26);
            this.lblMoto.TabIndex = 19;
            this.lblMoto.Text = "ယေန႕ကို ရင္းနွီးျမွဳပ္ႏွံသူသည္ မနက္ျဖန္ကို သစၥာရွိေသာသူ ျဖစ္သည္";
            // 
            // FrmBorrowReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.tabctrlBorrwReturn);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBorrowReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "စာအုပ္ ငွား/ ျပန္အပ္ ရန္";
            this.Load += new System.EventHandler(this.FrmBorrowReturn_Load);
            this.tabctrlBorrwReturn.ResumeLayout(false);
            this.tpgBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToBorrow)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.gBoxBasicInfo.ResumeLayout(false);
            this.gBoxBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.tpgReturn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBoxBasicInfo2.ResumeLayout(false);
            this.gBoxBasicInfo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToReturn)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlBorrwReturn;
        private System.Windows.Forms.TabPage tpgBorrow;
        private System.Windows.Forms.TabPage tpgReturn;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TextBox txtBookbarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvToBorrow;
        private System.Windows.Forms.DataGridView dgvToReturn;
        private System.Windows.Forms.CheckBox chkboxBarcodeSystem;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gBoxBasicInfo;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtMemberInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmemberid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookbarcode;
        private System.Windows.Forms.DataGridViewImageColumn colbookcover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbooktitle;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gBoxBasicInfo2;
        private System.Windows.Forms.PictureBox picImage2;
        private System.Windows.Forms.TextBox txtMemberInfo2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookbarcode2;
        private System.Windows.Forms.DataGridViewImageColumn colBookcover2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooktitle2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFine;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMoto;
    }
}
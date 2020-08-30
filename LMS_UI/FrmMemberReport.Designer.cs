namespace LMS_UI
{
    partial class FrmMemberReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnShowWithAddress = new System.Windows.Forms.Button();
            this.lblMoto = new System.Windows.Forms.Label();
            this.lblMemberQty = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.lblExpired = new System.Windows.Forms.Label();
            this.lblBaned = new System.Windows.Forms.Label();
            this.lblLower18 = new System.Windows.Forms.Label();
            this.gboxAge = new System.Windows.Forms.GroupBox();
            this.lblAbove50 = new System.Windows.Forms.Label();
            this.lbl30to50 = new System.Windows.Forms.Label();
            this.lbl18to30 = new System.Windows.Forms.Label();
            this.gboxOccupation = new System.Windows.Forms.GroupBox();
            this.dgvOccupation = new System.Windows.Forms.DataGridView();
            this.colOccupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxEducation = new System.Windows.Forms.GroupBox();
            this.dgvEducation = new System.Windows.Forms.DataGridView();
            this.coleducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlWithAddress = new System.Windows.Forms.Panel();
            this.pnlMemberReport = new System.Windows.Forms.Panel();
            this.gboxMemberType = new System.Windows.Forms.GroupBox();
            this.dgvMembertype = new System.Windows.Forms.DataGridView();
            this.colMemberType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cboTownship = new System.Windows.Forms.ComboBox();
            this.lblTownship = new System.Windows.Forms.Label();
            this.gboxVillage = new System.Windows.Forms.GroupBox();
            this.dgvVillage = new System.Windows.Forms.DataGridView();
            this.colVillage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxTownship = new System.Windows.Forms.GroupBox();
            this.dgvTownship = new System.Windows.Forms.DataGridView();
            this.colTownship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.gboxAge.SuspendLayout();
            this.gboxOccupation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupation)).BeginInit();
            this.gboxEducation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducation)).BeginInit();
            this.pnlWithAddress.SuspendLayout();
            this.pnlMemberReport.SuspendLayout();
            this.gboxMemberType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembertype)).BeginInit();
            this.gboxVillage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVillage)).BeginInit();
            this.gboxTownship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTownship)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.btnShowWithAddress);
            this.pnlHeader.Controls.Add(this.lblMoto);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 50);
            this.pnlHeader.TabIndex = 77;
            // 
            // btnShowWithAddress
            // 
            this.btnShowWithAddress.BackColor = System.Drawing.Color.DimGray;
            this.btnShowWithAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowWithAddress.FlatAppearance.BorderSize = 0;
            this.btnShowWithAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowWithAddress.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnShowWithAddress.ForeColor = System.Drawing.Color.White;
            this.btnShowWithAddress.Location = new System.Drawing.Point(5, 0);
            this.btnShowWithAddress.Name = "btnShowWithAddress";
            this.btnShowWithAddress.Size = new System.Drawing.Size(250, 50);
            this.btnShowWithAddress.TabIndex = 89;
            this.btnShowWithAddress.Text = "ေဒသလိုက္ အသင္း၀င္မ်ား အစီရင္ခံစာ";
            this.btnShowWithAddress.UseVisualStyleBackColor = false;
            this.btnShowWithAddress.Click += new System.EventHandler(this.btnShowWithAddress_Click);
            // 
            // lblMoto
            // 
            this.lblMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoto.AutoSize = true;
            this.lblMoto.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblMoto.ForeColor = System.Drawing.Color.White;
            this.lblMoto.Location = new System.Drawing.Point(997, 11);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(175, 26);
            this.lblMoto.TabIndex = 18;
            this.lblMoto.Text = "စာအုပ္စာေပ လူ႕မိတ္ေဆြ";
            // 
            // lblMemberQty
            // 
            this.lblMemberQty.AutoSize = true;
            this.lblMemberQty.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblMemberQty.Location = new System.Drawing.Point(241, 15);
            this.lblMemberQty.Name = "lblMemberQty";
            this.lblMemberQty.Size = new System.Drawing.Size(129, 26);
            this.lblMemberQty.TabIndex = 78;
            this.lblMemberQty.Text = "အသင္း၀င္ ဦးေရ -";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblMale.Location = new System.Drawing.Point(284, 141);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(86, 26);
            this.lblMale.TabIndex = 79;
            this.lblMale.Text = "အမ်ိဳးသား -";
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblFemale.Location = new System.Drawing.Point(282, 178);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(88, 26);
            this.lblFemale.TabIndex = 80;
            this.lblFemale.Text = "အမ်ိဳးသမီး -";
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblExpired.Location = new System.Drawing.Point(234, 57);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(136, 26);
            this.lblExpired.TabIndex = 81;
            this.lblExpired.Text = "သက္တမ္းကုန္ဆုံး -";
            // 
            // lblBaned
            // 
            this.lblBaned.AutoSize = true;
            this.lblBaned.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblBaned.Location = new System.Drawing.Point(258, 99);
            this.lblBaned.Name = "lblBaned";
            this.lblBaned.Size = new System.Drawing.Size(112, 26);
            this.lblBaned.TabIndex = 82;
            this.lblBaned.Text = "ငွားခြင့္ပိတ္ခံရ -";
            // 
            // lblLower18
            // 
            this.lblLower18.AutoSize = true;
            this.lblLower18.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblLower18.Location = new System.Drawing.Point(36, 36);
            this.lblLower18.Name = "lblLower18";
            this.lblLower18.Size = new System.Drawing.Size(119, 26);
            this.lblLower18.TabIndex = 83;
            this.lblLower18.Text = "၁၈ နွစ္ေအာက္ -";
            // 
            // gboxAge
            // 
            this.gboxAge.Controls.Add(this.lblAbove50);
            this.gboxAge.Controls.Add(this.lbl30to50);
            this.gboxAge.Controls.Add(this.lbl18to30);
            this.gboxAge.Controls.Add(this.lblLower18);
            this.gboxAge.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.gboxAge.Location = new System.Drawing.Point(583, 15);
            this.gboxAge.Name = "gboxAge";
            this.gboxAge.Size = new System.Drawing.Size(350, 200);
            this.gboxAge.TabIndex = 84;
            this.gboxAge.TabStop = false;
            this.gboxAge.Text = "အသက္အရြယ္";
            // 
            // lblAbove50
            // 
            this.lblAbove50.AutoSize = true;
            this.lblAbove50.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblAbove50.Location = new System.Drawing.Point(37, 138);
            this.lblAbove50.Name = "lblAbove50";
            this.lblAbove50.Size = new System.Drawing.Size(118, 26);
            this.lblAbove50.TabIndex = 86;
            this.lblAbove50.Text = "၅၀ နွစ္အထက္ -";
            // 
            // lbl30to50
            // 
            this.lbl30to50.AutoSize = true;
            this.lbl30to50.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lbl30to50.Location = new System.Drawing.Point(20, 104);
            this.lbl30to50.Name = "lbl30to50";
            this.lbl30to50.Size = new System.Drawing.Size(135, 26);
            this.lbl30to50.TabIndex = 85;
            this.lbl30to50.Text = "၃၀ မွ ၅၀ အတြင္း -";
            // 
            // lbl18to30
            // 
            this.lbl18to30.AutoSize = true;
            this.lbl18to30.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lbl18to30.Location = new System.Drawing.Point(20, 70);
            this.lbl18to30.Name = "lbl18to30";
            this.lbl18to30.Size = new System.Drawing.Size(135, 26);
            this.lbl18to30.TabIndex = 84;
            this.lbl18to30.Text = "၁၈ မွ ၃၀ အတြင္း -";
            // 
            // gboxOccupation
            // 
            this.gboxOccupation.Controls.Add(this.dgvOccupation);
            this.gboxOccupation.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.gboxOccupation.Location = new System.Drawing.Point(774, 227);
            this.gboxOccupation.Name = "gboxOccupation";
            this.gboxOccupation.Size = new System.Drawing.Size(350, 370);
            this.gboxOccupation.TabIndex = 87;
            this.gboxOccupation.TabStop = false;
            this.gboxOccupation.Text = "အလုပ္အကိုင္";
            // 
            // dgvOccupation
            // 
            this.dgvOccupation.AllowUserToAddRows = false;
            this.dgvOccupation.AllowUserToDeleteRows = false;
            this.dgvOccupation.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOccupation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvOccupation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOccupation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOccupation,
            this.colQty2});
            this.dgvOccupation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOccupation.Location = new System.Drawing.Point(3, 25);
            this.dgvOccupation.Name = "dgvOccupation";
            this.dgvOccupation.ReadOnly = true;
            this.dgvOccupation.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOccupation.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOccupation.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOccupation.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOccupation.RowTemplate.Height = 30;
            this.dgvOccupation.Size = new System.Drawing.Size(344, 342);
            this.dgvOccupation.TabIndex = 2;
            // 
            // colOccupation
            // 
            this.colOccupation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOccupation.DataPropertyName = "Occupation";
            this.colOccupation.HeaderText = "အလုပ္အကိုင္";
            this.colOccupation.Name = "colOccupation";
            this.colOccupation.ReadOnly = true;
            // 
            // colQty2
            // 
            this.colQty2.DataPropertyName = "QtyOFMember";
            this.colQty2.HeaderText = "ဦးေရ";
            this.colQty2.Name = "colQty2";
            this.colQty2.ReadOnly = true;
            // 
            // gboxEducation
            // 
            this.gboxEducation.Controls.Add(this.dgvEducation);
            this.gboxEducation.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.gboxEducation.Location = new System.Drawing.Point(408, 227);
            this.gboxEducation.Name = "gboxEducation";
            this.gboxEducation.Size = new System.Drawing.Size(350, 370);
            this.gboxEducation.TabIndex = 88;
            this.gboxEducation.TabStop = false;
            this.gboxEducation.Text = "ပညာအရည္အခ်င္း";
            // 
            // dgvEducation
            // 
            this.dgvEducation.AllowUserToAddRows = false;
            this.dgvEducation.AllowUserToDeleteRows = false;
            this.dgvEducation.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEducation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEducation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coleducation,
            this.colQty});
            this.dgvEducation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEducation.Location = new System.Drawing.Point(3, 25);
            this.dgvEducation.Name = "dgvEducation";
            this.dgvEducation.ReadOnly = true;
            this.dgvEducation.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEducation.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEducation.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEducation.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEducation.RowTemplate.Height = 30;
            this.dgvEducation.Size = new System.Drawing.Size(344, 342);
            this.dgvEducation.TabIndex = 1;
            // 
            // coleducation
            // 
            this.coleducation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coleducation.DataPropertyName = "education";
            this.coleducation.HeaderText = "ပညာအရည္အခ်င္း";
            this.coleducation.Name = "coleducation";
            this.coleducation.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "QtyOFMember";
            this.colQty.HeaderText = "ဦးေရ";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // pnlWithAddress
            // 
            this.pnlWithAddress.BackColor = System.Drawing.Color.White;
            this.pnlWithAddress.Controls.Add(this.cboState);
            this.pnlWithAddress.Controls.Add(this.lblState);
            this.pnlWithAddress.Controls.Add(this.cboTownship);
            this.pnlWithAddress.Controls.Add(this.lblTownship);
            this.pnlWithAddress.Controls.Add(this.gboxVillage);
            this.pnlWithAddress.Controls.Add(this.gboxTownship);
            this.pnlWithAddress.Location = new System.Drawing.Point(0, 2);
            this.pnlWithAddress.Name = "pnlWithAddress";
            this.pnlWithAddress.Size = new System.Drawing.Size(1184, 610);
            this.pnlWithAddress.TabIndex = 89;
            this.pnlWithAddress.Visible = false;
            // 
            // pnlMemberReport
            // 
            this.pnlMemberReport.AutoScroll = true;
            this.pnlMemberReport.Controls.Add(this.pnlWithAddress);
            this.pnlMemberReport.Controls.Add(this.gboxMemberType);
            this.pnlMemberReport.Controls.Add(this.gboxEducation);
            this.pnlMemberReport.Controls.Add(this.gboxAge);
            this.pnlMemberReport.Controls.Add(this.lblBaned);
            this.pnlMemberReport.Controls.Add(this.lblFemale);
            this.pnlMemberReport.Controls.Add(this.lblMemberQty);
            this.pnlMemberReport.Controls.Add(this.lblExpired);
            this.pnlMemberReport.Controls.Add(this.lblMale);
            this.pnlMemberReport.Controls.Add(this.gboxOccupation);
            this.pnlMemberReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMemberReport.Location = new System.Drawing.Point(0, 50);
            this.pnlMemberReport.Name = "pnlMemberReport";
            this.pnlMemberReport.Size = new System.Drawing.Size(1184, 613);
            this.pnlMemberReport.TabIndex = 95;
            // 
            // gboxMemberType
            // 
            this.gboxMemberType.Controls.Add(this.dgvMembertype);
            this.gboxMemberType.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.gboxMemberType.Location = new System.Drawing.Point(42, 227);
            this.gboxMemberType.Name = "gboxMemberType";
            this.gboxMemberType.Size = new System.Drawing.Size(350, 370);
            this.gboxMemberType.TabIndex = 89;
            this.gboxMemberType.TabStop = false;
            this.gboxMemberType.Text = "အသင္း၀င္အမ်ိဳးအစား";
            // 
            // dgvMembertype
            // 
            this.dgvMembertype.AllowUserToAddRows = false;
            this.dgvMembertype.AllowUserToDeleteRows = false;
            this.dgvMembertype.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembertype.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvMembertype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembertype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberType,
            this.colQty4});
            this.dgvMembertype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembertype.Location = new System.Drawing.Point(3, 25);
            this.dgvMembertype.Name = "dgvMembertype";
            this.dgvMembertype.ReadOnly = true;
            this.dgvMembertype.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMembertype.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMembertype.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMembertype.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMembertype.RowTemplate.Height = 30;
            this.dgvMembertype.Size = new System.Drawing.Size(344, 342);
            this.dgvMembertype.TabIndex = 1;
            // 
            // colMemberType
            // 
            this.colMemberType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemberType.DataPropertyName = "MemberType";
            this.colMemberType.HeaderText = "အသင္း၀င္အမ်ိဳးအစား";
            this.colMemberType.Name = "colMemberType";
            this.colMemberType.ReadOnly = true;
            // 
            // colQty4
            // 
            this.colQty4.DataPropertyName = "QtyOFMember";
            this.colQty4.HeaderText = "ဦးေရ";
            this.colQty4.Name = "colQty4";
            this.colQty4.ReadOnly = true;
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(237, 121);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(350, 34);
            this.cboState.TabIndex = 91;
            this.cboState.DropDownClosed += new System.EventHandler(this.cboState_DropDownClosed);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblState.Location = new System.Drawing.Point(232, 81);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(110, 26);
            this.lblState.TabIndex = 94;
            this.lblState.Text = "ျပည္နယ္/ တုိင္း";
            // 
            // cboTownship
            // 
            this.cboTownship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTownship.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboTownship.FormattingEnabled = true;
            this.cboTownship.Location = new System.Drawing.Point(603, 121);
            this.cboTownship.Name = "cboTownship";
            this.cboTownship.Size = new System.Drawing.Size(350, 34);
            this.cboTownship.TabIndex = 92;
            this.cboTownship.DropDownClosed += new System.EventHandler(this.cboTownship_DropDownClosed);
            // 
            // lblTownship
            // 
            this.lblTownship.AutoSize = true;
            this.lblTownship.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblTownship.Location = new System.Drawing.Point(601, 81);
            this.lblTownship.Name = "lblTownship";
            this.lblTownship.Size = new System.Drawing.Size(58, 26);
            this.lblTownship.TabIndex = 93;
            this.lblTownship.Text = "ျမိဳ႕နယ္";
            // 
            // gboxVillage
            // 
            this.gboxVillage.Controls.Add(this.dgvVillage);
            this.gboxVillage.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.gboxVillage.Location = new System.Drawing.Point(603, 161);
            this.gboxVillage.Name = "gboxVillage";
            this.gboxVillage.Size = new System.Drawing.Size(350, 370);
            this.gboxVillage.TabIndex = 90;
            this.gboxVillage.TabStop = false;
            this.gboxVillage.Text = "ေက်းရြာ/ ရပ္ကြက္";
            // 
            // dgvVillage
            // 
            this.dgvVillage.AllowUserToAddRows = false;
            this.dgvVillage.AllowUserToDeleteRows = false;
            this.dgvVillage.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVillage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvVillage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVillage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVillage,
            this.colQty3});
            this.dgvVillage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVillage.Location = new System.Drawing.Point(3, 25);
            this.dgvVillage.Name = "dgvVillage";
            this.dgvVillage.ReadOnly = true;
            this.dgvVillage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvVillage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVillage.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVillage.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVillage.RowTemplate.Height = 30;
            this.dgvVillage.Size = new System.Drawing.Size(344, 342);
            this.dgvVillage.TabIndex = 1;
            // 
            // colVillage
            // 
            this.colVillage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVillage.DataPropertyName = "village";
            this.colVillage.HeaderText = "ေက်းရြာ/ ရပ္ကြက္";
            this.colVillage.Name = "colVillage";
            this.colVillage.ReadOnly = true;
            // 
            // colQty3
            // 
            this.colQty3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQty3.DataPropertyName = "qtyofmember";
            this.colQty3.HeaderText = "ဦးေရ";
            this.colQty3.Name = "colQty3";
            this.colQty3.ReadOnly = true;
            // 
            // gboxTownship
            // 
            this.gboxTownship.Controls.Add(this.dgvTownship);
            this.gboxTownship.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.gboxTownship.Location = new System.Drawing.Point(237, 161);
            this.gboxTownship.Name = "gboxTownship";
            this.gboxTownship.Size = new System.Drawing.Size(350, 370);
            this.gboxTownship.TabIndex = 89;
            this.gboxTownship.TabStop = false;
            this.gboxTownship.Text = "ျမိဳ႕နယ္";
            // 
            // dgvTownship
            // 
            this.dgvTownship.AllowUserToAddRows = false;
            this.dgvTownship.AllowUserToDeleteRows = false;
            this.dgvTownship.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTownship.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvTownship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTownship.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTownship,
            this.colQty1});
            this.dgvTownship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTownship.Location = new System.Drawing.Point(3, 25);
            this.dgvTownship.Name = "dgvTownship";
            this.dgvTownship.ReadOnly = true;
            this.dgvTownship.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTownship.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTownship.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTownship.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTownship.RowTemplate.Height = 30;
            this.dgvTownship.Size = new System.Drawing.Size(344, 342);
            this.dgvTownship.TabIndex = 1;
            // 
            // colTownship
            // 
            this.colTownship.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTownship.DataPropertyName = "township";
            this.colTownship.HeaderText = "ျမိဳ႕နယ္";
            this.colTownship.Name = "colTownship";
            this.colTownship.ReadOnly = true;
            // 
            // colQty1
            // 
            this.colQty1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQty1.DataPropertyName = "qtyofMember";
            this.colQty1.HeaderText = "ဦးေရ";
            this.colQty1.Name = "colQty1";
            this.colQty1.ReadOnly = true;
            // 
            // FrmMemberReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.pnlMemberReport);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmMemberReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "အသင္း၀င္မ်ား အစီရင္ခၤစာ";
            this.Load += new System.EventHandler(this.FrmMemberReport_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gboxAge.ResumeLayout(false);
            this.gboxAge.PerformLayout();
            this.gboxOccupation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupation)).EndInit();
            this.gboxEducation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducation)).EndInit();
            this.pnlWithAddress.ResumeLayout(false);
            this.pnlWithAddress.PerformLayout();
            this.pnlMemberReport.ResumeLayout(false);
            this.pnlMemberReport.PerformLayout();
            this.gboxMemberType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembertype)).EndInit();
            this.gboxVillage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVillage)).EndInit();
            this.gboxTownship.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTownship)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.Label lblMemberQty;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.Label lblBaned;
        private System.Windows.Forms.Label lblLower18;
        private System.Windows.Forms.GroupBox gboxAge;
        private System.Windows.Forms.Label lblAbove50;
        private System.Windows.Forms.Label lbl30to50;
        private System.Windows.Forms.Label lbl18to30;
        private System.Windows.Forms.GroupBox gboxOccupation;
        private System.Windows.Forms.GroupBox gboxEducation;
        private System.Windows.Forms.DataGridView dgvEducation;
        private System.Windows.Forms.DataGridView dgvOccupation;
        private System.Windows.Forms.Button btnShowWithAddress;
        private System.Windows.Forms.Panel pnlWithAddress;
        private System.Windows.Forms.GroupBox gboxVillage;
        private System.Windows.Forms.DataGridView dgvVillage;
        private System.Windows.Forms.GroupBox gboxTownship;
        private System.Windows.Forms.DataGridView dgvTownship;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cboTownship;
        private System.Windows.Forms.Label lblTownship;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOccupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVillage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTownship;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty1;
        private System.Windows.Forms.Panel pnlMemberReport;
        private System.Windows.Forms.GroupBox gboxMemberType;
        private System.Windows.Forms.DataGridView dgvMembertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty4;
    }
}
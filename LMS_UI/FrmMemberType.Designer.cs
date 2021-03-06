namespace LMS_UI
{
    partial class FrmMemberType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemberType));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMembertype = new System.Windows.Forms.DataGridView();
            this.colMembertypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllowbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colallowday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtMembertype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numAllowbook = new System.Windows.Forms.NumericUpDown();
            this.numExpireDate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chbLifetime = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numAllowDay = new System.Windows.Forms.NumericUpDown();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembertype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAllowbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpireDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAllowDay)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvMembertype);
            this.panel2.Location = new System.Drawing.Point(12, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 298);
            this.panel2.TabIndex = 12;
            // 
            // dgvMembertype
            // 
            this.dgvMembertype.AllowUserToAddRows = false;
            this.dgvMembertype.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembertype.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembertype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembertype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMembertypeid,
            this.colNo,
            this.colMembertype,
            this.colAllowbook,
            this.colallowday,
            this.colExpiredate,
            this.colEdit});
            this.dgvMembertype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembertype.Location = new System.Drawing.Point(0, 0);
            this.dgvMembertype.Name = "dgvMembertype";
            this.dgvMembertype.ReadOnly = true;
            this.dgvMembertype.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMembertype.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMembertype.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMembertype.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMembertype.RowTemplate.Height = 30;
            this.dgvMembertype.Size = new System.Drawing.Size(760, 298);
            this.dgvMembertype.TabIndex = 0;
            this.dgvMembertype.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembertype_CellContentClick);
            // 
            // colMembertypeid
            // 
            this.colMembertypeid.DataPropertyName = "membertypeid";
            this.colMembertypeid.HeaderText = "Membertypeid";
            this.colMembertypeid.Name = "colMembertypeid";
            this.colMembertypeid.ReadOnly = true;
            this.colMembertypeid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္။";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 75;
            // 
            // colMembertype
            // 
            this.colMembertype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMembertype.DataPropertyName = "membertype";
            this.colMembertype.HeaderText = "အသင္း၀င္ အမ်ိဳးအစား";
            this.colMembertype.Name = "colMembertype";
            this.colMembertype.ReadOnly = true;
            // 
            // colAllowbook
            // 
            this.colAllowbook.DataPropertyName = "allowbook";
            this.colAllowbook.HeaderText = "ခြင့္ျပဳစာအုပ္ေရ";
            this.colAllowbook.Name = "colAllowbook";
            this.colAllowbook.ReadOnly = true;
            // 
            // colallowday
            // 
            this.colallowday.DataPropertyName = "allowday";
            this.colallowday.HeaderText = "ခြင့္ျပဳရက္";
            this.colallowday.Name = "colallowday";
            this.colallowday.ReadOnly = true;
            this.colallowday.Width = 75;
            // 
            // colExpiredate
            // 
            this.colExpiredate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExpiredate.DataPropertyName = "expiredate";
            this.colExpiredate.HeaderText = "အသင္း၀င္ သက္တမ္း";
            this.colExpiredate.Name = "colExpiredate";
            this.colExpiredate.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "ျပင္ဆင္ရန္";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "ျပင္ဆင္ရန္";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // txtMembertype
            // 
            this.txtMembertype.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtMembertype.Location = new System.Drawing.Point(303, 47);
            this.txtMembertype.Name = "txtMembertype";
            this.txtMembertype.Size = new System.Drawing.Size(300, 34);
            this.txtMembertype.TabIndex = 0;
            this.txtMembertype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMembertype_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.Location = new System.Drawing.Point(130, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "အသင္း၀င္ အမ်ိဳးအစား";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnSave.Location = new System.Drawing.Point(303, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ထည့္သြင္းရန္";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnCancel.Location = new System.Drawing.Point(460, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "ထြက္ရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.Location = new System.Drawing.Point(176, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "ခြင့္ျပဳစာအုပ္ေရ";
            // 
            // numAllowbook
            // 
            this.numAllowbook.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.numAllowbook.Location = new System.Drawing.Point(303, 97);
            this.numAllowbook.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numAllowbook.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAllowbook.Name = "numAllowbook";
            this.numAllowbook.Size = new System.Drawing.Size(150, 34);
            this.numAllowbook.TabIndex = 1;
            this.numAllowbook.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAllowbook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numAllowbook_KeyDown);
            // 
            // numExpireDate
            // 
            this.numExpireDate.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.numExpireDate.Location = new System.Drawing.Point(303, 197);
            this.numExpireDate.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numExpireDate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExpireDate.Name = "numExpireDate";
            this.numExpireDate.Size = new System.Drawing.Size(150, 34);
            this.numExpireDate.TabIndex = 3;
            this.numExpireDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExpireDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numExpireDate_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label3.Location = new System.Drawing.Point(137, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "အသင္း၀င္ သက္တမ္း";
            // 
            // chbLifetime
            // 
            this.chbLifetime.AutoSize = true;
            this.chbLifetime.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.chbLifetime.Location = new System.Drawing.Point(469, 204);
            this.chbLifetime.Name = "chbLifetime";
            this.chbLifetime.Size = new System.Drawing.Size(189, 30);
            this.chbLifetime.TabIndex = 6;
            this.chbLifetime.Text = "တစ္သက္တာ အသင္း၀င္";
            this.chbLifetime.UseVisualStyleBackColor = true;
            this.chbLifetime.CheckedChanged += new System.EventHandler(this.chbLifetime_CheckedChanged);
            this.chbLifetime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbLifetime_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.Location = new System.Drawing.Point(213, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 67;
            this.label4.Text = "ခြင့္ျပဳရက္";
            // 
            // numAllowDay
            // 
            this.numAllowDay.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.numAllowDay.Location = new System.Drawing.Point(303, 147);
            this.numAllowDay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numAllowDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAllowDay.Name = "numAllowDay";
            this.numAllowDay.Size = new System.Drawing.Size(150, 34);
            this.numAllowDay.TabIndex = 2;
            this.numAllowDay.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numAllowDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numAllowDay_KeyDown);
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.Controls.Add(this.label8);
            this.pnlContent.Controls.Add(this.label7);
            this.pnlContent.Controls.Add(this.label6);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Controls.Add(this.label19);
            this.pnlContent.Controls.Add(this.label20);
            this.pnlContent.Controls.Add(this.numAllowDay);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.chbLifetime);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.numExpireDate);
            this.pnlContent.Controls.Add(this.numAllowbook);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.btnSave);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtMembertype);
            this.pnlContent.Location = new System.Drawing.Point(12, 12);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(760, 335);
            this.pnlContent.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(103, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 26);
            this.label8.TabIndex = 93;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(149, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 26);
            this.label7.TabIndex = 92;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(186, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 26);
            this.label6.TabIndex = 91;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(110, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 26);
            this.label5.TabIndex = 90;
            this.label5.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label19.Location = new System.Drawing.Point(181, 254);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 26);
            this.label19.TabIndex = 89;
            this.label19.Text = " - လိုအပ္သည္";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(166, 254);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 26);
            this.label20.TabIndex = 88;
            this.label20.Text = "*";
            // 
            // FrmMemberType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMemberType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "အသင္း၀င္ အမ်ိဳးအစား";
            this.Load += new System.EventHandler(this.FrmMemberType_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembertype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAllowbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpireDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAllowDay)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMembertype;
        private System.Windows.Forms.TextBox txtMembertype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAllowbook;
        private System.Windows.Forms.NumericUpDown numExpireDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbLifetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAllowDay;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembertypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllowbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colallowday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiredate;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    }
}
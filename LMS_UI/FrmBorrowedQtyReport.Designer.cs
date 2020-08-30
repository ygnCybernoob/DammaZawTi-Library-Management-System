namespace LMS_UI
{
    partial class FrmBorrowedQtyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorrowedQtyReport));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSperator2 = new System.Windows.Forms.Panel();
            this.pnlSperator = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrowedNowMonth = new System.Windows.Forms.Button();
            this.dtpkStart = new System.Windows.Forms.DateTimePicker();
            this.dgvMemberRentReport = new System.Windows.Forms.DataGridView();
            this.colMemberid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberRentReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.btnShow2);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.pnlSperator2);
            this.pnlHeader.Controls.Add(this.pnlSperator);
            this.pnlHeader.Controls.Add(this.btnShow);
            this.pnlHeader.Controls.Add(this.numQty);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.dtpkEnd);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.btnBorrowedNowMonth);
            this.pnlHeader.Controls.Add(this.dtpkStart);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 50);
            this.pnlHeader.TabIndex = 78;
            // 
            // btnShow2
            // 
            this.btnShow2.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnShow2.Location = new System.Drawing.Point(881, 8);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(100, 35);
            this.btnShow2.TabIndex = 96;
            this.btnShow2.Text = "ၾကည့္ရန္";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(630, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 26);
            this.label3.TabIndex = 95;
            this.label3.Text = "စာအုပ္အေရအတြက္";
            // 
            // pnlSperator2
            // 
            this.pnlSperator2.BackColor = System.Drawing.Color.White;
            this.pnlSperator2.Location = new System.Drawing.Point(622, 0);
            this.pnlSperator2.Name = "pnlSperator2";
            this.pnlSperator2.Size = new System.Drawing.Size(2, 50);
            this.pnlSperator2.TabIndex = 94;
            // 
            // pnlSperator
            // 
            this.pnlSperator.BackColor = System.Drawing.Color.White;
            this.pnlSperator.Location = new System.Drawing.Point(160, 0);
            this.pnlSperator.Name = "pnlSperator";
            this.pnlSperator.Size = new System.Drawing.Size(2, 50);
            this.pnlSperator.TabIndex = 93;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnShow.Location = new System.Drawing.Point(519, 8);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 35);
            this.btnShow.TabIndex = 92;
            this.btnShow.Text = "ၾကည့္ရန္";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // numQty
            // 
            this.numQty.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.numQty.Location = new System.Drawing.Point(775, 8);
            this.numQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(100, 34);
            this.numQty.TabIndex = 91;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(475, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 26);
            this.label1.TabIndex = 89;
            this.label1.Text = "...ထိ";
            // 
            // dtpkEnd
            // 
            this.dtpkEnd.CustomFormat = "dd MMM, yyyy";
            this.dtpkEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpkEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkEnd.Location = new System.Drawing.Point(340, 12);
            this.dtpkEnd.Name = "dtpkEnd";
            this.dtpkEnd.Size = new System.Drawing.Size(135, 26);
            this.dtpkEnd.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 26);
            this.label2.TabIndex = 87;
            this.label2.Text = "မွ...";
            // 
            // btnBorrowedNowMonth
            // 
            this.btnBorrowedNowMonth.BackColor = System.Drawing.Color.DimGray;
            this.btnBorrowedNowMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowedNowMonth.FlatAppearance.BorderSize = 0;
            this.btnBorrowedNowMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowedNowMonth.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnBorrowedNowMonth.ForeColor = System.Drawing.Color.White;
            this.btnBorrowedNowMonth.Location = new System.Drawing.Point(5, 0);
            this.btnBorrowedNowMonth.Name = "btnBorrowedNowMonth";
            this.btnBorrowedNowMonth.Size = new System.Drawing.Size(150, 50);
            this.btnBorrowedNowMonth.TabIndex = 86;
            this.btnBorrowedNowMonth.Text = "ဤလငွားရမ္းမႈစာရင္း";
            this.btnBorrowedNowMonth.UseVisualStyleBackColor = false;
            this.btnBorrowedNowMonth.Click += new System.EventHandler(this.btnBorrowedNowMonth_Click);
            // 
            // dtpkStart
            // 
            this.dtpkStart.CustomFormat = "dd MMM, yyyy";
            this.dtpkStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpkStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkStart.Location = new System.Drawing.Point(168, 12);
            this.dtpkStart.Name = "dtpkStart";
            this.dtpkStart.Size = new System.Drawing.Size(135, 26);
            this.dtpkStart.TabIndex = 85;
            // 
            // dgvMemberRentReport
            // 
            this.dgvMemberRentReport.AllowUserToAddRows = false;
            this.dgvMemberRentReport.AllowUserToDeleteRows = false;
            this.dgvMemberRentReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberRentReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberRentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberRentReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberid,
            this.colNo,
            this.colMemberBarcode,
            this.colMembername,
            this.colBorrowedQty});
            this.dgvMemberRentReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberRentReport.Location = new System.Drawing.Point(0, 50);
            this.dgvMemberRentReport.Name = "dgvMemberRentReport";
            this.dgvMemberRentReport.ReadOnly = true;
            this.dgvMemberRentReport.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMemberRentReport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMemberRentReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMemberRentReport.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMemberRentReport.RowTemplate.Height = 30;
            this.dgvMemberRentReport.Size = new System.Drawing.Size(1184, 613);
            this.dgvMemberRentReport.TabIndex = 79;
            // 
            // colMemberid
            // 
            this.colMemberid.DataPropertyName = "Memberid";
            this.colMemberid.HeaderText = "Memberid";
            this.colMemberid.Name = "colMemberid";
            this.colMemberid.ReadOnly = true;
            this.colMemberid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 60;
            // 
            // colMemberBarcode
            // 
            this.colMemberBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemberBarcode.DataPropertyName = "MemberBarcode";
            this.colMemberBarcode.HeaderText = "အသင္း၀င္ ဘားကုဒ္";
            this.colMemberBarcode.Name = "colMemberBarcode";
            this.colMemberBarcode.ReadOnly = true;
            // 
            // colMembername
            // 
            this.colMembername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMembername.DataPropertyName = "MemberName";
            this.colMembername.HeaderText = "အသင္း၀င္အမည္";
            this.colMembername.Name = "colMembername";
            this.colMembername.ReadOnly = true;
            // 
            // colBorrowedQty
            // 
            this.colBorrowedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBorrowedQty.DataPropertyName = "BorrowedQty";
            this.colBorrowedQty.HeaderText = "ငွားခဲ့သည့္ စာအုပ္အေရအတြက္";
            this.colBorrowedQty.Name = "colBorrowedQty";
            this.colBorrowedQty.ReadOnly = true;
            // 
            // FrmBorrowedQtyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.dgvMemberRentReport);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBorrowedQtyReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "အသင္း၀င္မ်ား၏ ငွားရမ္းမႈစာရင္း";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberRentReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DataGridView dgvMemberRentReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrowedNowMonth;
        private System.Windows.Forms.DateTimePicker dtpkStart;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowedQty;
        private System.Windows.Forms.Panel pnlSperator;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel pnlSperator2;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Label label3;
    }
}
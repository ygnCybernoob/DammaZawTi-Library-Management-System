namespace LMS_UI
{
    partial class FrmOverDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOverDay));
            this.dgvOverDay = new System.Windows.Forms.DataGridView();
            this.colMemberid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowbookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookbarcode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBooktitle2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOverday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverDay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOverDay
            // 
            this.dgvOverDay.AllowUserToAddRows = false;
            this.dgvOverDay.AllowUserToDeleteRows = false;
            this.dgvOverDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverDay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOverDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberid,
            this.colBookid,
            this.colBorrowbookid,
            this.colNo,
            this.colMemberBarcode,
            this.colMemberName,
            this.colphone,
            this.colBookbarcode2,
            this.colBooktitle2,
            this.colDateBorrowed,
            this.colDueDate,
            this.colOverday});
            this.dgvOverDay.Location = new System.Drawing.Point(0, 50);
            this.dgvOverDay.Name = "dgvOverDay";
            this.dgvOverDay.ReadOnly = true;
            this.dgvOverDay.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOverDay.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOverDay.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOverDay.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOverDay.RowTemplate.Height = 30;
            this.dgvOverDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverDay.Size = new System.Drawing.Size(1084, 513);
            this.dgvOverDay.TabIndex = 1;
            this.dgvOverDay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOverDay_CellContentClick);
            // 
            // colMemberid
            // 
            this.colMemberid.DataPropertyName = "memberid";
            this.colMemberid.HeaderText = "memberid";
            this.colMemberid.Name = "colMemberid";
            this.colMemberid.ReadOnly = true;
            this.colMemberid.Visible = false;
            // 
            // colBookid
            // 
            this.colBookid.DataPropertyName = "bookid";
            this.colBookid.HeaderText = "Bookid";
            this.colBookid.Name = "colBookid";
            this.colBookid.ReadOnly = true;
            this.colBookid.Visible = false;
            // 
            // colBorrowbookid
            // 
            this.colBorrowbookid.DataPropertyName = "borrowbookid";
            this.colBorrowbookid.HeaderText = "BorrowBookid";
            this.colBorrowbookid.Name = "colBorrowbookid";
            this.colBorrowbookid.ReadOnly = true;
            this.colBorrowbookid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 65;
            // 
            // colMemberBarcode
            // 
            this.colMemberBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemberBarcode.DataPropertyName = "memberbarcode";
            this.colMemberBarcode.HeaderText = "အသင္း၀င္ ဘားကုဒ္";
            this.colMemberBarcode.Name = "colMemberBarcode";
            this.colMemberBarcode.ReadOnly = true;
            // 
            // colMemberName
            // 
            this.colMemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemberName.DataPropertyName = "Membername";
            this.colMemberName.HeaderText = "အသင္း၀င္အမည္";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            // 
            // colphone
            // 
            this.colphone.DataPropertyName = "phoneno";
            this.colphone.HeaderText = "ဖုန္းနံပါတ္";
            this.colphone.Name = "colphone";
            this.colphone.ReadOnly = true;
            // 
            // colBookbarcode2
            // 
            this.colBookbarcode2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBookbarcode2.DataPropertyName = "bookbarcode";
            this.colBookbarcode2.HeaderText = "စာအုပ္ ဘားကုဒ္";
            this.colBookbarcode2.Name = "colBookbarcode2";
            this.colBookbarcode2.ReadOnly = true;
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
            this.colOverday.DataPropertyName = "overday";
            this.colOverday.HeaderText = "ေက်ာ္လြန္ရက္";
            this.colOverday.Name = "colOverday";
            this.colOverday.ReadOnly = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 50);
            this.pnlHeader.TabIndex = 51;
            // 
            // FrmOverDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 563);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvOverDay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOverDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ရက္လြန္ စာအုပ္မ်ား";
            this.Load += new System.EventHandler(this.FrmOverDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOverDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowbookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookbarcode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooktitle2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverday;
        private System.Windows.Forms.Panel pnlHeader;
    }
}
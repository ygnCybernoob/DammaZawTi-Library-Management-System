namespace LMS_UI
{
    partial class FrmReturnedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReturnedList));
            this.dgvReturnedList = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookbarcode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBooktitle2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibrarian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSperator2 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.lblMoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedList)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReturnedList
            // 
            this.dgvReturnedList.AllowUserToAddRows = false;
            this.dgvReturnedList.AllowUserToDeleteRows = false;
            this.dgvReturnedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReturnedList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnedList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturnedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colMemberBarcode,
            this.colMembername,
            this.colBookbarcode2,
            this.colBooktitle2,
            this.colLibrarian,
            this.colDateBorrowed,
            this.colDueDate,
            this.colReturnDate,
            this.colFine});
            this.dgvReturnedList.Location = new System.Drawing.Point(0, 50);
            this.dgvReturnedList.Name = "dgvReturnedList";
            this.dgvReturnedList.ReadOnly = true;
            this.dgvReturnedList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvReturnedList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnedList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReturnedList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReturnedList.RowTemplate.Height = 30;
            this.dgvReturnedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReturnedList.Size = new System.Drawing.Size(1184, 607);
            this.dgvReturnedList.TabIndex = 1;
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
            this.colMemberBarcode.DataPropertyName = "memberbarcode";
            this.colMemberBarcode.HeaderText = "အသင္း၀င္ ဘားကုဒ္";
            this.colMemberBarcode.Name = "colMemberBarcode";
            this.colMemberBarcode.ReadOnly = true;
            // 
            // colMembername
            // 
            this.colMembername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMembername.DataPropertyName = "membername";
            this.colMembername.HeaderText = "အသင္း၀င္အမည္";
            this.colMembername.Name = "colMembername";
            this.colMembername.ReadOnly = true;
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
            // colLibrarian
            // 
            this.colLibrarian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLibrarian.DataPropertyName = "LibrarianName";
            this.colLibrarian.HeaderText = "တာ၀န္ခံ";
            this.colLibrarian.Name = "colLibrarian";
            this.colLibrarian.ReadOnly = true;
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
            // colReturnDate
            // 
            this.colReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReturnDate.DataPropertyName = "returndate";
            this.colReturnDate.HeaderText = "ျပန္အပ္သည့္ရက္စြဲ";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;
            // 
            // colFine
            // 
            this.colFine.DataPropertyName = "fine";
            this.colFine.HeaderText = "ရက္လြန္ေၾကး";
            this.colFine.Name = "colFine";
            this.colFine.ReadOnly = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.pnlSperator2);
            this.pnlHeader.Controls.Add(this.btnShow);
            this.pnlHeader.Controls.Add(this.txtBarcode);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.dtpkDate);
            this.pnlHeader.Controls.Add(this.lblMoto);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 50);
            this.pnlHeader.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(504, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 97;
            this.label2.Text = "ၾကည့္လိုသည့္ လ :";
            // 
            // pnlSperator2
            // 
            this.pnlSperator2.BackColor = System.Drawing.Color.White;
            this.pnlSperator2.Location = new System.Drawing.Point(486, 0);
            this.pnlSperator2.Name = "pnlSperator2";
            this.pnlSperator2.Size = new System.Drawing.Size(2, 50);
            this.pnlSperator2.TabIndex = 96;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnShow.Location = new System.Drawing.Point(369, 8);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 35);
            this.btnShow.TabIndex = 95;
            this.btnShow.Text = "ရွာရန္";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBarcode.Location = new System.Drawing.Point(163, 8);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(200, 34);
            this.txtBarcode.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 90;
            this.label1.Text = "အသင္း၀င္ဘားကုဒ္ :";
            // 
            // dtpkDate
            // 
            this.dtpkDate.CustomFormat = "MMM, yyyy";
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDate.Location = new System.Drawing.Point(642, 12);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(106, 26);
            this.dtpkDate.TabIndex = 78;
            this.dtpkDate.CloseUp += new System.EventHandler(this.dtpkDate_CloseUp);
            // 
            // lblMoto
            // 
            this.lblMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoto.AutoSize = true;
            this.lblMoto.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblMoto.ForeColor = System.Drawing.Color.White;
            this.lblMoto.Location = new System.Drawing.Point(997, 12);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(175, 26);
            this.lblMoto.TabIndex = 18;
            this.lblMoto.Text = "စာအုပ္စာေပ လူ႕မိတ္ေဆြ";
            // 
            // FrmReturnedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvReturnedList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReturnedList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ျပန္အပ္ျပီးစာရင္း";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedList)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReturnedList;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Panel pnlSperator2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookbarcode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooktitle2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibrarian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFine;
    }
}
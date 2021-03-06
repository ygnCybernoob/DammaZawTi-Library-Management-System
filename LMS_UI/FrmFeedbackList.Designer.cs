namespace LMS_UI
{
    partial class FrmFeedbackList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFeedbackList));
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.colFeedbackid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfeedbackdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmembername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.lblMoto = new System.Windows.Forms.Label();
            this.btnUnchecked = new System.Windows.Forms.Button();
            this.btnChecked = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.AllowUserToAddRows = false;
            this.dgvFeedback.AllowUserToDeleteRows = false;
            this.dgvFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFeedback.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeedback.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFeedbackid,
            this.colNo,
            this.colfeedbackdate,
            this.colMemberbarcode,
            this.colmembername,
            this.colsubject,
            this.colFeedback});
            this.dgvFeedback.Location = new System.Drawing.Point(0, 50);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.ReadOnly = true;
            this.dgvFeedback.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvFeedback.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFeedback.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFeedback.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFeedback.RowTemplate.Height = 30;
            this.dgvFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeedback.Size = new System.Drawing.Size(1184, 612);
            this.dgvFeedback.TabIndex = 1;
            this.dgvFeedback.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellDoubleClick);
            // 
            // colFeedbackid
            // 
            this.colFeedbackid.DataPropertyName = "feedbackid";
            this.colFeedbackid.HeaderText = "Feedbackid";
            this.colFeedbackid.Name = "colFeedbackid";
            this.colFeedbackid.ReadOnly = true;
            this.colFeedbackid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္။";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 75;
            // 
            // colfeedbackdate
            // 
            this.colfeedbackdate.DataPropertyName = "feedbackdate";
            this.colfeedbackdate.HeaderText = "ရက္စြဲ";
            this.colfeedbackdate.Name = "colfeedbackdate";
            this.colfeedbackdate.ReadOnly = true;
            this.colfeedbackdate.Width = 130;
            // 
            // colMemberbarcode
            // 
            this.colMemberbarcode.DataPropertyName = "memberbarcode";
            this.colMemberbarcode.HeaderText = "အသင္း၀င္ဘားကုဒ္";
            this.colMemberbarcode.Name = "colMemberbarcode";
            this.colMemberbarcode.ReadOnly = true;
            this.colMemberbarcode.Width = 200;
            // 
            // colmembername
            // 
            this.colmembername.DataPropertyName = "Membername";
            this.colmembername.HeaderText = "အမည္";
            this.colmembername.Name = "colmembername";
            this.colmembername.ReadOnly = true;
            this.colmembername.Width = 200;
            // 
            // colsubject
            // 
            this.colsubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colsubject.DataPropertyName = "subject";
            this.colsubject.HeaderText = "အေၾကာင္းအရာေခါင္းစဉ္";
            this.colsubject.Name = "colsubject";
            this.colsubject.ReadOnly = true;
            // 
            // colFeedback
            // 
            this.colFeedback.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFeedback.DataPropertyName = "feedback";
            this.colFeedback.HeaderText = "အေၾကာင္းအရာ";
            this.colFeedback.Name = "colFeedback";
            this.colFeedback.ReadOnly = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.dtpkDate);
            this.pnlHeader.Controls.Add(this.lblMoto);
            this.pnlHeader.Controls.Add(this.btnUnchecked);
            this.pnlHeader.Controls.Add(this.btnChecked);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 50);
            this.pnlHeader.TabIndex = 76;
            // 
            // dtpkDate
            // 
            this.dtpkDate.CustomFormat = "MMM, yyyy";
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDate.Location = new System.Drawing.Point(384, 12);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(106, 26);
            this.dtpkDate.TabIndex = 77;
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
            // btnUnchecked
            // 
            this.btnUnchecked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnchecked.FlatAppearance.BorderSize = 0;
            this.btnUnchecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnchecked.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnUnchecked.ForeColor = System.Drawing.Color.White;
            this.btnUnchecked.Location = new System.Drawing.Point(179, 0);
            this.btnUnchecked.Name = "btnUnchecked";
            this.btnUnchecked.Size = new System.Drawing.Size(200, 50);
            this.btnUnchecked.TabIndex = 1;
            this.btnUnchecked.Text = "မဖတ္ရႈရေသးေသာ စာမ်ား";
            this.btnUnchecked.UseVisualStyleBackColor = false;
            this.btnUnchecked.Click += new System.EventHandler(this.btnUnchecked_Click);
            // 
            // btnChecked
            // 
            this.btnChecked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChecked.FlatAppearance.BorderSize = 0;
            this.btnChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecked.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnChecked.ForeColor = System.Drawing.Color.White;
            this.btnChecked.Location = new System.Drawing.Point(4, 0);
            this.btnChecked.Name = "btnChecked";
            this.btnChecked.Size = new System.Drawing.Size(175, 50);
            this.btnChecked.TabIndex = 0;
            this.btnChecked.Text = "ဖတ္ရႈျပီးသား စာမ်ား";
            this.btnChecked.UseVisualStyleBackColor = false;
            this.btnChecked.Click += new System.EventHandler(this.btnChecked_Click);
            // 
            // FrmFeedbackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvFeedback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFeedbackList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "အေၾကာင္းၾကားစာ/ အမွာစာမ်ား";
            this.Load += new System.EventHandler(this.FrmFeedbackList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.Button btnUnchecked;
        private System.Windows.Forms.Button btnChecked;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeedbackid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfeedbackdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmembername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeedback;
    }
}
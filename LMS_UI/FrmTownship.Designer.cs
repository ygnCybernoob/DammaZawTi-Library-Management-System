namespace LMS_UI
{
    partial class FrmTownship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTownship));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTownship = new System.Windows.Forms.DataGridView();
            this.colStateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTownshipid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTownship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTownship = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTownship)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvTownship);
            this.panel2.Location = new System.Drawing.Point(12, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 298);
            this.panel2.TabIndex = 12;
            // 
            // dgvTownship
            // 
            this.dgvTownship.AllowUserToAddRows = false;
            this.dgvTownship.AllowUserToDeleteRows = false;
            this.dgvTownship.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTownship.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTownship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTownship.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStateid,
            this.colTownshipid,
            this.colNo,
            this.colTownship,
            this.colState,
            this.colDesp,
            this.colEdit});
            this.dgvTownship.Location = new System.Drawing.Point(0, 0);
            this.dgvTownship.Name = "dgvTownship";
            this.dgvTownship.ReadOnly = true;
            this.dgvTownship.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTownship.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTownship.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTownship.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTownship.RowTemplate.Height = 30;
            this.dgvTownship.Size = new System.Drawing.Size(760, 298);
            this.dgvTownship.TabIndex = 0;
            this.dgvTownship.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTownship_CellContentClick);
            // 
            // colStateid
            // 
            this.colStateid.DataPropertyName = "stateid";
            this.colStateid.HeaderText = "Stateid";
            this.colStateid.Name = "colStateid";
            this.colStateid.ReadOnly = true;
            this.colStateid.Visible = false;
            // 
            // colTownshipid
            // 
            this.colTownshipid.DataPropertyName = "townshipid";
            this.colTownshipid.HeaderText = "Townshipid";
            this.colTownshipid.Name = "colTownshipid";
            this.colTownshipid.ReadOnly = true;
            this.colTownshipid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္။";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 75;
            // 
            // colTownship
            // 
            this.colTownship.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTownship.DataPropertyName = "township";
            this.colTownship.HeaderText = "ျမိဳ႕နယ္";
            this.colTownship.Name = "colTownship";
            this.colTownship.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colState.DataPropertyName = "state";
            this.colState.HeaderText = "ျပည္နယ္/ တိုင္း";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // colDesp
            // 
            this.colDesp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDesp.DataPropertyName = "desp";
            this.colDesp.HeaderText = "အေၾကာင္းအရာ";
            this.colDesp.Name = "colDesp";
            this.colDesp.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "ျပင္ဆင္ရန္";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "ျပင္ဆင္ရန္";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.cboState);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDesp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTownship);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 335);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(192, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 26);
            this.label5.TabIndex = 95;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(140, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 26);
            this.label3.TabIndex = 94;
            this.label3.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label19.Location = new System.Drawing.Point(172, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 26);
            this.label19.TabIndex = 93;
            this.label19.Text = " - လိုအပ္သည္";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(157, 257);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 26);
            this.label20.TabIndex = 92;
            this.label20.Text = "*";
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(296, 44);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(300, 34);
            this.cboState.TabIndex = 0;
            this.cboState.DropDownClosed += new System.EventHandler(this.cboState_DropDownClosed);
            this.cboState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboState_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnCancel.Location = new System.Drawing.Point(452, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ထြက္ရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.Location = new System.Drawing.Point(167, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ျပည္နယ္/ တိုင္း";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnSave.Location = new System.Drawing.Point(296, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ထည့္သြင္းရန္";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.Location = new System.Drawing.Point(219, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "ျမိဳ႕နယ္";
            // 
            // txtDesp
            // 
            this.txtDesp.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtDesp.Location = new System.Drawing.Point(296, 144);
            this.txtDesp.Multiline = true;
            this.txtDesp.Name = "txtDesp";
            this.txtDesp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDesp.Size = new System.Drawing.Size(300, 100);
            this.txtDesp.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.Location = new System.Drawing.Point(164, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "အေၾကာင္းအရာ";
            // 
            // txtTownship
            // 
            this.txtTownship.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtTownship.Location = new System.Drawing.Point(295, 94);
            this.txtTownship.Name = "txtTownship";
            this.txtTownship.Size = new System.Drawing.Size(300, 34);
            this.txtTownship.TabIndex = 1;
            this.txtTownship.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTownship_KeyDown);
            this.txtTownship.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTownship_KeyUp);
            // 
            // FrmTownship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTownship";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ျမိဳ႕နယ္";
            this.Load += new System.EventHandler(this.FrmTownship_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTownship_KeyDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTownship)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTownship;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTownship;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTownshipid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTownship;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesp;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}
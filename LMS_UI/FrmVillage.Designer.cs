namespace LMS_UI
{
    partial class FrmVillage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVillage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVillage = new System.Windows.Forms.DataGridView();
            this.colStateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTownshipid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvillageid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVillage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTownship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtVillage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTownship = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnNew2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVillage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvVillage);
            this.panel2.Location = new System.Drawing.Point(12, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 298);
            this.panel2.TabIndex = 15;
            // 
            // dgvVillage
            // 
            this.dgvVillage.AllowUserToAddRows = false;
            this.dgvVillage.AllowUserToDeleteRows = false;
            this.dgvVillage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVillage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVillage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVillage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStateid,
            this.colTownshipid,
            this.colvillageid,
            this.colNo,
            this.colVillage,
            this.colTownship,
            this.colState,
            this.colDesp,
            this.colEdit});
            this.dgvVillage.Location = new System.Drawing.Point(0, 0);
            this.dgvVillage.Name = "dgvVillage";
            this.dgvVillage.ReadOnly = true;
            this.dgvVillage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvVillage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVillage.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVillage.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVillage.RowTemplate.Height = 30;
            this.dgvVillage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVillage.Size = new System.Drawing.Size(760, 298);
            this.dgvVillage.TabIndex = 0;
            this.dgvVillage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVillage_CellContentClick);
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
            // colvillageid
            // 
            this.colvillageid.DataPropertyName = "villageid";
            this.colvillageid.HeaderText = "Villageid";
            this.colvillageid.Name = "colvillageid";
            this.colvillageid.ReadOnly = true;
            this.colvillageid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္။";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            // 
            // colVillage
            // 
            this.colVillage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVillage.DataPropertyName = "village";
            this.colVillage.HeaderText = "ေက်းရြာ/ ရပ္ကြက္";
            this.colVillage.Name = "colVillage";
            this.colVillage.ReadOnly = true;
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
            // txtVillage
            // 
            this.txtVillage.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtVillage.Location = new System.Drawing.Point(235, 115);
            this.txtVillage.Name = "txtVillage";
            this.txtVillage.Size = new System.Drawing.Size(300, 34);
            this.txtVillage.TabIndex = 2;
            this.txtVillage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVillage_KeyDown);
            this.txtVillage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVillage_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.Location = new System.Drawing.Point(101, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "အေၾကာင္းအရာ";
            // 
            // txtDesp
            // 
            this.txtDesp.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtDesp.Location = new System.Drawing.Point(236, 157);
            this.txtDesp.Multiline = true;
            this.txtDesp.Name = "txtDesp";
            this.txtDesp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDesp.Size = new System.Drawing.Size(300, 100);
            this.txtDesp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.Location = new System.Drawing.Point(86, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "ေက်းရြာ/ ရပ္ကြက္";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnSave.Location = new System.Drawing.Point(236, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ထည့္သြင္းရန္";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.Location = new System.Drawing.Point(104, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ျပည္နယ္/ တိုင္း";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnCancel.Location = new System.Drawing.Point(392, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "ထြက္ရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboState.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(236, 31);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(300, 34);
            this.cboState.TabIndex = 0;
            this.cboState.DropDownClosed += new System.EventHandler(this.cboState_DropDownClosed);
            this.cboState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboState_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label3.Location = new System.Drawing.Point(156, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "ျမိဳ႕နယ္";
            // 
            // cboTownship
            // 
            this.cboTownship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTownship.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboTownship.FormattingEnabled = true;
            this.cboTownship.Location = new System.Drawing.Point(235, 73);
            this.cboTownship.Name = "cboTownship";
            this.cboTownship.Size = new System.Drawing.Size(300, 34);
            this.cboTownship.TabIndex = 1;
            this.cboTownship.DropDownClosed += new System.EventHandler(this.cboTownship_DropDownClosed);
            this.cboTownship.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTownship_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btnNew2);
            this.panel1.Controls.Add(this.cboTownship);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboState);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDesp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtVillage);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 335);
            this.panel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(59, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 26);
            this.label7.TabIndex = 98;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(129, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 26);
            this.label6.TabIndex = 97;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(77, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 26);
            this.label5.TabIndex = 96;
            this.label5.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label19.Location = new System.Drawing.Point(109, 270);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 26);
            this.label19.TabIndex = 95;
            this.label19.Text = " - လိုအပ္သည္";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(94, 270);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 26);
            this.label20.TabIndex = 94;
            this.label20.Text = "*";
            // 
            // btnNew2
            // 
            this.btnNew2.FlatAppearance.BorderSize = 0;
            this.btnNew2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew2.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnNew2.Image = global::LMS_UI.Properties.Resources.new_image;
            this.btnNew2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew2.Location = new System.Drawing.Point(541, 73);
            this.btnNew2.Name = "btnNew2";
            this.btnNew2.Size = new System.Drawing.Size(134, 34);
            this.btnNew2.TabIndex = 40;
            this.btnNew2.Text = "အသစ္ထည့္ရန္";
            this.btnNew2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew2.UseVisualStyleBackColor = true;
            this.btnNew2.Click += new System.EventHandler(this.btnNew2_Click);
            // 
            // FrmVillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVillage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ေက်းရြာ/ ရပ္ကြက္";
            this.Load += new System.EventHandler(this.FrmVillage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmVillage_KeyDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVillage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvVillage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTownshipid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvillageid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVillage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTownship;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesp;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.TextBox txtVillage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTownship;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}
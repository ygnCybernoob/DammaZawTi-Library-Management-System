namespace LMS_UI
{
    partial class FrmLostOrDamage
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoto = new System.Windows.Forms.Label();
            this.dgvLostOrDamage = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBooktitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLostOrDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.lblMoto);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 50);
            this.pnlHeader.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "ပ်က္စီး/ ေပ်ာက္ဆုံးစာအုပ္မ်ားစာရင္း";
            // 
            // lblMoto
            // 
            this.lblMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoto.AutoSize = true;
            this.lblMoto.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblMoto.ForeColor = System.Drawing.Color.White;
            this.lblMoto.Location = new System.Drawing.Point(797, 12);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(175, 26);
            this.lblMoto.TabIndex = 18;
            this.lblMoto.Text = "စာအုပ္စာေပ လူ႕မိတ္ေဆြ";
            // 
            // dgvLostOrDamage
            // 
            this.dgvLostOrDamage.AllowUserToAddRows = false;
            this.dgvLostOrDamage.AllowUserToDeleteRows = false;
            this.dgvLostOrDamage.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLostOrDamage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLostOrDamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLostOrDamage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colBookid,
            this.colBooktitle,
            this.colBookbarcode,
            this.colQty});
            this.dgvLostOrDamage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLostOrDamage.Location = new System.Drawing.Point(0, 50);
            this.dgvLostOrDamage.Name = "dgvLostOrDamage";
            this.dgvLostOrDamage.ReadOnly = true;
            this.dgvLostOrDamage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLostOrDamage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLostOrDamage.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLostOrDamage.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLostOrDamage.RowTemplate.Height = 30;
            this.dgvLostOrDamage.Size = new System.Drawing.Size(984, 513);
            this.dgvLostOrDamage.TabIndex = 80;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 60;
            // 
            // colBookid
            // 
            this.colBookid.DataPropertyName = "bookid";
            this.colBookid.HeaderText = "Bookid";
            this.colBookid.Name = "colBookid";
            this.colBookid.ReadOnly = true;
            this.colBookid.Visible = false;
            // 
            // colBooktitle
            // 
            this.colBooktitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBooktitle.DataPropertyName = "booktitle";
            this.colBooktitle.HeaderText = "စာအုပ္အမည္";
            this.colBooktitle.Name = "colBooktitle";
            this.colBooktitle.ReadOnly = true;
            // 
            // colBookbarcode
            // 
            this.colBookbarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBookbarcode.DataPropertyName = "bookbarcode";
            this.colBookbarcode.HeaderText = "စာအုပ္ဘားကုဒ္";
            this.colBookbarcode.Name = "colBookbarcode";
            this.colBookbarcode.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQty.DataPropertyName = "qtyofbook";
            this.colQty.HeaderText = "အေရအတြက္";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // FrmLostOrDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 563);
            this.Controls.Add(this.dgvLostOrDamage);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmLostOrDamage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ပ်က္စီး/ ေပ်ာက္ဆုံးစာအုပ္မ်ား";
            this.Load += new System.EventHandler(this.FrmLostOrDamage_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLostOrDamage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.DataGridView dgvLostOrDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooktitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.Label label1;
    }
}
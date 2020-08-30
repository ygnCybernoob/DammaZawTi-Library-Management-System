namespace LMS_UI
{
    partial class FrmBookReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMoto = new System.Windows.Forms.Label();
            this.lblTotalBook = new System.Windows.Forms.Label();
            this.gboxCategory = new System.Windows.Forms.GroupBox();
            this.dgvBookCategory = new System.Windows.Forms.DataGridView();
            this.colBookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxAuthor = new System.Windows.Forms.GroupBox();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLost = new System.Windows.Forms.Label();
            this.lblRenting = new System.Windows.Forms.Label();
            this.lblRemain = new System.Windows.Forms.Label();
            this.lblAdult = new System.Windows.Forms.Label();
            this.lblChild = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.gboxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCategory)).BeginInit();
            this.gboxAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.lblMoto);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 50);
            this.pnlHeader.TabIndex = 77;
            // 
            // lblMoto
            // 
            this.lblMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoto.AutoSize = true;
            this.lblMoto.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblMoto.ForeColor = System.Drawing.Color.White;
            this.lblMoto.Location = new System.Drawing.Point(1038, 12);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(136, 26);
            this.lblMoto.TabIndex = 18;
            this.lblMoto.Text = "စာေပဖတ္မွ ဘ၀လွ";
            // 
            // lblTotalBook
            // 
            this.lblTotalBook.AutoSize = true;
            this.lblTotalBook.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblTotalBook.Location = new System.Drawing.Point(300, 63);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(128, 26);
            this.lblTotalBook.TabIndex = 96;
            this.lblTotalBook.Text = "စာအုပ္ စုစုေပါင္း -";
            // 
            // gboxCategory
            // 
            this.gboxCategory.Controls.Add(this.dgvBookCategory);
            this.gboxCategory.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.gboxCategory.Location = new System.Drawing.Point(604, 261);
            this.gboxCategory.Name = "gboxCategory";
            this.gboxCategory.Size = new System.Drawing.Size(350, 370);
            this.gboxCategory.TabIndex = 95;
            this.gboxCategory.TabStop = false;
            this.gboxCategory.Text = "စာအုပ္အမ်ိဳးအစား";
            // 
            // dgvBookCategory
            // 
            this.dgvBookCategory.AllowUserToAddRows = false;
            this.dgvBookCategory.AllowUserToDeleteRows = false;
            this.dgvBookCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookCategory,
            this.dataGridViewTextBoxColumn2});
            this.dgvBookCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookCategory.Location = new System.Drawing.Point(3, 25);
            this.dgvBookCategory.Name = "dgvBookCategory";
            this.dgvBookCategory.ReadOnly = true;
            this.dgvBookCategory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBookCategory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBookCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBookCategory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBookCategory.RowTemplate.Height = 30;
            this.dgvBookCategory.Size = new System.Drawing.Size(344, 342);
            this.dgvBookCategory.TabIndex = 1;
            // 
            // colBookCategory
            // 
            this.colBookCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBookCategory.DataPropertyName = "category";
            this.colBookCategory.HeaderText = "စာအုပ္အမ်ိဳးအစား";
            this.colBookCategory.Name = "colBookCategory";
            this.colBookCategory.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Qtyofbook";
            this.dataGridViewTextBoxColumn2.HeaderText = "အုပ္ေရ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // gboxAuthor
            // 
            this.gboxAuthor.Controls.Add(this.dgvAuthor);
            this.gboxAuthor.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.gboxAuthor.Location = new System.Drawing.Point(230, 261);
            this.gboxAuthor.Name = "gboxAuthor";
            this.gboxAuthor.Size = new System.Drawing.Size(350, 370);
            this.gboxAuthor.TabIndex = 96;
            this.gboxAuthor.TabStop = false;
            this.gboxAuthor.Text = "စာေရးဆရာ";
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.AllowUserToAddRows = false;
            this.dgvAuthor.AllowUserToDeleteRows = false;
            this.dgvAuthor.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuthor,
            this.dataGridViewTextBoxColumn3});
            this.dgvAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuthor.Location = new System.Drawing.Point(3, 25);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.ReadOnly = true;
            this.dgvAuthor.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAuthor.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAuthor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAuthor.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAuthor.RowTemplate.Height = 30;
            this.dgvAuthor.Size = new System.Drawing.Size(344, 342);
            this.dgvAuthor.TabIndex = 1;
            // 
            // colAuthor
            // 
            this.colAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAuthor.DataPropertyName = "author1";
            this.colAuthor.HeaderText = "စာေရးဆရာ";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qtyofbook";
            this.dataGridViewTextBoxColumn3.HeaderText = "အုပ္ေရ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblLost.Location = new System.Drawing.Point(283, 97);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(145, 26);
            this.lblLost.TabIndex = 97;
            this.lblLost.Text = "ေပ်ာက္ဆုံး/ ပ်က္စီး -";
            // 
            // lblRenting
            // 
            this.lblRenting.AutoSize = true;
            this.lblRenting.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblRenting.Location = new System.Drawing.Point(281, 131);
            this.lblRenting.Name = "lblRenting";
            this.lblRenting.Size = new System.Drawing.Size(147, 26);
            this.lblRenting.TabIndex = 98;
            this.lblRenting.Text = "လက္ရွိ ငွားရမ္းထား -";
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblRemain.Location = new System.Drawing.Point(317, 165);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(111, 26);
            this.lblRemain.TabIndex = 97;
            this.lblRemain.Text = "က်န္ရွိ စာအုပ္ -";
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblAdult.Location = new System.Drawing.Point(327, 199);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(101, 26);
            this.lblAdult.TabIndex = 99;
            this.lblAdult.Text = "လူၾကီးစာေပ -";
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblChild.Location = new System.Drawing.Point(319, 233);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(109, 26);
            this.lblChild.TabIndex = 100;
            this.lblChild.Text = "ကေလးစာေပ -";
            // 
            // FrmBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.lblChild);
            this.Controls.Add(this.lblAdult);
            this.Controls.Add(this.lblRemain);
            this.Controls.Add(this.lblRenting);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.gboxAuthor);
            this.Controls.Add(this.lblTotalBook);
            this.Controls.Add(this.gboxCategory);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmBookReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "စာအုပ္အစီရင္ခံစာ ";
            this.Load += new System.EventHandler(this.FrmBookReport_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gboxCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCategory)).EndInit();
            this.gboxAuthor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.Label lblTotalBook;
        private System.Windows.Forms.GroupBox gboxCategory;
        private System.Windows.Forms.DataGridView dgvBookCategory;
        private System.Windows.Forms.GroupBox gboxAuthor;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.Label lblRenting;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
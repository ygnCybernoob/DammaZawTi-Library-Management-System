namespace LMS_UI
{
    partial class FrmTopRent
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
            this.dgvTopRentList = new System.Windows.Forms.DataGridView();
            this.colcategoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbooktitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpublishdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladultchild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopRentList)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTopRentList
            // 
            this.dgvTopRentList.AllowUserToAddRows = false;
            this.dgvTopRentList.AllowUserToDeleteRows = false;
            this.dgvTopRentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTopRentList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopRentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTopRentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopRentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcategoryid,
            this.colbookid,
            this.colNo,
            this.colbookbarcode,
            this.colbooktitle,
            this.colAuthor,
            this.colcategory,
            this.colpublisher,
            this.colpublishdate,
            this.coladultchild});
            this.dgvTopRentList.Location = new System.Drawing.Point(0, 50);
            this.dgvTopRentList.Name = "dgvTopRentList";
            this.dgvTopRentList.ReadOnly = true;
            this.dgvTopRentList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTopRentList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTopRentList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTopRentList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTopRentList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTopRentList.RowTemplate.Height = 50;
            this.dgvTopRentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTopRentList.Size = new System.Drawing.Size(984, 563);
            this.dgvTopRentList.TabIndex = 75;
            // 
            // colcategoryid
            // 
            this.colcategoryid.DataPropertyName = "categoryid";
            this.colcategoryid.HeaderText = "Categoryid";
            this.colcategoryid.Name = "colcategoryid";
            this.colcategoryid.ReadOnly = true;
            this.colcategoryid.Visible = false;
            // 
            // colbookid
            // 
            this.colbookid.DataPropertyName = "bookid";
            this.colbookid.HeaderText = "Bookid";
            this.colbookid.Name = "colbookid";
            this.colbookid.ReadOnly = true;
            this.colbookid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္။";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 60;
            // 
            // colbookbarcode
            // 
            this.colbookbarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colbookbarcode.DataPropertyName = "bookbarcode";
            this.colbookbarcode.HeaderText = "ဘားကုဒ္";
            this.colbookbarcode.Name = "colbookbarcode";
            this.colbookbarcode.ReadOnly = true;
            // 
            // colbooktitle
            // 
            this.colbooktitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colbooktitle.DataPropertyName = "booktitle";
            this.colbooktitle.HeaderText = "စာအုပ္အမည္";
            this.colbooktitle.Name = "colbooktitle";
            this.colbooktitle.ReadOnly = true;
            // 
            // colAuthor
            // 
            this.colAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAuthor.DataPropertyName = "author1";
            this.colAuthor.HeaderText = "စာေရးဆရာ";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            // 
            // colcategory
            // 
            this.colcategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colcategory.DataPropertyName = "category";
            this.colcategory.HeaderText = "စာအုပ္အမ်ိဳးအစား";
            this.colcategory.Name = "colcategory";
            this.colcategory.ReadOnly = true;
            // 
            // colpublisher
            // 
            this.colpublisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colpublisher.DataPropertyName = "publisher";
            this.colpublisher.HeaderText = "စာအုပ္တုိက္";
            this.colpublisher.Name = "colpublisher";
            this.colpublisher.ReadOnly = true;
            // 
            // colpublishdate
            // 
            this.colpublishdate.DataPropertyName = "publishdate";
            this.colpublishdate.HeaderText = "ထုတ္ေ၀သည့္ရက္စြဲ";
            this.colpublishdate.Name = "colpublishdate";
            this.colpublishdate.ReadOnly = true;
            this.colpublishdate.Width = 150;
            // 
            // coladultchild
            // 
            this.coladultchild.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coladultchild.DataPropertyName = "adultchild";
            this.coladultchild.HeaderText = "အမ်ိုးအစား";
            this.coladultchild.Name = "coladultchild";
            this.coladultchild.ReadOnly = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.lblMoto);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 50);
            this.pnlHeader.TabIndex = 77;
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
            // FrmTopRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 613);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvTopRentList);
            this.Name = "FrmTopRent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "အငွားရဆုံးစာအုပ္မ်ား";
            this.Load += new System.EventHandler(this.FrmTopRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopRentList)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTopRentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcategoryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbooktitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpublishdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn coladultchild;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMoto;
    }
}
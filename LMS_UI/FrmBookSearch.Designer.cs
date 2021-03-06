namespace LMS_UI
{
    partial class FrmBookSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookSearch));
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBookCategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTypebyAge = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.colDateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcategoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbooktitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpublishdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdultChild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMoto = new System.Windows.Forms.Label();
            this.btnTopBook = new System.Windows.Forms.Button();
            this.btnNewArrival = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chbMale = new System.Windows.Forms.CheckBox();
            this.chbFemale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnCancel.Location = new System.Drawing.Point(394, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "ထြက္ရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBookTitle.Location = new System.Drawing.Point(237, 126);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(300, 34);
            this.txtBookTitle.TabIndex = 1;
            this.txtBookTitle.TextChanged += new System.EventHandler(this.txtBookTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.Location = new System.Drawing.Point(121, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "စာအုပ္အမည္";
            // 
            // cboBookCategory
            // 
            this.cboBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookCategory.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboBookCategory.FormattingEnabled = true;
            this.cboBookCategory.Location = new System.Drawing.Point(237, 208);
            this.cboBookCategory.Name = "cboBookCategory";
            this.cboBookCategory.Size = new System.Drawing.Size(300, 34);
            this.cboBookCategory.TabIndex = 4;
            this.cboBookCategory.DropDownClosed += new System.EventHandler(this.cboBookCategory_DropDownClosed);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label11.Location = new System.Drawing.Point(92, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 26);
            this.label11.TabIndex = 48;
            this.label11.Text = "စာအုပ္အမ်ိဳးအစား";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBarcode.Location = new System.Drawing.Point(237, 84);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(300, 34);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.Location = new System.Drawing.Point(153, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "ဘားကုဒ္";
            // 
            // cboAuthor
            // 
            this.cboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboAuthor.FormattingEnabled = true;
            this.cboAuthor.Location = new System.Drawing.Point(237, 166);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(300, 34);
            this.cboAuthor.TabIndex = 3;
            this.cboAuthor.SelectedIndexChanged += new System.EventHandler(this.cboAuthor_SelectedIndexChanged);
            this.cboAuthor.DropDownClosed += new System.EventHandler(this.cboAuthor_DropDownClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label3.Location = new System.Drawing.Point(131, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 52;
            this.label3.Text = "စာေရးဆရာ";
            // 
            // cboTypebyAge
            // 
            this.cboTypebyAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypebyAge.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboTypebyAge.FormattingEnabled = true;
            this.cboTypebyAge.Items.AddRange(new object[] {
            "လူၾကီးစာေပ",
            "ကေလးစာေပ"});
            this.cboTypebyAge.Location = new System.Drawing.Point(237, 250);
            this.cboTypebyAge.Name = "cboTypebyAge";
            this.cboTypebyAge.Size = new System.Drawing.Size(300, 34);
            this.cboTypebyAge.TabIndex = 5;
            this.cboTypebyAge.DropDownClosed += new System.EventHandler(this.cboTypebyAge_DropDownClosed);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label15.Location = new System.Drawing.Point(31, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 26);
            this.label15.TabIndex = 72;
            this.label15.Text = "အမ်ိဳးအစား(အသက္အရြယ္)";
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateAdded,
            this.colcategoryid,
            this.colbookid,
            this.colNo,
            this.colbookbarcode,
            this.colbooktitle,
            this.colAuthor,
            this.colcategory,
            this.colpublishdate,
            this.colAdultChild,
            this.colDesp,
            this.colView});
            this.dgvBookList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBookList.Location = new System.Drawing.Point(0, 361);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBookList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBookList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBookList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBookList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBookList.RowTemplate.Height = 75;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBookList.Size = new System.Drawing.Size(1184, 300);
            this.dgvBookList.TabIndex = 74;
            this.dgvBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellContentClick);
            // 
            // colDateAdded
            // 
            this.colDateAdded.DataPropertyName = "dateadded";
            this.colDateAdded.HeaderText = "ထည့္သြင္းသည့္ရက္စြဲ";
            this.colDateAdded.Name = "colDateAdded";
            this.colDateAdded.ReadOnly = true;
            this.colDateAdded.Visible = false;
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
            // colpublishdate
            // 
            this.colpublishdate.DataPropertyName = "publishdate";
            this.colpublishdate.HeaderText = "ထုတ္ေ၀သည့္ရက္စြဲ";
            this.colpublishdate.Name = "colpublishdate";
            this.colpublishdate.ReadOnly = true;
            this.colpublishdate.Width = 150;
            // 
            // colAdultChild
            // 
            this.colAdultChild.DataPropertyName = "adultchild";
            this.colAdultChild.HeaderText = "အမ်ိဳးအစား";
            this.colAdultChild.Name = "colAdultChild";
            this.colAdultChild.ReadOnly = true;
            // 
            // colDesp
            // 
            this.colDesp.DataPropertyName = "desp";
            this.colDesp.HeaderText = "အေၾကာင္းအရာ";
            this.colDesp.Name = "colDesp";
            this.colDesp.ReadOnly = true;
            this.colDesp.Visible = false;
            // 
            // colView
            // 
            this.colView.HeaderText = "ၾကည့္ရႈရန္";
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colView.Text = "ၾကည့္ရႈရန္";
            this.colView.UseColumnTextForButtonValue = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.lblMoto);
            this.pnlHeader.Controls.Add(this.btnTopBook);
            this.pnlHeader.Controls.Add(this.btnNewArrival);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 50);
            this.pnlHeader.TabIndex = 75;
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
            // btnTopBook
            // 
            this.btnTopBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopBook.FlatAppearance.BorderSize = 0;
            this.btnTopBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopBook.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnTopBook.ForeColor = System.Drawing.Color.White;
            this.btnTopBook.Location = new System.Drawing.Point(222, 0);
            this.btnTopBook.Name = "btnTopBook";
            this.btnTopBook.Size = new System.Drawing.Size(200, 50);
            this.btnTopBook.TabIndex = 1;
            this.btnTopBook.Text = "အငွားရဆုံး စာအုပ္မ်ား";
            this.btnTopBook.UseVisualStyleBackColor = false;
            this.btnTopBook.Click += new System.EventHandler(this.btnTopBook_Click);
            // 
            // btnNewArrival
            // 
            this.btnNewArrival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewArrival.FlatAppearance.BorderSize = 0;
            this.btnNewArrival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewArrival.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnNewArrival.ForeColor = System.Drawing.Color.White;
            this.btnNewArrival.Location = new System.Drawing.Point(4, 0);
            this.btnNewArrival.Name = "btnNewArrival";
            this.btnNewArrival.Size = new System.Drawing.Size(218, 50);
            this.btnNewArrival.TabIndex = 0;
            this.btnNewArrival.Text = "အသစ္ေရာက္ရွိေသာ စာအုပ္မ်ား";
            this.btnNewArrival.UseVisualStyleBackColor = false;
            this.btnNewArrival.Click += new System.EventHandler(this.btnNewArrival_Click);
            // 
            // picImage
            // 
            this.picImage.Image = global::LMS_UI.Properties.Resources.search_image_2;
            this.picImage.Location = new System.Drawing.Point(847, 97);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(200, 200);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 76;
            this.picImage.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnClear.Location = new System.Drawing.Point(237, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 40);
            this.btnClear.TabIndex = 77;
            this.btnClear.Text = "ရွင္းလင္းရန္";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chbMale
            // 
            this.chbMale.AutoSize = true;
            this.chbMale.Checked = true;
            this.chbMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMale.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.chbMale.Location = new System.Drawing.Point(543, 168);
            this.chbMale.Name = "chbMale";
            this.chbMale.Size = new System.Drawing.Size(94, 30);
            this.chbMale.TabIndex = 78;
            this.chbMale.Text = "အမ်ိဳးသား";
            this.chbMale.UseVisualStyleBackColor = true;
            this.chbMale.CheckedChanged += new System.EventHandler(this.chbMale_CheckedChanged);
            // 
            // chbFemale
            // 
            this.chbFemale.AutoSize = true;
            this.chbFemale.Checked = true;
            this.chbFemale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFemale.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.chbFemale.Location = new System.Drawing.Point(643, 168);
            this.chbFemale.Name = "chbFemale";
            this.chbFemale.Size = new System.Drawing.Size(96, 30);
            this.chbFemale.TabIndex = 79;
            this.chbFemale.Text = "အမ်ိဳးသမီး";
            this.chbFemale.UseVisualStyleBackColor = true;
            this.chbFemale.CheckedChanged += new System.EventHandler(this.chbFemale_CheckedChanged);
            // 
            // FrmBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.chbFemale);
            this.Controls.Add(this.chbMale);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboTypebyAge);
            this.Controls.Add(this.cboAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboBookCategory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBookSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "စာအုပ္မ်ား ရွာေဇြရန္";
            this.Load += new System.EventHandler(this.FrmBookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBookCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTypebyAge;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnNewArrival;
        private System.Windows.Forms.Button btnTopBook;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcategoryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbooktitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpublishdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdultChild;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesp;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chbMale;
        private System.Windows.Forms.CheckBox chbFemale;
    }
}
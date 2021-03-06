namespace LMS_UI
{
    partial class FrmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBook));
            this.tabctrlBook = new System.Windows.Forms.TabControl();
            this.tpgBookAdd = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblRequire = new System.Windows.Forms.Label();
            this.btnNewBookCate = new System.Windows.Forms.Button();
            this.btnNew2 = new System.Windows.Forms.Button();
            this.chbAuthor2 = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbtChild = new System.Windows.Forms.RadioButton();
            this.rbtAdult = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDesp = new System.Windows.Forms.TextBox();
            this.dtpkPublishDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cboAuthor2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboAuthor1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBookCategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBooktitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.tpgBookList = new System.Windows.Forms.TabPage();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.cboBookCategory2 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtBookbarcode2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBookTitle2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.colcategoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor1id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor2Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookcover = new System.Windows.Forms.DataGridViewImageColumn();
            this.colbooktitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookcopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpublishdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldateadded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladultchild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabctrlBook.SuspendLayout();
            this.tpgBookAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.tpgBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlBook
            // 
            this.tabctrlBook.Controls.Add(this.tpgBookAdd);
            this.tabctrlBook.Controls.Add(this.tpgBookList);
            this.tabctrlBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlBook.Location = new System.Drawing.Point(0, 0);
            this.tabctrlBook.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabctrlBook.Name = "tabctrlBook";
            this.tabctrlBook.SelectedIndex = 0;
            this.tabctrlBook.Size = new System.Drawing.Size(1184, 713);
            this.tabctrlBook.TabIndex = 0;
            // 
            // tpgBookAdd
            // 
            this.tpgBookAdd.AutoScroll = true;
            this.tpgBookAdd.Controls.Add(this.label25);
            this.tpgBookAdd.Controls.Add(this.label22);
            this.tpgBookAdd.Controls.Add(this.label23);
            this.tpgBookAdd.Controls.Add(this.label21);
            this.tpgBookAdd.Controls.Add(this.label20);
            this.tpgBookAdd.Controls.Add(this.label19);
            this.tpgBookAdd.Controls.Add(this.label18);
            this.tpgBookAdd.Controls.Add(this.lblRequire);
            this.tpgBookAdd.Controls.Add(this.btnNewBookCate);
            this.tpgBookAdd.Controls.Add(this.btnNew2);
            this.tpgBookAdd.Controls.Add(this.chbAuthor2);
            this.tpgBookAdd.Controls.Add(this.btnCancel);
            this.tpgBookAdd.Controls.Add(this.btnSave);
            this.tpgBookAdd.Controls.Add(this.rbtChild);
            this.tpgBookAdd.Controls.Add(this.rbtAdult);
            this.tpgBookAdd.Controls.Add(this.label15);
            this.tpgBookAdd.Controls.Add(this.label14);
            this.tpgBookAdd.Controls.Add(this.txtDesp);
            this.tpgBookAdd.Controls.Add(this.dtpkPublishDate);
            this.tpgBookAdd.Controls.Add(this.label13);
            this.tpgBookAdd.Controls.Add(this.txtPublisher);
            this.tpgBookAdd.Controls.Add(this.label12);
            this.tpgBookAdd.Controls.Add(this.txtPrice);
            this.tpgBookAdd.Controls.Add(this.label10);
            this.tpgBookAdd.Controls.Add(this.label9);
            this.tpgBookAdd.Controls.Add(this.numQty);
            this.tpgBookAdd.Controls.Add(this.cboAuthor2);
            this.tpgBookAdd.Controls.Add(this.label8);
            this.tpgBookAdd.Controls.Add(this.cboAuthor1);
            this.tpgBookAdd.Controls.Add(this.label1);
            this.tpgBookAdd.Controls.Add(this.cboBookCategory);
            this.tpgBookAdd.Controls.Add(this.label11);
            this.tpgBookAdd.Controls.Add(this.txtBooktitle);
            this.tpgBookAdd.Controls.Add(this.label2);
            this.tpgBookAdd.Controls.Add(this.txtBarcode);
            this.tpgBookAdd.Controls.Add(this.label4);
            this.tpgBookAdd.Controls.Add(this.btnClear);
            this.tpgBookAdd.Controls.Add(this.picImage);
            this.tpgBookAdd.Controls.Add(this.btnChooseImage);
            this.tpgBookAdd.Location = new System.Drawing.Point(4, 30);
            this.tpgBookAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpgBookAdd.Name = "tpgBookAdd";
            this.tpgBookAdd.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpgBookAdd.Size = new System.Drawing.Size(1176, 679);
            this.tpgBookAdd.TabIndex = 0;
            this.tpgBookAdd.Text = "စာအုပ္စာရင္း ထည့္သြင္းရန္";
            this.tpgBookAdd.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(349, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 26);
            this.label25.TabIndex = 70;
            this.label25.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label22.Location = new System.Drawing.Point(334, 551);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 26);
            this.label22.TabIndex = 69;
            this.label22.Text = " - လိုအပ္သည္";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(319, 551);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 26);
            this.label23.TabIndex = 68;
            this.label23.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(229, 408);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 26);
            this.label21.TabIndex = 67;
            this.label21.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(314, 240);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 26);
            this.label20.TabIndex = 66;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(301, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 26);
            this.label19.TabIndex = 65;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(313, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 26);
            this.label18.TabIndex = 64;
            this.label18.Text = "*";
            // 
            // lblRequire
            // 
            this.lblRequire.AutoSize = true;
            this.lblRequire.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblRequire.ForeColor = System.Drawing.Color.Red;
            this.lblRequire.Location = new System.Drawing.Point(284, 28);
            this.lblRequire.Name = "lblRequire";
            this.lblRequire.Size = new System.Drawing.Size(21, 26);
            this.lblRequire.TabIndex = 63;
            this.lblRequire.Text = "*";
            // 
            // btnNewBookCate
            // 
            this.btnNewBookCate.FlatAppearance.BorderSize = 0;
            this.btnNewBookCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBookCate.Image = global::LMS_UI.Properties.Resources.new_image;
            this.btnNewBookCate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewBookCate.Location = new System.Drawing.Point(762, 20);
            this.btnNewBookCate.Name = "btnNewBookCate";
            this.btnNewBookCate.Size = new System.Drawing.Size(134, 34);
            this.btnNewBookCate.TabIndex = 16;
            this.btnNewBookCate.Text = "အသစ္ထည့္ရန္";
            this.btnNewBookCate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewBookCate.UseVisualStyleBackColor = true;
            this.btnNewBookCate.Click += new System.EventHandler(this.btnNewBookCate_Click);
            // 
            // btnNew2
            // 
            this.btnNew2.FlatAppearance.BorderSize = 0;
            this.btnNew2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew2.Image = global::LMS_UI.Properties.Resources.new_image;
            this.btnNew2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew2.Location = new System.Drawing.Point(762, 148);
            this.btnNew2.Name = "btnNew2";
            this.btnNew2.Size = new System.Drawing.Size(134, 34);
            this.btnNew2.TabIndex = 17;
            this.btnNew2.Text = "အသစ္ထည့္ရန္";
            this.btnNew2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew2.UseVisualStyleBackColor = true;
            this.btnNew2.Click += new System.EventHandler(this.btnNew2_Click);
            // 
            // chbAuthor2
            // 
            this.chbAuthor2.AutoSize = true;
            this.chbAuthor2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.chbAuthor2.Location = new System.Drawing.Point(762, 194);
            this.chbAuthor2.Name = "chbAuthor2";
            this.chbAuthor2.Size = new System.Drawing.Size(102, 30);
            this.chbAuthor2.TabIndex = 18;
            this.chbAuthor2.Text = "အသုံးျပဳရန္";
            this.chbAuthor2.UseVisualStyleBackColor = true;
            this.chbAuthor2.CheckedChanged += new System.EventHandler(this.chbAuthor2_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnCancel.Location = new System.Drawing.Point(613, 544);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "ထြက္ရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnSave.Location = new System.Drawing.Point(456, 544);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ထည့္သြင္းရန္";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbtChild
            // 
            this.rbtChild.AutoSize = true;
            this.rbtChild.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.rbtChild.Location = new System.Drawing.Point(569, 400);
            this.rbtChild.Name = "rbtChild";
            this.rbtChild.Size = new System.Drawing.Size(116, 30);
            this.rbtChild.TabIndex = 10;
            this.rbtChild.TabStop = true;
            this.rbtChild.Text = "ကေလးစာေပ";
            this.rbtChild.UseVisualStyleBackColor = true;
            this.rbtChild.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtChild_KeyDown);
            // 
            // rbtAdult
            // 
            this.rbtAdult.AutoSize = true;
            this.rbtAdult.Checked = true;
            this.rbtAdult.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.rbtAdult.Location = new System.Drawing.Point(455, 400);
            this.rbtAdult.Name = "rbtAdult";
            this.rbtAdult.Size = new System.Drawing.Size(108, 30);
            this.rbtAdult.TabIndex = 9;
            this.rbtAdult.TabStop = true;
            this.rbtAdult.Text = "လူၾကီးစာေပ";
            this.rbtAdult.UseVisualStyleBackColor = true;
            this.rbtAdult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtAdult_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label15.Location = new System.Drawing.Point(250, 403);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 26);
            this.label15.TabIndex = 62;
            this.label15.Text = "အမ်ိဳးအစား(အသက္အရြယ္)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label14.Location = new System.Drawing.Point(326, 445);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 26);
            this.label14.TabIndex = 61;
            this.label14.Text = "အေၾကာင္းအရာ";
            // 
            // txtDesp
            // 
            this.txtDesp.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtDesp.Location = new System.Drawing.Point(455, 438);
            this.txtDesp.Multiline = true;
            this.txtDesp.Name = "txtDesp";
            this.txtDesp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDesp.Size = new System.Drawing.Size(300, 100);
            this.txtDesp.TabIndex = 11;
            // 
            // dtpkPublishDate
            // 
            this.dtpkPublishDate.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.dtpkPublishDate.Location = new System.Drawing.Point(455, 358);
            this.dtpkPublishDate.Name = "dtpkPublishDate";
            this.dtpkPublishDate.Size = new System.Drawing.Size(300, 34);
            this.dtpkPublishDate.TabIndex = 8;
            this.dtpkPublishDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpkPublishDate_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label13.Location = new System.Drawing.Point(304, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 26);
            this.label13.TabIndex = 58;
            this.label13.Text = "ထုတ္ေ၀သည့္ေန႕စြဲ";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtPublisher.Location = new System.Drawing.Point(455, 316);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(300, 34);
            this.txtPublisher.TabIndex = 7;
            this.txtPublisher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPublisher_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label12.Location = new System.Drawing.Point(349, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 26);
            this.label12.TabIndex = 57;
            this.label12.Text = "စာအုပ္တိုက္";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtPrice.Location = new System.Drawing.Point(455, 274);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 34);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label10.Location = new System.Drawing.Point(386, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 26);
            this.label10.TabIndex = 55;
            this.label10.Text = "တန္ဖိုး";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label9.Location = new System.Drawing.Point(341, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 26);
            this.label9.TabIndex = 53;
            this.label9.Text = "အေရအတြက္";
            // 
            // numQty
            // 
            this.numQty.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.numQty.Location = new System.Drawing.Point(455, 232);
            this.numQty.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(150, 34);
            this.numQty.TabIndex = 5;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numQty_KeyDown);
            // 
            // cboAuthor2
            // 
            this.cboAuthor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor2.Enabled = false;
            this.cboAuthor2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboAuthor2.FormattingEnabled = true;
            this.cboAuthor2.Location = new System.Drawing.Point(455, 190);
            this.cboAuthor2.Name = "cboAuthor2";
            this.cboAuthor2.Size = new System.Drawing.Size(300, 34);
            this.cboAuthor2.TabIndex = 4;
            this.cboAuthor2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboAuthor2_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label8.Location = new System.Drawing.Point(328, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 49;
            this.label8.Text = "စာေရးဆရာ(၂)";
            // 
            // cboAuthor1
            // 
            this.cboAuthor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboAuthor1.FormattingEnabled = true;
            this.cboAuthor1.Location = new System.Drawing.Point(456, 148);
            this.cboAuthor1.Name = "cboAuthor1";
            this.cboAuthor1.Size = new System.Drawing.Size(300, 34);
            this.cboAuthor1.TabIndex = 3;
            this.cboAuthor1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboAuthor1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.Location = new System.Drawing.Point(328, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "စာေရးဆရာ(၁)";
            // 
            // cboBookCategory
            // 
            this.cboBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookCategory.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboBookCategory.FormattingEnabled = true;
            this.cboBookCategory.Location = new System.Drawing.Point(456, 20);
            this.cboBookCategory.Name = "cboBookCategory";
            this.cboBookCategory.Size = new System.Drawing.Size(300, 34);
            this.cboBookCategory.TabIndex = 0;
            this.cboBookCategory.DropDownClosed += new System.EventHandler(this.cboBookCategory_DropDownClosed);
            this.cboBookCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboBookCategory_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label11.Location = new System.Drawing.Point(311, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 26);
            this.label11.TabIndex = 46;
            this.label11.Text = "စာအုပ္အမ်ိဳးအစား";
            // 
            // txtBooktitle
            // 
            this.txtBooktitle.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBooktitle.Location = new System.Drawing.Point(456, 106);
            this.txtBooktitle.Name = "txtBooktitle";
            this.txtBooktitle.Size = new System.Drawing.Size(300, 34);
            this.txtBooktitle.TabIndex = 2;
            this.txtBooktitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBooktitle_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.Location = new System.Drawing.Point(340, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "စာအုပ္အမည္";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBarcode.Location = new System.Drawing.Point(456, 63);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(300, 34);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.Location = new System.Drawing.Point(371, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "ဘားကုဒ္";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnClear.Location = new System.Drawing.Point(8, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "ရွင္းလင္းရန္";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Image = global::LMS_UI.Properties.Resources.book_image;
            this.picImage.Location = new System.Drawing.Point(8, 8);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(150, 150);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 38;
            this.picImage.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnChooseImage.Location = new System.Drawing.Point(8, 164);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(150, 35);
            this.btnChooseImage.TabIndex = 14;
            this.btnChooseImage.Text = "ဓာတ္ပုံေရြးရန္...";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // tpgBookList
            // 
            this.tpgBookList.AutoScroll = true;
            this.tpgBookList.Controls.Add(this.picBox2);
            this.tpgBookList.Controls.Add(this.cboBookCategory2);
            this.tpgBookList.Controls.Add(this.label24);
            this.tpgBookList.Controls.Add(this.btnShow);
            this.tpgBookList.Controls.Add(this.txtBookbarcode2);
            this.tpgBookList.Controls.Add(this.label17);
            this.tpgBookList.Controls.Add(this.txtBookTitle2);
            this.tpgBookList.Controls.Add(this.label16);
            this.tpgBookList.Controls.Add(this.dgvBookList);
            this.tpgBookList.Location = new System.Drawing.Point(4, 30);
            this.tpgBookList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpgBookList.Name = "tpgBookList";
            this.tpgBookList.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpgBookList.Size = new System.Drawing.Size(1176, 679);
            this.tpgBookList.TabIndex = 1;
            this.tpgBookList.Text = "စာအုပ္စာရင္း";
            this.tpgBookList.UseVisualStyleBackColor = true;
            // 
            // picBox2
            // 
            this.picBox2.Image = global::LMS_UI.Properties.Resources.book_image2;
            this.picBox2.Location = new System.Drawing.Point(848, 8);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(150, 150);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 51;
            this.picBox2.TabStop = false;
            // 
            // cboBookCategory2
            // 
            this.cboBookCategory2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookCategory2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboBookCategory2.FormattingEnabled = true;
            this.cboBookCategory2.Location = new System.Drawing.Point(170, 28);
            this.cboBookCategory2.Name = "cboBookCategory2";
            this.cboBookCategory2.Size = new System.Drawing.Size(300, 34);
            this.cboBookCategory2.TabIndex = 49;
            this.cboBookCategory2.DropDownClosed += new System.EventHandler(this.cboBookCategory2_DropDownClosed);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label24.Location = new System.Drawing.Point(25, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(139, 26);
            this.label24.TabIndex = 50;
            this.label24.Text = "စာအုပ္အမ်ိဳးအစား -";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnShow.Location = new System.Drawing.Point(476, 47);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(150, 75);
            this.btnShow.TabIndex = 48;
            this.btnShow.Text = "စာရင္းအားလုံးကို ၾကည့္ရန္";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtBookbarcode2
            // 
            this.txtBookbarcode2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBookbarcode2.Location = new System.Drawing.Point(170, 68);
            this.txtBookbarcode2.Name = "txtBookbarcode2";
            this.txtBookbarcode2.Size = new System.Drawing.Size(300, 34);
            this.txtBookbarcode2.TabIndex = 46;
            this.txtBookbarcode2.TextChanged += new System.EventHandler(this.txtBookbarcode2_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label17.Location = new System.Drawing.Point(86, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 26);
            this.label17.TabIndex = 47;
            this.label17.Text = "ဘားကုဒ္ -";
            // 
            // txtBookTitle2
            // 
            this.txtBookTitle2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBookTitle2.Location = new System.Drawing.Point(170, 108);
            this.txtBookTitle2.Name = "txtBookTitle2";
            this.txtBookTitle2.Size = new System.Drawing.Size(300, 34);
            this.txtBookTitle2.TabIndex = 44;
            this.txtBookTitle2.TextChanged += new System.EventHandler(this.txtBookTitle2_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label16.Location = new System.Drawing.Point(54, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 26);
            this.label16.TabIndex = 45;
            this.label16.Text = "စာအုပ္အမည္ -";
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
            this.colcategoryid,
            this.colAuthor1id,
            this.colAuthor2Id,
            this.colbookid,
            this.colNo,
            this.colbookbarcode,
            this.colbookcover,
            this.colbooktitle,
            this.colAuthor,
            this.colcategory,
            this.colbookcopy,
            this.colprice,
            this.colpublisher,
            this.colpublishdate,
            this.coldateadded,
            this.coladultchild,
            this.colDesp,
            this.colEdit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookList.Location = new System.Drawing.Point(0, 170);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBookList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBookList.RowTemplate.Height = 75;
            this.dgvBookList.Size = new System.Drawing.Size(1173, 506);
            this.dgvBookList.TabIndex = 1;
            this.dgvBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellContentClick);
            this.dgvBookList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellDoubleClick);
            // 
            // colcategoryid
            // 
            this.colcategoryid.DataPropertyName = "categoryid";
            this.colcategoryid.HeaderText = "Categoryid";
            this.colcategoryid.Name = "colcategoryid";
            this.colcategoryid.ReadOnly = true;
            this.colcategoryid.Visible = false;
            // 
            // colAuthor1id
            // 
            this.colAuthor1id.DataPropertyName = "author1id";
            this.colAuthor1id.HeaderText = "Author1id";
            this.colAuthor1id.Name = "colAuthor1id";
            this.colAuthor1id.ReadOnly = true;
            this.colAuthor1id.Visible = false;
            // 
            // colAuthor2Id
            // 
            this.colAuthor2Id.DataPropertyName = "author2id";
            this.colAuthor2Id.HeaderText = "Author2Id";
            this.colAuthor2Id.Name = "colAuthor2Id";
            this.colAuthor2Id.ReadOnly = true;
            this.colAuthor2Id.Visible = false;
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
            this.colbookbarcode.DataPropertyName = "bookbarcode";
            this.colbookbarcode.HeaderText = "ဘားကုဒ္";
            this.colbookbarcode.Name = "colbookbarcode";
            this.colbookbarcode.ReadOnly = true;
            // 
            // colbookcover
            // 
            this.colbookcover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colbookcover.DataPropertyName = "bookcover";
            this.colbookcover.HeaderText = "စာအုပ္ မ်က္ႏွာဖုံး";
            this.colbookcover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colbookcover.Name = "colbookcover";
            this.colbookcover.ReadOnly = true;
            this.colbookcover.Width = 150;
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
            // colbookcopy
            // 
            this.colbookcopy.DataPropertyName = "bookcopy";
            this.colbookcopy.HeaderText = "အေရအတြက္";
            this.colbookcopy.Name = "colbookcopy";
            this.colbookcopy.ReadOnly = true;
            // 
            // colprice
            // 
            this.colprice.DataPropertyName = "price";
            this.colprice.HeaderText = "တန္ဖိုး";
            this.colprice.Name = "colprice";
            this.colprice.ReadOnly = true;
            this.colprice.Visible = false;
            // 
            // colpublisher
            // 
            this.colpublisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colpublisher.DataPropertyName = "publisher";
            this.colpublisher.HeaderText = "စာအုပ္တုိက္";
            this.colpublisher.Name = "colpublisher";
            this.colpublisher.ReadOnly = true;
            this.colpublisher.Visible = false;
            // 
            // colpublishdate
            // 
            this.colpublishdate.DataPropertyName = "publishdate";
            this.colpublishdate.HeaderText = "ထုတ္ေ၀သည့္ရက္စြဲ";
            this.colpublishdate.Name = "colpublishdate";
            this.colpublishdate.ReadOnly = true;
            this.colpublishdate.Width = 150;
            // 
            // coldateadded
            // 
            this.coldateadded.DataPropertyName = "dateadded";
            this.coldateadded.HeaderText = "စာရင္းသြင္းသည့္ရက္စြဲ";
            this.coldateadded.Name = "coldateadded";
            this.coldateadded.ReadOnly = true;
            this.coldateadded.Visible = false;
            // 
            // coladultchild
            // 
            this.coladultchild.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coladultchild.DataPropertyName = "adultchild";
            this.coladultchild.HeaderText = "အမ်ိုးအစား";
            this.coladultchild.Name = "coladultchild";
            this.coladultchild.ReadOnly = true;
            this.coladultchild.Visible = false;
            // 
            // colDesp
            // 
            this.colDesp.DataPropertyName = "desp";
            this.colDesp.HeaderText = "အေၾကာင္းအရာ";
            this.colDesp.Name = "colDesp";
            this.colDesp.ReadOnly = true;
            this.colDesp.Width = 150;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "ျပင္ဆင္ရန္";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "ျပင္ဆင္ရန္";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(390, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 34);
            this.comboBox1.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label3.Location = new System.Drawing.Point(250, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "စာေရးဆရာ(၁)";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(390, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(300, 34);
            this.comboBox2.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label5.Location = new System.Drawing.Point(233, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "စာအုပ္အမ်ိဳးအစား";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label6.Location = new System.Drawing.Point(262, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 26);
            this.label6.TabIndex = 43;
            this.label6.Text = "စာအုပ္အမည္";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label7.Location = new System.Drawing.Point(294, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 26);
            this.label7.TabIndex = 44;
            this.label7.Text = "ဘားကုဒ္";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.button1.Location = new System.Drawing.Point(8, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 40;
            this.button1.Text = "ရွင္းလင္းရန္";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.button2.Location = new System.Drawing.Point(8, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 39;
            this.button2.Text = "ဓာတ္ပုံေရြးရန္...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 713);
            this.Controls.Add(this.tabctrlBook);
            this.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "စာအုပ္မ်ား";
            this.Load += new System.EventHandler(this.FrmBook_Load);
            this.tabctrlBook.ResumeLayout(false);
            this.tpgBookAdd.ResumeLayout(false);
            this.tpgBookAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.tpgBookList.ResumeLayout(false);
            this.tpgBookList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlBook;
        private System.Windows.Forms.TabPage tpgBookAdd;
        private System.Windows.Forms.TabPage tpgBookList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.TextBox txtBooktitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBookCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboAuthor2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboAuthor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookTitle2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookbarcode2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpkPublishDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.RadioButton rbtChild;
        private System.Windows.Forms.RadioButton rbtAdult;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDesp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chbAuthor2;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnNewBookCate;
        private System.Windows.Forms.Button btnNew2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblRequire;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cboBookCategory2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcategoryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor1id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor2Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookbarcode;
        private System.Windows.Forms.DataGridViewImageColumn colbookcover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbooktitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookcopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpublishdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldateadded;
        private System.Windows.Forms.DataGridViewTextBoxColumn coladultchild;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesp;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;

    }
}
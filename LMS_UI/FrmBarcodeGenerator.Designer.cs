namespace LMS_UI
{
    partial class FrmBarcodeGenerator
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.chbMember = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numEnd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboBookCategory = new System.Windows.Forms.ComboBox();
            this.txtCodePreview = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.chbMember);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(484, 50);
            this.pnlHeader.TabIndex = 78;
            // 
            // chbMember
            // 
            this.chbMember.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.chbMember.ForeColor = System.Drawing.Color.White;
            this.chbMember.Location = new System.Drawing.Point(12, 10);
            this.chbMember.Name = "chbMember";
            this.chbMember.Size = new System.Drawing.Size(156, 30);
            this.chbMember.TabIndex = 0;
            this.chbMember.Text = "Member";
            this.chbMember.UseVisualStyleBackColor = true;
            this.chbMember.CheckedChanged += new System.EventHandler(this.chbMember_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label11.Location = new System.Drawing.Point(79, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 26);
            this.label11.TabIndex = 80;
            this.label11.Text = "ကုဒ္နံပါတ္";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label9.Location = new System.Drawing.Point(58, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 26);
            this.label9.TabIndex = 82;
            this.label9.Text = "အေရအတြက္";
            // 
            // numStart
            // 
            this.numStart.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.numStart.Location = new System.Drawing.Point(165, 102);
            this.numStart.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(100, 34);
            this.numStart.TabIndex = 1;
            this.numStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.Location = new System.Drawing.Point(271, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 26);
            this.label1.TabIndex = 83;
            this.label1.Text = "မွ";
            // 
            // numEnd
            // 
            this.numEnd.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.numEnd.Location = new System.Drawing.Point(299, 103);
            this.numEnd.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEnd.Name = "numEnd";
            this.numEnd.Size = new System.Drawing.Size(100, 34);
            this.numEnd.TabIndex = 2;
            this.numEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.Location = new System.Drawing.Point(405, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 26);
            this.label2.TabIndex = 85;
            this.label2.Text = "ထိ";
            // 
            // numWidth
            // 
            this.numWidth.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.numWidth.Location = new System.Drawing.Point(165, 142);
            this.numWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(100, 34);
            this.numWidth.TabIndex = 3;
            this.numWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.Location = new System.Drawing.Point(97, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 90;
            this.label4.Text = "အလ်ား";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label5.Location = new System.Drawing.Point(118, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 26);
            this.label5.TabIndex = 92;
            this.label5.Text = "အနံ";
            // 
            // numHeight
            // 
            this.numHeight.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.numHeight.Location = new System.Drawing.Point(165, 182);
            this.numHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(100, 34);
            this.numHeight.TabIndex = 4;
            this.numHeight.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnCancel.Location = new System.Drawing.Point(321, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "ထြက္ရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnConnect.Location = new System.Drawing.Point(165, 222);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 35);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "ထုတ္ရန္";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboBookCategory
            // 
            this.cboBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookCategory.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboBookCategory.FormattingEnabled = true;
            this.cboBookCategory.Location = new System.Drawing.Point(165, 62);
            this.cboBookCategory.Name = "cboBookCategory";
            this.cboBookCategory.Size = new System.Drawing.Size(200, 34);
            this.cboBookCategory.TabIndex = 0;
            this.cboBookCategory.SelectedIndexChanged += new System.EventHandler(this.cboBookCategory_SelectedIndexChanged);
            // 
            // txtCodePreview
            // 
            this.txtCodePreview.BackColor = System.Drawing.Color.White;
            this.txtCodePreview.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtCodePreview.Location = new System.Drawing.Point(371, 62);
            this.txtCodePreview.Name = "txtCodePreview";
            this.txtCodePreview.ReadOnly = true;
            this.txtCodePreview.Size = new System.Drawing.Size(100, 34);
            this.txtCodePreview.TabIndex = 7;
            // 
            // FrmBarcodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 313);
            this.Controls.Add(this.txtCodePreview);
            this.Controls.Add(this.cboBookCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numStart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pnlHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBarcodeGenerator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Generator";
            this.Load += new System.EventHandler(this.FrmBarcodeGenerator_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chbMember;
        private System.Windows.Forms.ComboBox cboBookCategory;
        private System.Windows.Forms.TextBox txtCodePreview;
    }
}
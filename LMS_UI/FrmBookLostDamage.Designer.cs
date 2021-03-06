namespace LMS_UI
{
    partial class FrmBookLostDamage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookLostDamage));
            this.label9 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.txtBooktitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label9.Location = new System.Drawing.Point(41, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 26);
            this.label9.TabIndex = 55;
            this.label9.Text = "အေရအတြက္";
            // 
            // numQty
            // 
            this.numQty.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.numQty.Location = new System.Drawing.Point(155, 157);
            this.numQty.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(150, 34);
            this.numQty.TabIndex = 2;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBooktitle
            // 
            this.txtBooktitle.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBooktitle.Location = new System.Drawing.Point(155, 117);
            this.txtBooktitle.Name = "txtBooktitle";
            this.txtBooktitle.Size = new System.Drawing.Size(300, 34);
            this.txtBooktitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 58;
            this.label2.Text = "စာအုပ္အမည္";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtBarcode.Location = new System.Drawing.Point(155, 77);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(300, 34);
            this.txtBarcode.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.Location = new System.Drawing.Point(71, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 59;
            this.label4.Text = "ဘားကုဒ္";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnCancel.Location = new System.Drawing.Point(312, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ထြက္ရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnSave.Location = new System.Drawing.Point(155, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ထည့္သြင္းရန္";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(494, 50);
            this.pnlHeader.TabIndex = 77;
            // 
            // FrmBookLostDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 323);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBooktitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBookLostDamage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ပ်က္စီး/ ေပ်ာက္ဆုံး စာအုပ္";
            this.Load += new System.EventHandler(this.FrmBookLostDamage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBookLostDamage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.TextBox txtBooktitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlHeader;
    }
}
namespace LMS_UI
{
    partial class FrmLibraryType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibraryType));
            this.cboLibrarytype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMoto = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboLibrarytype
            // 
            this.cboLibrarytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLibrarytype.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.cboLibrarytype.FormattingEnabled = true;
            this.cboLibrarytype.Items.AddRange(new object[] {
            "ေန႕စဉ္ ငွား စနစ္သုံး စာၾကည့္တိုက္",
            "သတ္မွတ္အေရအတြက္  စနစ္သုံး စာၾကည့္တိုက္"});
            this.cboLibrarytype.Location = new System.Drawing.Point(47, 112);
            this.cboLibrarytype.Name = "cboLibrarytype";
            this.cboLibrarytype.Size = new System.Drawing.Size(400, 34);
            this.cboLibrarytype.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.Location = new System.Drawing.Point(174, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "စာၾကည့္တိုက္အမ်ိဳးအစား";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnCancel.Location = new System.Drawing.Point(257, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "ထြက္ရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnSave.Location = new System.Drawing.Point(122, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "သတ္မွတ္ရန္";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(148, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 26);
            this.label19.TabIndex = 65;
            this.label19.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label15.Location = new System.Drawing.Point(14, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 26);
            this.label15.TabIndex = 67;
            this.label15.Text = " - လိုအပ္သည္";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(0, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 26);
            this.label16.TabIndex = 66;
            this.label16.Text = "*";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.lblMoto);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(494, 50);
            this.pnlHeader.TabIndex = 78;
            // 
            // lblMoto
            // 
            this.lblMoto.AutoSize = true;
            this.lblMoto.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblMoto.ForeColor = System.Drawing.Color.White;
            this.lblMoto.Location = new System.Drawing.Point(104, 12);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(287, 26);
            this.lblMoto.TabIndex = 19;
            this.lblMoto.Text = "စာအုပ္ငွားရမ္းထားမႈ မရွိမွသာ ျပင္ဆင္ပါရန္";
            // 
            // FrmLibraryType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 273);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboLibrarytype);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLibraryType";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "စာၾကည့္တိုက္အမ်ိဳးအစား";
            this.Load += new System.EventHandler(this.FrmLibraryType_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLibraryType_KeyDown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLibrarytype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMoto;

    }
}
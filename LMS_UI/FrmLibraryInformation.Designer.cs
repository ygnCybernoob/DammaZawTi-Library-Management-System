namespace LMS_UI
{
    partial class FrmLibraryInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibraryInformation));
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLibraryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnSave.Location = new System.Drawing.Point(222, 434);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "သတ္မွတ္ရန္";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.label1);
            this.pnlBack.Controls.Add(this.label15);
            this.pnlBack.Controls.Add(this.label16);
            this.pnlBack.Controls.Add(this.btnClear);
            this.pnlBack.Controls.Add(this.btnChooseImage);
            this.pnlBack.Controls.Add(this.picImage);
            this.pnlBack.Controls.Add(this.btnCancel);
            this.pnlBack.Controls.Add(this.txtLibraryName);
            this.pnlBack.Controls.Add(this.btnSave);
            this.pnlBack.Controls.Add(this.label2);
            this.pnlBack.Location = new System.Drawing.Point(12, 12);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(743, 589);
            this.pnlBack.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(119, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label15.Location = new System.Drawing.Point(111, 441);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 26);
            this.label15.TabIndex = 63;
            this.label15.Text = " - လိုအပ္သည္";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(96, 441);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 26);
            this.label16.TabIndex = 62;
            this.label16.Text = "*";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnClear.Location = new System.Drawing.Point(296, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "ရွင္းလင္းရန္";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.btnChooseImage.Location = new System.Drawing.Point(296, 270);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(150, 35);
            this.btnChooseImage.TabIndex = 0;
            this.btnChooseImage.Text = "Logo ေရြးရန္...";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(296, 114);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(150, 150);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 38;
            this.picImage.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnCancel.Location = new System.Drawing.Point(378, 434);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "ထြက္ရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLibraryName
            // 
            this.txtLibraryName.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtLibraryName.Location = new System.Drawing.Point(301, 372);
            this.txtLibraryName.Name = "txtLibraryName";
            this.txtLibraryName.Size = new System.Drawing.Size(300, 34);
            this.txtLibraryName.TabIndex = 1;
            this.txtLibraryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLibraryName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.Location = new System.Drawing.Point(141, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "စာၾကည့္တိုက္အမည္ :";
            // 
            // FrmLibraryInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 613);
            this.Controls.Add(this.pnlBack);
            this.Name = "FrmLibraryInformation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "စာၾကည့္တိုက္ အခ်က္အလက္";
            this.Load += new System.EventHandler(this.FrmLibraryInformation_Load);
            this.SizeChanged += new System.EventHandler(this.FrmLibraryInformation_SizeChanged);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLibraryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
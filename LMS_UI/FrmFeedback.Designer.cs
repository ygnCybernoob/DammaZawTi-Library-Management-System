namespace LMS_UI
{
    partial class FrmFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFeedback));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlBack = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnCancel.Location = new System.Drawing.Point(387, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ထြက္ရန္";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnSave.Location = new System.Drawing.Point(231, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ထည့္သြင္းရန္";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label2.Location = new System.Drawing.Point(101, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "အေၾကာင္းအရာ :";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtSubject.Location = new System.Drawing.Point(231, 52);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(300, 34);
            this.txtSubject.TabIndex = 1;
            this.txtSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubject_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtDescription.Location = new System.Drawing.Point(231, 94);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(600, 250);
            this.txtDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "အသင္း၀င္ ဘားကုဒ္ :";
            // 
            // txtMemberBarcode
            // 
            this.txtMemberBarcode.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtMemberBarcode.Location = new System.Drawing.Point(231, 10);
            this.txtMemberBarcode.Name = "txtMemberBarcode";
            this.txtMemberBarcode.Size = new System.Drawing.Size(300, 34);
            this.txtMemberBarcode.TabIndex = 0;
            this.txtMemberBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemberBarcode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label3.Location = new System.Drawing.Point(40, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "အေၾကာင္းအရာ ေခါင္းစဉ္ :";
            // 
            // picImage
            // 
            this.picImage.Image = global::LMS_UI.Properties.Resources.feedback_image;
            this.picImage.Location = new System.Drawing.Point(530, 76);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(125, 125);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 22;
            this.picImage.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.menuStrip1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 50);
            this.pnlHeader.TabIndex = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // shortcutToolStripMenuItem
            // 
            this.shortcutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.shortcutToolStripMenuItem.Name = "shortcutToolStripMenuItem";
            this.shortcutToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.shortcutToolStripMenuItem.Text = "Shortcut";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(48, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 26);
            this.label5.TabIndex = 53;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 26);
            this.label4.TabIndex = 54;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(74, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 26);
            this.label6.TabIndex = 55;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label7.Location = new System.Drawing.Point(101, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 57;
            this.label7.Text = " - လိုအပ္သည္";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(86, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 26);
            this.label8.TabIndex = 56;
            this.label8.Text = "*";
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.label1);
            this.pnlBack.Controls.Add(this.label7);
            this.pnlBack.Controls.Add(this.txtSubject);
            this.pnlBack.Controls.Add(this.label8);
            this.pnlBack.Controls.Add(this.label2);
            this.pnlBack.Controls.Add(this.label6);
            this.pnlBack.Controls.Add(this.btnSave);
            this.pnlBack.Controls.Add(this.label4);
            this.pnlBack.Controls.Add(this.btnCancel);
            this.pnlBack.Controls.Add(this.label5);
            this.pnlBack.Controls.Add(this.txtDescription);
            this.pnlBack.Controls.Add(this.txtMemberBarcode);
            this.pnlBack.Controls.Add(this.label3);
            this.pnlBack.Location = new System.Drawing.Point(170, 214);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(845, 403);
            this.pnlBack.TabIndex = 58;
            // 
            // FrmFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.picImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "အေၾကာင္းၾကားစာ/ အမွာစာ";
            this.Load += new System.EventHandler(this.FrmFeedback_Load);
            this.SizeChanged += new System.EventHandler(this.FrmFeedback_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}
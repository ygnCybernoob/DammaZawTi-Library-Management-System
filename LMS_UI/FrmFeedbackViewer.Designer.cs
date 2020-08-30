namespace LMS_UI
{
    partial class FrmFeedbackViewer
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
            this.rtxtFeedback = new System.Windows.Forms.RichTextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtFeedback
            // 
            this.rtxtFeedback.BackColor = System.Drawing.Color.White;
            this.rtxtFeedback.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.rtxtFeedback.Location = new System.Drawing.Point(12, 181);
            this.rtxtFeedback.Name = "rtxtFeedback";
            this.rtxtFeedback.ReadOnly = true;
            this.rtxtFeedback.Size = new System.Drawing.Size(970, 380);
            this.rtxtFeedback.TabIndex = 0;
            this.rtxtFeedback.Text = "";
            // 
            // picImage
            // 
            this.picImage.Image = global::LMS_UI.Properties.Resources.message_image;
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(150, 150);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 23;
            this.picImage.TabStop = false;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.lblMemberName.Location = new System.Drawing.Point(221, 76);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(63, 26);
            this.lblMemberName.TabIndex = 24;
            this.lblMemberName.Text = "ေပးပို႔သူ";
            // 
            // FrmFeedbackViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(994, 573);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.rtxtFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFeedbackViewer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback Viewer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFeedbackViewer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtFeedback;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblMemberName;
    }
}
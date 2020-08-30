using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using BarcodeLib;
using LMS_BLL;

namespace LMS_UI
{
    public partial class FrmBarcodeGenerator : Form
    {
        string CODE;

        public FrmBarcodeGenerator()
        {
            InitializeComponent();
        }

        #region myCode

        private string Select_BookTypeCode()
        {
            BookCategory_Controller category_controller = new BookCategory_Controller();

            return category_controller.Select_BookTypeCode((int)cboBookCategory.SelectedValue);
        }

        private void Bind_BookCategory()
        {
            BookCategory_Controller book_controller = new BookCategory_Controller();
            BookCategory_Collection book_collection = book_controller.Select_Category();

            cboBookCategory.DisplayMember = "category";
            cboBookCategory.ValueMember = "categoryid";
            cboBookCategory.DataSource = book_collection;
        }

        #endregion

        private void FrmBarcodeGenerator_Load(object sender, EventArgs e)
        {
            Bind_BookCategory();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CODE))
            {
                FolderBrowserDialog d = new FolderBrowserDialog();

                if (d.ShowDialog() == DialogResult.OK)
                {
                    string path = d.SelectedPath;
                    long start = (long)numStart.Value;
                    long end = (long)numEnd.Value;

                    Barcode code = new Barcode();
                    code.Width = (int)numWidth.Value;
                    code.Height = (int)numHeight.Value;
                    code.LabelPosition = LabelPositions.BOTTOMCENTER;
                    code.Alignment = AlignmentPositions.CENTER;
                    code.IncludeLabel = true;
                    code.EncodedType = TYPE.CODE128;


                    for (long i = start; i <= end; i++)
                    {
                        Image  img = code.Encode(TYPE.CODE128, CODE + i, Color.Black, Color.White);
                        img.Save(path + "\\" + (CODE+i )+".png", ImageFormat.Png);
                    }

                    Utilities.ShowMessage(Utilities.MessageType.Information, "ဘားကုဒ္မ်ားကို ထုတ္ျပီးပါျပီ");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboBookCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBookCategory.Items.Count > 0)
            {
                CODE = Select_BookTypeCode();
                txtCodePreview.Text = CODE;
            }
        }

        private void chbMember_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMember.Checked)
            {
                cboBookCategory.Enabled = false;
                CODE = "MB";
                txtCodePreview.Text = CODE;
            }
            else
            {
                cboBookCategory.Enabled = true;
                cboBookCategory_SelectedIndexChanged(null, null);
            }
        }
    }
}

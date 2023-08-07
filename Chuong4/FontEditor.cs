using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4
{
    public partial class FontEditor : Form
    {
        private FontStyle newFontStyle = FontStyle.Regular;

        //thiết lập màu cơ bản là màu đen
        int rgb1 = 0;
        int rgb2 = 0;
        int rgb3 = 0;

        public FontEditor()
        {
            InitializeComponent();
            
        }

        private void FontEditor_Load(object sender, EventArgs e)
        {
            initFont();
            initSizeFont();
        }

        private void initFont()
        {   
            List<String> font = new List<String>();

            //lấy toàn bộ tên font thêm vào list
            foreach (FontFamily fnt in FontFamily.Families)
            {
                font.Add(fnt.Name);
            }

            
            listBoxFont.DataSource = font;

            //cho font mặc định là Arial
            listBoxFont.SelectedIndex = 2;
        }

        private void initSizeFont()
        {
            int[] size = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int i in size) 
                comboBoxSizeFont.Items.Add(i);
        }

        private void listBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFont.SelectedItem == null) return;
            //Lấy tên font đã chọn ở listbox
            String selectFont = listBoxFont.SelectedItem.ToString();

            try
            {
                //đặt font cho văn bản đã chọn
                richTextBoxContent.SelectionFont = new Font(selectFont, richTextBoxContent.SelectionFont.Size);
            }
            catch(NullReferenceException) { MessageBox.Show("Xin lỗi tôi không thể đổi font này"); }
        }

        private void comboBoxSizeFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSizeFont.SelectedItem == null) return;

            if(richTextBoxContent.SelectionFont == null) return;

            //lấy size font mà người dùng chọn
            float newSizeFont = float.Parse(comboBoxSizeFont.SelectedItem.ToString());
            richTextBoxContent.SelectionFont = new Font(richTextBoxContent.SelectionFont.ToString(), newSizeFont,newFontStyle);


        }

        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBoxContent.SelectionFont == null) return;
            CheckBox cb = (CheckBox)sender;

            FontStyle newFontStyle = richTextBoxContent.SelectionFont.Style;
            switch (cb.Text) 
            {
                case "B":
                    if (checkBoxBold.Checked)
                        //thêm font style bold vào nếu chưa tồn tại
                        newFontStyle |= FontStyle.Bold;
                    else
                        //xóa font style bold nếu tồn tại
                        newFontStyle &= ~FontStyle.Bold;
                    break;
                case "U":
                    if(checkBoxUnderLine.Checked)
                        //thêm font style underline vào nếu chưa tồn tại
                        newFontStyle |= FontStyle.Underline;
                    else 
                        //xóa font style underline nếu tồn tại
                        newFontStyle &= ~FontStyle.Underline;
                    break;
                case "/":
                    if(checkBoxItalic.Checked)
                        //thêm font style italic vào nếu chưa tồn tại
                        newFontStyle |= FontStyle.Italic;
                    else
                        //xóa font style italic nếu tồn tại
                        newFontStyle &= ~FontStyle.Italic;
                    break;
            }

            String currentFont = richTextBoxContent.SelectionFont.FontFamily.Name;
            float currentSizeFont = richTextBoxContent.SelectionFont.Size;
            richTextBoxContent.SelectionFont = new Font(currentFont, currentSizeFont, newFontStyle);
        }

        //cho phép người dùng ctrl + A trên rich textbox
        private void richTextBoxContent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.A)
            {
                //chọn tất cả văn bản trong rich text box
                richTextBoxContent.SelectAll();

                //đánh dấu là sự kiện đã được xử lý
                e.Handled = true;
            }
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            rgb1 = hScrollBar1.Value;
            rgb2 = hScrollBar2.Value;
            rgb3 = hScrollBar3.Value;

            lbColor.BackColor = Color.FromArgb(rgb1, rgb2, rgb3);
            richTextBoxContent.SelectionColor = Color.FromArgb(rgb1, rgb2, rgb3);
        }
    }
}

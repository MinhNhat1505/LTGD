using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chuong4
{
    public partial class CommonDialog : Form
    {
        String defaultText = "Chương trình demo sử dụng các hộp thoại thông dụng của windows";
        Color defaultFontColor, defaultBackColor;
        Font defaultFont;
        bool flag = false;
        public CommonDialog()
        {
            InitializeComponent();
        }

        private void btnOpen1File_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDisplay.Text = fileDialog.FileName;
            }
        }

        private void CommonDialog_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = defaultText;
            defaultFontColor = txtDisplay.ForeColor;
            defaultBackColor = txtDisplay.BackColor;
            defaultFont = txtDisplay.Font;
        }

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                //cho phép chọn nhiều file
                Multiselect = true,
            };

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                int totalFile = fileDialog.FileNames.Length;
                txtDisplay.Text = String.Format("Có tổng cộng {0} file\r\n", totalFile);
                foreach (string file in fileDialog.FileNames)
                {
                    txtDisplay.Text += file + "\r\n";
                }
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog
            {
                //tạo 1 folder mới
                ShowNewFolderButton = true,

                Description = "Choose a directory",
            };
            if(folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtDisplay.Text = folderDialog.SelectedPath;
            }
        }

        private void btnChooseColorBack_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            if(cl.ShowDialog() == DialogResult.OK) 
            {
                txtDisplay.BackColor = cl.Color;
            }
        }

        private void btnChooseFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            if (cl.ShowDialog() == DialogResult.OK)
            {
                txtDisplay.ForeColor = cl.Color;
            }
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog
            {
                //hiển thị Effect,color,nút apply trong FontDialog
                ShowEffects = true,
                ShowColor = true,
                ShowApply = true,
            };

            //bắt sự kiện apply
            fontDialog.Apply += FontDialog_Apply;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtDisplay.Font = fontDialog.Font;
                txtDisplay.ForeColor = fontDialog.Color;
            }
        }

        private void FontDialog_Apply(object sender, EventArgs e)
        {
            FontDialog f = (FontDialog)sender;

            txtDisplay.Font = f.Font;
            txtDisplay.ForeColor = f.Color; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CommonDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false && MessageBox.Show("Bạn có muốn đóng form?","Xác nhận",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            flag = true;
            if(Opacity > 0)
            {
                e.Cancel = true;
                TimerFadeOut.Start();
            }
        }

        private void TimerFadeOut_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if(Opacity <= 0)
            {
                TimerFadeOut.Stop();
                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDisplay.Font = defaultFont;
            txtDisplay.BackColor = defaultBackColor;
            txtDisplay.ForeColor = defaultFontColor;
            txtDisplay.Text = defaultText;
        }
    }
}

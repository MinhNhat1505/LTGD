using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4
{
    public partial class MyPhoto_SubMain : Form
    {
        bool flag = false;
        public MyPhoto_SubMain()
        {
            InitializeComponent();
        }

        private void LoadImage(String path)
        {
            picImage.Image = Image.FromFile(path);
        }

        private void MyPhoto_SubMain_Load(object sender, EventArgs e)
        {
            LoadImage(Application.StartupPath + @"\Images\cat.jpg");
        }

        private void menuLoad_Click(object sender, EventArgs e)
        {
            MyPhoto_SubMain_Load(sender,e);
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All file|*.jpg;*.png;*.gif;*.bmp|" + "jpg file(*.jpg)|*.jpg|" + "png file(*.png)|*.png|" + "gif file(*.gif)|*.gif|"
                        + "Bitmap file(*.bmp)|*.bmp";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                LoadImage((String)dlg.FileName);
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            picImage.Image = null;
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "PNG |*.png|" + "JPEG |*.jpg|" + "BMP |*.bmp|" + "GIF |*.gif";
            if (dlg.ShowDialog() == DialogResult.OK ) 
            {
                //lấy đuôi file
                string type = Path.GetExtension(dlg.FileName).ToLower();

                switch(type) 
                {
                    case ".png":
                        picImage.Image.Save(dlg.FileName,ImageFormat.Png);
                        break;
                    case ".jpg":
                        picImage.Image.Save(dlg.FileName, ImageFormat.Jpeg);
                        break;
                    case ".bmp":
                        picImage.Image.Save(dlg.FileName,ImageFormat.Bmp); 
                        break;
                    case ".gif":
                        picImage.Image.Save(dlg.FileName, ImageFormat.Gif);
                        break;
                }
            }
        }
    }

    
}

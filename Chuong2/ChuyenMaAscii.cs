using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong2
{
    public partial class ChuyenMaAscii : Form
    {
        public ChuyenMaAscii()
        {
            InitializeComponent();
        }

        private void btnAsciiToChar_Click(object sender, EventArgs e)
        {
            try 
            {
                int ascii = int.Parse(txtASCII.Text);
                char character = (char)ascii;
                txtResultAsciiToChar.Text = character.ToString();
            }
            catch(Exception) 
            {
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void btnCharToAscii_Click(object sender, EventArgs e)
        {
            try
            {
                Char character = char.Parse(txtChar.Text);
                byte ascii = (byte)character;
                txtResultCharToAscii.Text = ascii.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập chữ cái");
            }
        }
    }
}

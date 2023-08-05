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
    public partial class GiaiPhuongTrinhBac2 : Form
    {
        public GiaiPhuongTrinhBac2()
        {
            InitializeComponent();
        }



        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(txtA.Text);
                double b = Double.Parse(txtB.Text);
                double c = Double.Parse(txtC.Text);
                giaiPTBac2(a, b, c);
            }
            catch (FormatException)
            {
                MessageBox.Show("vui lòng nhập số");
            }
            catch (Exception) 
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void giaiPTBac2(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            double x1;
            double x2;
            // tinh nghiem
            if (delta > 0)
            {
                x1 = (double)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (double)((-b - Math.Sqrt(delta)) / (2 * a));
                lbResult.Text = String.Format("x1 = {0}\nx2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                lbResult.Text = "x = " + x1.ToString();
            }
            else
            {
                lbResult.Text = "Phương trình vô nghiệm";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}

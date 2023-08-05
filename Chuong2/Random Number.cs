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
    public partial class Random_Number : Form
    {
        Random random = new Random();
        int score;
        public Random_Number()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int a = random.Next(10);
            int b = random.Next(10);
            int c = random.Next(10);

            lbFirstNumber.Text = a.ToString();
            lbSecondNumber.Text = b.ToString();
            lbThirdNumber.Text = c.ToString();

            if (a == b && a == c)
                score += 100;
            else
                score -= 10;
            lbResult.Text = score.ToString();
        }

        private void Random_Number_Load(object sender, EventArgs e)
        {
            score = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

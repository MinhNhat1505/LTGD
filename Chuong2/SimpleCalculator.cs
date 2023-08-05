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
    public partial class SimpleCalculator : Form
    {
        String[] calculations = {"+","-","*","/"};
        String display;
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;;
            String result = txtDisplay.Text; 
            for(int i = 0;i < calculations.Length; i++) 
            {
                if (result.Contains(calculations[i]))
                    return;
            }
            txtDisplay.Text += btn.Text;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
                return;
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                display = txtDisplay.Text;
                int i = 0;

                while (true)
                {
                    if (display.Contains(calculations[i]))
                        break;
                    i++;
                }

                int[] number = Array.ConvertAll(display.Split(char.Parse(calculations[i])), s => int.Parse(s));
                switch (calculations[i])
                {
                    case "+":
                        txtDisplay.Text += "=" + (number[0] + number[1]).ToString();
                        break;
                    case "-":
                        txtDisplay.Text += "=" + (number[0] - number[1]).ToString();
                        break;
                    case "*":
                        txtDisplay.Text += "=" + (number[0] * number[1]).ToString();
                        break;
                    case "/":
                        if (number[1] != 0)
                        {
                            double result = number[0] * 1.0 / number[1];
                            txtDisplay.Text += "=" + String.Format("{0:0.00}",result);
                        }
                        else
                            MessageBox.Show("Không thực hiện phép chia 0");
                        break;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Biểu thức không hợp lệ");
            }
            catch(Exception)
            {
                MessageBox.Show("Biểu thức không hợp lệ");
            }
        }
    }
}

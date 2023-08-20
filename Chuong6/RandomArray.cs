using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong6
{
    public partial class RandomArray : Form
    {
        //chứa mảng ban đầu
        private List<int> defaultArray = new List<int>();

        private Random rd = new Random();
        public RandomArray()
        {
            InitializeComponent();
        }

        private bool isPrime(int num)
        {
            if(num < 2) return false;

            if (num == 2) return true;

            for(int i = 2;i <= Math.Sqrt(num);i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        private void btnArrayGeneration_Click(object sender, EventArgs e)
        {
            try
            {
                txtDefaultArray.Text = "";
                if(defaultArray != null ) { defaultArray.Clear(); }

                int n = int.Parse(txtArrayElement.Text);
                for(int i = 0; i < n;i++) 
                {
                    defaultArray.Add(rd.Next(100));
                }

                //gán lại vào textbox
                txtDefaultArray.Text = String.Join(", ", defaultArray.Select(num => num.ToString()));
            }
            catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập số lượng phần tử");
            }
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            int sumEven = 0;
            int sumOdd = 0;
            int total = 0;
            List<int> primeNumber = new List<int>();

            foreach(int i in defaultArray) 
            {
                //cộng chẳn lẻ
                if(i % 2 == 0)
                    sumEven += i;
                else
                    sumOdd += i;

                //liệt kê số nguyên tố
                if(isPrime(i))
                    primeNumber.Add(i);

                //cộng tổng các số trong mảng
                total += i;
            }

            //gán giá trị vào textbox
            txtSumEvenElements.Text = sumEven.ToString();
            txtSumOddElements.Text = sumOdd.ToString();
            txtAverage.Text = String.Format("{0:0.000}",total * 1.0 / defaultArray.Count);
            txtPrimeArray.Text = primeNumber.Count == 0 ? "Không có số nguyên tố" : String.Join(", ", primeNumber.Select(num => num.ToString()));

        }

        private void RandomArray_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}

using PhepToanPhanSo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong3
{
    public partial class SinhPhanSoNgauNhien : Form
    {
        public SinhPhanSoNgauNhien()
        {
            InitializeComponent();
        }

        Random rd = new Random();
        String[] op = { "+", "-", "*", "/" };
        int opIndex = -1;

        PhanSo ps1,ps2;
        int score = 0;

        private void SinhPhanSoNgauNhien_Load(object sender, EventArgs e)
        {
            ps1 = new PhanSo();
            ps2 = new PhanSo();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            //lấy đáp án của người dùng và so sánh
            try
            {
                int ts = int.Parse(txtTSkq.Text);
                int ms = int.Parse(txtMSkq.Text);
                PhanSo kq = new PhanSo();
                bool check = true;
                switch (op[opIndex])
                {
                    case "+": kq = PhanSo.congPhanSo(ps1, ps2); break;
                    case "-": kq = PhanSo.truPhanSo(ps1, ps2); break;
                    case "x": kq = PhanSo.nhanPhanSo(ps1, ps2); break;
                    case "/": kq = PhanSo.chiaPhanSo(ps1, ps2); break;
                }

                if (ts != kq.Tuso || ms != kq.Mauso)
                    check = false;

                score += (check == true ? 10 : -10);
                lbScore.Text = score.ToString();
                MessageBox.Show(check == true ? "Bạn làm đúng" : "Bạn làm sai");
                btRandom_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập tử và mẫu số");
            }
            catch(Exception)
            {

            }

        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            //tạo mẫu số và tử số của 2 phân số và phép toán
            int ts1 = rd.Next(11);
            int ts2 = rd.Next(11);
            int ms1 = rd.Next(11);
            int ms2 = rd.Next(11);

            opIndex = rd.Next(4);

            ps1.Tuso = ts1;
            ps2.Tuso = ts2;
            ps1.Mauso = ms1;
            ps2.Mauso = ms2;

            //Hiển thị phân số và phép toán trên giao diện
            txtTS1.Text = ts1.ToString();
            txtTS2.Text = ts2.ToString();
            txtMS1.Text = ms1.ToString();
            txtMS2.Text = ms2.ToString();
            lbOP.Text = op[opIndex];

            
        }
    }
}

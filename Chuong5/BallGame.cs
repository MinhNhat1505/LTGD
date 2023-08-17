using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong5
{
    public partial class BallGame : Form
    {
        //khoảng cách mỗi lần ball di chuyển
        private int moveStepX = 5;
        private int moveStepY = 8;

        //lưu điểm mặc định của ball và cross bar
        private Point pDefaultBall, pDefaultCrossBar;

        //khoảng cách mỗi lần cross bar di chuyển
        private int crossBarMove = 20;

        //lưu vị trí con trỏ chuột khi click vào cross bar
        private Point pCursorCB;
        public BallGame()
        {
            InitializeComponent();
        }

        private void RestartTheGame()
        {
            picBall.Location = pDefaultBall;
            lbCrossBar.Location = pDefaultCrossBar;
        }

        private void BallGame_Load(object sender, EventArgs e)
        {
            picBall.Image = Image.FromFile(Application.StartupPath + @"\images\ball.png");
            pDefaultBall = picBall.Location;
            pDefaultCrossBar = lbCrossBar.Location;
        }

        private void BallGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode) 
            {
                case Keys.S:
                    timerBallMove.Start();
                    break;
                case Keys.Left:
                    if (lbCrossBar.Left - crossBarMove >= 0)
                        lbCrossBar.Left -= crossBarMove;
                    break;
                case Keys.Right:
                    if(lbCrossBar.Right + crossBarMove <= ClientRectangle.Width)
                        lbCrossBar.Left += crossBarMove;
                    break;
            }
        }

        private void lbCrossBar_MouseDown(object sender, MouseEventArgs e)
        {
            //lấy vị trí con trỏ chuột khi click vào cross bar
            pCursorCB = e.Location;
        }

        private void lbCrossBar_MouseMove(object sender, MouseEventArgs e)
        {
            //tính xem con trỏ chuột đã di chuyển bao xa so với vị trí ban đầu
            int dx = e.X - pCursorCB.X;

            if(e.Button == MouseButtons.Left)
            {
                if(lbCrossBar.Left + dx > 0 && lbCrossBar.Right + dx <  ClientRectangle.Width)
                    lbCrossBar.Left += dx;
                
            }
        }

        private void timerBallMove_Tick(object sender, EventArgs e)
        {
            //nếu ball chạm góc trái màn hình hoặc góc phải => cho đi ngược chiều trục hoành
            if (picBall.Left <= 0 || picBall.Right > ClientRectangle.Width)
                moveStepX = -moveStepX;

            //nếu ball đụng phía trên cùng hoặc đụng thanh scross bar thì cho đi ngược chiều trục tung
            if(picBall.Top <= 0 || picBall.Bounds.IntersectsWith(lbCrossBar.Bounds))
                moveStepY = -moveStepY;

            //cho quả bóng di chuyển
            picBall.Left += moveStepX;
            picBall.Top += moveStepY;

            //nếu Y của ball > Y của cross ball thì cho dừng lại
            if (picBall.Bottom > lbCrossBar.Bottom)
            {
                timerBallMove.Stop();

                if (MessageBox.Show("Bạn thua rồi,muốn chơi lại không?", "Xác nhận"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RestartTheGame();
                }
                else
                    Close();

            }


        }
    }
}

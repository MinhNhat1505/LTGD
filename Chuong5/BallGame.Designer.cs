namespace Chuong5
{
    partial class BallGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.lbCrossBar = new System.Windows.Forms.Label();
            this.timerBallMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // picBall
            // 
            this.picBall.Location = new System.Drawing.Point(316, 30);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(121, 87);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // lbCrossBar
            // 
            this.lbCrossBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbCrossBar.Location = new System.Drawing.Point(299, 389);
            this.lbCrossBar.Name = "lbCrossBar";
            this.lbCrossBar.Size = new System.Drawing.Size(184, 27);
            this.lbCrossBar.TabIndex = 1;
            this.lbCrossBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbCrossBar_MouseDown);
            this.lbCrossBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbCrossBar_MouseMove);
            // 
            // timerBallMove
            // 
            this.timerBallMove.Interval = 30;
            this.timerBallMove.Tick += new System.EventHandler(this.timerBallMove_Tick);
            // 
            // BallGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 475);
            this.Controls.Add(this.lbCrossBar);
            this.Controls.Add(this.picBall);
            this.Name = "BallGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ball Game";
            this.Load += new System.EventHandler(this.BallGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BallGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lbCrossBar;
        private System.Windows.Forms.Timer timerBallMove;
    }
}


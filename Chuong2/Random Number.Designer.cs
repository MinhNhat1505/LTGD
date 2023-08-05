namespace Chuong2
{
    partial class Random_Number
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
            this.lbFirstNumber = new System.Windows.Forms.Label();
            this.lbSecondNumber = new System.Windows.Forms.Label();
            this.lbThirdNumber = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFirstNumber
            // 
            this.lbFirstNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstNumber.Location = new System.Drawing.Point(60, 62);
            this.lbFirstNumber.Name = "lbFirstNumber";
            this.lbFirstNumber.Size = new System.Drawing.Size(192, 202);
            this.lbFirstNumber.TabIndex = 0;
            this.lbFirstNumber.Text = "0";
            this.lbFirstNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSecondNumber
            // 
            this.lbSecondNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondNumber.Location = new System.Drawing.Point(297, 62);
            this.lbSecondNumber.Name = "lbSecondNumber";
            this.lbSecondNumber.Size = new System.Drawing.Size(192, 202);
            this.lbSecondNumber.TabIndex = 1;
            this.lbSecondNumber.Text = "0";
            this.lbSecondNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThirdNumber
            // 
            this.lbThirdNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbThirdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThirdNumber.Location = new System.Drawing.Point(549, 62);
            this.lbThirdNumber.Name = "lbThirdNumber";
            this.lbThirdNumber.Size = new System.Drawing.Size(192, 202);
            this.lbThirdNumber.TabIndex = 2;
            this.lbThirdNumber.Text = "0";
            this.lbThirdNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(66, 297);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(674, 71);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "0";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(197, 391);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(138, 57);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(483, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 57);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Random_Number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbThirdNumber);
            this.Controls.Add(this.lbSecondNumber);
            this.Controls.Add(this.lbFirstNumber);
            this.Name = "Random_Number";
            this.Text = "Random_Number";
            this.Load += new System.EventHandler(this.Random_Number_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFirstNumber;
        private System.Windows.Forms.Label lbSecondNumber;
        private System.Windows.Forms.Label lbThirdNumber;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
    }
}
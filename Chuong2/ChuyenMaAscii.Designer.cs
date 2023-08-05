namespace Chuong2
{
    partial class ChuyenMaAscii
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxAsciiToChar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.btnAsciiToChar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultAsciiToChar = new System.Windows.Forms.TextBox();
            this.grpBoxCharToAscii = new System.Windows.Forms.GroupBox();
            this.txtResultCharToAscii = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCharToAscii = new System.Windows.Forms.Button();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBoxAsciiToChar.SuspendLayout();
            this.grpBoxCharToAscii.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN MÃ ASCII";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxAsciiToChar
            // 
            this.grpBoxAsciiToChar.Controls.Add(this.txtResultAsciiToChar);
            this.grpBoxAsciiToChar.Controls.Add(this.label3);
            this.grpBoxAsciiToChar.Controls.Add(this.btnAsciiToChar);
            this.grpBoxAsciiToChar.Controls.Add(this.txtASCII);
            this.grpBoxAsciiToChar.Controls.Add(this.label2);
            this.grpBoxAsciiToChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAsciiToChar.Location = new System.Drawing.Point(26, 118);
            this.grpBoxAsciiToChar.Name = "grpBoxAsciiToChar";
            this.grpBoxAsciiToChar.Size = new System.Drawing.Size(297, 214);
            this.grpBoxAsciiToChar.TabIndex = 1;
            this.grpBoxAsciiToChar.TabStop = false;
            this.grpBoxAsciiToChar.Text = "Chuyển mã ASCII sang ký tự";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã ASCII";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtASCII
            // 
            this.txtASCII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtASCII.Location = new System.Drawing.Point(141, 57);
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.Size = new System.Drawing.Size(118, 28);
            this.txtASCII.TabIndex = 1;
            // 
            // btnAsciiToChar
            // 
            this.btnAsciiToChar.Location = new System.Drawing.Point(141, 104);
            this.btnAsciiToChar.Name = "btnAsciiToChar";
            this.btnAsciiToChar.Size = new System.Drawing.Size(116, 30);
            this.btnAsciiToChar.TabIndex = 2;
            this.btnAsciiToChar.Text = "Chuyển";
            this.btnAsciiToChar.UseVisualStyleBackColor = true;
            this.btnAsciiToChar.Click += new System.EventHandler(this.btnAsciiToChar_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResultAsciiToChar
            // 
            this.txtResultAsciiToChar.Location = new System.Drawing.Point(141, 166);
            this.txtResultAsciiToChar.Name = "txtResultAsciiToChar";
            this.txtResultAsciiToChar.ReadOnly = true;
            this.txtResultAsciiToChar.Size = new System.Drawing.Size(118, 28);
            this.txtResultAsciiToChar.TabIndex = 4;
            this.txtResultAsciiToChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpBoxCharToAscii
            // 
            this.grpBoxCharToAscii.Controls.Add(this.txtResultCharToAscii);
            this.grpBoxCharToAscii.Controls.Add(this.label4);
            this.grpBoxCharToAscii.Controls.Add(this.btnCharToAscii);
            this.grpBoxCharToAscii.Controls.Add(this.txtChar);
            this.grpBoxCharToAscii.Controls.Add(this.label5);
            this.grpBoxCharToAscii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCharToAscii.Location = new System.Drawing.Point(477, 118);
            this.grpBoxCharToAscii.Name = "grpBoxCharToAscii";
            this.grpBoxCharToAscii.Size = new System.Drawing.Size(297, 214);
            this.grpBoxCharToAscii.TabIndex = 5;
            this.grpBoxCharToAscii.TabStop = false;
            this.grpBoxCharToAscii.Text = "Chuyển ký tự sang mã ASCII";
            // 
            // txtResultCharToAscii
            // 
            this.txtResultCharToAscii.Location = new System.Drawing.Point(141, 166);
            this.txtResultCharToAscii.Name = "txtResultCharToAscii";
            this.txtResultCharToAscii.ReadOnly = true;
            this.txtResultCharToAscii.Size = new System.Drawing.Size(118, 28);
            this.txtResultCharToAscii.TabIndex = 4;
            this.txtResultCharToAscii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCharToAscii
            // 
            this.btnCharToAscii.Location = new System.Drawing.Point(141, 104);
            this.btnCharToAscii.Name = "btnCharToAscii";
            this.btnCharToAscii.Size = new System.Drawing.Size(116, 30);
            this.btnCharToAscii.TabIndex = 2;
            this.btnCharToAscii.Text = "Chuyển";
            this.btnCharToAscii.UseVisualStyleBackColor = true;
            this.btnCharToAscii.Click += new System.EventHandler(this.btnCharToAscii_Click);
            // 
            // txtChar
            // 
            this.txtChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChar.Location = new System.Drawing.Point(141, 57);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(118, 28);
            this.txtChar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ký tự";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChuyenMaAscii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxCharToAscii);
            this.Controls.Add(this.grpBoxAsciiToChar);
            this.Controls.Add(this.label1);
            this.Name = "ChuyenMaAscii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển mã ASCII";
            this.grpBoxAsciiToChar.ResumeLayout(false);
            this.grpBoxAsciiToChar.PerformLayout();
            this.grpBoxCharToAscii.ResumeLayout(false);
            this.grpBoxCharToAscii.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxAsciiToChar;
        private System.Windows.Forms.Button btnAsciiToChar;
        private System.Windows.Forms.TextBox txtASCII;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultAsciiToChar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBoxCharToAscii;
        private System.Windows.Forms.TextBox txtResultCharToAscii;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCharToAscii;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.Label label5;
    }
}


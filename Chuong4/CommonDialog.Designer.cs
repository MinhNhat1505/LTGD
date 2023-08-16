namespace Chuong4
{
    partial class CommonDialog
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
            this.btnOpen1File = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.btnChooseFontColor = new System.Windows.Forms.Button();
            this.btnChooseColorBack = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnOpenFiles = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.TimerFadeOut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnOpen1File
            // 
            this.btnOpen1File.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen1File.Location = new System.Drawing.Point(22, 31);
            this.btnOpen1File.Name = "btnOpen1File";
            this.btnOpen1File.Size = new System.Drawing.Size(255, 53);
            this.btnOpen1File.TabIndex = 0;
            this.btnOpen1File.Text = "Chọn một tập tin";
            this.btnOpen1File.UseVisualStyleBackColor = true;
            this.btnOpen1File.Click += new System.EventHandler(this.btnOpen1File_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(621, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(255, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(321, 440);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(255, 53);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFont.Location = new System.Drawing.Point(22, 440);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(255, 53);
            this.btnChooseFont.TabIndex = 4;
            this.btnChooseFont.Text = "Chọn font";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            this.btnChooseFont.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // btnChooseFontColor
            // 
            this.btnChooseFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFontColor.Location = new System.Drawing.Point(22, 359);
            this.btnChooseFontColor.Name = "btnChooseFontColor";
            this.btnChooseFontColor.Size = new System.Drawing.Size(255, 53);
            this.btnChooseFontColor.TabIndex = 5;
            this.btnChooseFontColor.Text = "chọn màu chữ";
            this.btnChooseFontColor.UseVisualStyleBackColor = true;
            this.btnChooseFontColor.Click += new System.EventHandler(this.btnChooseFontColor_Click);
            // 
            // btnChooseColorBack
            // 
            this.btnChooseColorBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseColorBack.Location = new System.Drawing.Point(22, 275);
            this.btnChooseColorBack.Name = "btnChooseColorBack";
            this.btnChooseColorBack.Size = new System.Drawing.Size(255, 53);
            this.btnChooseColorBack.TabIndex = 6;
            this.btnChooseColorBack.Text = "Chọn màu nền";
            this.btnChooseColorBack.UseVisualStyleBackColor = true;
            this.btnChooseColorBack.Click += new System.EventHandler(this.btnChooseColorBack_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.Location = new System.Drawing.Point(22, 200);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(255, 53);
            this.btnOpenFolder.TabIndex = 7;
            this.btnOpenFolder.Text = "Chọn thư mục";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnOpenFiles
            // 
            this.btnOpenFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFiles.Location = new System.Drawing.Point(22, 117);
            this.btnOpenFiles.Name = "btnOpenFiles";
            this.btnOpenFiles.Size = new System.Drawing.Size(255, 53);
            this.btnOpenFiles.TabIndex = 8;
            this.btnOpenFiles.Text = "Chọn nhiều tập tin";
            this.btnOpenFiles.UseVisualStyleBackColor = true;
            this.btnOpenFiles.Click += new System.EventHandler(this.btnOpenFiles_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.Blue;
            this.txtDisplay.Location = new System.Drawing.Point(321, 31);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisplay.Size = new System.Drawing.Size(554, 389);
            this.txtDisplay.TabIndex = 9;
            // 
            // TimerFadeOut
            // 
            this.TimerFadeOut.Tick += new System.EventHandler(this.TimerFadeOut_Tick);
            // 
            // CommonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 525);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnOpenFiles);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnChooseColorBack);
            this.Controls.Add(this.btnChooseFontColor);
            this.Controls.Add(this.btnChooseFont);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpen1File);
            this.Name = "CommonDialog";
            this.Text = "CommonDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommonDialog_FormClosing);
            this.Load += new System.EventHandler(this.CommonDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen1File;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.Button btnChooseFontColor;
        private System.Windows.Forms.Button btnChooseColorBack;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnOpenFiles;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Timer TimerFadeOut;
    }
}
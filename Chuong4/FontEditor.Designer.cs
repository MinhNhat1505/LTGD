namespace Chuong4
{
    partial class FontEditor
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
            this.listBoxFont = new System.Windows.Forms.ListBox();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSizeFont = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxUnderLine = new System.Windows.Forms.CheckBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFont
            // 
            this.listBoxFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFont.FormattingEnabled = true;
            this.listBoxFont.ItemHeight = 16;
            this.listBoxFont.Location = new System.Drawing.Point(39, 64);
            this.listBoxFont.Name = "listBoxFont";
            this.listBoxFont.Size = new System.Drawing.Size(231, 340);
            this.listBoxFont.TabIndex = 0;
            this.listBoxFont.SelectedIndexChanged += new System.EventHandler(this.listBoxFont_SelectedIndexChanged);
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxContent.Location = new System.Drawing.Point(308, 66);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(697, 342);
            this.richTextBoxContent.TabIndex = 1;
            this.richTextBoxContent.Text = "";
            this.richTextBoxContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxContent_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Content";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSizeFont
            // 
            this.comboBoxSizeFont.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxSizeFont.FormattingEnabled = true;
            this.comboBoxSizeFont.Location = new System.Drawing.Point(208, 452);
            this.comboBoxSizeFont.Name = "comboBoxSizeFont";
            this.comboBoxSizeFont.Size = new System.Drawing.Size(134, 24);
            this.comboBoxSizeFont.TabIndex = 5;
            this.comboBoxSizeFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxSizeFont_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(523, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 9;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(523, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 10;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(523, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 11;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(577, 428);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(187, 15);
            this.hScrollBar1.TabIndex = 13;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hScrollBar2.Location = new System.Drawing.Point(577, 456);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(187, 15);
            this.hScrollBar2.TabIndex = 14;
            this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hScrollBar3.Location = new System.Drawing.Point(577, 482);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(187, 15);
            this.hScrollBar3.TabIndex = 15;
            this.hScrollBar3.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxBold.Location = new System.Drawing.Point(370, 452);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(34, 24);
            this.checkBoxBold.TabIndex = 16;
            this.checkBoxBold.Text = "B";
            this.checkBoxBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBold.UseVisualStyleBackColor = true;
            this.checkBoxBold.CheckedChanged += new System.EventHandler(this.checkBoxBold_CheckedChanged);
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxItalic.Location = new System.Drawing.Point(410, 452);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(34, 24);
            this.checkBoxItalic.TabIndex = 17;
            this.checkBoxItalic.Text = "/";
            this.checkBoxItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            this.checkBoxItalic.CheckedChanged += new System.EventHandler(this.checkBoxBold_CheckedChanged);
            // 
            // checkBoxUnderLine
            // 
            this.checkBoxUnderLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxUnderLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxUnderLine.Location = new System.Drawing.Point(450, 451);
            this.checkBoxUnderLine.Name = "checkBoxUnderLine";
            this.checkBoxUnderLine.Size = new System.Drawing.Size(34, 24);
            this.checkBoxUnderLine.TabIndex = 18;
            this.checkBoxUnderLine.Text = "U";
            this.checkBoxUnderLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxUnderLine.UseVisualStyleBackColor = true;
            this.checkBoxUnderLine.CheckedChanged += new System.EventHandler(this.checkBoxBold_CheckedChanged);
            // 
            // lbColor
            // 
            this.lbColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbColor.BackColor = System.Drawing.Color.Black;
            this.lbColor.Location = new System.Drawing.Point(792, 428);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(82, 69);
            this.lbColor.TabIndex = 19;
            this.lbColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FontEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 514);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.checkBoxUnderLine);
            this.Controls.Add(this.checkBoxItalic);
            this.Controls.Add(this.checkBoxBold);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSizeFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.listBoxFont);
            this.Name = "FontEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FontEditor";
            this.Load += new System.EventHandler(this.FontEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFont;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSizeFont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.CheckBox checkBoxBold;
        private System.Windows.Forms.CheckBox checkBoxItalic;
        private System.Windows.Forms.CheckBox checkBoxUnderLine;
        private System.Windows.Forms.Label lbColor;
    }
}
﻿namespace Transfer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.btStop = new System.Windows.Forms.Button();
            this.textRadioButton = new System.Windows.Forms.RadioButton();
            this.fileRadioButton = new System.Windows.Forms.RadioButton();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 98);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(134, 40);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(742, 21);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "D:\\ContinuesWorkspace\\savory-android-cms\\20180603114134\\savory-android-cms-releas" +
    "e-20180603114134.apk";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(167, 98);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(136, 40);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // textRadioButton
            // 
            this.textRadioButton.AutoSize = true;
            this.textRadioButton.Checked = true;
            this.textRadioButton.Location = new System.Drawing.Point(443, 167);
            this.textRadioButton.Name = "textRadioButton";
            this.textRadioButton.Size = new System.Drawing.Size(47, 16);
            this.textRadioButton.TabIndex = 5;
            this.textRadioButton.TabStop = true;
            this.textRadioButton.Text = "文本";
            this.textRadioButton.UseVisualStyleBackColor = true;
            // 
            // fileRadioButton
            // 
            this.fileRadioButton.AutoSize = true;
            this.fileRadioButton.Location = new System.Drawing.Point(443, 203);
            this.fileRadioButton.Name = "fileRadioButton";
            this.fileRadioButton.Size = new System.Drawing.Size(47, 16);
            this.fileRadioButton.TabIndex = 6;
            this.fileRadioButton.Text = "文件";
            this.fileRadioButton.UseVisualStyleBackColor = true;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 52);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(742, 21);
            this.outputTextBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 509);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.fileRadioButton);
            this.Controls.Add(this.textRadioButton);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btStart);
            this.Name = "MainForm";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.RadioButton textRadioButton;
        private System.Windows.Forms.RadioButton fileRadioButton;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}


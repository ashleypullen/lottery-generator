
namespace lottery_numbers
{
    partial class Form1
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
            this.btnNumbers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNums = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstLotteryNums = new System.Windows.Forms.ListBox();
            this.panelNums.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNumbers
            // 
            this.btnNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNumbers.Location = new System.Drawing.Point(166, 308);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(198, 71);
            this.btnNumbers.TabIndex = 0;
            this.btnNumbers.Text = "Lottery Numbers";
            this.btnNumbers.UseVisualStyleBackColor = false;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panelNums
            // 
            this.panelNums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelNums.Controls.Add(this.label7);
            this.panelNums.Controls.Add(this.label6);
            this.panelNums.Controls.Add(this.label1);
            this.panelNums.Controls.Add(this.label2);
            this.panelNums.Controls.Add(this.label5);
            this.panelNums.Controls.Add(this.label3);
            this.panelNums.Controls.Add(this.label4);
            this.panelNums.Location = new System.Drawing.Point(10, 202);
            this.panelNums.Name = "panelNums";
            this.panelNums.Size = new System.Drawing.Size(512, 100);
            this.panelNums.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(432, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 62);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(358, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 62);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(82, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(289, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 62);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(151, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 62);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(220, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 62);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // lstLotteryNums
            // 
            this.lstLotteryNums.FormattingEnabled = true;
            this.lstLotteryNums.Location = new System.Drawing.Point(151, 12);
            this.lstLotteryNums.Name = "lstLotteryNums";
            this.lstLotteryNums.Size = new System.Drawing.Size(225, 173);
            this.lstLotteryNums.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(129)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(534, 391);
            this.Controls.Add(this.lstLotteryNums);
            this.Controls.Add(this.panelNums);
            this.Controls.Add(this.btnNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelNums.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNums;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstLotteryNums;
    }
}


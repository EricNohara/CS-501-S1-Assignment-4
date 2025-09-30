namespace Textbook_Problem_7_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fruitPic1 = new PictureBox();
            fruitPic2 = new PictureBox();
            fruitPic3 = new PictureBox();
            amountTextBox = new TextBox();
            amountLabel = new Label();
            spinBtn = new Button();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)fruitPic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fruitPic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fruitPic3).BeginInit();
            SuspendLayout();
            // 
            // fruitPic1
            // 
            fruitPic1.Image = Properties.Resources.Apple;
            fruitPic1.Location = new Point(278, 194);
            fruitPic1.Name = "fruitPic1";
            fruitPic1.Size = new Size(126, 130);
            fruitPic1.TabIndex = 0;
            fruitPic1.TabStop = false;
            // 
            // fruitPic2
            // 
            fruitPic2.Image = Properties.Resources.Cherries;
            fruitPic2.Location = new Point(474, 194);
            fruitPic2.Name = "fruitPic2";
            fruitPic2.Size = new Size(144, 130);
            fruitPic2.TabIndex = 1;
            fruitPic2.TabStop = false;
            // 
            // fruitPic3
            // 
            fruitPic3.Image = Properties.Resources.Banana;
            fruitPic3.Location = new Point(674, 194);
            fruitPic3.Name = "fruitPic3";
            fruitPic3.Size = new Size(131, 130);
            fruitPic3.TabIndex = 2;
            fruitPic3.TabStop = false;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(474, 386);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(200, 39);
            amountTextBox.TabIndex = 3;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(243, 386);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(225, 32);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount Inserted: $ ";
            // 
            // spinBtn
            // 
            spinBtn.Location = new Point(373, 468);
            spinBtn.Name = "spinBtn";
            spinBtn.Size = new Size(150, 46);
            spinBtn.TabIndex = 5;
            spinBtn.Text = "Spin";
            spinBtn.UseVisualStyleBackColor = true;
            spinBtn.Click += spinBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(550, 468);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(150, 46);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 640);
            Controls.Add(exitBtn);
            Controls.Add(spinBtn);
            Controls.Add(amountLabel);
            Controls.Add(amountTextBox);
            Controls.Add(fruitPic3);
            Controls.Add(fruitPic2);
            Controls.Add(fruitPic1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fruitPic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fruitPic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fruitPic3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fruitPic1;
        private PictureBox fruitPic2;
        private PictureBox fruitPic3;
        private TextBox amountTextBox;
        private Label amountLabel;
        private Button spinBtn;
        private Button exitBtn;
    }
}

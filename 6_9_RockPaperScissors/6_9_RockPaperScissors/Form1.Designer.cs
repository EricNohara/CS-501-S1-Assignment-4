namespace _6_9_RockPaperScissors
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
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lblResult = new Label();
            lblComputer = new Label();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(198, 122);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(75, 23);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click_1;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(198, 180);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(75, 23);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(198, 235);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(75, 23);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(403, 150);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result";
            // 
            // lblComputer
            // 
            lblComputer.AutoSize = true;
            lblComputer.ForeColor = SystemColors.ControlText;
            lblComputer.Location = new Point(403, 188);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(104, 15);
            lblComputer.TabIndex = 4;
            lblComputer.Text = "Computers choice";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblComputer);
            Controls.Add(lblResult);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lblResult;
        private Label lblComputer;
    }
}

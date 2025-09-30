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
            btnRock.Location = new Point(368, 260);
            btnRock.Margin = new Padding(6, 6, 6, 6);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(139, 49);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click_1;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(368, 384);
            btnPaper.Margin = new Padding(6, 6, 6, 6);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(139, 49);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(368, 501);
            btnScissors.Margin = new Padding(6, 6, 6, 6);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(139, 49);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(748, 320);
            lblResult.Margin = new Padding(6, 0, 6, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(78, 32);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result";
            // 
            // lblComputer
            // 
            lblComputer.AutoSize = true;
            lblComputer.ForeColor = SystemColors.ControlText;
            lblComputer.Location = new Point(748, 401);
            lblComputer.Margin = new Padding(6, 0, 6, 0);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(207, 32);
            lblComputer.TabIndex = 4;
            lblComputer.Text = "Computers choice";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(lblComputer);
            Controls.Add(lblResult);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
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

namespace _7_6_name_search
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
            txtNameInput = new TextBox();
            btnCheckName = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtNameInput
            // 
            txtNameInput.Location = new Point(360, 125);
            txtNameInput.Name = "txtNameInput";
            txtNameInput.Size = new Size(100, 23);
            txtNameInput.TabIndex = 0;
            txtNameInput.Text = "Input a name";
            // 
            // btnCheckName
            // 
            btnCheckName.Location = new Point(371, 176);
            btnCheckName.Name = "btnCheckName";
            btnCheckName.Size = new Size(75, 23);
            btnCheckName.TabIndex = 1;
            btnCheckName.Text = "Check name";
            btnCheckName.UseVisualStyleBackColor = true;
            btnCheckName.Click += btnCheckName_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(328, 231);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(168, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Was it a most common name?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCheckName);
            Controls.Add(txtNameInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameInput;
        private Button btnCheckName;
        private Label lblResult;
    }
}

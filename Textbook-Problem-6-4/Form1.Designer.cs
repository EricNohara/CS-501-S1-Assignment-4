namespace Textbook_Problem_6_4
{
    partial class form_main
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
            components = new System.ComponentModel.Container();
            group_oilLube = new GroupBox();
            check_lubeJob = new CheckBox();
            check_oilChange = new CheckBox();
            group_flushes = new GroupBox();
            check_transmissionFlush = new CheckBox();
            check_radiatorFlush = new CheckBox();
            group_misc = new GroupBox();
            check_tireRotation = new CheckBox();
            check_replaceMuffler = new CheckBox();
            check_inspection = new CheckBox();
            group_partsLabor = new GroupBox();
            label_hours = new Label();
            label_parts = new Label();
            text_hours = new TextBox();
            text_parts = new TextBox();
            group_summary = new GroupBox();
            text_feesSummary = new TextBox();
            text_taxSummary = new TextBox();
            text_partsSummary = new TextBox();
            text_serviceLaborSummary = new TextBox();
            label_totalFeesSummary = new Label();
            label_taxSummary = new Label();
            label_partsSummary = new Label();
            label_serviceLaborSummary = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button_calculate = new Button();
            button_clear = new Button();
            button_exit = new Button();
            group_oilLube.SuspendLayout();
            group_flushes.SuspendLayout();
            group_misc.SuspendLayout();
            group_partsLabor.SuspendLayout();
            group_summary.SuspendLayout();
            SuspendLayout();
            // 
            // group_oilLube
            // 
            group_oilLube.Controls.Add(check_lubeJob);
            group_oilLube.Controls.Add(check_oilChange);
            group_oilLube.Location = new Point(12, 12);
            group_oilLube.Name = "group_oilLube";
            group_oilLube.Size = new Size(299, 116);
            group_oilLube.TabIndex = 0;
            group_oilLube.TabStop = false;
            group_oilLube.Text = "Oil and Lube";
            // 
            // check_lubeJob
            // 
            check_lubeJob.AutoSize = true;
            check_lubeJob.Location = new Point(23, 70);
            check_lubeJob.Name = "check_lubeJob";
            check_lubeJob.Size = new Size(128, 24);
            check_lubeJob.TabIndex = 1;
            check_lubeJob.Text = "Lube Job ($40)";
            check_lubeJob.UseVisualStyleBackColor = true;
            // 
            // check_oilChange
            // 
            check_oilChange.AutoSize = true;
            check_oilChange.Location = new Point(23, 40);
            check_oilChange.Name = "check_oilChange";
            check_oilChange.Size = new Size(142, 24);
            check_oilChange.TabIndex = 0;
            check_oilChange.Text = "Oil Change ($50)";
            check_oilChange.UseVisualStyleBackColor = true;
            // 
            // group_flushes
            // 
            group_flushes.Controls.Add(check_transmissionFlush);
            group_flushes.Controls.Add(check_radiatorFlush);
            group_flushes.Location = new Point(327, 12);
            group_flushes.Name = "group_flushes";
            group_flushes.Size = new Size(299, 116);
            group_flushes.TabIndex = 1;
            group_flushes.TabStop = false;
            group_flushes.Text = "Flushes";
            // 
            // check_transmissionFlush
            // 
            check_transmissionFlush.AutoSize = true;
            check_transmissionFlush.Location = new Point(23, 70);
            check_transmissionFlush.Name = "check_transmissionFlush";
            check_transmissionFlush.Size = new Size(198, 24);
            check_transmissionFlush.TabIndex = 3;
            check_transmissionFlush.Text = "Transmission Flush ($120)";
            check_transmissionFlush.UseVisualStyleBackColor = true;
            // 
            // check_radiatorFlush
            // 
            check_radiatorFlush.AutoSize = true;
            check_radiatorFlush.Location = new Point(23, 40);
            check_radiatorFlush.Name = "check_radiatorFlush";
            check_radiatorFlush.Size = new Size(171, 24);
            check_radiatorFlush.TabIndex = 2;
            check_radiatorFlush.Text = "Radiator Flush ($100)";
            check_radiatorFlush.UseVisualStyleBackColor = true;
            // 
            // group_misc
            // 
            group_misc.Controls.Add(check_tireRotation);
            group_misc.Controls.Add(check_replaceMuffler);
            group_misc.Controls.Add(check_inspection);
            group_misc.Location = new Point(12, 134);
            group_misc.Name = "group_misc";
            group_misc.Size = new Size(299, 147);
            group_misc.TabIndex = 1;
            group_misc.TabStop = false;
            group_misc.Text = "Misc";
            // 
            // check_tireRotation
            // 
            check_tireRotation.AutoSize = true;
            check_tireRotation.Location = new Point(23, 102);
            check_tireRotation.Name = "check_tireRotation";
            check_tireRotation.Size = new Size(155, 24);
            check_tireRotation.TabIndex = 6;
            check_tireRotation.Text = "Tire Rotation ($25)";
            check_tireRotation.UseVisualStyleBackColor = true;
            // 
            // check_replaceMuffler
            // 
            check_replaceMuffler.AutoSize = true;
            check_replaceMuffler.Location = new Point(23, 72);
            check_replaceMuffler.Name = "check_replaceMuffler";
            check_replaceMuffler.Size = new Size(182, 24);
            check_replaceMuffler.TabIndex = 5;
            check_replaceMuffler.Text = "Replace Muffler ($150)";
            check_replaceMuffler.UseVisualStyleBackColor = true;
            // 
            // check_inspection
            // 
            check_inspection.AutoSize = true;
            check_inspection.Location = new Point(23, 42);
            check_inspection.Name = "check_inspection";
            check_inspection.Size = new Size(137, 24);
            check_inspection.TabIndex = 4;
            check_inspection.Text = "Inspection ($35)";
            check_inspection.UseVisualStyleBackColor = true;
            // 
            // group_partsLabor
            // 
            group_partsLabor.Controls.Add(label_hours);
            group_partsLabor.Controls.Add(label_parts);
            group_partsLabor.Controls.Add(text_hours);
            group_partsLabor.Controls.Add(text_parts);
            group_partsLabor.Location = new Point(327, 134);
            group_partsLabor.Name = "group_partsLabor";
            group_partsLabor.Size = new Size(299, 147);
            group_partsLabor.TabIndex = 1;
            group_partsLabor.TabStop = false;
            group_partsLabor.Text = "Parts and Labor";
            // 
            // label_hours
            // 
            label_hours.AutoSize = true;
            label_hours.Location = new Point(42, 82);
            label_hours.Name = "label_hours";
            label_hours.Size = new Size(103, 20);
            label_hours.TabIndex = 3;
            label_hours.Text = "Labor (Hours):";
            // 
            // label_parts
            // 
            label_parts.AutoSize = true;
            label_parts.Location = new Point(102, 49);
            label_parts.Name = "label_parts";
            label_parts.Size = new Size(43, 20);
            label_parts.TabIndex = 2;
            label_parts.Text = "Parts:";
            // 
            // text_hours
            // 
            text_hours.BackColor = SystemColors.Window;
            text_hours.Location = new Point(151, 75);
            text_hours.Name = "text_hours";
            text_hours.Size = new Size(125, 27);
            text_hours.TabIndex = 1;
            // 
            // text_parts
            // 
            text_parts.BackColor = SystemColors.Window;
            text_parts.Location = new Point(151, 42);
            text_parts.Name = "text_parts";
            text_parts.Size = new Size(125, 27);
            text_parts.TabIndex = 0;
            // 
            // group_summary
            // 
            group_summary.Controls.Add(text_feesSummary);
            group_summary.Controls.Add(text_taxSummary);
            group_summary.Controls.Add(text_partsSummary);
            group_summary.Controls.Add(text_serviceLaborSummary);
            group_summary.Controls.Add(label_totalFeesSummary);
            group_summary.Controls.Add(label_taxSummary);
            group_summary.Controls.Add(label_partsSummary);
            group_summary.Controls.Add(label_serviceLaborSummary);
            group_summary.Location = new Point(12, 287);
            group_summary.Name = "group_summary";
            group_summary.Size = new Size(614, 178);
            group_summary.TabIndex = 2;
            group_summary.TabStop = false;
            group_summary.Text = "Summary";
            // 
            // text_feesSummary
            // 
            text_feesSummary.BackColor = SystemColors.Window;
            text_feesSummary.Location = new Point(305, 135);
            text_feesSummary.Name = "text_feesSummary";
            text_feesSummary.ReadOnly = true;
            text_feesSummary.Size = new Size(125, 27);
            text_feesSummary.TabIndex = 10;
            // 
            // text_taxSummary
            // 
            text_taxSummary.BackColor = SystemColors.Window;
            text_taxSummary.Location = new Point(305, 102);
            text_taxSummary.Name = "text_taxSummary";
            text_taxSummary.ReadOnly = true;
            text_taxSummary.Size = new Size(125, 27);
            text_taxSummary.TabIndex = 9;
            // 
            // text_partsSummary
            // 
            text_partsSummary.BackColor = SystemColors.Window;
            text_partsSummary.Location = new Point(305, 68);
            text_partsSummary.Name = "text_partsSummary";
            text_partsSummary.ReadOnly = true;
            text_partsSummary.Size = new Size(125, 27);
            text_partsSummary.TabIndex = 8;
            // 
            // text_serviceLaborSummary
            // 
            text_serviceLaborSummary.BackColor = SystemColors.Window;
            text_serviceLaborSummary.Location = new Point(305, 35);
            text_serviceLaborSummary.Name = "text_serviceLaborSummary";
            text_serviceLaborSummary.ReadOnly = true;
            text_serviceLaborSummary.Size = new Size(125, 27);
            text_serviceLaborSummary.TabIndex = 4;
            // 
            // label_totalFeesSummary
            // 
            label_totalFeesSummary.AutoSize = true;
            label_totalFeesSummary.Location = new Point(221, 138);
            label_totalFeesSummary.Name = "label_totalFeesSummary";
            label_totalFeesSummary.Size = new Size(78, 20);
            label_totalFeesSummary.TabIndex = 7;
            label_totalFeesSummary.Text = "Total Fees:";
            // 
            // label_taxSummary
            // 
            label_taxSummary.AutoSize = true;
            label_taxSummary.Location = new Point(198, 105);
            label_taxSummary.Name = "label_taxSummary";
            label_taxSummary.Size = new Size(101, 20);
            label_taxSummary.TabIndex = 6;
            label_taxSummary.Text = "Tax (on parts):";
            // 
            // label_partsSummary
            // 
            label_partsSummary.AutoSize = true;
            label_partsSummary.Location = new Point(256, 71);
            label_partsSummary.Name = "label_partsSummary";
            label_partsSummary.Size = new Size(43, 20);
            label_partsSummary.TabIndex = 5;
            label_partsSummary.Text = "Parts:";
            // 
            // label_serviceLaborSummary
            // 
            label_serviceLaborSummary.AutoSize = true;
            label_serviceLaborSummary.Location = new Point(169, 38);
            label_serviceLaborSummary.Name = "label_serviceLaborSummary";
            label_serviceLaborSummary.Size = new Size(130, 20);
            label_serviceLaborSummary.TabIndex = 4;
            label_serviceLaborSummary.Text = "Service and Labor:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button_calculate
            // 
            button_calculate.Location = new Point(96, 506);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(94, 29);
            button_calculate.TabIndex = 11;
            button_calculate.Text = "Calculate";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += button_calculate_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(268, 506);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 12;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(429, 506);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 13;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // form_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 570);
            Controls.Add(button_exit);
            Controls.Add(button_clear);
            Controls.Add(button_calculate);
            Controls.Add(group_summary);
            Controls.Add(group_partsLabor);
            Controls.Add(group_misc);
            Controls.Add(group_flushes);
            Controls.Add(group_oilLube);
            Name = "form_main";
            Text = "Joe's Automotive";
            group_oilLube.ResumeLayout(false);
            group_oilLube.PerformLayout();
            group_flushes.ResumeLayout(false);
            group_flushes.PerformLayout();
            group_misc.ResumeLayout(false);
            group_misc.PerformLayout();
            group_partsLabor.ResumeLayout(false);
            group_partsLabor.PerformLayout();
            group_summary.ResumeLayout(false);
            group_summary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox group_oilLube;
        private CheckBox check_lubeJob;
        private CheckBox check_oilChange;
        private GroupBox group_flushes;
        private CheckBox check_transmissionFlush;
        private CheckBox check_radiatorFlush;
        private GroupBox group_misc;
        private CheckBox check_tireRotation;
        private CheckBox check_replaceMuffler;
        private CheckBox check_inspection;
        private GroupBox group_partsLabor;
        private GroupBox group_summary;
        private Label label_hours;
        private Label label_parts;
        private TextBox text_hours;
        private TextBox text_parts;
        private ContextMenuStrip contextMenuStrip1;
        private Label label_totalFeesSummary;
        private Label label_taxSummary;
        private Label label_partsSummary;
        private Label label_serviceLaborSummary;
        private TextBox text_feesSummary;
        private TextBox text_taxSummary;
        private TextBox text_partsSummary;
        private TextBox text_serviceLaborSummary;
        private Button button_calculate;
        private Button button_clear;
        private Button button_exit;
    }
}

namespace BaobabRidgeRecords
{
    partial class MainForm
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
            btnSummary = new Button();
            lblTotalValue = new Label();
            lblAverageAgeValue = new Label();
            lblAvgRecoveryScore = new Label();
            lblStableValue = new Label();
            lblRecoveringStatus = new Label();
            lblReleaseReadyStatus = new Label();
            lblSeriousStatus = new Label();
            lblCriticalStatus = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblAvgAge = new Label();
            lblTotalAnimals = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnSummary
            // 
            btnSummary.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSummary.Location = new Point(24, 42);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(122, 57);
            btnSummary.TabIndex = 0;
            btnSummary.Text = "Generate Summary";
            btnSummary.UseVisualStyleBackColor = true;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 12F);
            lblTotalValue.Location = new Point(24, 117);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(109, 21);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "Total Animals: ";
            // 
            // lblAverageAgeValue
            // 
            lblAverageAgeValue.AutoSize = true;
            lblAverageAgeValue.Font = new Font("Segoe UI", 12F);
            lblAverageAgeValue.Location = new Point(24, 178);
            lblAverageAgeValue.Name = "lblAverageAgeValue";
            lblAverageAgeValue.Size = new Size(152, 21);
            lblAverageAgeValue.TabIndex = 2;
            lblAverageAgeValue.Text = "Average Age (years):";
            // 
            // lblAvgRecoveryScore
            // 
            lblAvgRecoveryScore.AutoSize = true;
            lblAvgRecoveryScore.Font = new Font("Segoe UI", 12F);
            lblAvgRecoveryScore.Location = new Point(24, 246);
            lblAvgRecoveryScore.Name = "lblAvgRecoveryScore";
            lblAvgRecoveryScore.Size = new Size(178, 21);
            lblAvgRecoveryScore.TabIndex = 3;
            lblAvgRecoveryScore.Text = "Average Recovery Score";
            // 
            // lblStableValue
            // 
            lblStableValue.AutoSize = true;
            lblStableValue.Font = new Font("Segoe UI", 12F);
            lblStableValue.Location = new Point(214, 487);
            lblStableValue.Name = "lblStableValue";
            lblStableValue.Size = new Size(19, 21);
            lblStableValue.TabIndex = 4;
            lblStableValue.Text = "0";
            // 
            // lblRecoveringStatus
            // 
            lblRecoveringStatus.AutoSize = true;
            lblRecoveringStatus.Font = new Font("Segoe UI", 12F);
            lblRecoveringStatus.Location = new Point(214, 531);
            lblRecoveringStatus.Name = "lblRecoveringStatus";
            lblRecoveringStatus.Size = new Size(19, 21);
            lblRecoveringStatus.TabIndex = 5;
            lblRecoveringStatus.Text = "0";
            // 
            // lblReleaseReadyStatus
            // 
            lblReleaseReadyStatus.AutoSize = true;
            lblReleaseReadyStatus.Font = new Font("Segoe UI", 12F);
            lblReleaseReadyStatus.Location = new Point(214, 579);
            lblReleaseReadyStatus.Name = "lblReleaseReadyStatus";
            lblReleaseReadyStatus.Size = new Size(19, 21);
            lblReleaseReadyStatus.TabIndex = 6;
            lblReleaseReadyStatus.Text = "0";
            // 
            // lblSeriousStatus
            // 
            lblSeriousStatus.AutoSize = true;
            lblSeriousStatus.Font = new Font("Segoe UI", 12F);
            lblSeriousStatus.Location = new Point(214, 437);
            lblSeriousStatus.Name = "lblSeriousStatus";
            lblSeriousStatus.Size = new Size(19, 21);
            lblSeriousStatus.TabIndex = 7;
            lblSeriousStatus.Text = "0";
            // 
            // lblCriticalStatus
            // 
            lblCriticalStatus.AutoSize = true;
            lblCriticalStatus.Font = new Font("Segoe UI", 12F);
            lblCriticalStatus.Location = new Point(214, 388);
            lblCriticalStatus.Name = "lblCriticalStatus";
            lblCriticalStatus.Size = new Size(19, 21);
            lblCriticalStatus.TabIndex = 8;
            lblCriticalStatus.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, 487);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 13;
            label1.Text = "Stable:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 531);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 12;
            label2.Text = "Recovering:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 579);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 11;
            label3.Text = "Release-Ready:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 437);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 10;
            label4.Text = "Serious: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 388);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 9;
            label5.Text = "Critical: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(214, 246);
            label6.Name = "label6";
            label6.Size = new Size(19, 21);
            label6.TabIndex = 18;
            label6.Text = "0";
            // 
            // lblAvgAge
            // 
            lblAvgAge.AutoSize = true;
            lblAvgAge.Font = new Font("Segoe UI", 12F);
            lblAvgAge.Location = new Point(214, 178);
            lblAvgAge.Name = "lblAvgAge";
            lblAvgAge.Size = new Size(19, 21);
            lblAvgAge.TabIndex = 15;
            lblAvgAge.Text = "0";
            // 
            // lblTotalAnimals
            // 
            lblTotalAnimals.AutoSize = true;
            lblTotalAnimals.Font = new Font("Segoe UI", 12F);
            lblTotalAnimals.Location = new Point(214, 117);
            lblTotalAnimals.Name = "lblTotalAnimals";
            lblTotalAnimals.Size = new Size(19, 21);
            lblTotalAnimals.TabIndex = 14;
            lblTotalAnimals.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 312);
            label7.Name = "label7";
            label7.Size = new Size(147, 21);
            label7.TabIndex = 19;
            label7.Text = "Animals Per Status:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 672);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblAvgAge);
            Controls.Add(lblTotalAnimals);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblCriticalStatus);
            Controls.Add(lblSeriousStatus);
            Controls.Add(lblReleaseReadyStatus);
            Controls.Add(lblRecoveringStatus);
            Controls.Add(lblStableValue);
            Controls.Add(lblAvgRecoveryScore);
            Controls.Add(lblAverageAgeValue);
            Controls.Add(lblTotalValue);
            Controls.Add(btnSummary);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSummary;
        private Label lblTotalValue;
        private Label lblAverageAgeValue;
        private Label lblAvgRecoveryScore;
        private Label lblStableValue;
        private Label lblRecoveringStatus;
        private Label lblReleaseReadyStatus;
        private Label lblSeriousStatus;
        private Label lblCriticalStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblAvgAge;
        private Label lblTotalAnimals;
        private Label label7;
    }
}

namespace Lesson1_Askisi_1
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
            btnSum = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblNum2 = new Label();
            txtNum3 = new TextBox();
            lblNum1 = new Label();
            SuspendLayout();
            // 
            // btnSum
            // 
            btnSum.BackColor = SystemColors.ControlDarkDark;
            btnSum.FlatAppearance.BorderSize = 3;
            btnSum.Location = new Point(316, 201);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(105, 58);
            btnSum.TabIndex = 0;
            btnSum.Text = "Υπολογισμός";
            btnSum.UseVisualStyleBackColor = false;
            btnSum.Click += btnSum_Click;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 13F);
            txtNum1.Location = new Point(177, 116);
            txtNum1.Multiline = true;
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(134, 53);
            txtNum1.TabIndex = 2;
            txtNum1.TextAlign = HorizontalAlignment.Center;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 13F);
            txtNum2.Location = new Point(437, 116);
            txtNum2.Multiline = true;
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(134, 53);
            txtNum2.TabIndex = 4;
            txtNum2.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 15F);
            lblNum2.Location = new Point(437, 66);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(103, 28);
            lblNum2.TabIndex = 3;
            lblNum2.Text = "Αριθμός 2";
            // 
            // txtNum3
            // 
            txtNum3.Font = new Font("Segoe UI", 13F);
            txtNum3.Location = new Point(276, 293);
            txtNum3.Multiline = true;
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(201, 82);
            txtNum3.TabIndex = 5;
            txtNum3.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 15F);
            lblNum1.Location = new Point(177, 66);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(103, 28);
            lblNum1.TabIndex = 6;
            lblNum1.Text = "Αριθμός 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(874, 539);
            Controls.Add(lblNum1);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnSum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSum;
        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblNum2;
        private TextBox txtNum3;
        private Label lblNum1;
    }
}

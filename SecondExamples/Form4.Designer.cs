namespace SecondExamples
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            optSaloon = new RadioButton();
            optMinibus = new RadioButton();
            optHiway = new RadioButton();
            lbDay = new Label();
            txtDay = new TextBox();
            calculateBtn = new Button();
            closeBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optSaloon);
            groupBox1.Controls.Add(optMinibus);
            groupBox1.Controls.Add(optHiway);
            groupBox1.Location = new Point(79, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Type of Cars";
            // 
            // optSaloon
            // 
            optSaloon.AutoSize = true;
            optSaloon.Location = new Point(22, 150);
            optSaloon.Name = "optSaloon";
            optSaloon.Size = new Size(76, 24);
            optSaloon.TabIndex = 2;
            optSaloon.TabStop = true;
            optSaloon.Text = "Saloon";
            optSaloon.UseVisualStyleBackColor = true;
            optSaloon.CheckedChanged += optSaloon_CheckedChanged;
            // 
            // optMinibus
            // 
            optMinibus.AutoSize = true;
            optMinibus.Location = new Point(22, 105);
            optMinibus.Name = "optMinibus";
            optMinibus.Size = new Size(86, 24);
            optMinibus.TabIndex = 1;
            optMinibus.TabStop = true;
            optMinibus.Text = "Mini Bus";
            optMinibus.UseVisualStyleBackColor = true;
            optMinibus.CheckedChanged += optMinibus_CheckedChanged;
            // 
            // optHiway
            // 
            optHiway.AutoSize = true;
            optHiway.Location = new Point(22, 54);
            optHiway.Name = "optHiway";
            optHiway.Size = new Size(155, 24);
            optHiway.TabIndex = 0;
            optHiway.TabStop = true;
            optHiway.Text = "Hi Way Air con Bus";
            optHiway.UseVisualStyleBackColor = true;
            optHiway.CheckedChanged += optHiway_CheckedChanged;
            // 
            // lbDay
            // 
            lbDay.AutoSize = true;
            lbDay.Location = new Point(79, 338);
            lbDay.Name = "lbDay";
            lbDay.Size = new Size(117, 20);
            lbDay.TabIndex = 3;
            lbDay.Text = "Number of Days";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(294, 335);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(254, 27);
            txtDay.TabIndex = 4;
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(79, 408);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(153, 50);
            calculateBtn.TabIndex = 5;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(294, 408);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(145, 50);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 490);
            Controls.Add(closeBtn);
            Controls.Add(calculateBtn);
            Controls.Add(txtDay);
            Controls.Add(lbDay);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Page 19 Eg 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton optSaloon;
        private RadioButton optMinibus;
        private RadioButton optHiway;
        private Label lbDay;
        private TextBox txtDay;
        private Button calculateBtn;
        private Button closeBtn;
    }
}
namespace CSharpExercises2
{
    partial class Form6
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
            rWHLabel = new Label();
            txtRWHour = new TextBox();
            wRLabel = new Label();
            oWHLabel = new Label();
            txtWageRate = new TextBox();
            txtOWHour = new TextBox();
            calculateBtn = new Button();
            SuspendLayout();
            // 
            // rWHLabel
            // 
            rWHLabel.AutoSize = true;
            rWHLabel.Location = new Point(102, 75);
            rWHLabel.Name = "rWHLabel";
            rWHLabel.Size = new Size(158, 20);
            rWHLabel.TabIndex = 0;
            rWHLabel.Text = "Regular Worked Hours";
            // 
            // txtRWHour
            // 
            txtRWHour.Location = new Point(326, 75);
            txtRWHour.Name = "txtRWHour";
            txtRWHour.Size = new Size(125, 27);
            txtRWHour.TabIndex = 1;
            // 
            // wRLabel
            // 
            wRLabel.AutoSize = true;
            wRLabel.Location = new Point(102, 124);
            wRLabel.Name = "wRLabel";
            wRLabel.Size = new Size(81, 20);
            wRLabel.TabIndex = 2;
            wRLabel.Text = "Wage Rate";
            // 
            // oWHLabel
            // 
            oWHLabel.AutoSize = true;
            oWHLabel.Location = new Point(102, 174);
            oWHLabel.Name = "oWHLabel";
            oWHLabel.Size = new Size(175, 20);
            oWHLabel.TabIndex = 3;
            oWHLabel.Text = "Over Time Worked Hours";
            // 
            // txtWageRate
            // 
            txtWageRate.Location = new Point(326, 121);
            txtWageRate.Name = "txtWageRate";
            txtWageRate.Size = new Size(125, 27);
            txtWageRate.TabIndex = 4;
            // 
            // txtOWHour
            // 
            txtOWHour.Location = new Point(326, 167);
            txtOWHour.Name = "txtOWHour";
            txtOWHour.Size = new Size(125, 27);
            txtOWHour.TabIndex = 5;
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(186, 277);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(170, 51);
            calculateBtn.TabIndex = 6;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculateBtn);
            Controls.Add(txtOWHour);
            Controls.Add(txtWageRate);
            Controls.Add(oWHLabel);
            Controls.Add(wRLabel);
            Controls.Add(txtRWHour);
            Controls.Add(rWHLabel);
            Name = "Form6";
            Text = "Page 21 e 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label rWHLabel;
        private TextBox txtRWHour;
        private Label wRLabel;
        private Label oWHLabel;
        private TextBox txtWageRate;
        private TextBox txtOWHour;
        private Button calculateBtn;
    }
}
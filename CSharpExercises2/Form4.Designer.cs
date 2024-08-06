namespace CSharpExercises2
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
            lSalary = new Label();
            txtSalary = new TextBox();
            calculateBtn = new Button();
            SuspendLayout();
            // 
            // lSalary
            // 
            lSalary.AutoSize = true;
            lSalary.Font = new Font("Segoe UI", 9F);
            lSalary.Location = new Point(188, 117);
            lSalary.Name = "lSalary";
            lSalary.Size = new Size(87, 20);
            lSalary.TabIndex = 0;
            lSalary.Text = "Enter Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(368, 110);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(125, 27);
            txtSalary.TabIndex = 1;
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(246, 200);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(205, 40);
            calculateBtn.TabIndex = 2;
            calculateBtn.Text = "Find bonus and payment";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculateBtn);
            Controls.Add(txtSalary);
            Controls.Add(lSalary);
            Name = "Form4";
            Text = "Page 21 ex 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lSalary;
        private TextBox txtSalary;
        private Button calculateBtn;
    }
}
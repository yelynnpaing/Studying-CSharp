namespace CSharpExercises2
{
    partial class Form2
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
            label1 = new Label();
            calculateBtn = new Button();
            txtFirstInt = new TextBox();
            label2 = new Label();
            txtSecondInt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 90);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "First Integer";
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(272, 252);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(94, 29);
            calculateBtn.TabIndex = 1;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // txtFirstInt
            // 
            txtFirstInt.Location = new Point(370, 83);
            txtFirstInt.Name = "txtFirstInt";
            txtFirstInt.Size = new Size(125, 27);
            txtFirstInt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 162);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Second Integer";
            // 
            // txtSecondInt
            // 
            txtSecondInt.Location = new Point(370, 155);
            txtSecondInt.Name = "txtSecondInt";
            txtSecondInt.Size = new Size(125, 27);
            txtSecondInt.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSecondInt);
            Controls.Add(label2);
            Controls.Add(txtFirstInt);
            Controls.Add(calculateBtn);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Page 21 ex 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button calculateBtn;
        private TextBox txtFirstInt;
        private Label label2;
        private TextBox txtSecondInt;
    }
}
namespace CSharpExercises2
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
            label1 = new Label();
            txtFirstInt = new TextBox();
            label2 = new Label();
            txtSecondInt = new TextBox();
            findMaxiBtn = new Button();
            label3 = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 96);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "First Integer number";
            label1.Click += label1_Click;
            // 
            // txtFirstInt
            // 
            txtFirstInt.Location = new Point(381, 89);
            txtFirstInt.Name = "txtFirstInt";
            txtFirstInt.Size = new Size(92, 27);
            txtFirstInt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 163);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 2;
            label2.Text = "Second Integer number";
            // 
            // txtSecondInt
            // 
            txtSecondInt.Location = new Point(381, 163);
            txtSecondInt.Name = "txtSecondInt";
            txtSecondInt.Size = new Size(92, 27);
            txtSecondInt.TabIndex = 3;
            // 
            // findMaxiBtn
            // 
            findMaxiBtn.Location = new Point(148, 310);
            findMaxiBtn.Name = "findMaxiBtn";
            findMaxiBtn.Size = new Size(230, 48);
            findMaxiBtn.TabIndex = 4;
            findMaxiBtn.Text = "Find Maximum number";
            findMaxiBtn.UseVisualStyleBackColor = true;
            findMaxiBtn.Click += findMaxiBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 243);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 5;
            label3.Text = "Maximum number is ";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(381, 243);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(92, 27);
            txtResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(label3);
            Controls.Add(findMaxiBtn);
            Controls.Add(txtSecondInt);
            Controls.Add(label2);
            Controls.Add(txtFirstInt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Page 21 ex 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstInt;
        private Label label2;
        private TextBox txtSecondInt;
        private Button findMaxiBtn;
        private Label label3;
        private TextBox txtResult;
    }
}

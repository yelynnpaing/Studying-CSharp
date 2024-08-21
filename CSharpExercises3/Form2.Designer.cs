namespace CSharpExercises3
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
            sumBtn = new Button();
            label1 = new Label();
            resultTxt = new TextBox();
            SuspendLayout();
            // 
            // sumBtn
            // 
            sumBtn.Location = new Point(366, 214);
            sumBtn.Name = "sumBtn";
            sumBtn.Size = new Size(94, 29);
            sumBtn.TabIndex = 0;
            sumBtn.Text = "Sum";
            sumBtn.UseVisualStyleBackColor = true;
            sumBtn.Click += sumBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 77);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 1;
            label1.Text = "Sum of Odd integers from 1 to 99  -  ";
            // 
            // resultTxt
            // 
            resultTxt.Location = new Point(457, 70);
            resultTxt.Name = "resultTxt";
            resultTxt.Size = new Size(125, 27);
            resultTxt.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultTxt);
            Controls.Add(label1);
            Controls.Add(sumBtn);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sumBtn;
        private Label label1;
        private TextBox resultTxt;
    }
}
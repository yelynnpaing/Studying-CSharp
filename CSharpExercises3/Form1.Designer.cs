namespace CSharpExercises3
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
            sumBtn = new Button();
            sumLabel = new Label();
            resultTxt = new TextBox();
            SuspendLayout();
            // 
            // sumBtn
            // 
            sumBtn.Location = new Point(296, 190);
            sumBtn.Name = "sumBtn";
            sumBtn.Size = new Size(122, 36);
            sumBtn.TabIndex = 0;
            sumBtn.Text = "Sum";
            sumBtn.UseVisualStyleBackColor = true;
            sumBtn.Click += sumBtn_Click;
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new Point(152, 72);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(228, 20);
            sumLabel.TabIndex = 1;
            sumLabel.Text = "Sum of even integers 2 to 100  -  \r\n";
            // 
            // resultTxt
            // 
            resultTxt.Location = new Point(409, 65);
            resultTxt.Name = "resultTxt";
            resultTxt.Size = new Size(155, 27);
            resultTxt.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultTxt);
            Controls.Add(sumLabel);
            Controls.Add(sumBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sumBtn;
        private Label sumLabel;
        private TextBox resultTxt;
    }
}

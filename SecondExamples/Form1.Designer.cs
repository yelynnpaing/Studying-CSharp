namespace SecondExamples
{
    partial class FindeGrade
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
            label2 = new Label();
            txtNum = new TextBox();
            findGradeBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(317, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 0;
            label1.Text = "P14Eg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 98);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter total Marks";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(386, 91);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(139, 27);
            txtNum.TabIndex = 2;
            // 
            // findGradeBtn
            // 
            findGradeBtn.Location = new Point(167, 192);
            findGradeBtn.Name = "findGradeBtn";
            findGradeBtn.Size = new Size(122, 38);
            findGradeBtn.TabIndex = 3;
            findGradeBtn.Text = "Find Grade";
            findGradeBtn.UseVisualStyleBackColor = true;
            findGradeBtn.Click += findGradeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(359, 192);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(115, 38);
            closeBtn.TabIndex = 4;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // FindeGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(findGradeBtn);
            Controls.Add(txtNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FindeGrade";
            Text = "FindGrade Eg 1";
            Load += FindeGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNum;
        private Button findGradeBtn;
        private Button closeBtn;
    }
}

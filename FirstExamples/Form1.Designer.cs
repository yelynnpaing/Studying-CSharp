namespace TestOne
{
    partial class P9eg
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
            exit = new Button();
            btnClear = new Button();
            firstNum = new Label();
            secondNum = new Label();
            ans = new Label();
            txtFristNum = new TextBox();
            txtSecondNum = new TextBox();
            txtAns = new TextBox();
            btnSum = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 47);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Page 9 Eg";
            label1.Click += label1_Click;
            // 
            // exit
            // 
            exit.Location = new Point(456, 302);
            exit.Name = "exit";
            exit.Size = new Size(126, 29);
            exit.TabIndex = 1;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(303, 302);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // firstNum
            // 
            firstNum.AutoSize = true;
            firstNum.Location = new Point(138, 111);
            firstNum.Name = "firstNum";
            firstNum.Size = new Size(132, 20);
            firstNum.TabIndex = 3;
            firstNum.Text = "Enter First Number";
            // 
            // secondNum
            // 
            secondNum.AutoSize = true;
            secondNum.Location = new Point(138, 163);
            secondNum.Name = "secondNum";
            secondNum.Size = new Size(154, 20);
            secondNum.TabIndex = 4;
            secondNum.Text = "Enter Second Number";
            // 
            // ans
            // 
            ans.AutoSize = true;
            ans.Location = new Point(138, 221);
            ans.Name = "ans";
            ans.Size = new Size(57, 20);
            ans.TabIndex = 5;
            ans.Text = "Answer";
            // 
            // txtFristNum
            // 
            txtFristNum.Location = new Point(368, 104);
            txtFristNum.Name = "txtFristNum";
            txtFristNum.Size = new Size(212, 27);
            txtFristNum.TabIndex = 6;
            // 
            // txtSecondNum
            // 
            txtSecondNum.Location = new Point(368, 156);
            txtSecondNum.Name = "txtSecondNum";
            txtSecondNum.Size = new Size(214, 27);
            txtSecondNum.TabIndex = 7;
            // 
            // txtAns
            // 
            txtAns.Location = new Point(368, 214);
            txtAns.Name = "txtAns";
            txtAns.Size = new Size(212, 27);
            txtAns.TabIndex = 8;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(138, 300);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(138, 31);
            btnSum.TabIndex = 9;
            btnSum.Text = "Sum";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // P9eg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSum);
            Controls.Add(txtAns);
            Controls.Add(txtSecondNum);
            Controls.Add(txtFristNum);
            Controls.Add(ans);
            Controls.Add(secondNum);
            Controls.Add(firstNum);
            Controls.Add(btnClear);
            Controls.Add(exit);
            Controls.Add(label1);
            Name = "P9eg";
            Text = "sum two number";
            Load += TestOne_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button exit;
        private Button btnClear;
        private Label firstNum;
        private Label secondNum;
        private Label ans;
        private TextBox txtFristNum;
        private TextBox txtSecondNum;
        private TextBox txtAns;
        private Button btnSum;
    }
}

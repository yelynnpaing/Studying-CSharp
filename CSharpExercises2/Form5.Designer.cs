namespace CSharpExercises2
{
    partial class Form5
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
            opt3 = new RadioButton();
            opt2 = new RadioButton();
            opt1 = new RadioButton();
            opt0 = new RadioButton();
            label1 = new Label();
            txtPurchase = new TextBox();
            computeBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(opt3);
            groupBox1.Controls.Add(opt2);
            groupBox1.Controls.Add(opt1);
            groupBox1.Controls.Add(opt0);
            groupBox1.Location = new Point(90, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tax code container";
            // 
            // opt3
            // 
            opt3.AutoSize = true;
            opt3.Location = new Point(27, 218);
            opt3.Name = "opt3";
            opt3.Size = new Size(96, 24);
            opt3.TabIndex = 3;
            opt3.TabStop = true;
            opt3.Text = "3 tax (7%)";
            opt3.UseVisualStyleBackColor = true;
            opt3.CheckedChanged += opt3_CheckedChanged;
            // 
            // opt2
            // 
            opt2.AutoSize = true;
            opt2.Location = new Point(27, 170);
            opt2.Name = "opt2";
            opt2.Size = new Size(96, 24);
            opt2.TabIndex = 2;
            opt2.TabStop = true;
            opt2.Text = "2 tax (5%)";
            opt2.UseVisualStyleBackColor = true;
            opt2.CheckedChanged += opt2_CheckedChanged;
            // 
            // opt1
            // 
            opt1.AutoSize = true;
            opt1.Location = new Point(27, 121);
            opt1.Name = "opt1";
            opt1.Size = new Size(96, 24);
            opt1.TabIndex = 1;
            opt1.TabStop = true;
            opt1.Text = "1 tax (3%)";
            opt1.UseVisualStyleBackColor = true;
            opt1.CheckedChanged += opt1_CheckedChanged;
            // 
            // opt0
            // 
            opt0.AutoSize = true;
            opt0.Location = new Point(27, 68);
            opt0.Name = "opt0";
            opt0.Size = new Size(96, 24);
            opt0.TabIndex = 0;
            opt0.TabStop = true;
            opt0.Text = "0 tax (0%)";
            opt0.UseVisualStyleBackColor = true;
            opt0.CheckedChanged += opt0_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 68);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter purchase amount";
            // 
            // txtPurchase
            // 
            txtPurchase.Location = new Point(312, 68);
            txtPurchase.Name = "txtPurchase";
            txtPurchase.Size = new Size(125, 27);
            txtPurchase.TabIndex = 2;
            // 
            // computeBtn
            // 
            computeBtn.Location = new Point(90, 465);
            computeBtn.Name = "computeBtn";
            computeBtn.Size = new Size(134, 41);
            computeBtn.TabIndex = 3;
            computeBtn.Text = "Calculate";
            computeBtn.UseVisualStyleBackColor = true;
            computeBtn.Click += computeBtn_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 518);
            Controls.Add(computeBtn);
            Controls.Add(txtPurchase);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Page 21 ex 5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton opt3;
        private RadioButton opt2;
        private RadioButton opt1;
        private RadioButton opt0;
        private Label label1;
        private TextBox txtPurchase;
        private Button computeBtn;
    }
}
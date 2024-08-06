namespace CSharpExercises
{
    partial class Form3
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
            pTxtNum = new TextBox();
            pLabel = new Label();
            sTxtNum = new TextBox();
            sideCal = new Button();
            sLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(306, 22);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "P11E3";
            // 
            // pTxtNum
            // 
            pTxtNum.Location = new Point(374, 104);
            pTxtNum.Name = "pTxtNum";
            pTxtNum.Size = new Size(105, 27);
            pTxtNum.TabIndex = 1;
            // 
            // pLabel
            // 
            pLabel.AutoSize = true;
            pLabel.Location = new Point(165, 104);
            pLabel.Name = "pLabel";
            pLabel.Size = new Size(110, 20);
            pLabel.TabIndex = 2;
            pLabel.Text = "Enter Perimeter";
            // 
            // sTxtNum
            // 
            sTxtNum.Location = new Point(374, 165);
            sTxtNum.Name = "sTxtNum";
            sTxtNum.Size = new Size(105, 27);
            sTxtNum.TabIndex = 3;
            // 
            // sideCal
            // 
            sideCal.Location = new Point(241, 254);
            sideCal.Name = "sideCal";
            sideCal.Size = new Size(158, 42);
            sideCal.TabIndex = 4;
            sideCal.Text = "Calculate side";
            sideCal.UseVisualStyleBackColor = true;
            sideCal.Click += sideCal_Click;
            // 
            // sLabel
            // 
            sLabel.AutoSize = true;
            sLabel.Location = new Point(165, 172);
            sLabel.Name = "sLabel";
            sLabel.Size = new Size(116, 20);
            sLabel.TabIndex = 5;
            sLabel.Text = "Side of a square";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sLabel);
            Controls.Add(sideCal);
            Controls.Add(sTxtNum);
            Controls.Add(pLabel);
            Controls.Add(pTxtNum);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox pTxtNum;
        private Label pLabel;
        private TextBox sTxtNum;
        private Button sideCal;
        private Label sLabel;
    }
}
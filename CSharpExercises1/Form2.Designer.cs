namespace CSharpExercises
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
            lLabel = new Label();
            bLabel = new Label();
            lTxtNum = new TextBox();
            bTxtNum = new TextBox();
            aTxtNum = new TextBox();
            areaCal = new Button();
            aLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(337, 39);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "P11E2";
            // 
            // lLabel
            // 
            lLabel.AutoSize = true;
            lLabel.Location = new Point(144, 109);
            lLabel.Name = "lLabel";
            lLabel.Size = new Size(54, 20);
            lLabel.TabIndex = 1;
            lLabel.Text = "Length";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new Point(144, 169);
            bLabel.Name = "bLabel";
            bLabel.Size = new Size(61, 20);
            bLabel.TabIndex = 2;
            bLabel.Text = "Breadth";
            // 
            // lTxtNum
            // 
            lTxtNum.Location = new Point(337, 106);
            lTxtNum.Name = "lTxtNum";
            lTxtNum.Size = new Size(150, 27);
            lTxtNum.TabIndex = 3;
            // 
            // bTxtNum
            // 
            bTxtNum.Location = new Point(337, 166);
            bTxtNum.Name = "bTxtNum";
            bTxtNum.Size = new Size(150, 27);
            bTxtNum.TabIndex = 4;
            // 
            // aTxtNum
            // 
            aTxtNum.Location = new Point(337, 249);
            aTxtNum.Name = "aTxtNum";
            aTxtNum.Size = new Size(150, 27);
            aTxtNum.TabIndex = 5;
            // 
            // areaCal
            // 
            areaCal.Location = new Point(194, 327);
            areaCal.Name = "areaCal";
            areaCal.Size = new Size(219, 42);
            areaCal.TabIndex = 6;
            areaCal.Text = "Calculate Area";
            areaCal.UseVisualStyleBackColor = true;
            areaCal.Click += areaCal_Click;
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new Point(148, 237);
            aLabel.Name = "aLabel";
            aLabel.Size = new Size(40, 20);
            aLabel.TabIndex = 7;
            aLabel.Text = "Area";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(aLabel);
            Controls.Add(areaCal);
            Controls.Add(aTxtNum);
            Controls.Add(bTxtNum);
            Controls.Add(lTxtNum);
            Controls.Add(bLabel);
            Controls.Add(lLabel);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lLabel;
        private Label bLabel;
        private TextBox lTxtNum;
        private TextBox bTxtNum;
        private TextBox aTxtNum;
        private Button areaCal;
        private Label aLabel;
    }
}
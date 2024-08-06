namespace CSharpExercises
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
            numberLabel = new Label();
            txtNum = new TextBox();
            rTxtNum = new TextBox();
            resultLabel = new Label();
            square = new Button();
            cube = new Button();
            clear = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(94, 95);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(110, 20);
            numberLabel.TabIndex = 0;
            numberLabel.Text = "Enter a number";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(307, 95);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(134, 27);
            txtNum.TabIndex = 1;
            // 
            // rTxtNum
            // 
            rTxtNum.Location = new Point(307, 151);
            rTxtNum.Name = "rTxtNum";
            rTxtNum.Size = new Size(134, 27);
            rTxtNum.TabIndex = 2;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(94, 151);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(49, 20);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Result";
            // 
            // square
            // 
            square.Location = new Point(83, 232);
            square.Name = "square";
            square.Size = new Size(104, 40);
            square.TabIndex = 4;
            square.Text = "Square";
            square.UseVisualStyleBackColor = true;
            square.Click += button1_Click;
            // 
            // cube
            // 
            cube.Location = new Point(261, 232);
            cube.Name = "cube";
            cube.Size = new Size(102, 40);
            cube.TabIndex = 5;
            cube.Text = "Cube";
            cube.UseVisualStyleBackColor = true;
            cube.Click += cube_Click;
            // 
            // clear
            // 
            clear.Location = new Point(428, 232);
            clear.Name = "clear";
            clear.Size = new Size(125, 40);
            clear.TabIndex = 6;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(339, 20);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 7;
            label3.Text = "P 11 E 1";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(clear);
            Controls.Add(cube);
            Controls.Add(square);
            Controls.Add(resultLabel);
            Controls.Add(rTxtNum);
            Controls.Add(txtNum);
            Controls.Add(numberLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberLabel;
        private TextBox txtNum;
        private TextBox rTxtNum;
        private Label resultLabel;
        private Button square;
        private Button cube;
        private Button clear;
        private Label label3;
    }
}

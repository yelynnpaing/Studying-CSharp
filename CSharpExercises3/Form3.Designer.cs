namespace CSharpExercises3
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
            Display = new Button();
            label1 = new Label();
            resultTxt = new ListBox();
            SuspendLayout();
            // 
            // Display
            // 
            Display.Location = new Point(284, 253);
            Display.Name = "Display";
            Display.Size = new Size(160, 52);
            Display.TabIndex = 0;
            Display.Text = "Display";
            Display.UseVisualStyleBackColor = true;
            Display.Click += Display_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 74);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 1;
            label1.Text = "Fibonanci sequence of numbers  -  ";
            // 
            // resultTxt
            // 
            resultTxt.FormattingEnabled = true;
            resultTxt.Location = new Point(470, 74);
            resultTxt.Name = "resultTxt";
            resultTxt.Size = new Size(258, 164);
            resultTxt.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultTxt);
            Controls.Add(label1);
            Controls.Add(Display);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Display;
        private Label label1;
        private ListBox resultTxt;
    }
}
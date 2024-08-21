namespace ThirdExamples
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
            length = new Button();
            clear = new Button();
            Close = new Button();
            label1 = new Label();
            nameTxt = new TextBox();
            label2 = new Label();
            txtLength = new TextBox();
            SuspendLayout();
            // 
            // length
            // 
            length.Location = new Point(184, 204);
            length.Name = "length";
            length.Size = new Size(105, 43);
            length.TabIndex = 0;
            length.Text = "Length";
            length.UseVisualStyleBackColor = true;
            length.Click += length_Click;
            // 
            // clear
            // 
            clear.Location = new Point(386, 204);
            clear.Name = "clear";
            clear.Size = new Size(105, 43);
            clear.TabIndex = 1;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Close
            // 
            Close.Location = new Point(574, 204);
            Close.Name = "Close";
            Close.Size = new Size(105, 43);
            Close.TabIndex = 2;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 72);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter Your Name ";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(474, 65);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(232, 27);
            nameTxt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 120);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 5;
            label2.Text = "Number of Your Name ";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(474, 113);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(232, 27);
            txtLength.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLength);
            Controls.Add(label2);
            Controls.Add(nameTxt);
            Controls.Add(label1);
            Controls.Add(Close);
            Controls.Add(clear);
            Controls.Add(length);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button length;
        private Button clear;
        private Button Close;
        private Label label1;
        private TextBox nameTxt;
        private Label label2;
        private TextBox txtLength;
    }
}

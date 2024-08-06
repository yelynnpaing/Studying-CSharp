namespace SecondExamples
{
    partial class RadioButtons
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
            clickBtn = new Button();
            label1 = new Label();
            optPgdca = new RadioButton();
            optYu = new RadioButton();
            SuspendLayout();
            // 
            // clickBtn
            // 
            clickBtn.Location = new Point(323, 233);
            clickBtn.Name = "clickBtn";
            clickBtn.Size = new Size(143, 47);
            clickBtn.TabIndex = 2;
            clickBtn.Text = "Click";
            clickBtn.UseVisualStyleBackColor = true;
            clickBtn.Click += clickBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(323, 22);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 3;
            label1.Text = "Using Radio Btns";
            // 
            // optPgdca
            // 
            optPgdca.AutoSize = true;
            optPgdca.Location = new Point(139, 113);
            optPgdca.Name = "optPgdca";
            optPgdca.Size = new Size(78, 24);
            optPgdca.TabIndex = 4;
            optPgdca.TabStop = true;
            optPgdca.Text = "PGDCA";
            optPgdca.UseVisualStyleBackColor = true;
            // 
            // optYu
            // 
            optYu.AutoSize = true;
            optYu.Location = new Point(551, 113);
            optYu.Name = "optYu";
            optYu.Size = new Size(147, 24);
            optYu.TabIndex = 5;
            optYu.TabStop = true;
            optYu.Text = "Yangon University";
            optYu.UseVisualStyleBackColor = true;
            // 
            // RadioButtons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(optYu);
            Controls.Add(optPgdca);
            Controls.Add(label1);
            Controls.Add(clickBtn);
            Name = "RadioButtons";
            Text = "Radio Buttons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button clickBtn;
        private Label label1;
        private RadioButton optPgdca;
        private RadioButton optYu;
    }
}
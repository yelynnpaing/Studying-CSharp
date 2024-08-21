namespace ThirdExamples
{
    partial class Form4
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
            ToLowerBtn = new Button();
            label1 = new Label();
            txtFirstString = new TextBox();
            label2 = new Label();
            txtSecondString = new TextBox();
            ToUpperBtn = new Button();
            clearBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // ToLowerBtn
            // 
            ToLowerBtn.Location = new Point(84, 226);
            ToLowerBtn.Name = "ToLowerBtn";
            ToLowerBtn.Size = new Size(141, 40);
            ToLowerBtn.TabIndex = 0;
            ToLowerBtn.Text = "ToLower";
            ToLowerBtn.UseVisualStyleBackColor = true;
            ToLowerBtn.Click += ToLowerBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 80);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "First String ";
            // 
            // txtFirstString
            // 
            txtFirstString.Location = new Point(370, 73);
            txtFirstString.Name = "txtFirstString";
            txtFirstString.Size = new Size(257, 27);
            txtFirstString.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 134);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Second String";
            // 
            // txtSecondString
            // 
            txtSecondString.Location = new Point(370, 127);
            txtSecondString.Name = "txtSecondString";
            txtSecondString.Size = new Size(257, 27);
            txtSecondString.TabIndex = 4;
            // 
            // ToUpperBtn
            // 
            ToUpperBtn.Location = new Point(255, 226);
            ToUpperBtn.Name = "ToUpperBtn";
            ToUpperBtn.Size = new Size(141, 40);
            ToUpperBtn.TabIndex = 5;
            ToUpperBtn.Text = "ToUpper";
            ToUpperBtn.UseVisualStyleBackColor = true;
            ToUpperBtn.Click += ToUpperBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(413, 226);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(141, 40);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(578, 226);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(141, 40);
            closeBtn.TabIndex = 7;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(clearBtn);
            Controls.Add(ToUpperBtn);
            Controls.Add(txtSecondString);
            Controls.Add(label2);
            Controls.Add(txtFirstString);
            Controls.Add(label1);
            Controls.Add(ToLowerBtn);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ToLowerBtn;
        private Label label1;
        private TextBox txtFirstString;
        private Label label2;
        private TextBox txtSecondString;
        private Button ToUpperBtn;
        private Button clearBtn;
        private Button closeBtn;
    }
}
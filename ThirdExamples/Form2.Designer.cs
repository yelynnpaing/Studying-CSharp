namespace ThirdExamples
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
            txtFirstString = new TextBox();
            label2 = new Label();
            txtSecondString = new TextBox();
            substringBtn = new Button();
            clearBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 60);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "First String";
            // 
            // txtFirstString
            // 
            txtFirstString.Location = new Point(363, 60);
            txtFirstString.Name = "txtFirstString";
            txtFirstString.Size = new Size(215, 27);
            txtFirstString.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 116);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 2;
            label2.Text = "Second String";
            // 
            // txtSecondString
            // 
            txtSecondString.Location = new Point(363, 113);
            txtSecondString.Name = "txtSecondString";
            txtSecondString.Size = new Size(215, 27);
            txtSecondString.TabIndex = 3;
            // 
            // substringBtn
            // 
            substringBtn.Location = new Point(122, 218);
            substringBtn.Name = "substringBtn";
            substringBtn.Size = new Size(144, 39);
            substringBtn.TabIndex = 4;
            substringBtn.Text = "SubString";
            substringBtn.UseVisualStyleBackColor = true;
            substringBtn.Click += substring_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(349, 218);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(144, 39);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(584, 218);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(144, 39);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(clearBtn);
            Controls.Add(substringBtn);
            Controls.Add(txtSecondString);
            Controls.Add(label2);
            Controls.Add(txtFirstString);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstString;
        private Label label2;
        private TextBox txtSecondString;
        private Button substringBtn;
        private Button clearBtn;
        private Button closeBtn;
    }
}
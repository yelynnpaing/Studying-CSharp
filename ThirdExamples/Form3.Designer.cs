namespace ThirdExamples
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
            txtFirstString = new TextBox();
            compareBtn = new Button();
            label2 = new Label();
            txtSecondString = new TextBox();
            clearBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 96);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = " First String";
            // 
            // txtFirstString
            // 
            txtFirstString.Location = new Point(394, 89);
            txtFirstString.Name = "txtFirstString";
            txtFirstString.Size = new Size(229, 27);
            txtFirstString.TabIndex = 1;
            // 
            // compareBtn
            // 
            compareBtn.Location = new Point(172, 242);
            compareBtn.Name = "compareBtn";
            compareBtn.Size = new Size(104, 38);
            compareBtn.TabIndex = 2;
            compareBtn.Text = "Compare";
            compareBtn.UseVisualStyleBackColor = true;
            compareBtn.Click += compareBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 158);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Second String";
            // 
            // txtSecondString
            // 
            txtSecondString.Location = new Point(394, 151);
            txtSecondString.Name = "txtSecondString";
            txtSecondString.Size = new Size(229, 27);
            txtSecondString.TabIndex = 4;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(346, 242);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(104, 38);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(519, 242);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(104, 38);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(clearBtn);
            Controls.Add(txtSecondString);
            Controls.Add(label2);
            Controls.Add(compareBtn);
            Controls.Add(txtFirstString);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstString;
        private Button compareBtn;
        private Label label2;
        private TextBox txtSecondString;
        private Button clearBtn;
        private Button closeBtn;
    }
}
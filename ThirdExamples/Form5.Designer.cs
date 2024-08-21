namespace ThirdExamples
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
            label1 = new Label();
            txtFirstString = new TextBox();
            trimBtn = new Button();
            label2 = new Label();
            txtSecondString = new TextBox();
            clearBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 84);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "First String";
            // 
            // txtFirstString
            // 
            txtFirstString.Location = new Point(380, 77);
            txtFirstString.Name = "txtFirstString";
            txtFirstString.Size = new Size(270, 27);
            txtFirstString.TabIndex = 1;
            // 
            // trimBtn
            // 
            trimBtn.Location = new Point(130, 238);
            trimBtn.Name = "trimBtn";
            trimBtn.Size = new Size(94, 38);
            trimBtn.TabIndex = 2;
            trimBtn.Text = "Trim";
            trimBtn.UseVisualStyleBackColor = true;
            trimBtn.Click += trimBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 145);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Second String";
            // 
            // txtSecondString
            // 
            txtSecondString.Location = new Point(380, 138);
            txtSecondString.Name = "txtSecondString";
            txtSecondString.Size = new Size(270, 27);
            txtSecondString.TabIndex = 4;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(324, 238);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 38);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(505, 238);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(94, 38);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(clearBtn);
            Controls.Add(txtSecondString);
            Controls.Add(label2);
            Controls.Add(trimBtn);
            Controls.Add(txtFirstString);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstString;
        private Button trimBtn;
        private Label label2;
        private TextBox txtSecondString;
        private Button clearBtn;
        private Button closeBtn;
    }
}
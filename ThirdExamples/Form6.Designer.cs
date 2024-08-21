namespace ThirdExamples
{
    partial class Form6
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
            txtString = new TextBox();
            stratBtn = new Button();
            label2 = new Label();
            txtStarts = new TextBox();
            clearBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 56);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Name";
            // 
            // txtString
            // 
            txtString.Location = new Point(426, 49);
            txtString.Name = "txtString";
            txtString.Size = new Size(290, 27);
            txtString.TabIndex = 1;
            // 
            // stratBtn
            // 
            stratBtn.Location = new Point(153, 236);
            stratBtn.Name = "stratBtn";
            stratBtn.Size = new Size(130, 36);
            stratBtn.TabIndex = 2;
            stratBtn.Text = "Starts";
            stratBtn.UseVisualStyleBackColor = true;
            stratBtn.Click += stratBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 127);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Starts with String";
            // 
            // txtStarts
            // 
            txtStarts.Location = new Point(426, 120);
            txtStarts.Name = "txtStarts";
            txtStarts.Size = new Size(290, 27);
            txtStarts.TabIndex = 4;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(359, 236);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(130, 36);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(564, 236);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(130, 36);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(clearBtn);
            Controls.Add(txtStarts);
            Controls.Add(label2);
            Controls.Add(stratBtn);
            Controls.Add(txtString);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtString;
        private Button stratBtn;
        private Label label2;
        private TextBox txtStarts;
        private Button clearBtn;
        private Button closeBtn;
    }
}
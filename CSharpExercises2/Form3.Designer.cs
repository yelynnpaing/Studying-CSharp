namespace CSharpExercises2
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
            cboMonth = new ComboBox();
            txtYear = new TextBox();
            findBtn = new Button();
            lbResult = new ListBox();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // cboMonth
            // 
            cboMonth.FormattingEnabled = true;
            cboMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cboMonth.Location = new Point(274, 87);
            cboMonth.Name = "cboMonth";
            cboMonth.Size = new Size(213, 28);
            cboMonth.TabIndex = 0;
            cboMonth.Text = "Select Month";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(103, 88);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 1;
            txtYear.Text = "Enter Year";
            // 
            // findBtn
            // 
            findBtn.Location = new Point(169, 232);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(148, 45);
            findBtn.TabIndex = 2;
            findBtn.Text = "Find";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // lbResult
            // 
            lbResult.FormattingEnabled = true;
            lbResult.Location = new Point(538, 87);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(211, 44);
            lbResult.TabIndex = 3;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(378, 232);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(132, 45);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearBtn);
            Controls.Add(lbResult);
            Controls.Add(findBtn);
            Controls.Add(txtYear);
            Controls.Add(cboMonth);
            Name = "Form3";
            Text = "Page 21 Ex 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMonth;
        private TextBox txtYear;
        private Button findBtn;
        private ListBox lbResult;
        private Button clearBtn;
    }
}
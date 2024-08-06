namespace SecondExamples
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
            examCbo = new ComboBox();
            subjectList = new ListBox();
            removeBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // examCbo
            // 
            examCbo.FormattingEnabled = true;
            examCbo.Items.AddRange(new object[] { "Semester I", "Semester II" });
            examCbo.Location = new Point(55, 88);
            examCbo.Name = "examCbo";
            examCbo.Size = new Size(235, 28);
            examCbo.TabIndex = 0;
            examCbo.Text = "Select Semester";
            examCbo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // subjectList
            // 
            subjectList.FormattingEnabled = true;
            subjectList.Location = new Point(411, 88);
            subjectList.Name = "subjectList";
            subjectList.Size = new Size(281, 124);
            subjectList.TabIndex = 1;
            subjectList.SelectedIndexChanged += subjectList_SelectedIndexChanged;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(420, 258);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(122, 43);
            removeBtn.TabIndex = 2;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(583, 257);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(110, 46);
            closeBtn.TabIndex = 3;
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
            Controls.Add(removeBtn);
            Controls.Add(subjectList);
            Controls.Add(examCbo);
            Name = "Form3";
            Text = "Combo Box and List Box";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox examCbo;
        private ListBox subjectList;
        private Button removeBtn;
        private Button closeBtn;
    }
}
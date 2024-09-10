namespace UsingListViewForm
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
            label1 = new Label();
            label2 = new Label();
            txtRNum = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            cboSubject = new ComboBox();
            addBtn = new Button();
            label4 = new Label();
            txtMarks = new TextBox();
            DelBtn = new Button();
            lstMarks = new ListView();
            saveBtn = new Button();
            label5 = new Label();
            txtTotalMark = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Roll No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 78);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // txtRNum
            // 
            txtRNum.Location = new Point(157, 28);
            txtRNum.Name = "txtRNum";
            txtRNum.Size = new Size(240, 27);
            txtRNum.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(157, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 27);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 120);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Subject";
            // 
            // cboSubject
            // 
            cboSubject.FormattingEnabled = true;
            cboSubject.Items.AddRange(new object[] { "Eco", "Matchematics", "Bio", "Physics", "Chemistry", "Myanmar", "English" });
            cboSubject.Location = new Point(157, 112);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(240, 28);
            cboSubject.TabIndex = 5;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.MenuHighlight;
            addBtn.Location = new Point(369, 154);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 163);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 7;
            label4.Text = "Marks";
            // 
            // txtMarks
            // 
            txtMarks.Location = new Point(157, 156);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(158, 27);
            txtMarks.TabIndex = 8;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.Red;
            DelBtn.Location = new Point(500, 154);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(94, 29);
            DelBtn.TabIndex = 9;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // lstMarks
            // 
            lstMarks.GridLines = true;
            lstMarks.Location = new Point(47, 202);
            lstMarks.Name = "lstMarks";
            lstMarks.Size = new Size(741, 175);
            lstMarks.TabIndex = 10;
            lstMarks.UseCompatibleStateImageBehavior = false;
            lstMarks.View = View.Details;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Green;
            saveBtn.ForeColor = SystemColors.ActiveCaptionText;
            saveBtn.Location = new Point(369, 388);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 395);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 12;
            label5.Text = "Total Marks";
            // 
            // txtTotalMark
            // 
            txtTotalMark.Location = new Point(630, 388);
            txtTotalMark.Name = "txtTotalMark";
            txtTotalMark.Size = new Size(158, 27);
            txtTotalMark.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotalMark);
            Controls.Add(label5);
            Controls.Add(saveBtn);
            Controls.Add(lstMarks);
            Controls.Add(DelBtn);
            Controls.Add(txtMarks);
            Controls.Add(label4);
            Controls.Add(addBtn);
            Controls.Add(cboSubject);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(txtRNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Add data into List View Box from Textbox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRNum;
        private TextBox txtName;
        private Label label3;
        private ComboBox cboSubject;
        private Button addBtn;
        private Label label4;
        private TextBox txtMarks;
        private Button DelBtn;
        private ListView lstMarks;
        private Button saveBtn;
        private Label label5;
        private TextBox txtTotalMark;
    }
}

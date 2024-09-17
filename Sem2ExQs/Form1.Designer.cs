namespace Sem2ExQs
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
            lvData = new ListView();
            addBtn = new Button();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            deleteBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 63);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // lvData
            // 
            lvData.GridLines = true;
            lvData.Location = new Point(118, 291);
            lvData.Name = "lvData";
            lvData.Size = new Size(650, 121);
            lvData.TabIndex = 1;
            lvData.UseCompatibleStateImageBehavior = false;
            lvData.View = View.Details;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(118, 235);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(285, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(319, 27);
            txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(285, 109);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(319, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(285, 168);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(319, 27);
            txtPhone.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 116);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 175);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Phone";
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(322, 235);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(510, 235);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(94, 29);
            closeBtn.TabIndex = 9;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(deleteBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(addBtn);
            Controls.Add(lvData);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sem 2 Ex Q 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvData;
        private Button addBtn;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label label2;
        private Label label3;
        private Button deleteBtn;
        private Button closeBtn;
    }
}

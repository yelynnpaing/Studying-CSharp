namespace CSharpCRUD1
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
            newBtn = new Button();
            label1 = new Label();
            txtCusID = new TextBox();
            label2 = new Label();
            txtCusName = new TextBox();
            label3 = new Label();
            txtNRC = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            saveBtn = new Button();
            updateBtn = new Button();
            delBtn = new Button();
            CloseBtn = new Button();
            dgCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // newBtn
            // 
            newBtn.Location = new Point(111, 252);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(94, 29);
            newBtn.TabIndex = 0;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 25);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Customer ID";
            // 
            // txtCusID
            // 
            txtCusID.Location = new Point(285, 18);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(328, 27);
            txtCusID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 66);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer Name";
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(285, 59);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(328, 27);
            txtCusName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 115);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 5;
            label3.Text = "NRC Number";
            // 
            // txtNRC
            // 
            txtNRC.Location = new Point(285, 108);
            txtNRC.Name = "txtNRC";
            txtNRC.Size = new Size(328, 27);
            txtNRC.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 157);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(285, 150);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(328, 27);
            txtAddress.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 198);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(285, 189);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(328, 27);
            txtPhone.TabIndex = 10;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(234, 252);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(353, 252);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 12;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(472, 252);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 13;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(597, 252);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(94, 29);
            CloseBtn.TabIndex = 14;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(111, 302);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.Size = new Size(684, 188);
            dgCustomer.TabIndex = 15;
            dgCustomer.CellContentClick += dgCustomer_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 529);
            Controls.Add(dgCustomer);
            Controls.Add(CloseBtn);
            Controls.Add(delBtn);
            Controls.Add(updateBtn);
            Controls.Add(saveBtn);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtNRC);
            Controls.Add(label3);
            Controls.Add(txtCusName);
            Controls.Add(label2);
            Controls.Add(txtCusID);
            Controls.Add(label1);
            Controls.Add(newBtn);
            Name = "Form1";
            Text = "CSharp CRUD 1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newBtn;
        private Label label1;
        private TextBox txtCusID;
        private Label label2;
        private TextBox txtCusName;
        private Label label3;
        private TextBox txtNRC;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtPhone;
        private Button saveBtn;
        private Button updateBtn;
        private Button delBtn;
        private Button CloseBtn;
        private DataGridView dgCustomer;
    }
}

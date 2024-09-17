namespace Sem2ExQs
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
            newBtn = new Button();
            label1 = new Label();
            txtCusId = new TextBox();
            label2 = new Label();
            txtCusName = new TextBox();
            saveBtn = new Button();
            dgCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // newBtn
            // 
            newBtn.Location = new Point(178, 154);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(141, 45);
            newBtn.TabIndex = 0;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "CustomerID";
            // 
            // txtCusId
            // 
            txtCusId.Location = new Point(301, 22);
            txtCusId.Name = "txtCusId";
            txtCusId.Size = new Size(279, 27);
            txtCusId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 94);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer Name";
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(301, 87);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(279, 27);
            txtCusName.TabIndex = 4;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(362, 154);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(128, 45);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(151, 250);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.Size = new Size(492, 188);
            dgCustomer.TabIndex = 6;
            dgCustomer.Click += dgCustomer_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgCustomer);
            Controls.Add(saveBtn);
            Controls.Add(txtCusName);
            Controls.Add(label2);
            Controls.Add(txtCusId);
            Controls.Add(label1);
            Controls.Add(newBtn);
            Name = "Form2";
            Text = "Sem 2 Ex Q 2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newBtn;
        private Label label1;
        private TextBox txtCusId;
        private Label label2;
        private TextBox txtCusName;
        private Button saveBtn;
        private DataGridView dgCustomer;
    }
}
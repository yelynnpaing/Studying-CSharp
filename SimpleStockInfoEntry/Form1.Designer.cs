namespace SimpleStockInfoEntry
{
    partial class stockForm
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
            txtStockId = new TextBox();
            newBtn = new Button();
            dgStock = new DataGridView();
            label2 = new Label();
            txtStockName = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            saveBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            closeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 16);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Stock ID";
            // 
            // txtStockId
            // 
            txtStockId.Location = new Point(278, 9);
            txtStockId.Name = "txtStockId";
            txtStockId.Size = new Size(305, 27);
            txtStockId.TabIndex = 1;
            // 
            // newBtn
            // 
            newBtn.Location = new Point(43, 192);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(94, 29);
            newBtn.TabIndex = 2;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // dgStock
            // 
            dgStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStock.Location = new Point(26, 279);
            dgStock.Name = "dgStock";
            dgStock.RowHeadersWidth = 51;
            dgStock.Size = new Size(647, 188);
            dgStock.TabIndex = 3;
            dgStock.CellContentClick += dgStock_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 59);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 4;
            label2.Text = "Stock Name";
            // 
            // txtStockName
            // 
            txtStockName.Location = new Point(278, 52);
            txtStockName.Name = "txtStockName";
            txtStockName.Size = new Size(305, 27);
            txtStockName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 103);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(278, 96);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(305, 27);
            txtPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 145);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(278, 138);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(305, 27);
            txtQuantity.TabIndex = 9;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(184, 192);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(324, 192);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(468, 192);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(617, 192);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(94, 29);
            closeBtn.TabIndex = 13;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // stockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 488);
            Controls.Add(closeBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(saveBtn);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtStockName);
            Controls.Add(label2);
            Controls.Add(dgStock);
            Controls.Add(newBtn);
            Controls.Add(txtStockId);
            Controls.Add(label1);
            Name = "stockForm";
            Text = "Stock Information Entry ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStockId;
        private Button newBtn;
        private DataGridView dgStock;
        private Label label2;
        private TextBox txtStockName;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtQuantity;
        private Button saveBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button closeBtn;
    }
}

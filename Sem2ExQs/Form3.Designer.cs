namespace Sem2ExQs
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
            txtStockName = new TextBox();
            allBtn = new Button();
            dgStock = new DataGridView();
            searchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 88);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Stock Name ";
            // 
            // txtStockName
            // 
            txtStockName.Location = new Point(328, 81);
            txtStockName.Name = "txtStockName";
            txtStockName.Size = new Size(269, 27);
            txtStockName.TabIndex = 1;
            // 
            // allBtn
            // 
            allBtn.Location = new Point(164, 155);
            allBtn.Name = "allBtn";
            allBtn.Size = new Size(121, 53);
            allBtn.TabIndex = 2;
            allBtn.Text = "All";
            allBtn.UseVisualStyleBackColor = true;
            allBtn.Click += allBtn_Click;
            // 
            // dgStock
            // 
            dgStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStock.Location = new Point(164, 250);
            dgStock.Name = "dgStock";
            dgStock.RowHeadersWidth = 51;
            dgStock.Size = new Size(569, 188);
            dgStock.TabIndex = 3;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(368, 155);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(121, 53);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchBtn);
            Controls.Add(dgStock);
            Controls.Add(allBtn);
            Controls.Add(txtStockName);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Sem 2 Ex Q 3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStockName;
        private Button allBtn;
        private DataGridView dgStock;
        private Button searchBtn;
    }
}
namespace SearchingDatas
{
    partial class SearchingDatas
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
            txtStockID = new TextBox();
            serachBtn = new Button();
            dgStock = new DataGridView();
            clearBtn = new Button();
            closeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 37);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Stock ID";
            // 
            // txtStockID
            // 
            txtStockID.Location = new Point(305, 30);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(255, 27);
            txtStockID.TabIndex = 1;
            // 
            // serachBtn
            // 
            serachBtn.Location = new Point(172, 110);
            serachBtn.Name = "serachBtn";
            serachBtn.Size = new Size(94, 29);
            serachBtn.TabIndex = 2;
            serachBtn.Text = "Search";
            serachBtn.UseVisualStyleBackColor = true;
            serachBtn.Click += serachBtn_Click;
            // 
            // dgStock
            // 
            dgStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStock.Location = new Point(31, 216);
            dgStock.Name = "dgStock";
            dgStock.RowHeadersWidth = 51;
            dgStock.Size = new Size(700, 188);
            dgStock.TabIndex = 3;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(305, 110);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(445, 110);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(94, 29);
            closeBtn.TabIndex = 5;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // SearchingDatas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(clearBtn);
            Controls.Add(dgStock);
            Controls.Add(serachBtn);
            Controls.Add(txtStockID);
            Controls.Add(label1);
            Name = "SearchingDatas";
            Text = "Searching Datas ";
            Load += SearchingDatas_Load;
            ((System.ComponentModel.ISupportInitialize)dgStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStockID;
        private Button serachBtn;
        private DataGridView dgStock;
        private Button clearBtn;
        private Button closeBtn;
    }
}

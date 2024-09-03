namespace UsingComboBox
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
            cboCusID = new ComboBox();
            txtCusName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 35);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Customber ID";
            // 
            // cboCusID
            // 
            cboCusID.FormattingEnabled = true;
            cboCusID.Location = new Point(277, 27);
            cboCusID.Name = "cboCusID";
            cboCusID.Size = new Size(284, 28);
            cboCusID.TabIndex = 1;
            cboCusID.SelectedIndexChanged += cboCusID_SelectedIndexChanged;
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(277, 98);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(284, 27);
            txtCusName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 105);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtCusName);
            Controls.Add(cboCusID);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Fill Data to ComboBox From Table";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCusID;
        private TextBox txtCusName;
        private Label label2;
    }
}

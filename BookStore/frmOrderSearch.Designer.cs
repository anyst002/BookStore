namespace BookStore
{
    partial class frmOrderSearch
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
            lblOrderNum = new Label();
            lblStoreID = new Label();
            txtOrderNum = new TextBox();
            textBox2 = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblOrderNum
            // 
            lblOrderNum.AutoSize = true;
            lblOrderNum.Location = new Point(32, 41);
            lblOrderNum.Name = "lblOrderNum";
            lblOrderNum.Size = new Size(132, 25);
            lblOrderNum.TabIndex = 0;
            lblOrderNum.Text = "Order Number:";
            // 
            // lblStoreID
            // 
            lblStoreID.AutoSize = true;
            lblStoreID.Location = new Point(32, 102);
            lblStoreID.Name = "lblStoreID";
            lblStoreID.Size = new Size(80, 25);
            lblStoreID.TabIndex = 1;
            lblStoreID.Text = "Store ID:";
            // 
            // txtOrderNum
            // 
            txtOrderNum.Location = new Point(186, 38);
            txtOrderNum.Name = "txtOrderNum";
            txtOrderNum.Size = new Size(150, 31);
            txtOrderNum.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(38, 185);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 34);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(144, 185);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 34);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(249, 185);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 34);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrderSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 250);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(textBox2);
            Controls.Add(txtOrderNum);
            Controls.Add(lblStoreID);
            Controls.Add(lblOrderNum);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmOrderSearch";
            ShowIcon = false;
            Text = "Order Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderNum;
        private Label lblStoreID;
        private Label lbl;
        private TextBox txtOrderNum;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private Button btnSearch;
        private Button btnClear;
        private Button btnClose;
    }
}
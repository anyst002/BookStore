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
            lblOrderNum.Location = new Point(22, 25);
            lblOrderNum.Margin = new Padding(2, 0, 2, 0);
            lblOrderNum.Name = "lblOrderNum";
            lblOrderNum.Size = new Size(87, 15);
            lblOrderNum.TabIndex = 0;
            lblOrderNum.Text = "Order Number:";
            // 
            // lblStoreID
            // 
            lblStoreID.AutoSize = true;
            lblStoreID.Location = new Point(22, 61);
            lblStoreID.Margin = new Padding(2, 0, 2, 0);
            lblStoreID.Name = "lblStoreID";
            lblStoreID.Size = new Size(51, 15);
            lblStoreID.TabIndex = 1;
            lblStoreID.Text = "Store ID:";
            // 
            // txtOrderNum
            // 
            txtOrderNum.Location = new Point(130, 23);
            txtOrderNum.Margin = new Padding(2, 2, 2, 2);
            txtOrderNum.Name = "txtOrderNum";
            txtOrderNum.Size = new Size(106, 23);
            txtOrderNum.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 59);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(27, 111);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(56, 20);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(101, 111);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(56, 20);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(174, 111);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(56, 20);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrderSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 150);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(textBox2);
            Controls.Add(txtOrderNum);
            Controls.Add(lblStoreID);
            Controls.Add(lblOrderNum);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "frmOrderSearch";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderNum;
        private Label lblStoreID;
        private TextBox txtOrderNum;
        private TextBox textBox2;
        private Button btnSearch;
        private Button btnClear;
        private Button btnClose;
    }
}
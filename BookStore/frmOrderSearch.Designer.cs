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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            this.btnSearch = new Button();
            this.btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblOrderNum
            // 
            lblOrderNum.AutoSize = true;
            lblOrderNum.Location = new Point(32, 41);
            lblOrderNum.Name = "lblOrderNum";
            lblOrderNum.Size = new Size(85, 25);
            lblOrderNum.TabIndex = 0;
            lblOrderNum.Text = "Order ID:";
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
            // textBox1
            // 
            textBox1.Location = new Point(126, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new Point(32, 182);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(80, 34);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new Point(138, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(80, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(243, 182);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 34);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmOrderSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 250);
            Controls.Add(btnClose);
            Controls.Add(this.btnClear);
            Controls.Add(this.btnSearch);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblStoreID);
            Controls.Add(lblOrderNum);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Button button2;
        private Button btnClose;
    }
}
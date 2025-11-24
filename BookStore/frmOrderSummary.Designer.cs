namespace BookStore
{
    partial class frmOrderSummary
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
            lblOrderLabel = new Label();
            lblOrderNumber = new Label();
            lblSubtotal = new Label();
            txtSubtotal = new Label();
            lblTax = new Label();
            txtTax = new TextBox();
            txtSubAmount = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            dataGridView1 = new DataGridView();
            colSumTitle = new DataGridViewTextBoxColumn();
            colSumAuthor = new DataGridViewTextBoxColumn();
            colSumYear = new DataGridViewTextBoxColumn();
            colSumISBN = new DataGridViewTextBoxColumn();
            colSumCost = new DataGridViewTextBoxColumn();
            colSumQuantity = new DataGridViewTextBoxColumn();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblOrderLabel
            // 
            lblOrderLabel.AutoSize = true;
            lblOrderLabel.Location = new Point(24, 15);
            lblOrderLabel.Name = "lblOrderLabel";
            lblOrderLabel.Size = new Size(50, 15);
            lblOrderLabel.TabIndex = 0;
            lblOrderLabel.Text = "Order# :";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(80, 15);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(0, 15);
            lblOrderNumber.TabIndex = 1;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(555, 18);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 2;
            lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.AutoSize = true;
            txtSubtotal.Location = new Point(606, 18);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(0, 15);
            txtSubtotal.TabIndex = 3;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(792, 18);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(27, 15);
            lblTax.TabIndex = 4;
            lblTax.Text = "Tax:";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(825, 15);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 5;
            // 
            // txtSubAmount
            // 
            txtSubAmount.Location = new Point(612, 15);
            txtSubAmount.Name = "txtSubAmount";
            txtSubAmount.Size = new Size(100, 23);
            txtSubAmount.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(792, 56);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(831, 56);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSumTitle, colSumAuthor, colSumYear, colSumISBN, colSumCost, colSumQuantity });
            dataGridView1.Location = new Point(93, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(645, 51);
            dataGridView1.TabIndex = 9;
            // 
            // colSumTitle
            // 
            colSumTitle.HeaderText = "Title";
            colSumTitle.Name = "colSumTitle";
            // 
            // colSumAuthor
            // 
            colSumAuthor.HeaderText = "Author";
            colSumAuthor.Name = "colSumAuthor";
            // 
            // colSumYear
            // 
            colSumYear.HeaderText = "Year";
            colSumYear.Name = "colSumYear";
            // 
            // colSumISBN
            // 
            colSumISBN.HeaderText = "ISBN";
            colSumISBN.Name = "colSumISBN";
            // 
            // colSumCost
            // 
            colSumCost.HeaderText = "Cost";
            colSumCost.Name = "colSumCost";
            // 
            // colSumQuantity
            // 
            colSumQuantity.HeaderText = "Quantity";
            colSumQuantity.Name = "colSumQuantity";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(387, 435);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // frmOrderSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 624);
            Controls.Add(btnOK);
            Controls.Add(dataGridView1);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtSubAmount);
            Controls.Add(txtTax);
            Controls.Add(lblTax);
            Controls.Add(txtSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(lblOrderNumber);
            Controls.Add(lblOrderLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmOrderSummary";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order Summary";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderLabel;
        private Label lblOrderNumber;
        private Label lblSubtotal;
        private Label txtSubtotal;
        private Label lblTax;
        private TextBox txtTax;
        private TextBox txtSubAmount;
        private Label lblTotal;
        private TextBox txtTotal;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colSumTitle;
        private DataGridViewTextBoxColumn colSumAuthor;
        private DataGridViewTextBoxColumn colSumYear;
        private DataGridViewTextBoxColumn colSumISBN;
        private DataGridViewTextBoxColumn colSumCost;
        private DataGridViewTextBoxColumn colSumQuantity;
        private Button btnOK;
    }
}
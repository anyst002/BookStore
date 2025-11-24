namespace BookStore
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            txtSearch = new TextBox();
            lblSearch = new Label();
            dataGridView1 = new DataGridView();
            colTitle = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colISBN = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            lblQty = new Label();
            txtQty = new TextBox();
            btnAddToCart = new Button();
            dataGridView2 = new DataGridView();
            colResultTitle = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            lblSubtotal = new Label();
            txtSubtotal = new TextBox();
            lblTax = new Label();
            lblTotal = new Label();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            btnConfirmOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(129, 69);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(547, 23);
            txtSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(60, 77);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(48, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search :";
            lblSearch.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colTitle, colAuthor, colYear, colISBN });
            dataGridView1.Location = new Point(129, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(450, 111);
            dataGridView1.TabIndex = 2;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            // 
            // colAuthor
            // 
            colAuthor.HeaderText = "Author";
            colAuthor.Name = "colAuthor";
            // 
            // colYear
            // 
            colYear.HeaderText = "Year";
            colYear.Name = "colYear";
            // 
            // colISBN
            // 
            colISBN.HeaderText = "ISBN";
            colISBN.Name = "colISBN";
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.ForeColor = SystemColors.ButtonShadow;
            btnSearch.Location = new Point(670, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(39, 23);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(79, 329);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(29, 15);
            lblQty.TabIndex = 4;
            lblQty.Text = "Qty:";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(129, 321);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 23);
            txtQty.TabIndex = 5;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(498, 321);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(96, 23);
            btnAddToCart.TabIndex = 6;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colResultTitle, colQty, colPrice });
            dataGridView2.Location = new Point(162, 362);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(339, 66);
            dataGridView2.TabIndex = 7;
            // 
            // colResultTitle
            // 
            colResultTitle.HeaderText = "Title";
            colResultTitle.Name = "colResultTitle";
            // 
            // colQty
            // 
            colQty.HeaderText = "Qty";
            colQty.Name = "colQty";
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(465, 537);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 8;
            lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(525, 534);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 9;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(465, 584);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(27, 15);
            lblTax.TabIndex = 10;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(465, 620);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total:";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(525, 576);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(525, 617);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 13;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Location = new Point(565, 671);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(111, 23);
            btnConfirmOrder.TabIndex = 14;
            btnConfirmOrder.Text = "Confirm Order";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 735);
            Controls.Add(btnConfirmOrder);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(txtSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(dataGridView2);
            Controls.Add(btnAddToCart);
            Controls.Add(txtQty);
            Controls.Add(lblQty);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Name = "frmOrder";
            Text = "frmOrder";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colISBN;
        private Button btnSearch;
        private Label lblQty;
        private TextBox txtQty;
        private Button btnAddToCart;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colResultTitle;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colPrice;
        private Label lblSubtotal;
        private TextBox txtSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnConfirmOrder;
    }
}
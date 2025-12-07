using BookStore.Data;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            grdCart = new DataGridView();
            orderItemBindingSource = new BindingSource(components);
            titleSearchResultBindingSource = new BindingSource(components);
            btnSearch = new Button();
            lblSubtotal = new Label();
            txtSubtotal = new TextBox();
            lblTax = new Label();
            lblTotal = new Label();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            btnConfirmOrder = new Button();
            btnExit = new Button();
            lblPayTerms = new Label();
            txtPayTerms = new TextBox();
            Remove = new DataGridViewButtonColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            auNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pubNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pubDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)titleSearchResultBindingSource).BeginInit();
            SuspendLayout();
            // 
            // grdCart
            // 
            grdCart.AllowUserToAddRows = false;
            grdCart.AllowUserToDeleteRows = false;
            grdCart.AllowUserToResizeColumns = false;
            grdCart.AllowUserToResizeRows = false;
            grdCart.AutoGenerateColumns = false;
            grdCart.BackgroundColor = SystemColors.ControlLight;
            grdCart.BorderStyle = BorderStyle.Fixed3D;
            grdCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCart.Columns.AddRange(new DataGridViewColumn[] { Remove, titleDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, qtyDataGridViewTextBoxColumn, Edit, auNameDataGridViewTextBoxColumn, pubNameDataGridViewTextBoxColumn, pubDateDataGridViewTextBoxColumn });
            grdCart.DataSource = orderItemBindingSource;
            grdCart.Location = new Point(12, 12);
            grdCart.MultiSelect = false;
            grdCart.Name = "grdCart";
            grdCart.ReadOnly = true;
            grdCart.RowHeadersVisible = false;
            grdCart.RowHeadersWidth = 20;
            grdCart.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grdCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCart.ShowEditingIcon = false;
            grdCart.Size = new Size(776, 315);
            grdCart.TabIndex = 4;
            grdCart.CellContentClick += grdCart_CellContentClick;
            // 
            // orderItemBindingSource
            // 
            orderItemBindingSource.DataSource = typeof(OrderItem);
            // 
            // titleSearchResultBindingSource
            // 
            titleSearchResultBindingSource.DataSource = typeof(TitleSearchResult);
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.ForeColor = SystemColors.ButtonShadow;
            btnSearch.Location = new Point(863, 208);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 67);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(794, 15);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 8;
            lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(863, 12);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 9;
            txtSubtotal.TabStop = false;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(794, 44);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(27, 15);
            lblTax.TabIndex = 10;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(794, 73);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total:";
            // 
            // txtTax
            // 
            txtTax.Enabled = false;
            txtTax.Location = new Point(863, 41);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 12;
            txtTax.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(863, 70);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 13;
            txtTotal.TabStop = false;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Enabled = false;
            btnConfirmOrder.Location = new Point(863, 158);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(100, 23);
            btnConfirmOrder.TabIndex = 3;
            btnConfirmOrder.Text = "Confirm Order";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(863, 304);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Cancel";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblPayTerms
            // 
            lblPayTerms.AutoSize = true;
            lblPayTerms.Location = new Point(794, 132);
            lblPayTerms.Name = "lblPayTerms";
            lblPayTerms.Size = new Size(63, 15);
            lblPayTerms.TabIndex = 16;
            lblPayTerms.Text = "Pay Terms:";
            // 
            // txtPayTerms
            // 
            txtPayTerms.Location = new Point(863, 129);
            txtPayTerms.Name = "txtPayTerms";
            txtPayTerms.Size = new Size(100, 23);
            txtPayTerms.TabIndex = 2;
            // 
            // Remove
            // 
            Remove.HeaderText = "X";
            Remove.Name = "Remove";
            Remove.ReadOnly = true;
            Remove.Text = "X";
            Remove.UseColumnTextForButtonValue = true;
            Remove.Width = 23;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 50;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            qtyDataGridViewTextBoxColumn.HeaderText = "Qty.";
            qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            qtyDataGridViewTextBoxColumn.ReadOnly = true;
            qtyDataGridViewTextBoxColumn.Width = 50;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 50;
            // 
            // auNameDataGridViewTextBoxColumn
            // 
            auNameDataGridViewTextBoxColumn.DataPropertyName = "AuName";
            auNameDataGridViewTextBoxColumn.HeaderText = "Author";
            auNameDataGridViewTextBoxColumn.Name = "auNameDataGridViewTextBoxColumn";
            auNameDataGridViewTextBoxColumn.ReadOnly = true;
            auNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pubNameDataGridViewTextBoxColumn
            // 
            pubNameDataGridViewTextBoxColumn.DataPropertyName = "PubName";
            pubNameDataGridViewTextBoxColumn.HeaderText = "Publisher";
            pubNameDataGridViewTextBoxColumn.Name = "pubNameDataGridViewTextBoxColumn";
            pubNameDataGridViewTextBoxColumn.ReadOnly = true;
            pubNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pubDateDataGridViewTextBoxColumn
            // 
            pubDateDataGridViewTextBoxColumn.DataPropertyName = "PubDate";
            pubDateDataGridViewTextBoxColumn.HeaderText = "Pub. Date";
            pubDateDataGridViewTextBoxColumn.Name = "pubDateDataGridViewTextBoxColumn";
            pubDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 337);
            Controls.Add(txtPayTerms);
            Controls.Add(lblPayTerms);
            Controls.Add(btnExit);
            Controls.Add(btnConfirmOrder);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(txtSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(btnSearch);
            Controls.Add(grdCart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Order";
            ((System.ComponentModel.ISupportInitialize)grdCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)titleSearchResultBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView grdCart;
        private Button btnSearch;
        private Label lblSubtotal;
        private TextBox txtSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnConfirmOrder;
        private Button btnExit;
        private Label lblPayTerms;
        private TextBox txtPayTerms;
        private BindingSource titleSearchResultBindingSource;
        private BindingSource orderItemBindingSource;
        private DataGridViewButtonColumn Remove;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Edit;
        private DataGridViewTextBoxColumn auNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pubNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pubDateDataGridViewTextBoxColumn;
    }
}
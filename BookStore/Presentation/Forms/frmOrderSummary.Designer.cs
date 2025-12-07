using BookStore.Data;

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
            components = new System.ComponentModel.Container();
            lblOrderNum = new Label();
            lblOrderNumber = new Label();
            btnOK = new Button();
            txtTotal = new TextBox();
            txtTax = new TextBox();
            lblTotal = new Label();
            lblTax = new Label();
            txtSubtotal = new TextBox();
            lblSubtotal = new Label();
            txtOrderNum = new TextBox();
            grdSummary = new DataGridView();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            auNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pubNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pubDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderItemBindingSource = new BindingSource(components);
            lblSuccess = new Label();
            ((System.ComponentModel.ISupportInitialize)grdSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblOrderNum
            // 
            lblOrderNum.AutoSize = true;
            lblOrderNum.Location = new Point(732, 115);
            lblOrderNum.Name = "lblOrderNum";
            lblOrderNum.Size = new Size(50, 15);
            lblOrderNum.TabIndex = 0;
            lblOrderNum.Text = "Order #:";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(80, 15);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(0, 15);
            lblOrderNumber.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(773, 304);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 23);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(801, 199);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 19;
            txtTotal.TabStop = false;
            // 
            // txtTax
            // 
            txtTax.Enabled = false;
            txtTax.Location = new Point(801, 170);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 18;
            txtTax.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(732, 202);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(732, 173);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(27, 15);
            lblTax.TabIndex = 16;
            lblTax.Text = "Tax:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(801, 141);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 15;
            txtSubtotal.TabStop = false;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(732, 144);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 14;
            lblSubtotal.Text = "Subtotal:";
            // 
            // txtOrderNum
            // 
            txtOrderNum.Enabled = false;
            txtOrderNum.Location = new Point(801, 112);
            txtOrderNum.Name = "txtOrderNum";
            txtOrderNum.Size = new Size(100, 23);
            txtOrderNum.TabIndex = 20;
            txtOrderNum.TabStop = false;
            // 
            // grdSummary
            // 
            grdSummary.AllowUserToAddRows = false;
            grdSummary.AllowUserToDeleteRows = false;
            grdSummary.AllowUserToResizeColumns = false;
            grdSummary.AllowUserToResizeRows = false;
            grdSummary.AutoGenerateColumns = false;
            grdSummary.BackgroundColor = SystemColors.ControlLight;
            grdSummary.BorderStyle = BorderStyle.Fixed3D;
            grdSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSummary.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, qtyDataGridViewTextBoxColumn, auNameDataGridViewTextBoxColumn, pubNameDataGridViewTextBoxColumn, pubDateDataGridViewTextBoxColumn });
            grdSummary.DataSource = orderItemBindingSource;
            grdSummary.Location = new Point(12, 12);
            grdSummary.MultiSelect = false;
            grdSummary.Name = "grdSummary";
            grdSummary.ReadOnly = true;
            grdSummary.RowHeadersVisible = false;
            grdSummary.RowHeadersWidth = 20;
            grdSummary.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grdSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSummary.ShowEditingIcon = false;
            grdSummary.Size = new Size(703, 315);
            grdSummary.TabIndex = 21;
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
            // orderItemBindingSource
            // 
            orderItemBindingSource.DataSource = typeof(OrderItem);
            // 
            // lblSuccess
            // 
            lblSuccess.AutoSize = true;
            lblSuccess.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuccess.Location = new Point(733, 35);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Size = new Size(168, 50);
            lblSuccess.TabIndex = 22;
            lblSuccess.Text = "Order Submitted!\r\nSummary:";
            lblSuccess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmOrderSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 340);
            Controls.Add(lblSuccess);
            Controls.Add(grdSummary);
            Controls.Add(txtOrderNum);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(txtSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(btnOK);
            Controls.Add(lblOrderNumber);
            Controls.Add(lblOrderNum);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmOrderSummary";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order Summary";
            ((System.ComponentModel.ISupportInitialize)grdSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderNum;
        private Label lblOrderNumber;
        private Button btnOK;
        private TextBox txtTotal;
        private TextBox txtTax;
        private Label lblTotal;
        private Label lblTax;
        private TextBox txtSubtotal;
        private Label lblSubtotal;
        private TextBox txtOrderNum;
        private DataGridView grdSummary;
        private BindingSource orderItemBindingSource;
        private Label lblSuccess;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn auNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pubNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pubDateDataGridViewTextBoxColumn;
    }
}
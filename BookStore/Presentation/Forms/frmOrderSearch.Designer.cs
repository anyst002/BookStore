using BookStore.Entities;

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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            btnSearch = new Button();
            btnCancel = new Button();
            lblQuantity = new Label();
            grdResults = new DataGridView();
            titleSearchResultBindingSource = new BindingSource(components);
            btnAdd = new Button();
            numQuantity = new NumericUpDown();
            txtSearch = new TextBox();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            auNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pubNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pubDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)titleSearchResultBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(13, 14);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(62, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Enter Title:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(326, 11);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(777, 339);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnClose_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(787, 215);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(86, 15);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Enter Quantity:";
            // 
            // grdResults
            // 
            grdResults.AllowUserToAddRows = false;
            grdResults.AllowUserToDeleteRows = false;
            grdResults.AllowUserToResizeColumns = false;
            grdResults.AllowUserToResizeRows = false;
            grdResults.AutoGenerateColumns = false;
            grdResults.BackgroundColor = SystemColors.ControlLight;
            grdResults.BorderStyle = BorderStyle.Fixed3D;
            grdResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdResults.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, auNameDataGridViewTextBoxColumn, pubNameDataGridViewTextBoxColumn, pubDateDataGridViewTextBoxColumn });
            grdResults.DataSource = titleSearchResultBindingSource;
            grdResults.Location = new Point(12, 46);
            grdResults.MultiSelect = false;
            grdResults.Name = "grdResults";
            grdResults.ReadOnly = true;
            grdResults.RowHeadersVisible = false;
            grdResults.RowHeadersWidth = 20;
            grdResults.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grdResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdResults.ShowEditingIcon = false;
            grdResults.Size = new Size(753, 315);
            grdResults.TabIndex = 3;
            grdResults.SelectionChanged += grdResults_SelectionChanged;
            // 
            // titleSearchResultBindingSource
            // 
            titleSearchResultBindingSource.DataSource = typeof(TitleSearchResult);
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(777, 271);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add To Cart";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(777, 236);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(106, 23);
            numQuantity.TabIndex = 4;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(234, 23);
            txtSearch.TabIndex = 1;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 300;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 50;
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
            // frmOrderSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 372);
            Controls.Add(txtSearch);
            Controls.Add(numQuantity);
            Controls.Add(btnAdd);
            Controls.Add(grdResults);
            Controls.Add(lblQuantity);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmOrderSearch";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)grdResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)titleSearchResultBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnSearch;
        private Button btnCancel;
        private Label lblQuantity;
        private DataGridView grdResults;
        private BindingSource titleSearchResultBindingSource;
        private Button btnAdd;
        private NumericUpDown numQuantity;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn auNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pubNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pubDateDataGridViewTextBoxColumn;
    }
}
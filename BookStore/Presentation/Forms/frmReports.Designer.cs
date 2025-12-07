using BookStore.Entities;

namespace BookStore
{
    partial class frmReports
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblStartDate = new Label();
            lblEndDate = new Label();
            btnViewReport = new Button();
            btnExit = new Button();
            grdReports = new DataGridView();
            ordDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ordNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesSummaryRowBindingSource = new BindingSource(components);
            lblTotal = new Label();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesSummaryRowBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(744, 12);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(120, 23);
            dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(744, 41);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(120, 23);
            dtpEndDate.TabIndex = 1;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(677, 14);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(61, 15);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(677, 43);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(57, 15);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "End Date:";
            // 
            // btnViewReport
            // 
            btnViewReport.Location = new Point(678, 83);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(187, 23);
            btnViewReport.TabIndex = 2;
            btnViewReport.Text = "View Formatted Report";
            btnViewReport.UseVisualStyleBackColor = true;
            btnViewReport.Click += btnViewReport_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(736, 304);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grdReports
            // 
            grdReports.AllowUserToAddRows = false;
            grdReports.AllowUserToDeleteRows = false;
            grdReports.AllowUserToResizeColumns = false;
            grdReports.AllowUserToResizeRows = false;
            grdReports.AutoGenerateColumns = false;
            grdReports.BackgroundColor = SystemColors.ControlLight;
            grdReports.BorderStyle = BorderStyle.Fixed3D;
            grdReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdReports.Columns.AddRange(new DataGridViewColumn[] { ordDateDataGridViewTextBoxColumn, ordNumDataGridViewTextBoxColumn, titleIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, qtyDataGridViewTextBoxColumn, totalValueDataGridViewTextBoxColumn });
            grdReports.DataSource = salesSummaryRowBindingSource;
            grdReports.Location = new Point(12, 12);
            grdReports.MultiSelect = false;
            grdReports.Name = "grdReports";
            grdReports.ReadOnly = true;
            grdReports.RowHeadersVisible = false;
            grdReports.RowHeadersWidth = 20;
            grdReports.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grdReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdReports.ShowEditingIcon = false;
            grdReports.Size = new Size(653, 315);
            grdReports.TabIndex = 3;
            // 
            // ordDateDataGridViewTextBoxColumn
            // 
            ordDateDataGridViewTextBoxColumn.DataPropertyName = "OrdDate";
            ordDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            ordDateDataGridViewTextBoxColumn.Name = "ordDateDataGridViewTextBoxColumn";
            ordDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordNumDataGridViewTextBoxColumn
            // 
            ordNumDataGridViewTextBoxColumn.DataPropertyName = "OrdNum";
            ordNumDataGridViewTextBoxColumn.HeaderText = "Order #";
            ordNumDataGridViewTextBoxColumn.Name = "ordNumDataGridViewTextBoxColumn";
            ordNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleIdDataGridViewTextBoxColumn
            // 
            titleIdDataGridViewTextBoxColumn.DataPropertyName = "TitleId";
            titleIdDataGridViewTextBoxColumn.HeaderText = "Title ID";
            titleIdDataGridViewTextBoxColumn.Name = "titleIdDataGridViewTextBoxColumn";
            titleIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            qtyDataGridViewTextBoxColumn.HeaderText = "Qty.";
            qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            qtyDataGridViewTextBoxColumn.ReadOnly = true;
            qtyDataGridViewTextBoxColumn.Width = 50;
            // 
            // totalValueDataGridViewTextBoxColumn
            // 
            totalValueDataGridViewTextBoxColumn.DataPropertyName = "TotalValue";
            totalValueDataGridViewTextBoxColumn.HeaderText = "Total Value";
            totalValueDataGridViewTextBoxColumn.Name = "totalValueDataGridViewTextBoxColumn";
            totalValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesSummaryRowBindingSource
            // 
            salesSummaryRowBindingSource.DataSource = typeof(SalesSummary);
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(677, 128);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total Sales:";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(744, 125);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(120, 23);
            txtTotal.TabIndex = 9;
            txtTotal.TabStop = false;
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 339);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(grdReports);
            Controls.Add(btnExit);
            Controls.Add(btnViewReport);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmReports";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Report";
            ((System.ComponentModel.ISupportInitialize)grdReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesSummaryRowBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label lblStartDate;
        private Label lblEndDate;
        private Button btnViewReport;
        private Button btnExit;
        private DataGridView grdReports;
        private DataGridViewTextBoxColumn ordDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalValueDataGridViewTextBoxColumn;
        private BindingSource salesSummaryRowBindingSource;
        private Label lblTotal;
        private TextBox txtTotal;
    }
}
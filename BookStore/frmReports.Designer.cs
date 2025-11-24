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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblStartDate = new Label();
            lblEndDate = new Label();
            btnViewReport = new Button();
            dataGridView1 = new DataGridView();
            colOrderID = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colISBN = new DataGridViewTextBoxColumn();
            colCost = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(135, 23);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(135, 62);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 1;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(68, 29);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(61, 15);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(68, 68);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(57, 15);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "End Date:";
            // 
            // btnViewReport
            // 
            btnViewReport.Location = new Point(471, 45);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(177, 23);
            btnViewReport.TabIndex = 4;
            btnViewReport.Text = "View Formatted Report";
            btnViewReport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colOrderID, colTitle, colAuthor, colYear, colISBN, colCost, colQty, colTotal });
            dataGridView1.Location = new Point(87, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(840, 69);
            dataGridView1.TabIndex = 5;
            // 
            // colOrderID
            // 
            colOrderID.HeaderText = "Order#";
            colOrderID.Name = "colOrderID";
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
            // colCost
            // 
            colCost.HeaderText = "Cost";
            colCost.Name = "colCost";
            // 
            // colQty
            // 
            colQty.HeaderText = "Quantity";
            colQty.Name = "colQty";
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(777, 456);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 636);
            Controls.Add(btnExit);
            Controls.Add(dataGridView1);
            Controls.Add(btnViewReport);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmReports";
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label lblStartDate;
        private Label lblEndDate;
        private Button btnViewReport;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colOrderID;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colISBN;
        private DataGridViewTextBoxColumn colCost;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colTotal;
        private Button btnExit;
    }
}
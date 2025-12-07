namespace BookStore
{
    partial class frmAddTitle
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.Label lblRoyalty;
        private System.Windows.Forms.Label lblYTDSales;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblPubDate;

        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.TextBox txtRoyalty;
        private System.Windows.Forms.TextBox txtYTDSales;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dtpPubDate;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitleID = new Label();
            lblTitle = new Label();
            lblType = new Label();
            lblPublisher = new Label();
            lblPrice = new Label();
            lblAdvance = new Label();
            lblRoyalty = new Label();
            lblYTDSales = new Label();
            lblNotes = new Label();
            lblPubDate = new Label();
            txtTitleID = new TextBox();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            txtAdvance = new TextBox();
            txtRoyalty = new TextBox();
            txtYTDSales = new TextBox();
            txtNotes = new TextBox();
            dtpPubDate = new DateTimePicker();
            btnSave = new Button();
            btnClear = new Button();
            btnExit = new Button();
            btnSelect = new Button();
            txtPublisher = new TextBox();
            txtType = new TextBox();
            SuspendLayout();
            // 
            // lblTitleID
            // 
            lblTitleID.AutoSize = true;
            lblTitleID.Location = new Point(40, 40);
            lblTitleID.Name = "lblTitleID";
            lblTitleID.Size = new Size(46, 15);
            lblTitleID.TabIndex = 0;
            lblTitleID.Text = "Title ID:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(40, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(40, 120);
            lblType.Name = "lblType";
            lblType.Size = new Size(34, 15);
            lblType.TabIndex = 2;
            lblType.Text = "Type:";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(40, 160);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(59, 15);
            lblPublisher.TabIndex = 3;
            lblPublisher.Text = "Publisher:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(40, 200);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // lblAdvance
            // 
            lblAdvance.AutoSize = true;
            lblAdvance.Location = new Point(40, 240);
            lblAdvance.Name = "lblAdvance";
            lblAdvance.Size = new Size(56, 15);
            lblAdvance.TabIndex = 5;
            lblAdvance.Text = "Advance:";
            // 
            // lblRoyalty
            // 
            lblRoyalty.AutoSize = true;
            lblRoyalty.Location = new Point(40, 280);
            lblRoyalty.Name = "lblRoyalty";
            lblRoyalty.Size = new Size(49, 15);
            lblRoyalty.TabIndex = 6;
            lblRoyalty.Text = "Royalty:";
            // 
            // lblYTDSales
            // 
            lblYTDSales.AutoSize = true;
            lblYTDSales.Location = new Point(40, 320);
            lblYTDSales.Name = "lblYTDSales";
            lblYTDSales.Size = new Size(60, 15);
            lblYTDSales.TabIndex = 7;
            lblYTDSales.Text = "YTD Sales:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(40, 360);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(41, 15);
            lblNotes.TabIndex = 8;
            lblNotes.Text = "Notes:";
            // 
            // lblPubDate
            // 
            lblPubDate.AutoSize = true;
            lblPubDate.Location = new Point(40, 430);
            lblPubDate.Name = "lblPubDate";
            lblPubDate.Size = new Size(76, 15);
            lblPubDate.TabIndex = 9;
            lblPubDate.Text = "Publish Date:";
            // 
            // txtTitleID
            // 
            txtTitleID.Location = new Point(160, 38);
            txtTitleID.MaxLength = 6;
            txtTitleID.Name = "txtTitleID";
            txtTitleID.Size = new Size(100, 23);
            txtTitleID.TabIndex = 10;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(160, 78);
            txtTitle.MaxLength = 80;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(250, 23);
            txtTitle.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(160, 198);
            txtPrice.MaxLength = 20;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 14;
            // 
            // txtAdvance
            // 
            txtAdvance.Location = new Point(160, 238);
            txtAdvance.MaxLength = 20;
            txtAdvance.Name = "txtAdvance";
            txtAdvance.Size = new Size(100, 23);
            txtAdvance.TabIndex = 15;
            // 
            // txtRoyalty
            // 
            txtRoyalty.Location = new Point(160, 278);
            txtRoyalty.MaxLength = 10;
            txtRoyalty.Name = "txtRoyalty";
            txtRoyalty.Size = new Size(100, 23);
            txtRoyalty.TabIndex = 16;
            // 
            // txtYTDSales
            // 
            txtYTDSales.Location = new Point(160, 318);
            txtYTDSales.MaxLength = 10;
            txtYTDSales.Name = "txtYTDSales";
            txtYTDSales.Size = new Size(100, 23);
            txtYTDSales.TabIndex = 17;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(160, 358);
            txtNotes.MaxLength = 200;
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(250, 60);
            txtNotes.TabIndex = 18;
            // 
            // dtpPubDate
            // 
            dtpPubDate.Format = DateTimePickerFormat.Short;
            dtpPubDate.Location = new Point(160, 428);
            dtpPubDate.Name = "dtpPubDate";
            dtpPubDate.Size = new Size(150, 23);
            dtpPubDate.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(80, 480);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 35);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(200, 480);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 35);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(320, 480);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 35);
            btnExit.TabIndex = 22;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(284, 157);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 24;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtPublisher
            // 
            txtPublisher.Enabled = false;
            txtPublisher.Location = new Point(160, 157);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(100, 23);
            txtPublisher.TabIndex = 25;
            txtPublisher.TabStop = false;
            // 
            // txtType
            // 
            txtType.Location = new Point(160, 118);
            txtType.MaxLength = 12;
            txtType.Name = "txtType";
            txtType.Size = new Size(100, 23);
            txtType.TabIndex = 26;
            // 
            // frmAddTitle
            // 
            ClientSize = new Size(462, 550);
            Controls.Add(txtType);
            Controls.Add(txtPublisher);
            Controls.Add(btnSelect);
            Controls.Add(lblTitleID);
            Controls.Add(lblTitle);
            Controls.Add(lblType);
            Controls.Add(lblPublisher);
            Controls.Add(lblPrice);
            Controls.Add(lblAdvance);
            Controls.Add(lblRoyalty);
            Controls.Add(lblYTDSales);
            Controls.Add(lblNotes);
            Controls.Add(lblPubDate);
            Controls.Add(txtTitleID);
            Controls.Add(txtTitle);
            Controls.Add(txtPrice);
            Controls.Add(txtAdvance);
            Controls.Add(txtRoyalty);
            Controls.Add(txtYTDSales);
            Controls.Add(txtNotes);
            Controls.Add(dtpPubDate);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmAddTitle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Title";
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnSelect;
        private TextBox txtPublisher;
        private TextBox txtType;
    }
}

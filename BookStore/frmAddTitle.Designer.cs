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
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboPublisher;
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
            this.lblTitleID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.lblRoyalty = new System.Windows.Forms.Label();
            this.lblYTDSales = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPubDate = new System.Windows.Forms.Label();

            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtRoyalty = new System.Windows.Forms.TextBox();
            this.txtYTDSales = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpPubDate = new System.Windows.Forms.DateTimePicker();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Labels
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(40, 40);
            this.lblTitleID.Text = "Title ID:";

            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(40, 80);
            this.lblTitle.Text = "Title:";

            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(40, 120);
            this.lblType.Text = "Type:";

            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(40, 160);
            this.lblPublisher.Text = "Publisher:";

            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(40, 200);
            this.lblPrice.Text = "Price:";

            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Location = new System.Drawing.Point(40, 240);
            this.lblAdvance.Text = "Advance:";

            this.lblRoyalty.AutoSize = true;
            this.lblRoyalty.Location = new System.Drawing.Point(40, 280);
            this.lblRoyalty.Text = "Royalty:";

            this.lblYTDSales.AutoSize = true;
            this.lblYTDSales.Location = new System.Drawing.Point(40, 320);
            this.lblYTDSales.Text = "YTD Sales:";

            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(40, 360);
            this.lblNotes.Text = "Notes:";

            this.lblPubDate.AutoSize = true;
            this.lblPubDate.Location = new System.Drawing.Point(40, 430);
            this.lblPubDate.Text = "Publish Date:";

            // Input Controls
            this.txtTitleID.Location = new System.Drawing.Point(160, 38);
            this.txtTitleID.MaxLength = 6;

            this.txtTitle.Location = new System.Drawing.Point(160, 78);
            this.txtTitle.MaxLength = 80;
            this.txtTitle.Width = 250;

            this.cboType.Location = new System.Drawing.Point(160, 118);
            this.cboType.Width = 250;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboPublisher.Location = new System.Drawing.Point(160, 158);
            this.cboPublisher.Width = 250;
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.txtPrice.Location = new System.Drawing.Point(160, 198);
            this.txtPrice.Width = 100;
            this.txtPrice.MaxLength = 20;

            this.txtAdvance.Location = new System.Drawing.Point(160, 238);
            this.txtAdvance.Width = 100;
            this.txtAdvance.MaxLength = 20;

            this.txtRoyalty.Location = new System.Drawing.Point(160, 278);
            this.txtRoyalty.Width = 100;
            this.txtRoyalty.MaxLength = 10;

            this.txtYTDSales.Location = new System.Drawing.Point(160, 318);
            this.txtYTDSales.Width = 100;
            this.txtYTDSales.MaxLength = 10;

            this.txtNotes.Location = new System.Drawing.Point(160, 358);
            this.txtNotes.Width = 300;
            this.txtNotes.Height = 60;
            this.txtNotes.Multiline = true;
            this.txtNotes.MaxLength = 200;

            this.dtpPubDate.Location = new System.Drawing.Point(160, 428);
            this.dtpPubDate.Width = 150;
            this.dtpPubDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Buttons
            this.btnSave.Location = new System.Drawing.Point(80, 480);
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.Text = "Save";

            this.btnClear.Location = new System.Drawing.Point(200, 480);
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.Text = "Clear";

            this.btnExit.Location = new System.Drawing.Point(320, 480);
            this.btnExit.Size = new System.Drawing.Size(90, 35);
            this.btnExit.Text = "Exit";

            // Form
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.lblTitleID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAdvance);
            this.Controls.Add(this.lblRoyalty);
            this.Controls.Add(this.lblYTDSales);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblPubDate);

            this.Controls.Add(this.txtTitleID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboPublisher);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAdvance);
            this.Controls.Add(this.txtRoyalty);
            this.Controls.Add(this.txtYTDSales);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dtpPubDate);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);

            this.Name = "frmAddTitle";
            this.Text = "Add New Book Title";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

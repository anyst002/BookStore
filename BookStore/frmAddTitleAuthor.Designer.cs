namespace BookStore
{
    partial class frmAddTitleAuthor
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblRoyalty;

        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.ComboBox cboTitle;

        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtRoyalty;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblRoyalty = new System.Windows.Forms.Label();

            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.cboTitle = new System.Windows.Forms.ComboBox();

            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtRoyalty = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblAuthor
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(40, 40);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 17);
            this.lblAuthor.Text = "Author:";

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(40, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.Text = "Title:";

            // lblOrder
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(40, 140);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(93, 17);
            this.lblOrder.Text = "Author Order:";

            // lblRoyalty
            this.lblRoyalty.AutoSize = true;
            this.lblRoyalty.Location = new System.Drawing.Point(40, 190);
            this.lblRoyalty.Name = "lblRoyalty";
            this.lblRoyalty.Size = new System.Drawing.Size(77, 17);
            this.lblRoyalty.Text = "Royalty %:";

            // cboAuthor
            this.cboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor.Location = new System.Drawing.Point(160, 38);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(250, 24);

            // cboTitle
            this.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitle.Location = new System.Drawing.Point(160, 88);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(250, 24);

            // txtOrder
            this.txtOrder.Location = new System.Drawing.Point(160, 138);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(60, 22);
            this.txtOrder.MaxLength = 3;

            // txtRoyalty
            this.txtRoyalty.Location = new System.Drawing.Point(160, 188);
            this.txtRoyalty.Name = "txtRoyalty";
            this.txtRoyalty.Size = new System.Drawing.Size(60, 22);
            this.txtRoyalty.MaxLength = 3;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(60, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(190, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(320, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 35);
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;

            // frmAddTitleAuthor
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblRoyalty);

            this.Controls.Add(this.cboAuthor);
            this.Controls.Add(this.cboTitle);

            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.txtRoyalty);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);

            this.Name = "frmAddTitleAuthor";
            this.Text = "Add Title Author";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

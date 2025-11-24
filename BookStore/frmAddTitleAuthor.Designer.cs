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
            lblAuthor = new Label();
            lblTitle = new Label();
            lblOrder = new Label();
            lblRoyalty = new Label();
            cboAuthor = new ComboBox();
            cboTitle = new ComboBox();
            txtOrder = new TextBox();
            txtRoyalty = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(40, 40);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(57, 20);
            lblAuthor.TabIndex = 0;
            lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(40, 90);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Location = new Point(40, 140);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(99, 20);
            lblOrder.TabIndex = 2;
            lblOrder.Text = "Author Order:";
            // 
            // lblRoyalty
            // 
            lblRoyalty.AutoSize = true;
            lblRoyalty.Location = new Point(40, 190);
            lblRoyalty.Name = "lblRoyalty";
            lblRoyalty.Size = new Size(77, 20);
            lblRoyalty.TabIndex = 3;
            lblRoyalty.Text = "Royalty %:";
            // 
            // cboAuthor
            // 
            cboAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAuthor.Location = new Point(160, 38);
            cboAuthor.Name = "cboAuthor";
            cboAuthor.Size = new Size(250, 28);
            cboAuthor.TabIndex = 4;
            // 
            // cboTitle
            // 
            cboTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTitle.Location = new Point(160, 88);
            cboTitle.Name = "cboTitle";
            cboTitle.Size = new Size(250, 28);
            cboTitle.TabIndex = 5;
            // 
            // txtOrder
            // 
            txtOrder.Location = new Point(160, 138);
            txtOrder.MaxLength = 3;
            txtOrder.Name = "txtOrder";
            txtOrder.Size = new Size(60, 27);
            txtOrder.TabIndex = 6;
            // 
            // txtRoyalty
            // 
            txtRoyalty.Location = new Point(160, 188);
            txtRoyalty.MaxLength = 3;
            txtRoyalty.Name = "txtRoyalty";
            txtRoyalty.Size = new Size(60, 27);
            txtRoyalty.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(60, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(190, 250);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 35);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(320, 250);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 35);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmAddTitleAuthor
            // 
            ClientSize = new Size(500, 330);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(lblOrder);
            Controls.Add(lblRoyalty);
            Controls.Add(cboAuthor);
            Controls.Add(cboTitle);
            Controls.Add(txtOrder);
            Controls.Add(txtRoyalty);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Name = "frmAddTitleAuthor";
            Text = "Add Title Author";
            Load += frmAddTitleAuthor_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

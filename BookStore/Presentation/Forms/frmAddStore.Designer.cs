namespace BookStore
{
    partial class frmAddStore
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblStorId;
        private System.Windows.Forms.Label lblStorName;
        private System.Windows.Forms.Label lblStorAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;

        private System.Windows.Forms.TextBox txtStorId;
        private System.Windows.Forms.TextBox txtStorName;
        private System.Windows.Forms.TextBox txtStorAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.MaskedTextBox mtxtZip;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblStorId = new Label();
            lblStorName = new Label();
            lblStorAddress = new Label();
            lblCity = new Label();
            lblState = new Label();
            lblZip = new Label();
            txtStorId = new TextBox();
            txtStorName = new TextBox();
            txtStorAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            mtxtZip = new MaskedTextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblStorId
            // 
            lblStorId.AutoSize = true;
            lblStorId.Location = new Point(30, 30);
            lblStorId.Name = "lblStorId";
            lblStorId.Size = new Size(51, 15);
            lblStorId.TabIndex = 0;
            lblStorId.Text = "Store ID:";
            // 
            // lblStorName
            // 
            lblStorName.AutoSize = true;
            lblStorName.Location = new Point(30, 70);
            lblStorName.Name = "lblStorName";
            lblStorName.Size = new Size(72, 15);
            lblStorName.TabIndex = 2;
            lblStorName.Text = "Store Name:";
            // 
            // lblStorAddress
            // 
            lblStorAddress.AutoSize = true;
            lblStorAddress.Location = new Point(30, 110);
            lblStorAddress.Name = "lblStorAddress";
            lblStorAddress.Size = new Size(82, 15);
            lblStorAddress.TabIndex = 4;
            lblStorAddress.Text = "Store Address:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(30, 150);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 6;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(30, 190);
            lblState.Name = "lblState";
            lblState.Size = new Size(36, 15);
            lblState.TabIndex = 8;
            lblState.Text = "State:";
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new Point(30, 230);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(27, 15);
            lblZip.TabIndex = 10;
            lblZip.Text = "Zip:";
            // 
            // txtStorId
            // 
            txtStorId.Location = new Point(150, 27);
            txtStorId.MaxLength = 4;
            txtStorId.Name = "txtStorId";
            txtStorId.Size = new Size(100, 23);
            txtStorId.TabIndex = 1;
            // 
            // txtStorName
            // 
            txtStorName.Location = new Point(150, 67);
            txtStorName.MaxLength = 40;
            txtStorName.Name = "txtStorName";
            txtStorName.Size = new Size(100, 23);
            txtStorName.TabIndex = 3;
            // 
            // txtStorAddress
            // 
            txtStorAddress.Location = new Point(150, 107);
            txtStorAddress.MaxLength = 40;
            txtStorAddress.Name = "txtStorAddress";
            txtStorAddress.Size = new Size(100, 23);
            txtStorAddress.TabIndex = 5;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(150, 147);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 7;
            // 
            // txtState
            // 
            txtState.Location = new Point(150, 187);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(100, 23);
            txtState.TabIndex = 9;
            // 
            // mtxtZip
            // 
            mtxtZip.Location = new Point(150, 227);
            mtxtZip.Mask = "00000";
            mtxtZip.Name = "mtxtZip";
            mtxtZip.Size = new Size(100, 23);
            mtxtZip.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(150, 280);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(270, 280);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // frmAddStore
            // 
            ClientSize = new Size(376, 329);
            Controls.Add(lblStorId);
            Controls.Add(txtStorId);
            Controls.Add(lblStorName);
            Controls.Add(txtStorName);
            Controls.Add(lblStorAddress);
            Controls.Add(txtStorAddress);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(lblState);
            Controls.Add(txtState);
            Controls.Add(lblZip);
            Controls.Add(mtxtZip);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmAddStore";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Store";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

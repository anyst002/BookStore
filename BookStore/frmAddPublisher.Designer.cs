namespace BookStore
{
    partial class frmAddPublisher
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblPubId;
        private System.Windows.Forms.Label lblPubName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCountry;

        private System.Windows.Forms.TextBox txtPubId;
        private System.Windows.Forms.TextBox txtPubName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCountry;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;

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
            lblPubId = new Label();
            lblPubName = new Label();
            lblCity = new Label();
            lblState = new Label();
            lblCountry = new Label();
            txtPubId = new TextBox();
            txtPubName = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtCountry = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblPubId
            // 
            lblPubId.AutoSize = true;
            lblPubId.Location = new Point(30, 30);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(73, 15);
            lblPubId.TabIndex = 0;
            lblPubId.Text = "Publisher ID:";
            // 
            // lblPubName
            // 
            lblPubName.AutoSize = true;
            lblPubName.Location = new Point(30, 70);
            lblPubName.Name = "lblPubName";
            lblPubName.Size = new Size(94, 15);
            lblPubName.TabIndex = 2;
            lblPubName.Text = "Publisher Name:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(30, 110);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 4;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(30, 150);
            lblState.Name = "lblState";
            lblState.Size = new Size(36, 15);
            lblState.TabIndex = 6;
            lblState.Text = "State:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(30, 190);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(53, 15);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Country:";
            // 
            // txtPubId
            // 
            txtPubId.Location = new Point(150, 27);
            txtPubId.MaxLength = 4;
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(120, 23);
            txtPubId.TabIndex = 1;
            // 
            // txtPubName
            // 
            txtPubName.Location = new Point(150, 67);
            txtPubName.MaxLength = 40;
            txtPubName.Name = "txtPubName";
            txtPubName.Size = new Size(250, 23);
            txtPubName.TabIndex = 3;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(150, 107);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(200, 23);
            txtCity.TabIndex = 5;
            // 
            // txtState
            // 
            txtState.Location = new Point(150, 147);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(60, 23);
            txtState.TabIndex = 7;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(150, 187);
            txtCountry.MaxLength = 30;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(200, 23);
            txtCountry.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 240);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(150, 240);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 30);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(270, 240);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 30);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // frmAddPublisher
            // 
            ClientSize = new Size(450, 300);
            Controls.Add(lblPubId);
            Controls.Add(txtPubId);
            Controls.Add(lblPubName);
            Controls.Add(txtPubName);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(lblState);
            Controls.Add(txtState);
            Controls.Add(lblCountry);
            Controls.Add(txtCountry);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmAddPublisher";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Publisher";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

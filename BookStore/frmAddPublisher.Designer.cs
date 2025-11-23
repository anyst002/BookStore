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
            this.lblPubId = new System.Windows.Forms.Label();
            this.lblPubName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();

            this.txtPubId = new System.Windows.Forms.TextBox();
            this.txtPubName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblPubId
            this.lblPubId.AutoSize = true;
            this.lblPubId.Location = new System.Drawing.Point(30, 30);
            this.lblPubId.Name = "lblPubId";
            this.lblPubId.Size = new System.Drawing.Size(74, 15);
            this.lblPubId.TabIndex = 0;
            this.lblPubId.Text = "Publisher ID:";
            // txtPubId
            this.txtPubId.Location = new System.Drawing.Point(150, 27);
            this.txtPubId.MaxLength = 4; // char(4)
            this.txtPubId.Name = "txtPubId";
            this.txtPubId.Size = new System.Drawing.Size(120, 23);
            this.txtPubId.TabIndex = 1;

            // lblPubName
            this.lblPubName.AutoSize = true;
            this.lblPubName.Location = new System.Drawing.Point(30, 70);
            this.lblPubName.Name = "lblPubName";
            this.lblPubName.Size = new System.Drawing.Size(96, 15);
            this.lblPubName.TabIndex = 2;
            this.lblPubName.Text = "Publisher Name:";
            // txtPubName
            this.txtPubName.Location = new System.Drawing.Point(150, 67);
            this.txtPubName.MaxLength = 40; // varchar(40)
            this.txtPubName.Name = "txtPubName";
            this.txtPubName.Size = new System.Drawing.Size(250, 23);
            this.txtPubName.TabIndex = 3;

            // lblCity
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(30, 110);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 15);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // txtCity
            this.txtCity.Location = new System.Drawing.Point(150, 107);
            this.txtCity.MaxLength = 20; // varchar(20)
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 23);
            this.txtCity.TabIndex = 5;

            // lblState
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(30, 150);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(36, 15);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State:";
            // txtState
            this.txtState.Location = new System.Drawing.Point(150, 147);
            this.txtState.MaxLength = 2; // char(2)
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(60, 23);
            this.txtState.TabIndex = 7;

            // lblCountry
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(30, 190);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(54, 15);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country:";
            // txtCountry
            this.txtCountry.Location = new System.Drawing.Point(150, 187);
            this.txtCountry.MaxLength = 30; // varchar(30)
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 23);
            this.txtCountry.TabIndex = 9;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(30, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(150, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(270, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.lblPubId);
            this.Controls.Add(this.txtPubId);
            this.Controls.Add(this.lblPubName);
            this.Controls.Add(this.txtPubName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddPublisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

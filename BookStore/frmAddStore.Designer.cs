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
            this.lblStorId = new System.Windows.Forms.Label();
            this.lblStorName = new System.Windows.Forms.Label();
            this.lblStorAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();

            this.txtStorId = new System.Windows.Forms.TextBox();
            this.txtStorName = new System.Windows.Forms.TextBox();
            this.txtStorAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.mtxtZip = new System.Windows.Forms.MaskedTextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.lblStorId.AutoSize = true;
            this.lblStorId.Location = new System.Drawing.Point(30, 30);
            this.lblStorId.Text = "Store ID:";
            this.txtStorId.Location = new System.Drawing.Point(150, 27);
            this.txtStorId.MaxLength = 4;   // char(4)

            this.lblStorName.AutoSize = true;
            this.lblStorName.Location = new System.Drawing.Point(30, 70);
            this.lblStorName.Text = "Store Name:";
            this.txtStorName.Location = new System.Drawing.Point(150, 67);
            this.txtStorName.MaxLength = 40; // varchar(40)

            this.lblStorAddress.AutoSize = true;
            this.lblStorAddress.Location = new System.Drawing.Point(30, 110);
            this.lblStorAddress.Text = "Store Address:";
            this.txtStorAddress.Location = new System.Drawing.Point(150, 107);
            this.txtStorAddress.MaxLength = 40; // varchar(40)

            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(30, 150);
            this.lblCity.Text = "City:";
            this.txtCity.Location = new System.Drawing.Point(150, 147);
            this.txtCity.MaxLength = 20; // varchar(20)

            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(30, 190);
            this.lblState.Text = "State:";
            this.txtState.Location = new System.Drawing.Point(150, 187);
            this.txtState.MaxLength = 2; // char(2)

            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(30, 230);
            this.lblZip.Text = "Zip:";
            this.mtxtZip.Location = new System.Drawing.Point(150, 227);
            this.mtxtZip.Mask = "00000"; // zip char(5)

            this.btnSave.Location = new System.Drawing.Point(30, 280);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnClear.Location = new System.Drawing.Point(150, 280);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnClose.Location = new System.Drawing.Point(270, 280);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.ClientSize = new System.Drawing.Size(460, 340);
            this.Controls.Add(this.lblStorId);
            this.Controls.Add(this.txtStorId);
            this.Controls.Add(this.lblStorName);
            this.Controls.Add(this.txtStorName);
            this.Controls.Add(this.lblStorAddress);
            this.Controls.Add(this.txtStorAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.mtxtZip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Store";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

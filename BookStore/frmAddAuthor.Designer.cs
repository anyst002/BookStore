namespace BookStore
{
    partial class frmAddAuthor
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
            lblAuthorID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblCity = new Label();
            lblState = new Label();
            lblZip = new Label();
            lblContract = new Label();
            txtID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            mtxtPhone = new MaskedTextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            chkContract = new CheckBox();
            mtxtZip = new MaskedTextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblAuthorID
            // 
            lblAuthorID.AutoSize = true;
            lblAuthorID.Location = new Point(22, 11);
            lblAuthorID.Margin = new Padding(2, 0, 2, 0);
            lblAuthorID.Name = "lblAuthorID";
            lblAuthorID.Size = new Size(61, 15);
            lblAuthorID.TabIndex = 0;
            lblAuthorID.Text = "Author ID:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(17, 38);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(18, 64);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(41, 89);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(31, 118);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(55, 146);
            lblCity.Margin = new Padding(2, 0, 2, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 5;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(49, 175);
            lblState.Margin = new Padding(2, 0, 2, 0);
            lblState.Name = "lblState";
            lblState.Size = new Size(36, 15);
            lblState.TabIndex = 6;
            lblState.Text = "State:";
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new Point(59, 204);
            lblZip.Margin = new Padding(2, 0, 2, 0);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(27, 15);
            lblZip.TabIndex = 7;
            lblZip.Text = "Zip:";
            // 
            // lblContract
            // 
            lblContract.AutoSize = true;
            lblContract.Location = new Point(29, 233);
            lblContract.Margin = new Padding(2, 0, 2, 0);
            lblContract.Name = "lblContract";
            lblContract.Size = new Size(56, 15);
            lblContract.TabIndex = 8;
            lblContract.Text = "Contract:";
            // 
            // txtID
            // 
            txtID.Location = new Point(92, 10);
            txtID.Margin = new Padding(2, 2, 2, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(106, 23);
            txtID.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(92, 37);
            txtFirstName.Margin = new Padding(2, 2, 2, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(106, 23);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(92, 62);
            txtLastName.Margin = new Padding(2, 2, 2, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(106, 23);
            txtLastName.TabIndex = 11;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(92, 88);
            mtxtPhone.Margin = new Padding(2, 2, 2, 2);
            mtxtPhone.Mask = "(999) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(106, 23);
            mtxtPhone.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(92, 116);
            txtAddress.Margin = new Padding(2, 2, 2, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(106, 23);
            txtAddress.TabIndex = 13;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(92, 144);
            txtCity.Margin = new Padding(2, 2, 2, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(106, 23);
            txtCity.TabIndex = 14;
            // 
            // txtState
            // 
            txtState.Location = new Point(92, 173);
            txtState.Margin = new Padding(2, 2, 2, 2);
            txtState.Name = "txtState";
            txtState.Size = new Size(106, 23);
            txtState.TabIndex = 15;
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Location = new Point(101, 235);
            chkContract.Margin = new Padding(2, 2, 2, 2);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(15, 14);
            chkContract.TabIndex = 17;
            chkContract.UseVisualStyleBackColor = true;
            // 
            // mtxtZip
            // 
            mtxtZip.Location = new Point(92, 202);
            mtxtZip.Margin = new Padding(2, 2, 2, 2);
            mtxtZip.Mask = "00000";
            mtxtZip.Name = "mtxtZip";
            mtxtZip.Size = new Size(106, 23);
            mtxtZip.TabIndex = 18;
            mtxtZip.ValidatingType = typeof(int);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(22, 263);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(56, 20);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(92, 263);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(56, 20);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(161, 263);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(56, 20);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddAuthor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 293);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(mtxtZip);
            Controls.Add(chkContract);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(mtxtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtID);
            Controls.Add(lblContract);
            Controls.Add(lblZip);
            Controls.Add(lblState);
            Controls.Add(lblCity);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblAuthorID);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "frmAddAuthor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Author";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAuthorID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblCity;
        private Label lblState;
        private Label lblZip;
        private Label lblContract;
        private TextBox txtID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private MaskedTextBox mtxtPhone;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private CheckBox chkContract;
        private MaskedTextBox mtxtZip;
        private Button btnSave;
        private Button btnClear;
        private Button btnClose;
    }
}
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
            lblAuthorID.Location = new Point(31, 19);
            lblAuthorID.Name = "lblAuthorID";
            lblAuthorID.Size = new Size(94, 25);
            lblAuthorID.TabIndex = 0;
            lblAuthorID.Text = "Author ID:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(24, 64);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(101, 25);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(26, 107);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(59, 148);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(66, 25);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(44, 196);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(81, 25);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(79, 243);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(46, 25);
            lblCity.TabIndex = 5;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(70, 292);
            lblState.Name = "lblState";
            lblState.Size = new Size(55, 25);
            lblState.TabIndex = 6;
            lblState.Text = "State:";
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new Point(84, 340);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(41, 25);
            lblZip.TabIndex = 7;
            lblZip.Text = "Zip:";
            // 
            // lblContract
            // 
            lblContract.AutoSize = true;
            lblContract.Location = new Point(42, 388);
            lblContract.Name = "lblContract";
            lblContract.Size = new Size(83, 25);
            lblContract.TabIndex = 8;
            lblContract.Text = "Contract:";
            // 
            // txtID
            // 
            txtID.Location = new Point(131, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(131, 61);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(131, 104);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 11;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(131, 146);
            mtxtPhone.Mask = "(999) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(150, 31);
            mtxtPhone.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(131, 193);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 13;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(131, 240);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 14;
            // 
            // txtState
            // 
            txtState.Location = new Point(131, 289);
            txtState.Name = "txtState";
            txtState.Size = new Size(150, 31);
            txtState.TabIndex = 15;
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Location = new Point(144, 391);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(22, 21);
            chkContract.TabIndex = 17;
            chkContract.UseVisualStyleBackColor = true;
            // 
            // mtxtZip
            // 
            mtxtZip.Location = new Point(131, 337);
            mtxtZip.Mask = "00000";
            mtxtZip.Name = "mtxtZip";
            mtxtZip.Size = new Size(150, 31);
            mtxtZip.TabIndex = 18;
            mtxtZip.ValidatingType = typeof(int);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(31, 438);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 34);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(131, 438);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 34);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(230, 438);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 34);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddAuthor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 489);
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
            MaximizeBox = false;
            Name = "frmAddAuthor";
            ShowIcon = false;
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
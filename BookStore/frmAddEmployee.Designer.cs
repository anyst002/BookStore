namespace BookStore
{
    partial class frmAddEmployee
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
            lblEmployeeId = new Label();
            txtEmployeeId = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblMiddleInitial = new Label();
            txtMiddleInitial = new TextBox();
            lblJobId = new Label();
            txtJobId = new TextBox();
            lblJobLevel = new Label();
            btnSave = new Button();
            btnClear = new Button();
            btnClose = new Button();
            lblPubId = new Label();
            txtPubId = new TextBox();
            lblHireDate = new Label();
            txtJobLevel = new TextBox();
            btnSelectJobId = new Button();
            btnSelectPubId = new Button();
            datHireDate = new DateTimePicker();
            SuspendLayout();
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(24, 25);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(76, 15);
            lblEmployeeId.TabIndex = 15;
            lblEmployeeId.Text = "Employee ID:";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(144, 22);
            txtEmployeeId.MaxLength = 9;
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(100, 23);
            txtEmployeeId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(24, 65);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 17;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(144, 62);
            txtFirstName.MaxLength = 20;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(24, 105);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 19;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(144, 102);
            txtLastName.MaxLength = 30;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 3;
            // 
            // lblMiddleInitial
            // 
            lblMiddleInitial.AutoSize = true;
            lblMiddleInitial.Location = new Point(24, 145);
            lblMiddleInitial.Name = "lblMiddleInitial";
            lblMiddleInitial.Size = new Size(79, 15);
            lblMiddleInitial.TabIndex = 21;
            lblMiddleInitial.Text = "Middle Initial:";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(144, 142);
            txtMiddleInitial.MaxLength = 1;
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(100, 23);
            txtMiddleInitial.TabIndex = 4;
            // 
            // lblJobId
            // 
            lblJobId.AutoSize = true;
            lblJobId.Location = new Point(24, 185);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(42, 15);
            lblJobId.TabIndex = 23;
            lblJobId.Text = "Job ID:";
            // 
            // txtJobId
            // 
            txtJobId.Enabled = false;
            txtJobId.Location = new Point(144, 182);
            txtJobId.MaxLength = 5;
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(100, 23);
            txtJobId.TabIndex = 24;
            txtJobId.TabStop = false;
            // 
            // lblJobLevel
            // 
            lblJobLevel.AutoSize = true;
            lblJobLevel.Location = new Point(24, 225);
            lblJobLevel.Name = "lblJobLevel";
            lblJobLevel.Size = new Size(58, 15);
            lblJobLevel.TabIndex = 25;
            lblJobLevel.Text = "Job Level:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(24, 354);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(144, 354);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(264, 354);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // lblPubId
            // 
            lblPubId.AutoSize = true;
            lblPubId.Location = new Point(24, 265);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(73, 15);
            lblPubId.TabIndex = 30;
            lblPubId.Text = "Publisher ID:";
            // 
            // txtPubId
            // 
            txtPubId.Enabled = false;
            txtPubId.Location = new Point(144, 262);
            txtPubId.MaxLength = 4;
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(100, 23);
            txtPubId.TabIndex = 31;
            txtPubId.TabStop = false;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Location = new Point(24, 305);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(59, 15);
            lblHireDate.TabIndex = 32;
            lblHireDate.Text = "Hire Date:";
            // 
            // txtJobLevel
            // 
            txtJobLevel.Location = new Point(144, 222);
            txtJobLevel.MaxLength = 3;
            txtJobLevel.Name = "txtJobLevel";
            txtJobLevel.Size = new Size(100, 23);
            txtJobLevel.TabIndex = 6;
            // 
            // btnSelectJobId
            // 
            btnSelectJobId.Location = new Point(264, 182);
            btnSelectJobId.Name = "btnSelectJobId";
            btnSelectJobId.Size = new Size(75, 23);
            btnSelectJobId.TabIndex = 5;
            btnSelectJobId.Text = "Select";
            btnSelectJobId.UseVisualStyleBackColor = true;
            btnSelectJobId.Click += btnSelectJobId_Click;
            // 
            // btnSelectPubId
            // 
            btnSelectPubId.Location = new Point(264, 262);
            btnSelectPubId.Name = "btnSelectPubId";
            btnSelectPubId.Size = new Size(75, 23);
            btnSelectPubId.TabIndex = 7;
            btnSelectPubId.Text = "Select";
            btnSelectPubId.UseVisualStyleBackColor = true;
            btnSelectPubId.Click += btnSelectPubId_Click;
            // 
            // datHireDate
            // 
            datHireDate.Format = DateTimePickerFormat.Short;
            datHireDate.Location = new Point(144, 302);
            datHireDate.Name = "datHireDate";
            datHireDate.Size = new Size(100, 23);
            datHireDate.TabIndex = 8;
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 401);
            Controls.Add(datHireDate);
            Controls.Add(btnSelectPubId);
            Controls.Add(btnSelectJobId);
            Controls.Add(txtJobLevel);
            Controls.Add(lblPubId);
            Controls.Add(txtPubId);
            Controls.Add(lblHireDate);
            Controls.Add(lblEmployeeId);
            Controls.Add(txtEmployeeId);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblMiddleInitial);
            Controls.Add(txtMiddleInitial);
            Controls.Add(lblJobId);
            Controls.Add(txtJobId);
            Controls.Add(lblJobLevel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmAddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployeeId;
        private TextBox txtEmployeeId;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblMiddleInitial;
        private TextBox txtMiddleInitial;
        private Label lblJobId;
        private TextBox txtJobId;
        private Label lblJobLevel;
        private Button btnSave;
        private Button btnClear;
        private Button btnClose;
        private Label lblPubId;
        private TextBox txtPubId;
        private Label lblHireDate;
        private TextBox txtJobLevel;
        private Button btnSelectJobId;
        private Button btnSelectPubId;
        private DateTimePicker datHireDate;
    }
}
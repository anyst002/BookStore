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
            btnClear = new Button();
            btnSave = new Button();
            btnExit = new Button();
            lblFname = new Label();
            lblLname = new Label();
            lblMinit = new Label();
            txtbxFname = new TextBox();
            txtbxLname = new TextBox();
            txtbxMinit = new TextBox();
            txtEmpID = new TextBox();
            txtbxPubID = new TextBox();
            txtbxJLvl = new TextBox();
            txtbxJobID = new TextBox();
            masktxtbxHireDate = new MaskedTextBox();
            lblHireDate = new Label();
            lblPubID = new Label();
            lblJoblvl = new Label();
            lblJobId = new Label();
            lblEmpId = new Label();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(200, 371);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 38);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(349, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 38);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(492, 371);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 38);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Location = new Point(64, 59);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(77, 20);
            lblFname.TabIndex = 3;
            lblFname.Text = "First name";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Location = new Point(405, 59);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(76, 20);
            lblLname.TabIndex = 4;
            lblLname.Text = "Last name";
            // 
            // lblMinit
            // 
            lblMinit.AutoSize = true;
            lblMinit.Location = new Point(301, 59);
            lblMinit.Name = "lblMinit";
            lblMinit.Size = new Size(32, 20);
            lblMinit.TabIndex = 5;
            lblMinit.Text = "M.I.";
            // 
            // txtbxFname
            // 
            txtbxFname.Location = new Point(62, 82);
            txtbxFname.Name = "txtbxFname";
            txtbxFname.Size = new Size(198, 27);
            txtbxFname.TabIndex = 6;
            // 
            // txtbxLname
            // 
            txtbxLname.Location = new Point(405, 82);
            txtbxLname.Name = "txtbxLname";
            txtbxLname.Size = new Size(227, 27);
            txtbxLname.TabIndex = 7;
            // 
            // txtbxMinit
            // 
            txtbxMinit.Location = new Point(301, 82);
            txtbxMinit.Name = "txtbxMinit";
            txtbxMinit.Size = new Size(67, 27);
            txtbxMinit.TabIndex = 8;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(64, 172);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(198, 27);
            txtEmpID.TabIndex = 9;
            // 
            // txtbxPubID
            // 
            txtbxPubID.Location = new Point(62, 261);
            txtbxPubID.Name = "txtbxPubID";
            txtbxPubID.Size = new Size(124, 27);
            txtbxPubID.TabIndex = 10;
            // 
            // txtbxJLvl
            // 
            txtbxJLvl.Location = new Point(474, 172);
            txtbxJLvl.Name = "txtbxJLvl";
            txtbxJLvl.Size = new Size(158, 27);
            txtbxJLvl.TabIndex = 11;
            // 
            // txtbxJobID
            // 
            txtbxJobID.Location = new Point(301, 172);
            txtbxJobID.Name = "txtbxJobID";
            txtbxJobID.Size = new Size(138, 27);
            txtbxJobID.TabIndex = 12;
            // 
            // masktxtbxHireDate
            // 
            masktxtbxHireDate.Location = new Point(230, 261);
            masktxtbxHireDate.Mask = "00/00/0000";
            masktxtbxHireDate.Name = "masktxtbxHireDate";
            masktxtbxHireDate.Size = new Size(138, 27);
            masktxtbxHireDate.TabIndex = 13;
            masktxtbxHireDate.ValidatingType = typeof(DateTime);
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Location = new Point(230, 238);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(71, 20);
            lblHireDate.TabIndex = 14;
            lblHireDate.Text = "Hire date";
            // 
            // lblPubID
            // 
            lblPubID.AutoSize = true;
            lblPubID.Location = new Point(64, 238);
            lblPubID.Name = "lblPubID";
            lblPubID.Size = new Size(88, 20);
            lblPubID.TabIndex = 15;
            lblPubID.Text = "Publisher ID";
            // 
            // lblJoblvl
            // 
            lblJoblvl.AutoSize = true;
            lblJoblvl.Location = new Point(474, 149);
            lblJoblvl.Name = "lblJoblvl";
            lblJoblvl.Size = new Size(67, 20);
            lblJoblvl.TabIndex = 16;
            lblJoblvl.Text = "Job level";
            // 
            // lblJobId
            // 
            lblJobId.AutoSize = true;
            lblJobId.Location = new Point(301, 149);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(51, 20);
            lblJobId.TabIndex = 17;
            lblJobId.Text = "Job ID";
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(64, 149);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(94, 20);
            lblEmpId.TabIndex = 18;
            lblEmpId.Text = "Employee ID";
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmpId);
            Controls.Add(lblJobId);
            Controls.Add(lblJoblvl);
            Controls.Add(lblPubID);
            Controls.Add(lblHireDate);
            Controls.Add(masktxtbxHireDate);
            Controls.Add(txtbxJobID);
            Controls.Add(txtbxJLvl);
            Controls.Add(txtbxPubID);
            Controls.Add(txtEmpID);
            Controls.Add(txtbxMinit);
            Controls.Add(txtbxLname);
            Controls.Add(txtbxFname);
            Controls.Add(lblMinit);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnSave;
        private Button btnExit;
        private Label lblFname;
        private Label lblLname;
        private Label lblMinit;
        private TextBox txtbxFname;
        private TextBox txtbxLname;
        private TextBox txtbxMinit;
        private TextBox txtEmpID;
        private TextBox txtbxPubID;
        private TextBox txtbxJLvl;
        private TextBox txtbxJobID;
        private MaskedTextBox masktxtbxHireDate;
        private Label lblHireDate;
        private Label lblPubID;
        private Label lblJoblvl;
        private Label lblJobId;
        private Label lblEmpId;
    }
}
namespace BookStore
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            mtxtEmployeeId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleInitial.Clear();
            txtJobId.Clear();
            txtJobLevel.Clear();
            txtPubId.Clear();
            datHireDate.ResetText();
        }

        private void Insert()
        {
            string? initial = (string.IsNullOrWhiteSpace(txtMiddleInitial.Text)) ? null : txtMiddleInitial.Text;
            byte? lvl = (string.IsNullOrWhiteSpace(txtJobLevel.Text)) ? null : Convert.ToByte(txtJobLevel.Text);

            Employee emp = new Employee(mtxtEmployeeId.Text.ToUpper()
                , txtFirstName.Text.Trim()
                , initial
                , txtLastName.Text.Trim()
                , Convert.ToInt16(txtJobId.Text)
                , lvl
                , txtPubId.Text
                , datHireDate.Value);

            MaintenanceRepository repo = new MaintenanceRepository();
            repo.InsertEmployee(emp);

            MessageBox.Show("Employee added successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.Validate(() =>
            {
                if(!mtxtEmployeeId.MaskFull) //TODO make this an assertion later
                {
                    MessageBox.Show("Please enter an acceptable ID.",
                                "ID Missing");
                    return;
                }

                AssertNotNullOrWhiteSpace(txtFirstName.Text, "Please enter a first name.");
                AssertNotNullOrWhiteSpace(txtLastName.Text, "Please enter a last name.");
                if (!string.IsNullOrWhiteSpace(txtJobLevel.Text))
                    AssertByte(txtJobLevel.Text, "Job level must be between 0-255 or blank.");

                Insert();
                Clear();
            });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();   
        }

        private void btnSelectJobId_Click(object sender, EventArgs e)
        {
            MaintenanceRepository repo = new MaintenanceRepository();
            List<IdInfo> list = repo.GetJobIds();
            txtJobId.Text = MaintenanceRepository.SelectId(list);
        }

        private void btnSelectPubId_Click(object sender, EventArgs e)
        {
            MaintenanceRepository repo = new MaintenanceRepository();
            List<IdInfo> list = repo.GetPublisherIds();
            txtPubId.Text = MaintenanceRepository.SelectId(list);
        }
    }
}

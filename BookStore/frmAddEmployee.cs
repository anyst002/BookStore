//using static MaintenanceRepository;

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
            txtEmployeeId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleInitial.Clear();
            txtJobId.Clear();
            txtJobLevel.Clear();
            txtPubId.Clear();
            datHireDate.ResetText();
        }

        private void SelectId(Action action, System.Windows.Forms.TextBox textbox) //TODO move to maintrepo
        {
            //get list of ids from database
            //List<(string id, string descriptor)> list = action.Invoke();

            //frmSelectId selectForm = new frmSelectId(list);
            //selectForm.ShowDialog();
            //(string id, string descriptor) item = output from selection somehow

            //textbox.Text = item.id;
        }

        private void Insert()
        {
            //Employee emp = new Employee(txtEmployeeId.Text
                                        //, txtFirstName.Text.Trim()
                                        //, txtMiddleInitial.Trim()
                                        //, txtLastName.Text.Trim()
                                        //, txtJobId.Text
                                        //, txtJobLevel.Text.Trim()
                                        //, txtPubId.Text
                                        //, datHireDate.Value);
            //InsertEmployee(emp); repo call
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.Validate(() =>
            {
                AssertNoWhitespace(AssertStringLengthEquals(txtEmployeeId.Text, 9
                    , "Employee ID must be exactly 9 characters.")
                    , "Employee ID cannot include spaces.");
                AssertNotNullOrWhiteSpace(txtFirstName.Text, "Please enter a first name.");
                AssertNotNullOrWhiteSpace(txtLastName.Text, "Please enter a last name.");
                if (!string.IsNullOrWhiteSpace(txtJobLevel.Text))
                    AssertByte(txtJobLevel.Text, "Job level must be between 0-255 or blank.");

                MessageBox.Show("Store validated successfully.\n(Database save added later.)",
                                "Validated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Insert();
            });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); //TODO should be changed to hide later
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();   
        }

        private void btnSelectJobId_Click(object sender, EventArgs e)
        {
            //SelectId(GetJobIds, txtJobId); repo call
            txtJobId.Text = "temp";
        }

        private void btnSelectPubId_Click(object sender, EventArgs e)
        {
            //SelectId(GetPublisherIds, txtPubId); repo call
            txtPubId.Text = "temp";
        }
    }
}

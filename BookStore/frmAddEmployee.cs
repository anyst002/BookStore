//using static MaintenanceRepository;

using System.Collections.Generic;

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

        private void SelectId(Action action, System.Windows.Forms.TextBox textbox) //TODO move to MaintenanceRepository
        {
            //get list of ids from database
            //ListViewItem[] list = action.Invoke();

            //frmSelectId selectForm = new frmSelectId(list);
            //selectForm.ShowDialog();
            //ListViewItem item = output from selection somehow, verify not null

            //textbox.Text = item.SubItems[0];
        }

        private void Insert()
        {
            //string? initial = (string.IsNullOrWhiteSpace(txtMiddleInitial.Text)) ? null : txtMiddleInitial.Text;
            //byte? lvl = (string.IsNullOrWhiteSpace(txtJobLevel.Text)) ? null : Convert.ToByte(txtJobLevel.Text);

            //Employee emp = new Employee(txtEmployeeId.Text
                                        //, txtFirstName.Text.Trim()
                                        //, initial
                                        //, txtLastName.Text.Trim()
                                        //, Convert.ToInt16(txtJobId.Text)
                                        //, lvl
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
            frmSelectId selectForm = new frmSelectId();
            selectForm.ShowDialog();
            txtJobId.Text = "temp";
        }

        private void btnSelectPubId_Click(object sender, EventArgs e)
        {
            //SelectId(GetPublisherIds, txtPubId); repo call
            frmSelectId selectForm = new frmSelectId();
            selectForm.ShowDialog();
            txtPubId.Text = "temp";
        }
    }
}

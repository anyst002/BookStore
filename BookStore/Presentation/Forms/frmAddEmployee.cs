using static BookStore.Business.BusinessManager;
using static BookStore.Presentation.PresentationUtilities;
using BookStore.Entities;
using BookStore.Business;

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
            AddEmployee(mtxtEmployeeId.Text
                , txtFirstName.Text.Trim()
                , txtMiddleInitial.Text
                , txtLastName.Text.Trim()
                , Convert.ToInt16(txtJobId.Text)
                , txtJobLevel.Text
                , txtPubId.Text
                , datHireDate.Value);

            MessageBox.Show("Employee added successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.Validate(() =>
            {
                if(!mtxtEmployeeId.MaskFull) //TODO make this an assertion later
                {
                    MessageBox.Show("Please enter an employee ID.",
                                "Input Missing");
                    return;
                }

                char[] id = mtxtEmployeeId.Text.ToCharArray(); //this whole block is terrible but it'll work for now
                if (!(id[1] >= 'A' && id[1] <= 'Z') && id[1] != '-')
                {
                    MessageBox.Show("Second digit of employee ID must be between A-Z inclusive or a -.",
                                "ID Error");
                    return;
                }
                if (id[3] == '0')
                {
                    MessageBox.Show("Fourth digit of employee ID must be between 1-9 inclusive.",
                                "ID Error");
                    return;
                }
                if (id[8] != 'F' && id[8] != 'M')
                {
                    MessageBox.Show("Final digit of employee ID must be either F or M.",
                                "ID Error");
                    return;
                }

                AssertNotNullOrWhiteSpace(txtFirstName.Text, "Please enter a first name.");
                AssertNotNullOrWhiteSpace(txtLastName.Text, "Please enter a last name.");
                if (!string.IsNullOrWhiteSpace(txtJobLevel.Text))
                    AssertByte(txtJobLevel.Text, "Job level must be between 0-255 or blank.");

                Insert();
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
            List<IdInfo> list = SelectJobIds();
            txtJobId.Text = SelectId(list);
        }

        private void btnSelectPubId_Click(object sender, EventArgs e)
        {
            List<IdInfo> list = SelectPublisherIds();
            txtPubId.Text = SelectId(list);
        }
    }
}

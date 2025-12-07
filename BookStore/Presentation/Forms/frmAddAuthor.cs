using static BookStore.Business.BusinessManager;
using static BookStore.Presentation.PresentationUtilities;
using BookStore.Business;

namespace BookStore
{
    public partial class frmAddAuthor : Form
    {
        public frmAddAuthor()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            AddAuthor(mtxtID.Text
                , txtLastName.Text.Trim()
                , txtFirstName.Text.Trim()
                , mtxtPhone.Text
                , txtAddress.Text.Trim()
                , txtCity.Text.Trim()
                , txtState.Text.Trim()
                , mtxtZip.Text.Replace("-", "")
                , chkContract.Checked);

            MessageBox.Show("Author added successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void Clear()
        {
            mtxtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            mtxtPhone.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            mtxtZip.Clear();
            chkContract.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.Validate(() =>
            {
                AssertMaskFull(mtxtID, "Please enter an author ID.");

                AssertNotNullOrWhiteSpace(txtFirstName.Text, "Please enter a first name.");
                AssertNotNullOrWhiteSpace(txtLastName.Text, "Please enter a last name.");

                AssertMaskFull(mtxtPhone, "Please enter a phone number.");

                ValidateState(txtState.Text);

                ValidateZip(mtxtZip);

                Insert();
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

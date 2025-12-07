using static BookStore.Business.BusinessManager;
using static BookStore.Presentation.PresentationUtilities;
using BookStore.Business;

namespace BookStore
{
    public partial class frmAddStore : Form
    {
        public frmAddStore()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            AddStore(txtStorId.Text.Trim()
                , txtStorName.Text.Trim()
                , txtStorAddress.Text.Trim()
                , txtCity.Text.Trim()
                , txtState.Text.Trim()
                , mtxtZip.Text.Replace("-", ""));

            MessageBox.Show("Store saved successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            Clear();
        }

        private void Clear()
        {
            txtStorId.Clear();
            txtStorName.Clear();
            txtStorAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            mtxtZip.Clear();
            txtStorId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.Validate(() =>
            {
                AssertNotNullOrWhiteSpace(txtStorId.Text, "Store ID is required.");
                AssertNoWhitespace(txtStorId.Text, "Store ID cannot include spaces.");
                AssertStringLengthEquals(txtStorId.Text, 4, "Store ID must be exactly 4 characters.");

                ValidateState(txtState.Text);
                ValidateZip(mtxtZip);

                Insert();
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


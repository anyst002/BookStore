using static BookStore.Business.BusinessManager;
using static BookStore.Presentation.PresentationUtilities;
using BookStore.Business;

namespace BookStore
{
    public partial class frmAddPublisher : Form
    {
        public frmAddPublisher()
        {
            InitializeComponent();
        }
        private void Insert()
        {
            AddPublisher(mtxtPubId.Text.Trim()
                , txtPubName.Text.Trim()
                , txtCity.Text.Trim()
                , txtState.Text.Trim()
                , txtCountry.Text.Trim());

            MessageBox.Show("Publisher saved successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Clear();
        }

        private void Clear()
        {
            mtxtPubId.Clear();
            txtPubName.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtCountry.Clear();
            mtxtPubId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.Validate(() =>
            {
                AssertMaskFull(mtxtPubId, "Publisher ID is required.");

                ValidateState(txtState.Text);

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


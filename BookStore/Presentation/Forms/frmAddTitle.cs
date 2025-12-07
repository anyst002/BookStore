using static BookStore.Business.BusinessManager;
using static BookStore.Presentation.PresentationUtilities;
using BookStore.Entities;
using BookStore.Business;

namespace BookStore
{
    public partial class frmAddTitle : Form
    {
        public frmAddTitle()
        {
            InitializeComponent();
        }

        private void AddAuthorPopup()
        {
            DialogResult res = MessageBox.Show(
                "Would you like to add authors to this title?",
                "Add Authors?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                frmAddTitleAuthor f = new frmAddTitleAuthor(txtTitleID.Text.Trim());
                f.ShowDialog();
            }
        }

        private void Insert()
        {
            AddTitle(txtTitleID.Text.Trim()
                , txtTitle.Text.Trim()
                , txtType.Text.Trim()
                , txtPublisher.Text
                , txtPrice.Text.Trim()
                , txtAdvance.Text.Trim()
                , txtRoyalty.Text.Trim()
                , txtYTDSales.Text.Trim()
                , txtNotes.Text.Trim()
                , dtpPubDate.Value.Date);

            MessageBox.Show("Title added successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AddAuthorPopup();

            Clear();
        }


        private void Clear()
        {
            txtTitleID.Clear();
            txtTitle.Clear();
            txtType.Clear();
            txtPublisher.Clear();
            txtPrice.Clear();
            txtAdvance.Clear();
            txtRoyalty.Clear();
            txtYTDSales.Clear();
            txtNotes.Clear();
            dtpPubDate.ResetText();
            txtTitleID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            validator.Validate(() =>
            {
                AssertNotNullOrWhiteSpace(txtTitleID.Text, "Title ID is required.");

                AssertNoWhitespace(AssertStringLengthEquals(txtTitleID.Text, 6
                    , "Title ID must be exactly 6 characters.")
                    , "Title ID cannot include spaces.");

                AssertNotNullOrWhiteSpace(txtTitle.Text, "Title is required.");

                AssertNotNullOrWhiteSpace(txtType.Text, "Type is required.");

                if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    AssertPositive(AssertDecimal(txtPrice.Text
                        , "Price must be a whole number.")
                        , "Price must be positive.");
                }
                if (!string.IsNullOrWhiteSpace(txtAdvance.Text))
                {
                    AssertPositive(AssertDecimal(txtAdvance.Text
                        , "Advance must be a whole number.")
                        , "Advance must be positive.");
                }
                if (!string.IsNullOrWhiteSpace(txtRoyalty.Text))
                {
                    AssertPositive(AssertInt32(txtRoyalty.Text
                        , "Royalty must be a whole number.")
                        , "Royalty must be positive.");
                }
                if (!string.IsNullOrWhiteSpace(txtYTDSales.Text))
                {
                    AssertPositive(AssertInt32(txtYTDSales.Text
                        , "YTD Sales must be a whole number.")
                        , "YTD Sales must be positive.");
                }

                Insert();
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<IdInfo> list = SelectPublisherIds();
            txtPublisher.Text = SelectId(list);
        }
    }
}

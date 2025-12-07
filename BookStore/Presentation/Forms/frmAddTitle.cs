using BookStore.Data;
using BookStore.Entities;
using BookStore.Business;
using BookStore.Presentation;

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
            BusinessManager.AddTitle(txtTitleID.Text.Trim()
                , txtTitle.Text.Trim()
                , cboType.SelectedItem!.ToString()   // validated in btnSave // switch to string
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
            cboType.SelectedIndex = -1;
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
                AssertNotNullOrWhiteSpace(txtTitleID.Text, "Title ID is required."); //TODO check for all whitespace

                AssertNoWhitespace(AssertStringLengthEquals(txtTitleID.Text, 6
                    , "Title ID must be exactly 6 characters.")
                    , "Title ID cannot include spaces.");

                AssertNotNullOrWhiteSpace(txtTitle.Text, "Title is required.");

                AssertComboSelection(cboType, "Please select a Type."); //TODO change this to textbox
                AssertNotNullOrWhiteSpace(txtPublisher.Text, "Please select a Publisher."); //TODO make optional

                AssertNonNegative(AssertDecimal(txtPrice.Text, "Price must be a decimal.")); //TODO make optional
                AssertNonNegative(AssertDecimal(txtAdvance.Text, "Advance must be a decimal.")); //TODO make optional
                AssertNonNegative(AssertInt32(txtRoyalty.Text, "Royalty must be a whole number.")); //TODO make optional
                AssertNonNegative(AssertInt32(txtYTDSales.Text, "YTD Sales must be a whole number.")); //TODO make optional

                MessageBox.Show("Title validated successfully!", "Validated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            MaintenanceRepository repo = new MaintenanceRepository();
            List<IdInfo> list = repo.GetPublisherIds();
            txtPublisher.Text = MaintenanceRepository.SelectId(list);
        }
    }
}

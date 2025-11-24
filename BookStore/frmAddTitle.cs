using InputValidator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static InputValidator.InputAssertions;

namespace BookStore
{
    public partial class frmAddTitle : Form
    {
        public frmAddTitle()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            //Title title = new Title( construct here )
            //InsertTitle(title);

            DialogResult res = MessageBox.Show("Would you like to add authors to this title?", "Added",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                frmAddTitleAuthor titleAuthorForm = new frmAddTitleAuthor("temp");
                //frmAddTitleAuthor titleAuthorForm = new frmAddTitleAuthor(title.TitleId);
                titleAuthorForm.ShowDialog();
            }

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
                AssertNotNullOrWhiteSpace(txtTitleID.Text, "Title ID is required.");

                AssertNoWhitespace(AssertStringLengthEquals(txtTitleID.Text, 6
                    , "Title ID must be exactly 6 characters.")
                    , "Title ID cannot include spaces.");

                AssertNotNullOrWhiteSpace(txtTitle.Text, "Title is required.");

                AssertComboSelection(cboType, "Please select a Type.");
                AssertNotNullOrWhiteSpace(txtPublisher.Text, "Please select a Publisher.");

                AssertNonNegative(AssertDecimal(txtPrice.Text, "Price must be a decimal."));
                AssertNonNegative(AssertDecimal(txtAdvance.Text, "Advance must be a decimal."));
                AssertNonNegative(AssertInt32(txtRoyalty.Text, "Royalty must be a whole number."));
                AssertNonNegative(AssertInt32(txtYTDSales.Text, "YTD Sales must be a whole number."));

                DateTime pubDate = dtpPubDate.Value;

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

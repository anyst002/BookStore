using System;
using System.Windows.Forms;
using InputValidator;
using static InputValidator.InputAssertions;

namespace BookStore
{
    public partial class frmAddTitle : Form
    {
        private readonly Validator _validator = new Validator();

        public frmAddTitle()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _validator.Validate(() =>
            {
                if (string.IsNullOrWhiteSpace(txtTitleID.Text))
                    throw new NullReferenceException("Title ID is required.");

                if (txtTitleID.Text.Trim().Length != 6)
                    throw new ArgumentOutOfRangeException("", "Title ID must be exactly 6 characters.");

                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    throw new NullReferenceException("Title is required.");

                AssertComboSelection(cboType, "Please select a Type.");
                AssertComboSelection(cboPublisher, "Please select a Publisher.");

                AssertNonNegative(AssertDecimal(txtPrice.Text, "Price must be a decimal."));
                AssertNonNegative(AssertDecimal(txtAdvance.Text, "Advance must be a decimal."));
                AssertNonNegative(AssertInt32(txtRoyalty.Text, "Royalty must be a whole number."));
                AssertNonNegative(AssertInt32(txtYTDSales.Text, "YTD Sales must be a whole number."));

                DateTime pubDate = dtpPubDate.Value;

                MessageBox.Show("Title validated successfully!", "Validated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitleID.Clear();
            txtTitle.Clear();
            cboType.SelectedIndex = -1;
            cboPublisher.SelectedIndex = -1;
            txtPrice.Clear();
            txtAdvance.Clear();
            txtRoyalty.Clear();
            txtYTDSales.Clear();
            txtNotes.Clear();
            dtpPubDate.Value = DateTime.Today;
            txtTitleID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

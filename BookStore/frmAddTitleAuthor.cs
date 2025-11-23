using System;
using System.Windows.Forms;
using InputValidator;
using static InputValidator.InputAssertions;

namespace BookStore
{
    public partial class frmAddTitleAuthor : Form
    {
        private readonly Validator _validator = new Validator();

        public frmAddTitleAuthor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _validator.Validate(() =>
            {
                AssertComboSelection(cboAuthor, "Please select an Author.");
                AssertComboSelection(cboTitle, "Please select a Title.");

                int order = AssertInt32(txtOrder.Text, "Order must be a whole number.");
                AssertPositive(order, "Order must be positive.");

                int royalty = AssertInt32(txtRoyalty.Text, "Royalty must be a whole number.");
                if (royalty < 0 || royalty > 100)
                    throw new ArgumentOutOfRangeException("", "Royalty must be between 0 and 100.");

                MessageBox.Show("Title-Author relationship validated successfully!",
                    "Validated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboAuthor.SelectedIndex = -1;
            cboTitle.SelectedIndex = -1;
            txtOrder.Clear();
            txtRoyalty.Clear();
            cboAuthor.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

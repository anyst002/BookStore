using System;
using System.Windows.Forms;
using InputValidator;
using static InputValidator.InputAssertions;

namespace BookStore
{
    public partial class frmAddTitleAuthor : Form
    {
        public frmAddTitleAuthor(string title)
        {
            InitializeComponent();
            txtTitle.Text = title;
        }

        private void Insert()
        {
            //TitleAuthor entry = new TitleAuthor( construct here )
            //InsertTitleAuthor(entry);

            Clear();
        }

        private void Clear()
        {
            txtAuthor.Clear();
            txtOrder.Clear();
            txtRoyalty.Clear();
            txtOrder.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.Validate(() =>
            {
                AssertNotNullOrWhiteSpace(txtAuthor.Text, "Please select an author.");
                int order = AssertInt32(txtOrder.Text, "Order must be a whole number.");
                AssertPositive(order, "Order must be positive.");

                int royalty = AssertInt32(txtRoyalty.Text, "Royalty must be a whole number.");
                if (royalty < 0 || royalty > 100)
                    throw new ArgumentOutOfRangeException("", "Royalty must be between 0 and 100.");

                MessageBox.Show("Title-Author relationship validated successfully!",
                    "Validated", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            List<IdInfo> list = repo.GetAuthorIds();
            MaintenanceRepository.SelectId(list, txtAuthor);
        }
    }
}

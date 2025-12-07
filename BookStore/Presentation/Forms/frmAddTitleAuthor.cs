using BookStore.Business;
using BookStore.Entities;
using static BookStore.Business.BusinessManager;
using static BookStore.Presentation.PresentationUtilities;

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
            AddTitleAuthor(txtAuthor.Text
                , txtTitle.Text
                , txtOrder.Text.Trim()
                , txtRoyalty.Text.Trim());

            MessageBox.Show("Author added to title successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                
                if (!string.IsNullOrWhiteSpace(txtOrder.Text))
                {
                    int order = AssertInt32(txtOrder.Text, "Author order must be a whole number.");
                    AssertPositive(order, "Author order must be positive.");
                }

                if (!string.IsNullOrWhiteSpace(txtRoyalty.Text))
                {
                    int royalty = AssertInt32(txtRoyalty.Text, "Royalty must be a whole number.");
                    AssertInRange(royalty, 0, 100, "Royalty must be between 0 and 100.");
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
            List<IdInfo> list = SelectAuthorIds();
            txtAuthor.Text = SelectId(list);
        }
    }
}

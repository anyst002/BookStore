using InputValidator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using InputValidator;
using static InputValidator.InputAssertions;


namespace BookStore
{
    public partial class frmAddTitle : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;

        SqlConnection connection;
        SqlCommand command;

        public frmAddTitle()
        {
            InitializeComponent();

            connection = new(connectionString);
            command = new("", connection);

            LoadPublishers();
            LoadTypes();
        }

        private void Insert()
        {
            MaintenanceRepository repo = new MaintenanceRepository();

            // Construct the Title record from UI inputs
            Title title = new Title(
                TitleId: txtTitleID.Text,
                TitleName: txtTitle.Text,
                Type: cboType.SelectedItem!.ToString(),   // validated in btnSave
                PubId: txtPublisher.Text,
                Price: decimal.Parse(txtPrice.Text),
                Advance: decimal.Parse(txtAdvance.Text),
                Royalty: int.Parse(txtRoyalty.Text),
                YtdSales: int.Parse(txtYTDSales.Text),
                Notes: txtNotes.Text,
                PubDate: dtpPubDate.Value.Date;
            );

            // Insert into the database
            repo.InsertTitle(title);

            MessageBox.Show("Title added successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ask to add authors to this title
            DialogResult res = MessageBox.Show(
                "Would you like to add authors to this title?",
                "Add Authors?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                frmAddTitleAuthor f = new frmAddTitleAuthor(title.TitleId);
                f.ShowDialog();
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

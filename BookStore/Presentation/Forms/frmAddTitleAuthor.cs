using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using static BookStore.Presentation.InputAssertions;
using BookStore.Data;
using BookStore.Presentation;
using BookStore.Entities;

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
            MaintenanceRepository repo = new MaintenanceRepository();

            TitleAuthor entry = new TitleAuthor(
                AuId: txtAuthor.Text,
                TitleId: txtTitle.Text,
                AuOrd: byte.Parse(txtOrder.Text),
                RoyaltyPer: int.Parse(txtRoyalty.Text)
            );

            repo.InsertTitleAuthor(entry);

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
            txtAuthor.Text = MaintenanceRepository.SelectId(list);
        }
    }
}

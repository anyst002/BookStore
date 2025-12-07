using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using static BookStore.Presentation.InputAssertions;
using BookStore.Data;
using BookStore.Presentation;
using BookStore.Entities;
using BookStore.Business;

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
            BusinessManager.AddTitleAuthor(txtAuthor.Text
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
                int order = AssertInt32(txtOrder.Text, "Order must be a whole number."); //TODO make nullable
                AssertPositive(order, "Order must be positive.");

                int royalty = AssertInt32(txtRoyalty.Text, "Royalty must be a whole number."); //TODO make nullable
                if (royalty < 0 || royalty > 100)
                    throw new ArgumentOutOfRangeException("", "Royalty must be between 0 and 100.");

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

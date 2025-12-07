using BookStore.Data;
using BookStore.Entities;
using BookStore.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmAddAuthor : Form
    {
        public frmAddAuthor()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            string? address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text;
            string? city = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text;
            string? state = string.IsNullOrWhiteSpace(txtState.Text) ? null : txtState.Text;
            string? zip = string.IsNullOrWhiteSpace(mtxtZip.Text.Replace("-", "")) ? null : mtxtZip.Text;

            Author author = new Author(mtxtID.Text
                , txtFirstName.Text.Trim()
                , txtLastName.Text.Trim()
                , mtxtPhone.Text
                , address
                , city
                , state
                , zip
                , chkContract.Checked);

            MaintenanceRepository repo = new MaintenanceRepository();
            repo.InsertAuthor(author);

            MessageBox.Show("Author added successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Clear()
        {
            mtxtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            mtxtPhone.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            mtxtZip.Clear();
            chkContract.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.Validate(() =>
            {
                if (!mtxtID.MaskFull) //TODO make this an assertion later
                {
                    MessageBox.Show("Please enter an author ID.",
                                "Input Missing");
                    return;
                }

                AssertNotNullOrWhiteSpace(txtFirstName.Text, "Please enter a first name.");
                AssertNotNullOrWhiteSpace(txtLastName.Text, "Please enter a last name.");

                if (!mtxtPhone.MaskFull) //TODO make this an assertion later
                {
                    MessageBox.Show("Please enter a phone number.",
                                "Input Missing");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtState.Text))
                    AssertStringLengthEquals(txtState.Text, 2, "State must be exactly 2 characters.");

                if (!string.IsNullOrWhiteSpace(mtxtZip.Text.Replace("-", "")) && !mtxtZip.MaskFull)
                {
                    MessageBox.Show("Zip must be 5 digits.",
                                "Input Missing");
                    return;
                }

                Insert();
                Clear();
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

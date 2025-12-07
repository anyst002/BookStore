using BookStore.Data;
using BookStore.Entities;
using BookStore.Business;
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
            BusinessManager.AddAuthor(mtxtID.Text
                , txtLastName.Text.Trim()
                , txtFirstName.Text.Trim()
                , mtxtPhone.Text
                , txtAddress.Text.Trim()
                , txtCity.Text.Trim()
                , txtState.Text.Trim()
                , mtxtZip.Text.Replace("-", "")
                , chkContract.Checked);

            MessageBox.Show("Author added successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
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
            Close();
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
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

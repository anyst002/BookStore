using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputValidator;

namespace BookStore
{
    public partial class frmAddPublisher : Form
    {
        private readonly Validator _validator = new Validator();

        public frmAddPublisher()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _validator.Validate(() =>
            {
                if (string.IsNullOrWhiteSpace(txtPubId.Text))
                    throw new NullReferenceException("Publisher ID is required.");

                if (txtPubId.Text.Trim().Length != 4)
                    throw new ArgumentOutOfRangeException("", "Publisher ID must be exactly 4 characters.");

                if (!string.IsNullOrWhiteSpace(txtState.Text) &&
                    txtState.Text.Trim().Length != 2)
                    throw new ArgumentOutOfRangeException("", "State must be exactly 2 characters.");

                var publisher = new Publisher
                {
                    PubId    = txtPubId.Text.Trim(),
                    PubName  = string.IsNullOrWhiteSpace(txtPubName.Text) ? null : txtPubName.Text.Trim(),
                    City     = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text.Trim(),
                    State    = string.IsNullOrWhiteSpace(txtState.Text) ? null : txtState.Text.Trim(),
                    Country  = string.IsNullOrWhiteSpace(txtCountry.Text) ? null : txtCountry.Text.Trim()
                };

                PublisherRepository.InsertPublisher(publisher);

                MessageBox.Show("Publisher saved successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                btnClear_Click(sender, e);
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPubId.Clear();
            txtPubName.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtCountry.Clear();
            txtPubId.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


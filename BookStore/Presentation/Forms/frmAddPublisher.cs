using BookStore.Data;
using BookStore.Entities;
using BookStore.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace BookStore
{
    public partial class frmAddPublisher : Form
    {
        private readonly Validator _validator = new Validator();

        public frmAddPublisher()
        {
            InitializeComponent();
        }
        private void Insert()
        {
            string? PubName = string.IsNullOrWhiteSpace(txtPubName.Text) ? null : txtPubName.Text.Trim();
            string? City = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text.Trim();
            string? State = string.IsNullOrWhiteSpace(txtState.Text) ? null : txtState.Text.Trim();
            string? Country = string.IsNullOrWhiteSpace(txtCountry.Text) ? null : txtCountry.Text.Trim();

            Publisher publisher = new Publisher(mtxtPubId.Text.Trim()
                , PubName
                , City
                , State
                , Country);

            MaintenanceRepository repo = new MaintenanceRepository();
            repo.InsertPublisher(publisher);

            MessageBox.Show("Publisher saved successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void Clear()
        {
            mtxtPubId.Clear();
            txtPubName.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtCountry.Clear();
            mtxtPubId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _validator.Validate(() =>
            {
                if (!mtxtPubId.MaskFull) //TODO make this an assertion later
                {
                    MessageBox.Show("Publisher ID is required.",
                                "Input Missing");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtState.Text) &&
                    txtState.Text.Trim().Length != 2)
                    throw new ArgumentOutOfRangeException("", "State must be exactly 2 characters.");

                Insert();
                Clear();
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


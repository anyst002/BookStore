using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Data;
using BookStore.Entities;
using BookStore.Presentation;

namespace BookStore
{
    public partial class frmAddStore : Form
    {
        private readonly Validator _validator = new Validator();

        public frmAddStore()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            string? StorName = string.IsNullOrWhiteSpace(txtStorName.Text) ? null : txtStorName.Text.Trim();
            string? StorAddress = string.IsNullOrWhiteSpace(txtStorAddress.Text) ? null : txtStorAddress.Text.Trim();
            string? City = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text.Trim();
            string? State = string.IsNullOrWhiteSpace(txtState.Text) ? null : txtState.Text.Trim();
            string? Zip = string.IsNullOrEmpty(mtxtZip.Text) ? null : mtxtZip.Text;

            Store store = new Store(txtStorId.Text.Trim()
                , StorName
                , StorAddress
                , City
                , State
                , Zip);

            MaintenanceRepository repo = new MaintenanceRepository();
            repo.InsertStore(store);

            MessageBox.Show("Store saved successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void Clear()
        {
            txtStorId.Clear();
            txtStorName.Clear();
            txtStorAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            mtxtZip.Clear();
            txtStorId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _validator.Validate(() =>
            {
                if (string.IsNullOrWhiteSpace(txtStorId.Text))
                    throw new NullReferenceException("Store ID is required.");
                    
                if (txtStorId.Text.Trim().Length != 4)
                    throw new ArgumentOutOfRangeException("", "Store ID must be exactly 4 characters.");

                if (!string.IsNullOrWhiteSpace(txtState.Text) &&
                    txtState.Text.Trim().Length != 2)
                    throw new ArgumentOutOfRangeException("", "State must be exactly 2 characters.");

                var rawZip = mtxtZip.Text.Replace("_", "").Trim();
                if (!string.IsNullOrEmpty(rawZip) && rawZip.Length != 5)
                    throw new ArgumentOutOfRangeException("", "Zip must be 5 digits.");

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


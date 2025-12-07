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
using BookStore.Business;
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
            BusinessManager.AddStore(txtStorId.Text.Trim()
                , txtStorName.Text.Trim()
                , txtStorAddress.Text.Trim()
                , txtCity.Text.Trim()
                , txtState.Text.Trim()
                , mtxtZip.Text);

            MessageBox.Show("Store saved successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            Clear();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


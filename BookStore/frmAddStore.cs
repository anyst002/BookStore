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
    public partial class frmAddStore : Form
    {
        private readonly Validator _validator = new Validator();

        public frmAddStore()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _validator.Validate(() =>
            {
                if (string.IsNullOrWhiteSpace(txtStorId.Text))
                    throw new NullReferenceException("Store ID is required.");
                if (txtStorId.Text.Trim().Length != 4)
                    throw new ArgumentOutOfRangeException("", "Store ID must be exactly 4 characters.");

                if (!string.IsNullOrWhiteSpace(txtState.Text) && txtState.Text.Trim().Length != 2)
                    throw new ArgumentOutOfRangeException("", "State must be exactly 2 characters.");

                if (!string.IsNullOrWhiteSpace(mtxtZip.Text.Replace("_", "").Trim()) &&
                    !mtxtZip.MaskFull)
                    throw new ArgumentOutOfRangeException("", "Zip must be 5 digits.");

                MessageBox.Show("Store validated successfully.\n(Database save added later.)",
                                "Validated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStorId.Clear();
            txtStorName.Clear();
            txtStorAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            mtxtZip.Clear();
            txtStorId.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


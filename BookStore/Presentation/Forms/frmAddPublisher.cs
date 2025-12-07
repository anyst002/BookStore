using BookStore.Data;
using BookStore.Entities;
using BookStore.Business;
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
            BusinessManager.AddPublisher(mtxtPubId.Text.Trim()
                , txtPubName.Text.Trim()
                , txtCity.Text.Trim()
                , txtState.Text.Trim()
                , txtCountry.Text.Trim());

            MessageBox.Show("Publisher saved successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Clear();
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


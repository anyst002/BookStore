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
    public partial class frmOrderQuantity : Form
    {
        public short quantity = 1;
        public frmOrderQuantity(short quantity)
        {
            InitializeComponent();
            this.quantity = quantity;
            numQuantity.Value = quantity;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToInt16(numQuantity.Value);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

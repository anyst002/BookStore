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
    public partial class frmOrderSummary : Form
    {
        public frmOrderSummary(Order order)
        {
            InitializeComponent();
            grdSummary.DataSource = order.cart;

            txtOrderNum.Text = order.ordNum.ToString();

            decimal subtotal = order.GetSubtotal();
            txtSubtotal.Text = subtotal.ToString("C");

            decimal tax = subtotal * Order.taxPer;
            txtTax.Text = tax.ToString("C");

            decimal total = subtotal + tax;
            txtTotal.Text = total.ToString("C");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using BookStore.Business;

namespace BookStore
{
    public partial class frmOrderSummary : Form
    {
        public frmOrderSummary(Order order)
        {
            InitializeComponent();
            grdSummary.DataSource = order.Cart;

            txtOrderNum.Text = order.OrdNum.ToString();

            txtSubtotal.Text = order.GetSubtotal().ToString("C");
            txtTax.Text = order.GetTax().ToString("C");
            txtTotal.Text = order.GetTotal().ToString("C");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

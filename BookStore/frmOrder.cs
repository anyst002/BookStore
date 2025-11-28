namespace BookStore
{
    public partial class frmOrder : Form
    {
        private string storeId;
        private Order order;

        public frmOrder(string storeId)
        {
            InitializeComponent();
            this.storeId = storeId;
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmOrderSearch search = new frmOrderSearch();
            search.ShowDialog();
            OrderItem? item = search.result;

            if (item is null) return;
            else
            {
                order.AddItem(item);
                UpdateGrid();
                CalculateSubtotal();
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            //validate payment terms have been entered and more than 0 items in cart
            //order.PlaceOrder();
            frmOrderSummary summary = new frmOrderSummary();
            summary.ShowDialog();
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset()
        {
            order = new Order(storeId);
            txtTax.Text = Convert.ToString(Order.tax);
            UpdateGrid();
            CalculateSubtotal();
            txtPayTerms.Clear();
        }

        private void CalculateSubtotal()
        {
            decimal subtotal = order.GetSubtotal();
            txtSubtotal.Text = Convert.ToString(subtotal);
            txtTotal.Text = Convert.ToString((subtotal * Order.tax) + subtotal); //format as currency
        }

        private void UpdateGrid()
        {
            grdCart.DataSource = null; //terrible way of doing this but idk what else to do atm, probably why it crashes when you click a row
            grdCart.DataSource = order.cart;
        }
    }
}

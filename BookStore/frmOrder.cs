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
            
            grdCart.DataSource = order.cart;
            CalculateSubtotal();
            txtPayTerms.Clear();
        }

        private void CalculateSubtotal()
        {
            decimal subtotal = order.GetSubtotal();
            txtSubtotal.Text = subtotal.ToString("C");

            decimal tax = subtotal * Order.taxPer;
            txtTax.Text = tax.ToString("C");

            decimal total = subtotal + tax;
            txtTotal.Text = total.ToString("C");
        }

        private void grdCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //remove cart item
                if (String.Equals(grid.Columns[e.ColumnIndex].Name, "Remove"))
                {
                    order.RemoveItem((OrderItem)grid.Rows[e.RowIndex].DataBoundItem);
                }
                //edit cart item quantity
                else if (String.Equals(grid.Columns[e.ColumnIndex].Name, "Edit"))
                {
                    OrderItem item = (OrderItem)grid.Rows[e.RowIndex].DataBoundItem;
                    frmOrderQuantity edit = new frmOrderQuantity(item.Qty);
                    edit.ShowDialog();
                    order.UpdateItemQuantity(item, edit.quantity);
                }

                CalculateSubtotal();
            }
        }
    }
}

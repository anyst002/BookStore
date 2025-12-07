using BookStore.Business;

namespace BookStore
{
    public partial class frmOrder : Form
    {
        private readonly string _storeId;
        private Order order;

        public frmOrder(string storeId)
        {
            InitializeComponent();
            _storeId = storeId;
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmOrderSearch search = new frmOrderSearch(order);
            search.ShowDialog();

            CalculateSubtotal();
            ToggleConfirmButton();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.Validate(() =>
            {
                order.PayTerms = AssertNotNullOrWhiteSpace(txtPayTerms.Text, "Please enter payment terms.");

                order.PlaceOrder();

                frmOrderSummary summary = new frmOrderSummary(order);
                summary.ShowDialog();
                Reset();
            });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset()
        {
            order = new Order(_storeId);
            
            grdCart.DataSource = order.Cart;
            CalculateSubtotal();
            txtPayTerms.Clear();
            ToggleConfirmButton();
        }

        private void ToggleConfirmButton()
        {
            btnConfirmOrder.Enabled = (grdCart.RowCount == 0) ? false : true;
        }

        private void CalculateSubtotal()
        {
            txtSubtotal.Text = order.GetSubtotal().ToString("C");
            txtTax.Text = order.GetTax().ToString("C");
            txtTotal.Text = order.GetTotal().ToString("C");
        }

        private void grdCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //remove cart item
                if (String.Equals(grid.Columns[e.ColumnIndex].Name, "Remove"))
                {
                    order.RemoveItem(grid.Rows[e.RowIndex].DataBoundItem);
                    ToggleConfirmButton();
                }
                //edit cart item quantity
                else if (String.Equals(grid.Columns[e.ColumnIndex].Name, "Edit"))
                {
                    frmOrderQuantity edit = new frmOrderQuantity(grid.Rows[e.RowIndex].DataBoundItem, order);
                    edit.ShowDialog();
                }

                CalculateSubtotal();
            }
        }
    }
}

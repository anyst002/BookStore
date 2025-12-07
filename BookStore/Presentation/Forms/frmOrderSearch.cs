using BookStore.Business;

namespace BookStore
{
    public partial class frmOrderSearch : Form
    {
        private readonly Order _order;
        public frmOrderSearch(Order order)
        {
            InitializeComponent();
            _order = order;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _order.AddTitleSummary(grdResults.CurrentRow.DataBoundItem, Convert.ToInt16(numQuantity.Value));

            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                grdResults.DataSource = Order.GetSearchResults(txtSearch.Text);
            }
        }

        private void grdResults_SelectionChanged(object sender, EventArgs e)
        {
            if (grdResults.SelectedRows.Count == 0) btnAdd.Enabled = false;
            else btnAdd.Enabled = true;
        }
    }
}

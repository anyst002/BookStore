using BookStore.Data;

namespace BookStore
{
    public partial class frmOrderSearch : Form
    {
        public OrderItem? result = null;
        public frmOrderSearch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TitleSearchResult selection = (TitleSearchResult)grdResults.CurrentRow.DataBoundItem;
            result = new OrderItem(selection.TitleId
                , selection.Title
                , selection.Price
                , Convert.ToInt16(numQuantity.Value)
                , selection.AuName
                , selection.PubName
                , selection.PubDate);
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text)) return;

            OrderRepository repo = new OrderRepository();
            List<TitleSearchResult> list = repo.GetTitlesByPartialTitle(txtSearch.Text);
            grdResults.DataSource = list;
        }

        private void grdResults_SelectionChanged(object sender, EventArgs e)
        {
            if (grdResults.SelectedRows.Count == 0) btnAdd.Enabled = false;
            else btnAdd.Enabled = true;
        }
    }
}

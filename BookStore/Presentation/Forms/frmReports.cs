using static BookStore.Business.BusinessManager;
using BookStore.Entities;

namespace BookStore
{
    public partial class frmReports : Form
    {
        private readonly string _storeId;
        public frmReports(string storeId)
        {
            InitializeComponent();
            _storeId = storeId;
        }

        private void UpdateTotal()
        {
            if (grdReports.RowCount == 0)
            {
                txtTotal.Clear();
            }
            else
            {
                decimal subtotal = CalculateSalesSummaryTotal((List<SalesSummaryRow>)grdReports.DataSource);
                txtTotal.Text = subtotal.ToString("C");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date;

            grdReports.DataSource = GetReports(start, end, _storeId);

            UpdateTotal();
        }
    }
}

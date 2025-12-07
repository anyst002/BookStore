global using static BookStore.Business.InputAssertions;
using static BookStore.Business.BusinessManager;
using static BookStore.Presentation.PresentationUtilities;
using BookStore.Entities;

namespace BookStore
{
    public partial class frmMainMenu : Form
    {
        private string storeId = "";
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            frmMaintenance maintenance = new frmMaintenance();
            maintenance.ShowDialog();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder(storeId);
            order.ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            frmReports reports = new frmReports(storeId);
            reports.ShowDialog();
        }

        private void btnMMClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStoreSelect_Click(object sender, EventArgs e)
        {
            List<IdInfo> list = SelectStoreIds();
            storeId = SelectId(list);

            if (!storeId.Equals(""))
            {
                grpStoreSpecific.Text = $"Store ID: {storeId}";
                grpStoreSpecific.Enabled = true;
            }

        }
    }
}

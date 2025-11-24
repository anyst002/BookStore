global using static InputValidator.InputAssertions;
global using InputValidator;

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
            MaintenanceRepository repo = new MaintenanceRepository();
            List<IdInfo> list = repo.GetJobIds();
            storeId = MaintenanceRepository.SelectId(list);

            if (!storeId.Equals(""))
            {
                grpStoreSpecific.Text = $"Store ID: {storeId}";
                grpStoreSpecific.Enabled = true;
            }

        }
    }
}

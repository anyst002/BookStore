global using static InputValidator.InputAssertions;
global using InputValidator;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Reflection;

namespace BookStore
{
    public partial class frmMainMenu : Form
    {
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
            frmOrder order = new frmOrder();
            order.ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            frmReports reports = new frmReports();
            reports.ShowDialog();
        }

        private void btnMMClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

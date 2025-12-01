using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmReports : Form
    {
        private string storeId;
        private ReportRepository reportRepo;
        public frmReports(string storeId)
        {
            InitializeComponent();
            this.storeId = storeId;
            reportRepo = new ReportRepository(storeId);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStartDate.Value;
            DateTime end = dtpEndDate.Value;
            var data = reportRepo.GetSalesByTimeRange();
            dgvReport.DataSource = data;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

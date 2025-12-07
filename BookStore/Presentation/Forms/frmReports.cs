using BookStore.Data;
using BookStore.Entities;
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
        public frmReports(string storeId)
        {
            InitializeComponent();
            this.storeId = storeId;
        }

        private void UpdateTotal()
        {
            if (grdReports.RowCount == 0)
            {
                txtTotal.Clear();
            }
            else
            {
                decimal subtotal = 0.00m;
                foreach (DataGridViewRow row in grdReports.Rows)
                {
                    SalesSummaryRow entry = (SalesSummaryRow)row.DataBoundItem;
                    subtotal += entry.TotalValue ?? 0;
                }
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

            ReportRepository repo = new ReportRepository(storeId);
            List<SalesSummaryRow> data = repo.GetSalesByTimeRange(start, end);

            grdReports.DataSource = data;
            UpdateTotal();
        }
    }
}

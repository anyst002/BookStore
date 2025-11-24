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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using BookStore.Entities;

namespace BookStore
{
    public partial class frmSelectId : Form
    {
        public string id = "";
        public frmSelectId(List<IdInfo> list)
        {
            InitializeComponent();

            grdDataGrid.DataSource = list;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            id = (string)grdDataGrid.SelectedRows[0].Cells[0].Value;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

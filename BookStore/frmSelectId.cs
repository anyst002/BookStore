namespace BookStore
{
    public partial class frmSelectId : Form
    {
        public IdInfo? selected = null;
        public frmSelectId(List<IdInfo> list)
        {
            InitializeComponent();

            grdDataGrid.DataSource = list;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (grdDataGrid.SelectedRows.Count == 1)
            {
                selected = new IdInfo(
                  (string)grdDataGrid.SelectedRows[0].Cells[0].Value
                , (string)grdDataGrid.SelectedRows[0].Cells[1].Value);

                Close();
            }
            else
            {
                MessageBox.Show("Please select a single ID.", "Invalid Selection");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

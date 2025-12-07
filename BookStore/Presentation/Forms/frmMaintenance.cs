namespace BookStore
{
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void btnTitles_Click(object sender, EventArgs e)
        {
            frmAddTitle addTitle = new frmAddTitle();
            addTitle.ShowDialog();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            frmAddAuthor addAuthor = new frmAddAuthor();
            addAuthor.ShowDialog();
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            frmAddPublisher addPublisher = new frmAddPublisher();
            addPublisher.ShowDialog();
        }

        private void btnStores_Click(object sender, EventArgs e)
        {
            frmAddStore addStore = new frmAddStore();
            addStore.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmAddEmployee addEmployee = new frmAddEmployee();
            addEmployee.ShowDialog();
        }

        private void btnMaintClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            string myConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BookStore; Integrated Security = True;
            Pooling = False; Encrypt = True; TrustServerCertificate = False; Encrypt = False;
            AttachDbFilename =| DataDirectory |\BookStore.MDF;";
            frmAddEmployee addEmployee = new frmAddEmployee(myConnectionString);
            addEmployee.ShowDialog();
        }
    }
}

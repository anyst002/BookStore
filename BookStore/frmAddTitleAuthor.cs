using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using InputValidator;
using static InputValidator.InputAssertions;

namespace BookStore
{
    public partial class frmAddTitleAuthor : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;

        SqlConnection connection;
        SqlCommand command;

        public frmAddTitleAuthor()
        {
            InitializeComponent();

            connection = new(connectionString);
            command = new("", connection);

            LoadAuthors();
            LoadTitles();
        }

        private void LoadAuthors()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT au_id, au_lname + ', ' + au_fname AS fullname FROM authors ORDER BY au_lname";

                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                connection.Close();

                cboAuthor.DataSource = dt;
                cboAuthor.DisplayMember = "fullname";
                cboAuthor.ValueMember = "au_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void LoadTitles()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT title_id, title FROM titles ORDER BY title";

                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                connection.Close();

                cboTitle.DataSource = dt;
                cboTitle.DisplayMember = "title";
                cboTitle.ValueMember = "title_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            validator.Validate(() =>
            {
                string authorId = AssertComboSelection(cboAuthor, "Author is required.");
                string titleId = AssertComboSelection(cboTitle, "Title is required.");

                int order = AssertNonNegative(AssertInt32(txtOrder.Text, "Invalid order."));
                int royalty = AssertNonNegative(AssertInt32(txtRoyalty.Text, "Invalid royalty."));

                connection.Open();
                command.CommandText = @"
                    INSERT INTO titleauthor (au_id, title_id, au_ord, royaltyper)
                    VALUES (@au, @title, @ord, @roy);";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@au", authorId);
                command.Parameters.AddWithValue("@title", titleId);
                command.Parameters.AddWithValue("@ord", order);
                command.Parameters.AddWithValue("@roy", royalty);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Author added to title successfully!");
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboAuthor.SelectedIndex = -1;
            cboTitle.SelectedIndex = -1;
            txtOrder.Clear();
            txtRoyalty.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

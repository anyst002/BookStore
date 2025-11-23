using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using InputValidator;
using static InputValidator.InputAssertions;

namespace BookStore
{
    public partial class frmAddTitle : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;

        SqlConnection connection;
        SqlCommand command;

        public frmAddTitle()
        {
            InitializeComponent();

            connection = new(connectionString);
            command = new("", connection);

            LoadPublishers();
            LoadTypes();
        }

        private void LoadPublishers()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT pub_id, pub_name FROM publishers ORDER BY pub_name";

                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                connection.Close();

                cboPublisher.DataSource = dt;
                cboPublisher.DisplayMember = "pub_name";
                cboPublisher.ValueMember = "pub_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void LoadTypes()
        {
            cboType.Items.Clear();

            cboType.Items.Add("business");
            cboType.Items.Add("mod_cook");
            cboType.Items.Add("popular_comp");
            cboType.Items.Add("trad_cook");
            cboType.Items.Add("UNDECIDED");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            validator.Validate(() =>
            {
                string id = AssertNotEmpty(txtTitleID.Text, "Title ID is required.");
                string title = AssertNotEmpty(txtTitle.Text, "Title is required.");
                string type = AssertComboSelection(cboType, "Type is required.");
                string pubId = AssertComboSelection(cboPublisher, "Publisher is required.");

                decimal price = AssertNonNegative(AssertDecimal(txtPrice.Text, "Invalid price."));
                decimal advance = AssertNonNegative(AssertDecimal(txtAdvance.Text, "Invalid advance."));
                int royalty = AssertNonNegative(AssertInt32(txtRoyalty.Text, "Invalid royalty."));
                int ytd = AssertNonNegative(AssertInt32(txtYTDSales.Text, "Invalid YTD sales."));
                string notes = txtNotes.Text;
                DateTime pubDate = dtpPubDate.Value;

                connection.Open();
                command.CommandText = @"
                    INSERT INTO titles (title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate)
                    VALUES (@id, @title, @type, @pub, @price, @adv, @roy, @ytd, @notes, @date);";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@pub", pubId);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@adv", advance);
                command.Parameters.AddWithValue("@roy", royalty);
                command.Parameters.AddWithValue("@ytd", ytd);
                command.Parameters.AddWithValue("@notes", notes);
                command.Parameters.AddWithValue("@date", pubDate);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Title added successfully!");
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitleID.Clear();
            txtTitle.Clear();
            cboType.SelectedIndex = -1;
            cboPublisher.SelectedIndex = -1;
            txtPrice.Clear();
            txtAdvance.Clear();
            txtRoyalty.Clear();
            txtYTDSales.Clear();
            txtNotes.Clear();
            dtpPubDate.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

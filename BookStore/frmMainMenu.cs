using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Reflection;

namespace BookStore
{
    public partial class frmMainMenu : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;
        
        SqlConnection connection;
        SqlCommand command;

        public frmMainMenu()
        {
            InitializeComponent();

            connection = new(connectionString);
            command = new("", connection);
        }

        public void frmMainMenu_Load(object sender, EventArgs e)
        {
            //just for testing the connection, delete/move later
            connection.Open();
            command.CommandText = $"SELECT * FROM titles";
            using SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            MessageBox.Show(reader.GetString(0));
            reader.Close();
        }
    }
}

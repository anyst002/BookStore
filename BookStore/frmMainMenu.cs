global using static InputValidator.InputAssertions;
global using InputValidator;
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

        private void ValidationExample() //TODO delete later
        {
            /* first instantiate a validator object. to switch to a different
             * validator, simply change the call to:
             * "Validator validator = new CustomValidator();",
             * the rest of the code will function the same but
             * will now use CustomValidator's specific error handling
             */

            //Validator validator = new Validator();


            /* wrap your code in a lambda expression within the Validate() call */

            //validator.Validate(() =>
            //{
                /* assertions verify that input meets desired property,
                 * automatically throws exception if not, displays a message box,
                 * and ends the program flow, allowing exception handling to be reused
                 */

                //int intQuantity = AssertNonNegative(AssertInt32(txtQuantity.Text));
                //decimal decPrice = AssertNonNegative(AssertDecimal(txtPrice.Text));


                /* a custom string can optionally be supplied on any assertion to
                 * override the default message when an exception occurs
                 */

                //string strRadioSelection = AssertRadioSelection(gboGroupBox, "Please select a sandwich.");
                //string strComboSelection = AssertComboSelection(cboComboBox, "Please select a side.");


                /* any code beyond the assertions will only run if the inputs
                 * have been properly validated, if any assertion fails the rest of the
                 * code within Validate() will be skipped, allowing code after
                 * Validate() to act as a finally{} clause
                 */

                //lblSummary.Text = $"{strRadioSelection} - {strComboSelection}";

                //CalculateTotals();
            //});


            /* code that runs whether or not Validate threw an error */

            //Reset();
        }
    }
}

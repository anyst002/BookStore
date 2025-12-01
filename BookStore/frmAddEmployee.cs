using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmAddEmployee : Form
    {
        private readonly string ConnectionString;
        public frmAddEmployee( string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            ClearText();
        }

        private void ClearText()
        {
            txtbxFname.Text = "";
            txtbxMinit.Text = "";
            txtbxLname.Text = "";
            txtbxJLvl.Text = "";
            txtbxPubID.Text = "";
            txtbxJobID.Text = "";
            txtEmpID.Text = "";
            masktxtbxHireDate.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEmpID.Text))
                {
                    MessageBox.Show("Employee ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmpID.Focus();
                    return;
                }

                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string insertSql = @"
                    INSERT INTO insertEmployee (emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date)
                    VALUES (@emp_id, @fname, @minit, @lname, @job_id, @job_lvl, @pub_id, @hire_date)";
                    using (var command = new SqlCommand(insertSql, conn))
                    {
                        command.Parameters.AddWithValue("@emp_id", txtEmpID.Text.Trim());
                        command.Parameters.AddWithValue("@fname", (object)txtbxFname.Text.Trim() ?? DBNull.Value);
                        command.Parameters.AddWithValue("@minit", (object)txtbxMinit.Text.Trim() ?? DBNull.Value);
                        command.Parameters.AddWithValue("@lname", (object)txtbxLname.Text.Trim() ?? DBNull.Value);
                        command.Parameters.AddWithValue("@job_id", (object)txtbxJobID.Text.Trim() ?? DBNull.Value);
                        command.Parameters.AddWithValue("@job_lvl", (object)txtbxJLvl.Text.Trim() ?? DBNull.Value);
                        command.Parameters.AddWithValue("@pub_id", (object)txtbxPubID.Text.Trim() ?? DBNull.Value);
                        command.Parameters.AddWithValue("@hire_date", (object)masktxtbxHireDate.Text.Trim() ?? DBNull.Value);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Employee Saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearText();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("An employee with that Employee ID already exists.", "Dupicate Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Trouble with database: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

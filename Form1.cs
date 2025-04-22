using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;";

        public Form1()
        {
            InitializeComponent();
            ExecuteSqlScript("SQLQuery1.sql");
        }

        private void ExecuteSqlScript(string scriptPath)
        {
            try
            {
                // Read the SQL script
                string script = File.ReadAllText(scriptPath);

                // Split the script into individual commands using "GO" as a delimiter
                string[] commands = script.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (string command in commands)
                    {
                        if (!string.IsNullOrWhiteSpace(command))
                        {
                            using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                            {
                                sqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Database setup completed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while executing the SQL script: {ex.Message}");
            }
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            lblCurrentBill1.Text = "0";
        }

        private void btnRecordOrder_Click(object sender, EventArgs e)
        {
            // Your existing code
        }

        private void btnCurrentOrder_Click(object sender, EventArgs e)
        {
            // Your existing code
        }
    }
}

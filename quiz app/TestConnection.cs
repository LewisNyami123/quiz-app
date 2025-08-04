using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace quiz_app
{
    public partial class TestConnection : Form
    {
        public TestConnection()
        {
            InitializeComponent();
        }



        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=db24058.public.databaseasp.net; Database=db24058; User Id=db24058; Password=S!r62fR-q%8C; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;";

            using (Microsoft.Data.SqlClient.SqlConnection connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection Successfull", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed!\nError", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            // Inside your TestConnection Form's code-behind (e.g., TestConnection.cs)


            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                if (connection != null)
                {
                    MessageBox.Show("Connection test successful! Database is accessible.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Example: Execute a simple query to get the number of users
                    try
                    {
                        string query = "SELECT COUNT(*) FROM Users;";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int userCount = (int)command.ExecuteScalar();
                            MessageBox.Show($"Number of users in the database: {userCount}", "User Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Error executing test query: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to establish database connection. Check connection string or network.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            // Use a 'using' statement to ensure the connection is properly closed and disposed
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                if (connection != null)
                {
                    // If connection is successful, you can now perform database operations
                    // For now, we're just testing the connection
                    Console.WriteLine("Connection test successful! Database is accessible.");

                    // Example: Execute a simple query to get the number of users
                    // This will also confirm your 'Users' table exists and is accessible
                    try
                    {
                        string query = "SELECT COUNT(*) FROM Users;";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int userCount = (int)command.ExecuteScalar();
                            Console.WriteLine($"Number of users in the database: {userCount}");
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error executing test query:");
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Failed to establish database connection.");
                }
            } // Connection is automatically closed and disposed here by the 'using' block

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }

        private void TestConnection_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = ""; // For now, email is empty, as we don't have an email textbox.

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Username and password cannot be empty.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            bool registered = DatabaseHelper.RegisterUser(username, password, email);

            if (registered)
            {
                lblMessage.Text = "Registration successful! You can now log in.";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                lblMessage.Text = "Registration failed. Username might already be taken, or a database error occurred.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
      
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Please enter username and password.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            int userId = DatabaseHelper.LoginUser(username, password);

            if (userId != -1)
            {
                lblMessage.Text = $"Login successful! Welcome, {username}. User ID: {userId}";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                // Optional: Here you would typically hide the login form and show your main quiz application form.
                // Example:
                // this.Hide(); // Hides the current login form
                // MainQuizForm quizForm = new MainQuizForm(userId); // Assuming you have a MainQuizForm
                // quizForm.Show();
            }
            else
            {
                lblMessage.Text = "Login failed. Incorrect username or password.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



    

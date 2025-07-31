using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; // Essential for SQL Server connectivity
using BCrypt.Net; // Essential for password hashing (from NuGet package)

namespace quiz_app
{
    // THIS IS THE CORRECT CLASS DECLARATION
    // It's just 'public static class DatabaseHelper'
    public static class DatabaseHelper
    {
        // This is a PUBLIC STATIC PROPERTY that holds your connection string.
        // You MUST replace 'your_database_name', 'your_username', 'your_password'
        // with your actual credentials for the db24058.public.databaseasp.net server.
        public static string ConnectionString { get; } = "Server=db24058.public.databaseasp.net; Database=db24058; User Id=db24058; Password=S!r62fR-q%8C; Encrypt=False; TrustServerCertificate=True; MultipleActiveResultSets=True; Connect Timeout=30;";

        // This method opens a database connection.
        public static SqlConnection? GetConnection()
        {
            try
            {
                 SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                // Console.WriteLine("Database connection opened successfully!"); // Optional: for debugging
                return connection;
            }

            catch (SqlException ex)
            {
                // This is where SQL-specific errors like timeout/SSL would show up
                MessageBox.Show($"Database connection error (SqlException in GetConnection()): {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex) // Catch any other unexpected exceptions
            {
                MessageBox.Show($"An unexpected error occurred in GetConnection(): {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        // --- User Registration Method ---
        public static bool RegisterUser(string username, string password, string email)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            // INSERT query
            string insertQuery = "INSERT INTO Users (Username, PassHash, Email, CreatedAt) VALUES (@Username, @PassHash, @Email, GETDATE());";

            // CHECK for existing username
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    if (connection == null) return false;

                    // 1. Check if the username already exists
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", username);
                        int existingUserCount = (int)checkCommand.ExecuteScalar();
                        if (existingUserCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    // 2. Proceed to insert only if username is unique
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Username", username);
                        insertCommand.Parameters.AddWithValue("@PassHash", passwordHash);
                        insertCommand.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? "" : email);

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Registration error (SqlException in RegisterUser): {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        } 

        // --- User Login Method ---
        public static int LoginUser(string username, string password)
        {
            string query = "SELECT Id, PasswordHash FROM Users WHERE Username = @Username;";

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    if (connection == null) return -1; // Connection failed

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // If a user with that username is found
                            {
                                string storedHash = reader["PasswordHash"].ToString();
                                int userId = (int)reader["Id"];

                                // Verify the entered password against the stored hash
                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    return userId; // Login successful, return user ID
                                }
                            }
                            // No user found or password incorrect
                            return -1;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Login error: {ex.Message}");
                return -1;
            }
        }
    }
} 
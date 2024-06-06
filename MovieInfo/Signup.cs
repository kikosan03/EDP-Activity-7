using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MovieInfo
{
    public partial class Signup : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;
        public Signup()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            server = "localhost";
            database = "activity2";
            uid = "root";
            pass = "erick";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={pass};";
            connection = new MySqlConnection(connectionString);
        }

        private void confirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void account_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string username = account.Text;
            string passwords = password.Text;
            string confirmPassword = confirmpass.Text;
            string emails = email.Text;

            // Check if passwords match
            if (passwords != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Hash the password
            string hashedPassword = HashPassword(passwords);

                try
                {
                    connection.Open();
                    string query = "INSERT INTO users (username, password, email, role) VALUES (@username, @password, @email, @role)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@email", emails);
                    cmd.Parameters.AddWithValue("@role", "user");
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Close the signup form or navigate to another form
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to signup. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private string HashPassword(string passwords)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passwords));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MovieInfo
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            CheckLoginButtonEnabled();
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

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = user.Text;
            string enteredPassword = password.Text;

            try
            {
                connection.Open();

                // Hash the entered password
                string hashedPassword = HashPassword(enteredPassword);

                // Check if user exists in the users table
                string query = "SELECT * FROM users WHERE username=@username AND password=@password";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", hashedPassword);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    int userId = Convert.ToInt32(row["user_id"]); // Get the user_id
                    string roles = row["role"].ToString();
                    MessageBox.Show($"{roles} Login successful!");
                    // Check the role of the user
                    string role = dt.Rows[0]["role"].ToString();
                    if (role == "admin")
                    {
                        // Open admin dashboard
                        this.Hide();
                        var adminDashboard = new Dashboard();
                        adminDashboard.Show();
                    }
                    else
                    {
                        // Open user dashboard
                        this.Hide();
                        var userDashboard = new ratings(userId); // Pass the user_id
                        userDashboard.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
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

        private void recover_Click(object sender, EventArgs e)
        {
            this.Hide();
            var recovery = new Recovery();
            recovery.Show();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            CheckLoginButtonEnabled();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            CheckLoginButtonEnabled();
        }

        private void CheckLoginButtonEnabled()
        {
            loginbtn.Enabled = !string.IsNullOrWhiteSpace(user.Text) && !string.IsNullOrWhiteSpace(password.Text);
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signup = new Signup();
            signup.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var otherform = new About();
            this.Hide();
            otherform.Show();
        }
    }
}

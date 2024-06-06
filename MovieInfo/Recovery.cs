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
    public partial class Recovery : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;
        private int userId;

        public Recovery()
        {
            InitializeComponent();
            InitializeDatabase();
            CheckSearchButtonEnabled();
            CheckConfirmButtonEnabled();
            newpassword.Enabled = false;
            Confirmpass.Enabled = false;
            Confirm.Enabled = false;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            this.Hide();
            about.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var back = new Form1();
            this.Hide();
            back.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string username = searchtext.Text;

            try
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE username=@username";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("User account found!");
                        userId = reader.GetInt32("user_id");
                        newpassword.Enabled = true;
                        Confirmpass.Enabled = true;
                        Confirm.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("User account not found!");
                    }
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

        private void newpassword_TextChanged(object sender, EventArgs e)
        {
            CheckConfirmButtonEnabled();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string newPassword = newpassword.Text;
            string confirmedPassword = Confirmpass.Text;

            if (newPassword != confirmedPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string hashedPassword = HashPassword(newPassword);

            try
            {
                connection.Open();

                string query = "UPDATE users SET password = @password WHERE user_id = @userId";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@password", hashedPassword);
                command.Parameters.AddWithValue("@userId", this.userId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password changed successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to change password!");
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
        private string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            CheckSearchButtonEnabled();
        }
        private void CheckSearchButtonEnabled()
        {
            search.Enabled = !string.IsNullOrWhiteSpace(searchtext.Text);
        }

        private void Confirmpass_TextChanged(object sender, EventArgs e)
        {
            CheckConfirmButtonEnabled();
        }
        private void CheckConfirmButtonEnabled()
        {
            Confirm.Enabled = !string.IsNullOrWhiteSpace(newpassword.Text) && !string.IsNullOrWhiteSpace(Confirmpass.Text);
        }

    }
}

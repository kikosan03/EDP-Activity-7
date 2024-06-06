using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//librarary


namespace MovieInfo
{
    public partial class Dashboard : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        private int selectedMovieId;

        public Dashboard()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadDataIntoDataGridView();
            UpdateTotalCount("SELECT COUNT(*) FROM movies", totalMovies);
            UpdateTotalCount("SELECT COUNT(*) FROM actors", TotalActors);
            UpdateTotalCount("SELECT COUNT(*) FROM directors", totalDirectors);
            UpdateTotalCount("SELECT COUNT(*) FROM genres", totalGenres);
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve the movie ID from the selected row
                selectedMovieId = Convert.ToInt32(selectedRow.Cells["movie_id"].Value);
            }
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
        private void LoadDataIntoDataGridView()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM actors";
                command = new MySqlCommand(query, connection);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text;
            // Logic to search movies, actors, directors, etc.
            MessageBox.Show($"Searching for: {searchQuery}");
        }

        private void btnDisplayMovie_Click(object sender, EventArgs e)
        {
            DisplayData("SELECT * FROM movies");
        }

        private void btnDisplayActor_Click(object sender, EventArgs e)
        {
            DisplayData("SELECT * FROM actors");
        }

        private void btnDisplayDirector_Click(object sender, EventArgs e)
        {
            DisplayData("SELECT * FROM directors");
        }

        private void btnDisplayGenre_Click(object sender, EventArgs e)
        {
            DisplayData("SELECT * FROM genres");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totalMovies_Click(object sender, EventArgs e)
        {

        }

        private void TotalActors_Click(object sender, EventArgs e)
        {

        }

        private void totalDirectors_Click(object sender, EventArgs e)
        {

        }

        private void totalGenres_Click(object sender, EventArgs e)
        {

        }
        private void DisplayData(string query)
        {
            try
            {
                connection.Open();

                command = new MySqlCommand(query, connection);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
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
        private void UpdateTotalCount(string query, Label labelToUpdate)
        {
            try
            {
                connection.Open();

                command = new MySqlCommand(query, connection);
                int totalCount = Convert.ToInt32(command.ExecuteScalar());
                labelToUpdate.Text = totalCount.ToString();
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

        private void reportbtn_Click(object sender, EventArgs e)
        {
            var otherform = new Report();
            this.Hide();
            otherform.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            this.Hide();
            about.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            this.Hide();
            form.Show();
        }

        private void addmoviebtn_Click(object sender, EventArgs e)
        {
            var form1 = new movies();
            this.Hide();
            form1.Show();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (selectedMovieId == 0)
            {
                MessageBox.Show("Please select a movie first.");
                return;
            }

            try
            {
                connection.Open();

                // Delete the movie from the database
                string query = "DELETE FROM movies WHERE movie_id = @movie_id";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@movie_id", selectedMovieId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Movie deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to delete movie!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the movie: " + ex.Message);
            }
            finally
            {
                connection.Close();
                LoadDataIntoDataGridView(); // Refresh the data grid view
            }
        }

        private void managebtn_Click(object sender, EventArgs e)
        {
            var otherform = new manageuser();
            this.Hide();
            otherform.Show();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

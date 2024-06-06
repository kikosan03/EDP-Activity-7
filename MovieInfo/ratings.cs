using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MovieInfo
{
    public partial class ratings : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        private int userId;
        private int selectedMovieId; // Added to store the selected movie ID

        public ratings(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            InitializeDatabase();
            LoadDataIntoDataGridView();
            dataGridView1.CellClick += dataGridView1_CellClick;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve data from the selected row
                selectedMovieId = Convert.ToInt32(selectedRow.Cells["movie_id"].Value);
                string titles = Convert.ToString(selectedRow.Cells["title"].Value);
                string years = Convert.ToString(selectedRow.Cells["release_year"].Value);

                // Populate text boxes and controls with the selected row data
                movieID.Text = selectedMovieId.ToString();
                title.Text = titles;
                year.Text = years;
            }
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM movies";
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

        private void SaveRating(int rating)
        {
            if (selectedMovieId == 0)
            {
                MessageBox.Show("Please select a movie first.");
                return;
            }

            try
            {
                connection.Open();

                string query = "INSERT INTO ratings (movie_id, user_id, rating, timestamp) VALUES (@movie_id, @user_id, @rating, CURRENT_TIMESTAMP)";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@movie_id", selectedMovieId);
                command.Parameters.AddWithValue("@user_id", userId);
                command.Parameters.AddWithValue("@rating", rating);

                command.ExecuteNonQuery();

                MessageBox.Show("Rating saved successfully!");
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

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            SaveRating(1);
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            SaveRating(2);
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            SaveRating(3);
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            SaveRating(4);
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            SaveRating(5);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var logout = new Form1();
            this.Hide();
            logout.Show();
        }

        private void movieID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

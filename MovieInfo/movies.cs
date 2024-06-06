using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MovieInfo
{
    public partial class movies : Form
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

        public movies()
        {
            InitializeComponent();
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
                string durations = Convert.ToString(selectedRow.Cells["duration"].Value);
                string plots = Convert.ToString(selectedRow.Cells["plot_summary"].Value);
                string budgets = Convert.ToString(selectedRow.Cells["budget"].Value);
                string earnings = Convert.ToString(selectedRow.Cells["box_office_earnings"].Value);

                // Populate text boxes and controls with the selected row data
                movieID.Text = selectedMovieId.ToString();
                title.Text = titles;
                year.Text = years;
                duration.Text = durations;
                plot.Text = plots;
                budget.Text = budgets;
                earning.Text = earnings;
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
        private void Addnewbtn_Click(object sender, EventArgs e)
        {
            string title = this.title.Text;
            string year = this.year.Text;
            string duration = this.duration.Text;
            string plot = this.plot.Text;
            string budget = this.budget.Text;
            string earning = this.earning.Text;

            AddNewMovie(title, year, duration, plot, budget, earning);
            LoadDataIntoDataGridView();
        }
        private void AddNewMovie(string title, string year, string duration, string plot, string budget, string earning)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO movies ( title, release_year, duration, plot_summary, budget, box_office_earnings) " +
                       "VALUES (@title, @release_year, @duration, @plot_summary, @budget, @box_office_earnings)";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@release_year", year);
                command.Parameters.AddWithValue("@duration", duration);
                command.Parameters.AddWithValue("@plot_summary", plot);
                command.Parameters.AddWithValue("@budget", budget);
                command.Parameters.AddWithValue("@box_office_earnings", earning);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Movie added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add movie!");
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int movieId = Convert.ToInt32(movieID.Text);
            string title = this.title.Text;
            string year = this.year.Text;
            string duration = this.duration.Text;
            string plot = this.plot.Text;
            string budget = this.budget.Text;
            string earning = this.earning.Text;

            UpdateNewMovie(movieId, title, year, duration, plot, budget, earning);
            LoadDataIntoDataGridView();
        }
        private void UpdateNewMovie(int movieId, string title, string year, string duration, string plot, string budget, string earning)
        {
            try
            {
                connection.Open();
                // Update the student record in the database
                string query = "UPDATE movies SET title = @title, release_year = @release_year, duration = @duration, " +
                       "plot_summary = @plot_summary, budget = @budget, box_office_earnings = @box_office_earnings WHERE movie_id = @movie_id";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@movie_id", movieId);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@release_year", year);
                command.Parameters.AddWithValue("@duration", duration);
                command.Parameters.AddWithValue("@plot_summary", plot);
                command.Parameters.AddWithValue("@budget", budget);
                command.Parameters.AddWithValue("@box_office_earnings", earning);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Movie information updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update movie information!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating movie information: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TextBox text changed event logic can be implemented here.
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var otherform = new Dashboard();
            this.Hide();
            otherform.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System.Drawing;

namespace MovieInfo
{
    public partial class manageuser : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        private int selectedUserId;

        public manageuser()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadDataIntoDataGridView();
            dataGridView1.CellClick += dataGridView1_CellClick;
            UpdateTotalCount("SELECT COUNT(*) FROM movies", totalUsers);
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

                string query = "SELECT * FROM users";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve the user ID from the selected row
                selectedUserId = Convert.ToInt32(selectedRow.Cells["user_id"].Value);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            try
            {
                connection.Open();

                // Delete the user from the database
                string query = "DELETE FROM users WHERE user_id = @user_id";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user_id", selectedUserId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to delete user!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the user: " + ex.Message);
            }
            finally
            {
                connection.Close();
                LoadDataIntoDataGridView(); // Refresh the data grid view
            }
        }

        private void manageuser_Load(object sender, EventArgs e)
        {
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();
            SearchUsers(searchQuery);
        }

        private void totalMovies_Click(object sender, EventArgs e)
        {
        }

        private void labelMoviesCount_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var otherform = new Dashboard();
            this.Hide();
            otherform.Show();
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

        private void SearchUsers(string searchQuery)
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE username LIKE @searchQuery OR email LIKE @searchQuery";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

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

        private void printbtn_Click(object sender, EventArgs e)
        {
            string filePath = @"F:\VisualStudio2022 Repository\MovieInfo\UsersInfo.xlsx";
            try
            {
                connection.Open();

                string query = "SELECT user_id, username, email, role FROM users";
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Report worksheet
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Report");
                    ExcelWorksheet worksheet2 = excelPackage.Workbook.Worksheets.Add("Graphs");

                    // Logo and title for Report
                    var picture = worksheet.Drawings.AddPicture("Logo", new FileInfo("F:\\VisualStudio2022 Repository\\MovieInfo\\MovieInfo\\Properties\\favicon.ico"));
                    picture.SetSize(70, 70);
                    picture.SetPosition(0, 0, 0, 0);

                    worksheet.Cells["B1:I1"].Merge = true;
                    worksheet.Cells["B1"].Value = "User Information Report";
                    worksheet.Cells["B1"].Style.Font.Size = 20;
                    worksheet.Cells["B1"].Style.Font.Name = "Broadway";
                    worksheet.Cells["B1"].Style.Font.Color.SetColor(Color.Black);
                    worksheet.Cells["B1"].Style.Font.Bold = true;
                    worksheet.Cells["B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["B1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    worksheet.Cells["D3:G3"].Merge = true;
                    worksheet.Cells["D3"].Value = "User Details";
                    worksheet.Cells["D3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["D3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Cells["D4"].Value = "User ID";
                    worksheet.Cells["E4"].Value = "Username";
                    worksheet.Cells["F4"].Value = "Email";
                    worksheet.Cells["G4"].Value = "Role";

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        worksheet.Cells[i + 5, 4].Value = dataTable.Rows[i]["user_id"];
                        worksheet.Cells[i + 5, 5].Value = dataTable.Rows[i]["username"];
                        worksheet.Cells[i + 5, 6].Value = dataTable.Rows[i]["email"];
                        worksheet.Cells[i + 5, 7].Value = dataTable.Rows[i]["role"];
                    }

                    worksheet.Cells["D4:G4"].Style.Font.Bold = true;
                    worksheet.Cells["D4:G4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["D4:G4"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Cells["D4:G4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells["D4:G4"].Style.Fill.BackgroundColor.SetColor(Color.LightGray);

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    // Logo and title for Graphs
                    var picture2 = worksheet2.Drawings.AddPicture("Logo", new FileInfo("F:\\VisualStudio2022 Repository\\MovieInfo\\MovieInfo\\Properties\\favicon.ico"));
                    picture2.SetSize(70, 70);
                    picture2.SetPosition(0, 0, 0, 0);

                    worksheet2.Cells["B1:I1"].Merge = true;
                    worksheet2.Cells["B1"].Value = "User Information Graph";
                    worksheet2.Cells["B1"].Style.Font.Size = 20;
                    worksheet2.Cells["B1"].Style.Font.Name = "Broadway";
                    worksheet2.Cells["B1"].Style.Font.Color.SetColor(Color.Black);
                    worksheet2.Cells["B1"].Style.Font.Bold = true;
                    worksheet2.Cells["B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet2.Cells["B1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    // Populate data for graph
                    List<string> roles = new List<string> { "admin", "user" };
                    List<int> roleCounts = new List<int>();

                    foreach (string role in roles)
                    {
                        int count = dataTable.Select($"role = '{role}'").Length;

                        roleCounts.Add(count);
                    }

                    // Add data to worksheet for graph
                    worksheet2.Cells["A5"].Value = "Role";
                    worksheet2.Cells["B5"].Value = "Count";

                    for (int i = 0; i < roles.Count; i++)
                    {
                        worksheet2.Cells[i + 6, 1].Value = roles[i];
                        worksheet2.Cells[i + 6, 2].Value = roleCounts[i];
                    }

                    // Create chart
                    var chart = worksheet2.Drawings.AddChart("RoleChart", eChartType.ColumnClustered);
                    chart.SetPosition(2, 0, 0, 0);
                    chart.SetSize(615, 370);
                    chart.Title.Text = "User Roles";
                    chart.YAxis.Title.Text = "Total Users";
                    chart.XAxis.Title.Text = "Role";

                    var roleRange = worksheet2.Cells[6, 1, 5 + roles.Count, 1];
                    var roleCountsRange = worksheet2.Cells[6, 2, 5 + roles.Count, 2];

                    // Pass ExcelRangeBase objects to chart.Series.Add
                    chart.Series.Add(roleCountsRange, roleRange);
                    chart.Legend.Position = eLegendPosition.Bottom;

                    excelPackage.SaveAs(new FileInfo(filePath));
                    MessageBox.Show("Excel file saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

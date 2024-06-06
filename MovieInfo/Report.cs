using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
using System.Drawing;
using System.IO;

namespace MovieInfo
{
    public partial class Report : Form
    {
        private MySqlConnection connection;

        public Report()
        {
            InitializeComponent();
            InitializeDatabase();
            GenerateRatingChart();
        }

        private void InitializeDatabase()
        {
            string connectionString = "SERVER=localhost;DATABASE=activity2;UID=root;PASSWORD=erick;";
            connection = new MySqlConnection(connectionString);
        }

        private void GenerateRatingChart()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT m.title, COUNT(r.rating) AS total_ratings
                                            FROM movies m
                                            LEFT JOIN ratings r ON m.movie_id = r.movie_id
                                            GROUP BY m.title";

                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }

                if (dataTable.Rows.Count > 0)
                {
                    cartesianChart1.Series.Clear();
                    cartesianChart1.AxisX.Clear();

                    var series = new ColumnSeries
                    {
                        Title = "Total Ratings",
                        Values = new ChartValues<int>()
                    };

                    var labels = new List<string>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string title = row["title"].ToString();
                        int totalRatings = row["total_ratings"] != DBNull.Value ? Convert.ToInt32(row["total_ratings"]) : 0;

                        labels.Add(title);
                        series.Values.Add(totalRatings);
                    }

                    cartesianChart1.Series.Add(series);

                    cartesianChart1.AxisX.Add(new Axis
                    {
                        Labels = labels
                    });
                }
                else
                {
                    MessageBox.Show("No data available to generate chart.");
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

        private void labelSubtitle_Click(object sender, EventArgs e)
        {
            // Event handler for clicking on the labelSubtitle
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            // Event handler for changes in the chart's children
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var backtool = new Dashboard();
            this.Hide();
            backtool.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            this.Hide();
            form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            this.Hide();
            about.Show();
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            string filePath = @"F:\VisualStudio2022 Repository\MovieInfo\Movieinfo.xlsx";
            try
            {
                connection.Open();

                string query = @"SELECT m.title, COUNT(r.rating) AS total_ratings
                                 FROM movies m
                                 LEFT JOIN ratings r ON m.movie_id = r.movie_id
                                 GROUP BY m.title";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<string> movieTitles = new List<string>();
                    List<int> totalRatings = new List<int>();

                    while (reader.Read())
                    {
                        string title = reader["title"].ToString();
                        int ratings = reader["total_ratings"] != DBNull.Value ? Convert.ToInt32(reader["total_ratings"]) : 0;

                        movieTitles.Add(title);
                        totalRatings.Add(ratings);
                    }

                    reader.Close();

                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Report");
                        ExcelWorksheet worksheet2 = excelPackage.Workbook.Worksheets.Add("Graphs");

                        // Logo and title for Report
                        var picture = worksheet.Drawings.AddPicture("Logo", new FileInfo("F:\\VisualStudio2022 Repository\\MovieInfo\\MovieInfo\\Properties\\favicon.ico"));
                        picture.SetSize(70, 70);
                        picture.SetPosition(0, 0, 0, 0);

                        worksheet.Cells["B1:I1"].Merge = true;
                        worksheet.Cells["B1"].Value = "Movie Information Report";
                        worksheet.Cells["B1"].Style.Font.Size = 20;
                        worksheet.Cells["B1"].Style.Font.Name = "Broadway";
                        worksheet.Cells["B1"].Style.Font.Color.SetColor(Color.Black);
                        worksheet.Cells["B1"].Style.Font.Bold = true;
                        worksheet.Cells["B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells["B1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        worksheet.Cells["D3:E3"].Merge = true;
                        worksheet.Cells["D3"].Value = "Movie Ratings";
                        worksheet.Cells["D3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells["D3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        worksheet.Cells["D4"].Value = "Movie Title";
                        worksheet.Cells["E4"].Value = "Total Ratings";

                        for (int i = 0; i < movieTitles.Count; i++)
                        {
                            worksheet.Cells[i + 5, 4].Value = movieTitles[i];
                            worksheet.Cells[i + 5, 5].Value = totalRatings[i];
                        }

                        worksheet.Cells["D4:E4"].Style.Font.Bold = true;
                        worksheet.Cells["D4:E4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells["D4:E4"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        worksheet.Cells["D4:E4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells["D4:E4"].Style.Fill.BackgroundColor.SetColor(Color.LightGray);

                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        // Logo and title for Graphs
                        var picture2 = worksheet2.Drawings.AddPicture("Logo", new FileInfo("F:\\VisualStudio2022 Repository\\MovieInfo\\MovieInfo\\Properties\\favicon.ico"));
                        picture2.SetSize(70, 70);
                        picture2.SetPosition(0, 0, 0, 0);

                        worksheet2.Cells["B1:I1"].Merge = true;
                        worksheet2.Cells["B1"].Value = "Movie Information";
                        worksheet2.Cells["B1"].Style.Font.Size = 20;
                        worksheet2.Cells["B1"].Style.Font.Name = "Broadway";
                        worksheet2.Cells["B1"].Style.Font.Color.SetColor(Color.Black);
                        worksheet2.Cells["B1"].Style.Font.Bold = true;
                        worksheet2.Cells["B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet2.Cells["B1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        // Populate data
                        for (int i = 0; i < movieTitles.Count; i++)
                        {
                            worksheet2.Cells[i + 3, 1].Value = movieTitles[i];
                            worksheet2.Cells[i + 3, 2].Value = totalRatings[i];
                        }

                        // Create chart
                        ExcelChart chart = worksheet2.Drawings.AddChart("RatingChart", eChartType.ColumnClustered);
                        chart.SetPosition(2, 0, 0, 0);
                        chart.SetSize(615, 370);
                        chart.Title.Text = "Movie Ratings";
                        chart.YAxis.Title.Text = "Total Ratings";
                        chart.XAxis.Title.Text = "Movie Title";

                        chart.Series.Add(worksheet2.Cells[3, 2, movieTitles.Count + 2, 2], worksheet2.Cells[3, 1, movieTitles.Count + 2, 1]);
                        chart.Legend.Position = eLegendPosition.Bottom;

                        excelPackage.SaveAs(new FileInfo(filePath));
                        MessageBox.Show("Excel file saved successfully!");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Exception: {ex.Message}");
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

using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Immortals
{
    public partial class AdminDashboard : Form
    {
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataTable dt;
        public AdminDashboard()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb");
            this.Load += AdminDashboard_Load;
        }

        private void PopulateTopupHistoryDataGridView()
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM TopupHistory";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                topuphistoryDgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            PopulateTopupHistoryDataGridView();
        }

        private void adminsignoutBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void admintopupBtn_Click(object sender, EventArgs e)
        {
            new AdminTopup().Show();
        }

        private void salesreportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                DateTime currentDate = DateTime.Now;
                DateTime currentYearStart = new DateTime(currentDate.Year, 1, 1);
                DateTime currentMonthStart = new DateTime(currentDate.Year, currentDate.Month, 1);
                DateTime currentDayStart = currentDate.Date;

                string query = $"SELECT SUM(TopupAmount) FROM TopupHistory WHERE TopupDate >= #{currentYearStart}#";
                int totalSalesYear = ExecuteScalarIntQuery(query);

                query = $"SELECT SUM(TopupAmount) FROM TopupHistory WHERE TopupDate >= #{currentMonthStart}#";
                int totalSalesMonth = ExecuteScalarIntQuery(query);

                query = $"SELECT SUM(TopupAmount) FROM TopupHistory WHERE TopupDate >= #{currentDayStart}#";
                int totalSalesDay = ExecuteScalarIntQuery(query);

                string salesReportContent = $"Sales Report\n" +
                                            $"Date: {currentDate.ToString("MMMM dd, yyyy HH:mm:ss")}\n\n" +
                                            $"Total sales for year {currentDate.Year}: P{totalSalesYear}\n" +
                                            $"Total sales for the month of {currentDate.ToString("MMMM")}: P{totalSalesMonth}\n" +
                                            $"Total sales today: P{totalSalesDay}";

                string reportPath = @"W:\Documents\BSCpE\Soft Dev\Immortals\SalesReport.txt";
                Directory.CreateDirectory(Path.GetDirectoryName(reportPath));
                File.WriteAllText(reportPath, salesReportContent);

                var dialogResult = MessageBox.Show($"Sales report generated at {reportPath}.\nDo you want to print it now?",
                                                   "Sales Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    PrintSalesReport(reportPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void PrintSalesReport(string reportPath)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (sender, e) =>
            {
                string reportContent = File.ReadAllText(reportPath);
                e.Graphics.DrawString(reportContent, new Font("Arial", 20), Brushes.Black, new RectangleF(10, 10, e.MarginBounds.Width, e.MarginBounds.Height));
            };

            try
            {
                PrintDialog printDialog = new PrintDialog
                {
                    Document = printDoc
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while printing: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ExecuteScalarIntQuery(string query)
        {
            OleDbCommand cmd = new OleDbCommand(query, con);
            object result = cmd.ExecuteScalar();
            return result == DBNull.Value ? 0 : Convert.ToInt32(result);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string username = searchTbx.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                PopulateTopupHistoryDataGridView();
                return;
            }

            try
            {
                con.Open();

                string query = $"SELECT * FROM TopupHistory WHERE Username = ?";
                da = new OleDbDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@username", username);

                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No top-up records found for the specified username.");
                    topuphistoryDgv.DataSource = null;
                }
                else
                {
                    topuphistoryDgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void analyticsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string queryGuestAccounts = "SELECT COUNT(*) FROM GuestAccount";
                int totalGuestAccounts = ExecuteScalarIntQuery(queryGuestAccounts);

                string queryRegisteredAccounts = "SELECT COUNT(Username) FROM AccountInformation";
                int totalRegisteredAccounts = ExecuteScalarIntQuery(queryRegisteredAccounts);

                string queryRegisteredAccountsBalance = "SELECT SUM(userBalance) FROM AccountInformation";
                int totalRegisteredAccountsBalance = ExecuteScalarIntQuery(queryRegisteredAccountsBalance);

                string queryGuestAccountsBalance = "SELECT SUM(userBalance) FROM GuestAccount";
                int totalGuestAccountsBalance = ExecuteScalarIntQuery(queryGuestAccountsBalance);

                string queryTodayEarnings = "SELECT SUM(TopupAmount) FROM TopupHistory WHERE TopupDate = DATE()";
                int todayEarnings = ExecuteScalarIntQuery(queryTodayEarnings);

                string queryWeeklyEarnings = "SELECT SUM(TopupAmount) FROM TopupHistory WHERE TopupDate >= DATEADD('d', -7, DATE())";
                int weeklyEarnings = ExecuteScalarIntQuery(queryWeeklyEarnings);

                Chart analyticsChart = new Chart();
                analyticsChart.Dock = DockStyle.Fill;

                ChartArea accountsArea = new ChartArea("AccountsArea");
                analyticsChart.ChartAreas.Add(accountsArea);

                ChartArea balancesArea = new ChartArea("BalancesArea");
                analyticsChart.ChartAreas.Add(balancesArea);

                ChartArea earningsArea = new ChartArea("EarningsArea");
                analyticsChart.ChartAreas.Add(earningsArea);

                Series accountsSeries = new Series("User Accounts");
                accountsSeries.ChartType = SeriesChartType.Pie;
                accountsSeries.Points.AddXY("Guest Accounts", totalGuestAccounts);
                accountsSeries.Points.AddXY("Registered Accounts", totalRegisteredAccounts);
                accountsSeries.ChartArea = "AccountsArea";
                analyticsChart.Series.Add(accountsSeries);

                Series balanceSeries = new Series("Balances");
                balanceSeries.ChartType = SeriesChartType.Column;
                balanceSeries.Points.AddXY("Registered Balance", totalRegisteredAccountsBalance);
                balanceSeries.Points.AddXY("Guest Balance", totalGuestAccountsBalance);
                balanceSeries.ChartArea = "BalancesArea";
                analyticsChart.Series.Add(balanceSeries);

                Series earningsSeries = new Series("Earnings");
                earningsSeries.ChartType = SeriesChartType.Line;
                earningsSeries.Points.AddXY("Today", todayEarnings);
                earningsSeries.Points.AddXY("This Week", weeklyEarnings);
                earningsSeries.ChartArea = "EarningsArea";
                analyticsChart.Series.Add(earningsSeries);

                Form chartForm = new Form
                {
                    Text = "Analytics Dashboard",
                    Size = new Size(800, 600)
                };
                chartForm.Controls.Add(analyticsChart);
                chartForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

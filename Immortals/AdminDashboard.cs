using System;
using System.Data;
using System.Data.OleDb;
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
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Vincent\\Documents\\Immortals.accdb");
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

                MessageBox.Show($"Total sales for year {currentDate.Year} : P{totalSalesYear}\n" +
                                $"Total sales for month of {currentDate.ToString("MMMM")} : P{totalSalesMonth}\n" +
                                $"Total sales today : P{totalSalesDay}");
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
                TimeSpan totalRegisteredAccountsBalance = TimeSpan.FromSeconds(ExecuteScalarIntQuery(queryRegisteredAccountsBalance));

                string queryGuestAccountsBalance = "SELECT SUM(userBalance) FROM GuestAccount";
                TimeSpan totalGuestAccountsBalance = TimeSpan.FromSeconds(ExecuteScalarIntQuery(queryGuestAccountsBalance));

                MessageBox.Show($"Total Guest Accounts: {totalGuestAccounts}\n" +
                                $"Total Registered Accounts: {totalRegisteredAccounts}\n" +
                                $"Total Registered Accounts Unused Balance: {totalRegisteredAccountsBalance.ToString(@"hh\:mm\:ss")}\n" +
                                $"Total Guest Accounts Unused Balance: {totalGuestAccountsBalance.ToString(@"hh\:mm\:ss")}");
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

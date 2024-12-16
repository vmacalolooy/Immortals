using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Immortals
{
    public partial class UserTopupHistory : Form
    {
        private string username;

        public UserTopupHistory(string username)
        {
            InitializeComponent();
            this.username = username;
            PopulateTopupHistory(username);
        }

        private void PopulateTopupHistory(string username)
        {
            try
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb";
                string query = "SELECT TopupDate, TopupAmount FROM TopupHistory WHERE Username = @username";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@username", username);

                        DataTable topupTable = new DataTable();
                        adapter.Fill(topupTable);

                        
                        dataGridView.DataSource = topupTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating top-up history: " + ex.Message);
            }
        }
    }
}
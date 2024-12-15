using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Immortals
{
    public partial class AdminTopup : Form
    {
        private OleDbConnection con;

        public AdminTopup()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Vincent\\Documents\\Immortals.accdb");
        }

        private void submittopupBtn_Click(object sender, EventArgs e)
        {
            string username = usertopupTbx.Text;
            int amount = Convert.ToInt32(amountTbx.Text);
            int amountSeconds = amount * 240;

            try
            {
                con.Open();

                string updateBalanceQuery = $"UPDATE AccountInformation SET userBalance = userBalance + {amountSeconds} WHERE Username = '{username}'";
                OleDbCommand updateBalanceCmd = new OleDbCommand(updateBalanceQuery, con);
                int rowsUpdated = updateBalanceCmd.ExecuteNonQuery();

                if (rowsUpdated > 0)
                {

                    string insertHistoryQuery = $"INSERT INTO TopupHistory (Username, TopupDate, TopupAmount) VALUES ('{username}', '{DateTime.Now}', {amount})";
                    OleDbCommand insertHistoryCmd = new OleDbCommand(insertHistoryQuery, con);
                    int rowsInserted = insertHistoryCmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Top-up successful and logged.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to log top-up.");
                    }
                }
                else
                {
                    MessageBox.Show("Username not found or unable to update balance.");
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
    }
}

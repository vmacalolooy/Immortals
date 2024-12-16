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
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb");
        }

        private void submittopupBtn_Click(object sender, EventArgs e)
        {
            string username = usertopupTbx.Text;

            try
            {
                if (!int.TryParse(amountTbx.Text, out int amount))
                {
                    MessageBox.Show("Please enter a valid numeric top-up amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (amount < 0)
                {
                    MessageBox.Show("Top-up amount cannot be negative. Please enter a positive value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int amountSeconds = amount * 240;

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
                        MessageBox.Show("Top-up successful and logged.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Top-up successful, but logging failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Username not found or unable to update balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

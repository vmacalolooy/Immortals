using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Immortals
{
    public partial class GuestDashboard : Form
    {
        private int guestID;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Vincent\\Documents\\Immortals.accdb";

        public GuestDashboard(int guestID)
        {
            InitializeComponent();
            this.guestID = guestID;
            labelGuestID.Text = guestID.ToString();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int userBalance;
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    string selectBalanceQuery = $"SELECT userBalance FROM GuestAccount WHERE GuestID = {guestID}";
                    OleDbCommand cmd = new OleDbCommand(selectBalanceQuery, con);
                    userBalance = Convert.ToInt32(cmd.ExecuteScalar());
                }

                if (userBalance > 0)
                {
                    GamesMenu gamesMenuForm = new GamesMenu(guestID);
                    gamesMenuForm.Show();
                }
                else
                {
                    MessageBox.Show("You don't have enough balance. Please top-up first.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking user balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void topupBtn_Click(object sender, EventArgs e)
        {
            UserTopPanel.Visible = true;
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
            timer1.Stop();
        }

        private void submittopupBtn_Click(object sender, EventArgs e)
        {
            int topupAmount;
            if (!int.TryParse(usertopupTbx.Text, out topupAmount))
            {
                MessageBox.Show("Please enter a valid numeric amount.");
                return;
            }

            int topupInSeconds = topupAmount * 240;

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();
                string updateBalanceQuery = $"UPDATE GuestAccount SET userBalance = userBalance + {topupInSeconds} WHERE GuestID = {guestID}";
                OleDbCommand cmd = new OleDbCommand(updateBalanceQuery, con);
                cmd.ExecuteNonQuery();
            }

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();
                string insertTopupQuery = $"INSERT INTO TopupHistory (Username, TopupDate, TopupAmount) VALUES ('GuestUser', '{DateTime.Now}', {topupAmount})";
                OleDbCommand cmd = new OleDbCommand(insertTopupQuery, con);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Please wait as we confirm your payment.", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Windows.Forms.Timer delayTimer = new System.Windows.Forms.Timer();
            delayTimer.Interval = 5000;
            delayTimer.Tick += (delaySender, delayEventArgs) =>
            {
                delayTimer.Stop();
                MessageBox.Show("Top-up successful. Have fun!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshUserBalanceLabel();
            };

            delayTimer.Start();

            UserTopPanel.Visible = false;
        }


        private void RefreshUserBalanceLabel()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    string selectBalanceQuery = $"SELECT userBalance FROM GuestAccount WHERE GuestID = {guestID}";
                    OleDbCommand cmd = new OleDbCommand(selectBalanceQuery, con);
                    int userBalance = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userBalance > 0)
                    {
                        timer1.Start();
                    }
                    else
                    {
                        timer1.Stop();
                    }

                    int hours = userBalance / 3600;
                    int minutes = (userBalance % 3600) / 60;
                    int seconds = userBalance % 60;

                    labelTime.Text = $"{hours:00} : {minutes:00} : {seconds:00}";

                    if (userBalance == 300)
                    {
                        MessageBox.Show("You are running out of balance. Please top-up.", "Balance Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing user balance label: {ex.Message}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    string updateBalanceQuery = $"UPDATE GuestAccount SET userBalance = userBalance - 1 WHERE GuestID = {guestID}";
                    OleDbCommand cmd = new OleDbCommand(updateBalanceQuery, con);
                    cmd.ExecuteNonQuery();
                }

                RefreshUserBalanceLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user balance: {ex.Message}");
            }
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }
    }
}

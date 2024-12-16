using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Immortals
{
    public partial class GamesMenu : Form
    {
        private int guestID;
        private string username;
        private bool balanceAlertShown = false;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb";
        private System.Windows.Forms.Timer balanceTimer;

        public GamesMenu(int guestID)
        {
            InitializeComponent();
            this.guestID = guestID;
            InitializeBalanceTimer();
        }

        public GamesMenu(string username)
        {
            InitializeComponent();
            this.username = username;
            InitializeBalanceTimer();
        }

        private void InitializeBalanceTimer()
        {
            balanceTimer = new System.Windows.Forms.Timer();
            balanceTimer.Interval = 1000; // 1 second

            if (!string.IsNullOrEmpty(username))
            {
                
                balanceTimer.Tick += UsernameBalanceTimer_Tick;
            }
            else
            {
                
                balanceTimer.Tick += GuestIDBalanceTimer_Tick;
            }

            balanceTimer.Start();
        }

        private void GuestIDBalanceTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    string selectBalanceQuery = $"SELECT userBalance FROM GuestAccount WHERE GuestID = {guestID}";
                    OleDbCommand cmd = new OleDbCommand(selectBalanceQuery, con);
                    int userBalance = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userBalance == 1)
                    {
                        balanceTimer.Stop();
                        MessageBox.Show("You do not have enough balance. Please top-up to continue playing.", "Balance Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                    else if (userBalance == 300)
                    {
                        MessageBox.Show("You are running out of balance. Please top-up.", "Balance Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking user balance: {ex.Message}");
            }
        }

        private void UsernameBalanceTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    string selectBalanceQuery = $"SELECT userBalance FROM AccountInformation WHERE username = '{username}'";
                    OleDbCommand cmd = new OleDbCommand(selectBalanceQuery, con);
                    int userBalance = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userBalance == 1 && !balanceAlertShown)
                    {

                        balanceAlertShown = true;
                        userBalance = 0;
                        MessageBox.Show("You do not have enough balance. Please top-up to continue playing.", "Balance Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                    else if (userBalance == 300)
                    {
                        MessageBox.Show("You are running out of balance. Please top-up.", "Balance Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking user balance: {ex.Message}");
            }
        }

        private void dotaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string steamPath = @"C:\Program Files (x86)\Steam\Steam.exe";

                if (System.IO.File.Exists(steamPath))
                {
                    Process.Start(steamPath, "-applaunch 570");
                }
                else
                {
                    MessageBox.Show("Steam is not installed or the path is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void valorantBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string riotClientPath = @"C:\Riot Games\Riot Client\RiotClientServices.exe";

                if (System.IO.File.Exists(riotClientPath))
                {
                    Process.Start(riotClientPath, "--launch-product=valorant --launch-patchline=live");
                }
                else
                {
                    MessageBox.Show("Riot Client is not installed or the path is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lolBtn_Click(object sender, EventArgs e)
        {
            new Valorant().Show();
        }

        private void csBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string steamPath = @"C:\Program Files (x86)\Steam\Steam.exe";

                if (System.IO.File.Exists(steamPath))
                {
                    Process.Start(steamPath, "-applaunch 730");
                }
                else
                {
                    MessageBox.Show("Steam is not installed or the path is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forniteBtn_Click(object sender, EventArgs e)
        {
            new Fornite().Show();
        }

        private void chromeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

                if (System.IO.File.Exists(chromePath))
                {
                    Process.Start(chromePath);
                }
                else
                {
                    MessageBox.Show("Google Chrome is not installed or the path is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
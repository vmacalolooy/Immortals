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
using System.Threading;

namespace Immortals
{
    public partial class Dashboard : Form
    {
        private int initialBalanceInSeconds;
        private int elapsedSeconds;
        int amount, seconds;
        private int currentLoginID;
        public Dashboard(int initialBalanceInSeconds, string username)
        {
            InitializeComponent();
            this.initialBalanceInSeconds = initialBalanceInSeconds;
            elapsedSeconds = initialBalanceInSeconds;
            timer1.Enabled = true;
            UpdateTimerDisplay();

            labelUsername.Text = username;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            currentLoginID = InsertLoginRecord();
            var posi = this.PointToScreen(mainPanel.Location);
            posi = pictureBox3.PointToClient(posi);
            mainPanel.Parent = pictureBox3;
            mainPanel.Location = posi;
            mainPanel.BackColor = Color.FromArgb(50, 60, 31, 137);
        }
        private void InsertLogoutRecord(int loginID)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb"))
                {
                    string updateQuery = "UPDATE LoginHistory SET LogoutDateTime = @logoutDateTime WHERE LogID = @loginID";

                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@logoutDateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@loginID", loginID);

                        con.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Failed to update logout record.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating logout record: " + ex.Message);
            }
        }
        private int InsertLoginRecord()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb"))
                {
                    string insertQuery = "INSERT INTO LoginHistory (Username, LoginDateTime) VALUES (@username, @loginDateTime)";

                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@username", labelUsername.Text);
                        cmd.Parameters.AddWithValue("@loginDateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        con.Open();

                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "SELECT @@IDENTITY";
                        int loginID = Convert.ToInt32(cmd.ExecuteScalar());

                        return loginID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting login record: " + ex.Message);
                return -1;
            }
        }
        private void InsertTopupRecord(int topupAmount)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb"))
                {
                    string insertQuery = "INSERT INTO TopupHistory (Username, TopupDate, TopupAmount) VALUES (@username, @topupDate, @topupAmount)";

                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@username", labelUsername.Text);
                        cmd.Parameters.AddWithValue("@topupDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@topupAmount", topupAmount);

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting topup record: " + ex.Message);
            }
        }

        private void UpdateTimerDisplay()
        {
            int hours = elapsedSeconds / 3600;
            int minutes = (elapsedSeconds % 3600) / 60;
            int seconds = elapsedSeconds % 60;

            string timeString = $"{hours:00} : {minutes:00} : {seconds:00}";
            labelTime.Text = timeString;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds--;

            if (elapsedSeconds <= 0)
            {
                timer1.Stop();
                MessageBox.Show("You do not have enough balance please top-up.");

                UpdateUserBalanceInDatabase();
                UpdateTimerDisplay();
                return;
            }
            else if (elapsedSeconds == 300)
            {
                MessageBox.Show("You are running out of balance please top-up.");
                UpdateUserBalanceInDatabase();
                UpdateTimerDisplay();
            }
            else
            {
                UpdateUserBalanceInDatabase();
                UpdateTimerDisplay();
            }
        }



        private void UpdateUserBalanceInDatabase()
        {
            try
            {

                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb"))
                {

                    string updateQuery = "UPDATE AccountInformation SET userBalance = @userBalance WHERE username = @username";

                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@userBalance", elapsedSeconds);
                        cmd.Parameters.AddWithValue("@username", labelUsername.Text);


                        con.Open();


                        int rowsAffected = cmd.ExecuteNonQuery();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user balance: " + ex.Message);
            }
        }

        private void membersignoutBtn_Click(object sender, EventArgs e)
        {
            if (currentLoginID != 0)
            {
                InsertLogoutRecord(currentLoginID);
                timer1.Stop();
            }
            else
            {
                MessageBox.Show("Error: Invalid currentLoginID.");
                return;
            }

            new Form1().Show();
            this.Hide();

        }

        private void topupBtn_Click(object sender, EventArgs e)
        {
            UserAccPanel.Visible = false;
            UserTopPanel.Visible = true;


        }

        private void submittopupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                amount = int.Parse(usertopupTbx.Text);
                if(amount < 0)
                {
                    MessageBox.Show("Please enter a valid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int secondsToAdd = amount * 240;
                elapsedSeconds += secondsToAdd;
                successLabel.Visible = false;
                processLabel.Visible = true;

                InsertTopupRecord(amount);

                System.Windows.Forms.Timer delayTimer = new System.Windows.Forms.Timer();
                delayTimer.Interval = 5000;

                delayTimer.Tick += (delaySender, delayEventArgs) =>
                {
                    delayTimer.Stop();

                    UpdateUserBalanceInDatabase();
                    UpdateTimerDisplay();
                    timer1.Start();
                    timer1.Enabled = true;
                    processLabel.Visible = false;
                    successLabel.Visible = true;
                };

                delayTimer.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer amount.");
            }
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {

        }

        private void accountdetailsBtn_Click(object sender, EventArgs e)
        {

            UserAccPanel.Visible = true;
            UserTopPanel.Visible = false;
            UpdateUsernameTbx.Text = labelUsername.Text;
        }

        private void UpdateUsernameTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateAccInfoBtn_Click(object sender, EventArgs e)
        {
            string oldUsername = labelUsername.Text;
            string oldPassword = OldPassTbx.Text;

            string newUsername = UpdateUsernameTbx.Text;
            string newPassword = UserPassTbx.Text;
            string confirmPass = UserConPassTbx.Text;

            if (newPassword != confirmPass)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            try
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb"))
                {
                    string checkUsernameQuery = "SELECT COUNT(*) FROM AccountInformation WHERE username = @newUsername AND username <> @oldUsername";

                    using (OleDbCommand checkUsernameCmd = new OleDbCommand(checkUsernameQuery, con))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("@newUsername", newUsername);
                        checkUsernameCmd.Parameters.AddWithValue("@oldUsername", oldUsername);

                        con.Open();

                        int usernameCount = (int)checkUsernameCmd.ExecuteScalar();

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("The username you entered already exists. Please choose a different username.");
                            return;
                        }
                    }

                    string selectQuery = "SELECT userPassword FROM AccountInformation WHERE username = @username";

                    using (OleDbCommand selectCmd = new OleDbCommand(selectQuery, con))
                    {
                        selectCmd.Parameters.AddWithValue("@username", oldUsername);

                        string storedPassword = (string)selectCmd.ExecuteScalar();

                        if (storedPassword == oldPassword)
                        {
                            string updateQuery = "UPDATE AccountInformation SET username = @newUsername, userPassword = @newPassword WHERE username = @oldUsername";

                            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@newUsername", newUsername);
                                updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                                updateCmd.Parameters.AddWithValue("@oldUsername", oldUsername);

                                int rowsAffected = updateCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Account information updated successfully.");
                                    labelUsername.Text = newUsername;
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update account information.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Old password is incorrect. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating account information: " + ex.Message);
            }
        }

        private void UserDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb"))
                    {
                        string deleteQuery = "DELETE FROM AccountInformation WHERE username = @username";

                        using (OleDbCommand cmd = new OleDbCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@username", labelUsername.Text);

                            con.Open();

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Account deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete account.");
                            }
                        }
                    }

                    membersignoutBtn_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting account: " + ex.Message);
                }
            }
        }

        private void ShowHidePassCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (OldPassTbx.PasswordChar == '•')
            {
                OldPassTbx.PasswordChar = '\0';
                UserPassTbx.PasswordChar = '\0';
                UserConPassTbx.PasswordChar = '\0';
            }
            else
            {
                OldPassTbx.PasswordChar = '•';
                UserPassTbx.PasswordChar = '•';
                UserConPassTbx.PasswordChar = '•';
            }
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void memberplayBtn_Click(object sender, EventArgs e)
        {

            if (elapsedSeconds > 0)
            {

                GamesMenu gamesMenuForm = new GamesMenu(labelUsername.Text);
                gamesMenuForm.Show();
            }
            else
            {

                MessageBox.Show("You do not have enough balance. Please top-up your account.");
            }
        }

        private void viewHistoryBtn_Click(object sender, EventArgs e)
        {
            UserTopupHistory userTopupHistoryForm = new UserTopupHistory(labelUsername.Text);
            userTopupHistoryForm.Show();
        }
    }
}

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Immortals
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection? con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb");
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;



        private void Form1_Load(object sender, EventArgs e)
        {
            var posi = this.PointToScreen(panel1.Location);
            posi = pictureBox1.PointToClient(posi);
            panel1.Parent = pictureBox1;
            panel1.Location = posi;
            panel1.BackColor = Color.FromArgb(50, 60, 31, 137);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb");
            ds = new DataSet();
            con.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (usernameTbx.Text == "")
                {
                    usernameTbx.Text = "Enter username";
                    usernameTbx.ForeColor = Color.DimGray;
                    return;
                }

                usernameTbx.ForeColor = Color.Black;
                labelInvalidLogin.Visible = false;
                panel5.Visible = false;

            }
            catch { }
        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.ForeColor = Color.White;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.ForeColor = Color.White;
        }

        private void passwordTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (passwordTbx.Text == "")
                {
                    passwordTbx.Text = "Enter password";
                    passwordTbx.PasswordChar = '\0';
                    button5.BringToFront();
                    passwordTbx.ForeColor = Color.DimGray;
                    return;
                }
                passwordTbx.ForeColor = Color.Black;
                passwordTbx.PasswordChar = '•';
                button4.BringToFront();
                panel7.Visible = false;

            }
            catch { }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTbx.Text == "Enter username")
            {
                panel5.Visible = true;
                usernameTbx.Focus();
                return;
            }

            if (passwordTbx.Text == "Enter password")
            {
                panel7.Visible = true;
                passwordTbx.Focus();
                return;
            }

            con.Open();
            string login = "Select * from AccountInformation where username = '" + usernameTbx.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string username = dr["username"].ToString();
                string userPassword = dr["userPassword"].ToString();

                if (username == "admin" && passwordTbx.Text == userPassword)
                {
                    new AdminDashboard().Show();
                    this.Hide();
                }
                else if (passwordTbx.Text == userPassword)
                {
                    int initialBalanceInSeconds = 0;
                    if (dr["userBalance"] != DBNull.Value)
                    {
                        initialBalanceInSeconds = Convert.ToInt32(dr["userBalance"]);
                    }
                    new Dashboard(initialBalanceInSeconds, username).Show();
                    this.Hide();
                }
                else
                {
                    labelInvalidLogin.Visible = true;
                    passwordTbx.Focus();
                    passwordTbx.SelectAll();
                }
            }
            else
            {
                labelInvalidLogin.Visible = true;
                usernameTbx.Focus();
                usernameTbx.SelectAll();
            }

            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTbx_MouseEnter(object sender, EventArgs e)
        {

        }

        private void usernameTbx_MouseClick(object sender, MouseEventArgs e)
        {
            usernameTbx.SelectAll();
        }

        private void passwordTbx_MouseClick(object sender, MouseEventArgs e)
        {
            passwordTbx.SelectAll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (passwordTbx.PasswordChar == '•')
            {
                button5.BringToFront();
                passwordTbx.PasswordChar = '\0';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (passwordTbx.PasswordChar == '\0')
            {
                button4.BringToFront();
                passwordTbx.PasswordChar = '•';
            }
        }

        private void beamemberBtn_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
            this.Hide();
        }

        private void playGuestBtn_Click(object sender, EventArgs e)
        {
            con.Open();


            string insertQuery = "INSERT INTO GuestAccount (Username) VALUES ('GuestUser')";
            cmd = new OleDbCommand(insertQuery, con);
            cmd.ExecuteNonQuery();


            string getLastIDQuery = "SELECT @@Identity";
            cmd = new OleDbCommand(getLastIDQuery, con);
            int guestID = Convert.ToInt32(cmd.ExecuteScalar());


            GuestDashboard guestDashboard = new GuestDashboard(guestID);
            guestDashboard.Show();


            this.Hide();

            con.Close();
        }
    }
}

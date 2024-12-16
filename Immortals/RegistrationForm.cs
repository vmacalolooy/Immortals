using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Immortals
{
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }

        OleDbConnection? con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\\Documents\\BSCpE\\Soft Dev\\Immortals\\Immortals.accdb");
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        OleDbDataReader? dr;

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            var posi = this.PointToScreen(panel1.Location);
            posi = pictureBox2.PointToClient(posi);
            panel1.Parent = pictureBox2;
            panel1.Location = posi;
            panel1.BackColor = Color.FromArgb(50, 60, 31, 137);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            if (newusernameTbx.Text == "Enter new username")
            {
                panel51.Visible = true;
                newusernameTbx.Focus();
                return;
            }
            if (newpasswordTbx.Text == "Enter password")
            {
                panel71.Visible = true;
                newpasswordTbx.Focus();
                return;
            }
            if (confirmpasswordTbx.Text == "Confirm password")
            {
                panel111.Visible = true;
                confirmpasswordTbx.Focus();
                return;
            }
            else if (newpasswordTbx.Text == confirmpasswordTbx.Text)
            {

                con.Open();
                string checkUsernameQuery = "SELECT IIf(Count(*)>0, 'Yes', 'No') FROM AccountInformation WHERE username = @username";
                cmd = new OleDbCommand(checkUsernameQuery, con);
                cmd.Parameters.AddWithValue("@username", newusernameTbx.Text);
                string usernameExists = cmd.ExecuteScalar().ToString();
                con.Close();

                if (usernameExists == "Yes")
                {
                    labelUserExist.Visible = true;
                    newusernameTbx.Focus();
                    newusernameTbx.SelectAll();
                    return;
                }

                con.Open();
                string register = "INSERT INTO AccountInformation (username, userPassword) VALUES (@newusername, @newpassword)";
                cmd = new OleDbCommand(register, con);
                cmd.Parameters.AddWithValue("@newusername", newusernameTbx.Text);
                cmd.Parameters.AddWithValue("@newpassword", newpasswordTbx.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                newusernameTbx.Text = "Enter new username";
                newpasswordTbx.Text = "Enter password";
                confirmpasswordTbx.Text = "Confirm password";
                labelSuccess.Visible = true;
            }
            else
            {
                newpasswordTbx.Text = "Enter password";
                newpasswordTbx.PasswordChar = '\0';
                button51.BringToFront();
                newpasswordTbx.ForeColor = Color.DimGray;
                confirmpasswordTbx.Text = "Enter password";
                confirmpasswordTbx.PasswordChar = '\0';
                button52.BringToFront();
                confirmpasswordTbx.ForeColor = Color.DimGray;
                label71.Visible = true;
                newpasswordTbx.Focus();
                newpasswordTbx.SelectAll();
            }
        }

        private void newusernameTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (newusernameTbx.Text == "")
                {
                    newusernameTbx.Text = "Enter new username";
                    newusernameTbx.ForeColor = Color.DimGray;
                    return;
                }
                newusernameTbx.ForeColor = Color.Black;
                labelUserExist.Visible = false;
                labelSuccess.Visible = false;
                panel51.Visible = false;

            }
            catch { }
        }

        private void newpasswordTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (newpasswordTbx.Text == "")
                {
                    newpasswordTbx.Text = "Enter password";
                    newpasswordTbx.PasswordChar = '\0';
                    button51.BringToFront();
                    newpasswordTbx.ForeColor = Color.DimGray;
                    return;
                }
                newpasswordTbx.ForeColor = Color.Black;
                newpasswordTbx.PasswordChar = '•';
                button41.BringToFront();
                panel71.Visible = false;
                label71.Visible = false;

            }
            catch { }
        }

        private void confirmpasswordTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (confirmpasswordTbx.Text == "")
                {
                    confirmpasswordTbx.Text = "Enter password";
                    confirmpasswordTbx.PasswordChar = '\0';
                    button52.BringToFront();
                    confirmpasswordTbx.ForeColor = Color.DimGray;
                    return;
                }
                confirmpasswordTbx.ForeColor = Color.Black;
                confirmpasswordTbx.PasswordChar = '•';
                button42.BringToFront();
                panel111.Visible = false;
                label71.Visible = false;

            }
            catch { }
        }

        private void newusernameTbx_MouseClick(object sender, MouseEventArgs e)
        {
            newusernameTbx.SelectAll();
        }

        private void newpasswordTbx_MouseClick(object sender, MouseEventArgs e)
        {
            newpasswordTbx.SelectAll();
        }

        private void confirmpasswordTbx_MouseClick(object sender, MouseEventArgs e)
        {
            confirmpasswordTbx.SelectAll();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (newpasswordTbx.PasswordChar == '\0')
            {
                button41.BringToFront();
                newpasswordTbx.PasswordChar = '•';
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (confirmpasswordTbx.PasswordChar == '\0')
            {
                button42.BringToFront();
                confirmpasswordTbx.PasswordChar = '•';
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (confirmpasswordTbx.PasswordChar == '•')
            {
                button52.BringToFront();
                confirmpasswordTbx.PasswordChar = '\0';
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (newpasswordTbx.PasswordChar == '•')
            {
                button51.BringToFront();
                newpasswordTbx.PasswordChar = '\0';
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void backtologinBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}

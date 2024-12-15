namespace Immortals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            labelInvalidLogin = new Label();
            beamemberBtn = new Button();
            playGuestBtn = new Button();
            loginBtn = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            label3 = new Label();
            panel8 = new Panel();
            button5 = new Button();
            button4 = new Button();
            panel9 = new Panel();
            passwordTbx = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            usernameTbx = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1337, 748);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(labelInvalidLogin);
            panel1.Controls.Add(beamemberBtn);
            panel1.Controls.Add(playGuestBtn);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(438, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 447);
            panel1.TabIndex = 2;
            panel1.MouseLeave += panel1_MouseLeave;
            // 
            // labelInvalidLogin
            // 
            labelInvalidLogin.AutoSize = true;
            labelInvalidLogin.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidLogin.ForeColor = Color.Red;
            labelInvalidLogin.Location = new Point(170, 79);
            labelInvalidLogin.Name = "labelInvalidLogin";
            labelInvalidLogin.Size = new Size(291, 17);
            labelInvalidLogin.TabIndex = 10;
            labelInvalidLogin.Text = "Invalid username or password try again.";
            labelInvalidLogin.Visible = false;
            // 
            // beamemberBtn
            // 
            beamemberBtn.Cursor = Cursors.Hand;
            beamemberBtn.FlatAppearance.BorderSize = 2;
            beamemberBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            beamemberBtn.FlatStyle = FlatStyle.Flat;
            beamemberBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            beamemberBtn.ForeColor = SystemColors.ButtonHighlight;
            beamemberBtn.Location = new Point(170, 292);
            beamemberBtn.Name = "beamemberBtn";
            beamemberBtn.Size = new Size(250, 33);
            beamemberBtn.TabIndex = 7;
            beamemberBtn.Text = "Be a Member";
            beamemberBtn.UseVisualStyleBackColor = true;
            beamemberBtn.Click += beamemberBtn_Click;
            // 
            // playGuestBtn
            // 
            playGuestBtn.Cursor = Cursors.Hand;
            playGuestBtn.FlatAppearance.BorderSize = 2;
            playGuestBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            playGuestBtn.FlatStyle = FlatStyle.Flat;
            playGuestBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playGuestBtn.ForeColor = SystemColors.ButtonHighlight;
            playGuestBtn.Location = new Point(170, 339);
            playGuestBtn.Name = "playGuestBtn";
            playGuestBtn.Size = new Size(250, 33);
            playGuestBtn.TabIndex = 6;
            playGuestBtn.Text = "Play as Guest";
            playGuestBtn.UseVisualStyleBackColor = true;
            playGuestBtn.Click += playGuestBtn_Click;
            playGuestBtn.MouseEnter += loginBtn_MouseEnter;
            // 
            // loginBtn
            // 
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 2;
            loginBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(170, 241);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(250, 33);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            loginBtn.MouseEnter += loginBtn_MouseEnter;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(198, 151);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 53);
            panel6.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(label3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 31);
            panel7.Name = "panel7";
            panel7.Size = new Size(230, 17);
            panel7.TabIndex = 3;
            panel7.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 4;
            label3.Text = "Invalid Password";
            // 
            // panel8
            // 
            panel8.Controls.Add(button5);
            panel8.Controls.Add(button4);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(passwordTbx);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(230, 31);
            panel8.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.BackgroundImage = Properties.Resources.HideEye1;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(197, 9);
            button5.Name = "button5";
            button5.Size = new Size(25, 20);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImage = Properties.Resources.ShowEye1;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(197, 10);
            button4.Name = "button4";
            button4.Size = new Size(25, 20);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel9
            // 
            panel9.Location = new Point(11, 95);
            panel9.Name = "panel9";
            panel9.Size = new Size(267, 42);
            panel9.TabIndex = 2;
            // 
            // passwordTbx
            // 
            passwordTbx.BackColor = Color.FromArgb(218, 244, 251);
            passwordTbx.BorderStyle = BorderStyle.None;
            passwordTbx.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTbx.ForeColor = Color.DimGray;
            passwordTbx.Location = new Point(3, 10);
            passwordTbx.Name = "passwordTbx";
            passwordTbx.Size = new Size(219, 18);
            passwordTbx.TabIndex = 1;
            passwordTbx.Text = "Enter password";
            passwordTbx.TextAlign = HorizontalAlignment.Center;
            passwordTbx.MouseClick += passwordTbx_MouseClick;
            passwordTbx.TextChanged += passwordTbx_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.PaleTurquoise;
            label4.Location = new Point(111, 161);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(201, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 53);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 31);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 16);
            panel5.TabIndex = 3;
            panel5.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 18);
            label2.TabIndex = 4;
            label2.Text = "Invalid Username";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(usernameTbx);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 31);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(11, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 42);
            panel3.TabIndex = 2;
            // 
            // usernameTbx
            // 
            usernameTbx.BackColor = Color.FromArgb(218, 244, 251);
            usernameTbx.BorderStyle = BorderStyle.None;
            usernameTbx.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTbx.ForeColor = Color.DimGray;
            usernameTbx.Location = new Point(0, 5);
            usernameTbx.Name = "usernameTbx";
            usernameTbx.Size = new Size(219, 18);
            usernameTbx.TabIndex = 1;
            usernameTbx.Text = "Enter username";
            usernameTbx.TextAlign = HorizontalAlignment.Center;
            usernameTbx.MouseClick += usernameTbx_MouseClick;
            usernameTbx.TextChanged += textBox1_TextChanged;
            usernameTbx.MouseEnter += usernameTbx_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(107, 104);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.LoginPage;
            pictureBox1.Location = new Point(-10, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1422, 771);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login__1_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox usernameTbx;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Label label2;
        private Panel panel6;
        private Panel panel7;
        private Label label3;
        private Panel panel8;
        private Panel panel9;
        private TextBox passwordTbx;
        private Label label4;
        private Button loginBtn;
        private Button playGuestBtn;
        private Button button4;
        private Button button5;
        private Button beamemberBtn;
        private Label labelInvalidLogin;
    }
}
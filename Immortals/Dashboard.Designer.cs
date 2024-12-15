namespace Immortals
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            memberplayBtn = new Button();
            pictureBox3 = new PictureBox();
            accountdetailsBtn = new Button();
            topupBtn = new Button();
            membersignoutBtn = new Button();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            mainPanel = new Panel();
            UserAccPanel = new Panel();
            ShowHidePassCbx = new CheckBox();
            UserConPassTbx = new TextBox();
            UpdateUsernameTbx = new TextBox();
            OldPassTbx = new TextBox();
            UserPassTbx = new TextBox();
            UserDeleteBtn = new Button();
            UpdateAccInfoBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            UpdateConfirmPassTbx = new Label();
            UpdateNewPassTbx = new Label();
            label4 = new Label();
            UserTopPanel = new Panel();
            submittopupBtn = new Button();
            successLabel = new Label();
            label7 = new Label();
            usertopupTbx = new TextBox();
            label1 = new Label();
            processLabel = new Label();
            DelayTimer = new System.Windows.Forms.Timer(components);
            labelUsername = new Label();
            viewHistoryBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            mainPanel.SuspendLayout();
            UserAccPanel.SuspendLayout();
            UserTopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // memberplayBtn
            // 
            memberplayBtn.BackColor = Color.Transparent;
            memberplayBtn.Cursor = Cursors.Hand;
            memberplayBtn.FlatAppearance.BorderSize = 0;
            memberplayBtn.FlatStyle = FlatStyle.Flat;
            memberplayBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberplayBtn.ForeColor = Color.White;
            memberplayBtn.Location = new Point(128, 350);
            memberplayBtn.Name = "memberplayBtn";
            memberplayBtn.Size = new Size(223, 50);
            memberplayBtn.TabIndex = 0;
            memberplayBtn.Text = "Play Now";
            memberplayBtn.TextAlign = ContentAlignment.MiddleLeft;
            memberplayBtn.UseVisualStyleBackColor = false;
            memberplayBtn.Click += memberplayBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.memberDashboard;
            pictureBox3.Location = new Point(1, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1373, 749);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // accountdetailsBtn
            // 
            accountdetailsBtn.BackColor = Color.Transparent;
            accountdetailsBtn.Cursor = Cursors.Hand;
            accountdetailsBtn.FlatAppearance.BorderSize = 0;
            accountdetailsBtn.FlatStyle = FlatStyle.Flat;
            accountdetailsBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountdetailsBtn.ForeColor = Color.White;
            accountdetailsBtn.Location = new Point(128, 432);
            accountdetailsBtn.Name = "accountdetailsBtn";
            accountdetailsBtn.Size = new Size(223, 50);
            accountdetailsBtn.TabIndex = 0;
            accountdetailsBtn.Text = "Account Details";
            accountdetailsBtn.TextAlign = ContentAlignment.MiddleLeft;
            accountdetailsBtn.UseVisualStyleBackColor = false;
            accountdetailsBtn.Click += accountdetailsBtn_Click;
            // 
            // topupBtn
            // 
            topupBtn.BackColor = Color.Transparent;
            topupBtn.Cursor = Cursors.Hand;
            topupBtn.FlatAppearance.BorderSize = 0;
            topupBtn.FlatStyle = FlatStyle.Flat;
            topupBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            topupBtn.ForeColor = Color.White;
            topupBtn.Location = new Point(128, 522);
            topupBtn.Name = "topupBtn";
            topupBtn.Size = new Size(223, 50);
            topupBtn.TabIndex = 0;
            topupBtn.Text = "Top - up";
            topupBtn.TextAlign = ContentAlignment.MiddleLeft;
            topupBtn.UseVisualStyleBackColor = false;
            topupBtn.Click += topupBtn_Click;
            // 
            // membersignoutBtn
            // 
            membersignoutBtn.BackColor = Color.Transparent;
            membersignoutBtn.Cursor = Cursors.Hand;
            membersignoutBtn.FlatAppearance.BorderSize = 0;
            membersignoutBtn.FlatStyle = FlatStyle.Flat;
            membersignoutBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            membersignoutBtn.ForeColor = Color.White;
            membersignoutBtn.Location = new Point(128, 601);
            membersignoutBtn.Name = "membersignoutBtn";
            membersignoutBtn.Size = new Size(223, 50);
            membersignoutBtn.TabIndex = 0;
            membersignoutBtn.Text = "Sign Out";
            membersignoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            membersignoutBtn.UseVisualStyleBackColor = false;
            membersignoutBtn.Click += membersignoutBtn_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.Transparent;
            labelTime.FlatStyle = FlatStyle.Flat;
            labelTime.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(115, 711);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(197, 38);
            labelTime.TabIndex = 6;
            labelTime.Text = "00 : 00 : 00";
            labelTime.Click += labelTime_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Controls.Add(UserAccPanel);
            mainPanel.Controls.Add(UserTopPanel);
            mainPanel.Location = new Point(357, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1066, 771);
            mainPanel.TabIndex = 7;
            // 
            // UserAccPanel
            // 
            UserAccPanel.BackColor = Color.Transparent;
            UserAccPanel.Controls.Add(ShowHidePassCbx);
            UserAccPanel.Controls.Add(UserConPassTbx);
            UserAccPanel.Controls.Add(UpdateUsernameTbx);
            UserAccPanel.Controls.Add(OldPassTbx);
            UserAccPanel.Controls.Add(UserPassTbx);
            UserAccPanel.Controls.Add(UserDeleteBtn);
            UserAccPanel.Controls.Add(UpdateAccInfoBtn);
            UserAccPanel.Controls.Add(label3);
            UserAccPanel.Controls.Add(label2);
            UserAccPanel.Controls.Add(UpdateConfirmPassTbx);
            UserAccPanel.Controls.Add(UpdateNewPassTbx);
            UserAccPanel.Controls.Add(label4);
            UserAccPanel.Location = new Point(361, 47);
            UserAccPanel.Name = "UserAccPanel";
            UserAccPanel.Size = new Size(297, 690);
            UserAccPanel.TabIndex = 12;
            UserAccPanel.Visible = false;
            // 
            // ShowHidePassCbx
            // 
            ShowHidePassCbx.AutoSize = true;
            ShowHidePassCbx.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ShowHidePassCbx.ForeColor = SystemColors.ControlLightLight;
            ShowHidePassCbx.Location = new Point(22, 420);
            ShowHidePassCbx.Name = "ShowHidePassCbx";
            ShowHidePassCbx.Size = new Size(163, 21);
            ShowHidePassCbx.TabIndex = 12;
            ShowHidePassCbx.Text = "Show/Hide Password";
            ShowHidePassCbx.UseVisualStyleBackColor = true;
            ShowHidePassCbx.CheckedChanged += ShowHidePassCbx_CheckedChanged;
            // 
            // UserConPassTbx
            // 
            UserConPassTbx.BackColor = Color.FromArgb(218, 244, 251);
            UserConPassTbx.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserConPassTbx.Location = new Point(18, 382);
            UserConPassTbx.Name = "UserConPassTbx";
            UserConPassTbx.PasswordChar = '•';
            UserConPassTbx.Size = new Size(226, 30);
            UserConPassTbx.TabIndex = 11;
            // 
            // UpdateUsernameTbx
            // 
            UpdateUsernameTbx.BackColor = Color.FromArgb(218, 244, 251);
            UpdateUsernameTbx.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateUsernameTbx.Location = new Point(18, 149);
            UpdateUsernameTbx.Name = "UpdateUsernameTbx";
            UpdateUsernameTbx.Size = new Size(226, 30);
            UpdateUsernameTbx.TabIndex = 11;
            // 
            // OldPassTbx
            // 
            OldPassTbx.BackColor = Color.FromArgb(218, 244, 251);
            OldPassTbx.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            OldPassTbx.Location = new Point(18, 231);
            OldPassTbx.Name = "OldPassTbx";
            OldPassTbx.PasswordChar = '•';
            OldPassTbx.Size = new Size(226, 30);
            OldPassTbx.TabIndex = 11;
            // 
            // UserPassTbx
            // 
            UserPassTbx.BackColor = Color.FromArgb(218, 244, 251);
            UserPassTbx.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserPassTbx.Location = new Point(18, 305);
            UserPassTbx.Name = "UserPassTbx";
            UserPassTbx.PasswordChar = '•';
            UserPassTbx.Size = new Size(226, 30);
            UserPassTbx.TabIndex = 11;
            // 
            // UserDeleteBtn
            // 
            UserDeleteBtn.BackColor = Color.Red;
            UserDeleteBtn.FlatAppearance.BorderColor = Color.White;
            UserDeleteBtn.FlatAppearance.BorderSize = 2;
            UserDeleteBtn.FlatStyle = FlatStyle.Flat;
            UserDeleteBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserDeleteBtn.ForeColor = Color.White;
            UserDeleteBtn.Location = new Point(6, 516);
            UserDeleteBtn.Name = "UserDeleteBtn";
            UserDeleteBtn.Size = new Size(231, 39);
            UserDeleteBtn.TabIndex = 10;
            UserDeleteBtn.Text = "Delete Account";
            UserDeleteBtn.UseVisualStyleBackColor = false;
            UserDeleteBtn.Click += UserDeleteBtn_Click;
            // 
            // UpdateAccInfoBtn
            // 
            UpdateAccInfoBtn.FlatAppearance.BorderColor = Color.White;
            UpdateAccInfoBtn.FlatAppearance.BorderSize = 2;
            UpdateAccInfoBtn.FlatStyle = FlatStyle.Flat;
            UpdateAccInfoBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateAccInfoBtn.ForeColor = Color.White;
            UpdateAccInfoBtn.Location = new Point(6, 461);
            UpdateAccInfoBtn.Name = "UpdateAccInfoBtn";
            UpdateAccInfoBtn.Size = new Size(231, 39);
            UpdateAccInfoBtn.TabIndex = 10;
            UpdateAccInfoBtn.Text = "Update Information";
            UpdateAccInfoBtn.UseVisualStyleBackColor = true;
            UpdateAccInfoBtn.Click += UpdateAccInfoBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Rockwell", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 30);
            label3.Name = "label3";
            label3.Size = new Size(269, 39);
            label3.TabIndex = 8;
            label3.Text = "Account Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 203);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 8;
            label2.Text = "Old Password";
            // 
            // UpdateConfirmPassTbx
            // 
            UpdateConfirmPassTbx.AutoSize = true;
            UpdateConfirmPassTbx.BackColor = Color.Transparent;
            UpdateConfirmPassTbx.FlatStyle = FlatStyle.Flat;
            UpdateConfirmPassTbx.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateConfirmPassTbx.ForeColor = Color.White;
            UpdateConfirmPassTbx.Location = new Point(13, 358);
            UpdateConfirmPassTbx.Name = "UpdateConfirmPassTbx";
            UpdateConfirmPassTbx.Size = new Size(172, 21);
            UpdateConfirmPassTbx.TabIndex = 8;
            UpdateConfirmPassTbx.Text = "Confirm Password";
            // 
            // UpdateNewPassTbx
            // 
            UpdateNewPassTbx.AutoSize = true;
            UpdateNewPassTbx.BackColor = Color.Transparent;
            UpdateNewPassTbx.FlatStyle = FlatStyle.Flat;
            UpdateNewPassTbx.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateNewPassTbx.ForeColor = Color.White;
            UpdateNewPassTbx.Location = new Point(18, 281);
            UpdateNewPassTbx.Name = "UpdateNewPassTbx";
            UpdateNewPassTbx.Size = new Size(140, 21);
            UpdateNewPassTbx.TabIndex = 8;
            UpdateNewPassTbx.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 125);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // UserTopPanel
            // 
            UserTopPanel.BackColor = Color.Transparent;
            UserTopPanel.Controls.Add(viewHistoryBtn);
            UserTopPanel.Controls.Add(submittopupBtn);
            UserTopPanel.Controls.Add(successLabel);
            UserTopPanel.Controls.Add(label7);
            UserTopPanel.Controls.Add(usertopupTbx);
            UserTopPanel.Controls.Add(label1);
            UserTopPanel.Controls.Add(processLabel);
            UserTopPanel.Location = new Point(39, 47);
            UserTopPanel.Name = "UserTopPanel";
            UserTopPanel.Size = new Size(297, 545);
            UserTopPanel.TabIndex = 12;
            UserTopPanel.Visible = false;
            // 
            // submittopupBtn
            // 
            submittopupBtn.Cursor = Cursors.Hand;
            submittopupBtn.FlatAppearance.BorderSize = 2;
            submittopupBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            submittopupBtn.FlatStyle = FlatStyle.Flat;
            submittopupBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            submittopupBtn.ForeColor = SystemColors.ButtonHighlight;
            submittopupBtn.Location = new Point(13, 182);
            submittopupBtn.Name = "submittopupBtn";
            submittopupBtn.Size = new Size(145, 33);
            submittopupBtn.TabIndex = 9;
            submittopupBtn.Text = "Submit";
            submittopupBtn.UseVisualStyleBackColor = true;
            submittopupBtn.Click += submittopupBtn_Click;
            // 
            // successLabel
            // 
            successLabel.AutoSize = true;
            successLabel.BackColor = Color.Transparent;
            successLabel.FlatStyle = FlatStyle.Flat;
            successLabel.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            successLabel.ForeColor = Color.Lime;
            successLabel.Location = new Point(13, 149);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(139, 17);
            successLabel.TabIndex = 10;
            successLabel.Text = "Top-up successful.";
            successLabel.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Rockwell", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 30);
            label7.Name = "label7";
            label7.Size = new Size(133, 39);
            label7.TabIndex = 8;
            label7.Text = "Top-up";
            // 
            // usertopupTbx
            // 
            usertopupTbx.BackColor = Color.FromArgb(218, 244, 251);
            usertopupTbx.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usertopupTbx.Location = new Point(13, 116);
            usertopupTbx.Name = "usertopupTbx";
            usertopupTbx.Size = new Size(231, 30);
            usertopupTbx.TabIndex = 0;
            usertopupTbx.TextChanged += UpdateUsernameTbx_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 92);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 8;
            label1.Text = "Enter amount:";
            // 
            // processLabel
            // 
            processLabel.AutoSize = true;
            processLabel.BackColor = Color.Transparent;
            processLabel.FlatStyle = FlatStyle.Flat;
            processLabel.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            processLabel.ForeColor = Color.Snow;
            processLabel.Location = new Point(13, 149);
            processLabel.Name = "processLabel";
            processLabel.Size = new Size(240, 17);
            processLabel.TabIndex = 11;
            processLabel.Text = "Processing payment please wait.";
            processLabel.Visible = false;
            // 
            // DelayTimer
            // 
            DelayTimer.Interval = 1000;
            DelayTimer.Tick += DelayTimer_Tick;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.FlatStyle = FlatStyle.Flat;
            labelUsername.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(148, 229);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(58, 19);
            labelUsername.TabIndex = 6;
            labelUsername.Text = "label1";
            // 
            // viewHistoryBtn
            // 
            viewHistoryBtn.Cursor = Cursors.Hand;
            viewHistoryBtn.FlatAppearance.BorderSize = 2;
            viewHistoryBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            viewHistoryBtn.FlatStyle = FlatStyle.Flat;
            viewHistoryBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            viewHistoryBtn.ForeColor = SystemColors.ButtonHighlight;
            viewHistoryBtn.Location = new Point(18, 467);
            viewHistoryBtn.Name = "viewHistoryBtn";
            viewHistoryBtn.Size = new Size(261, 33);
            viewHistoryBtn.TabIndex = 9;
            viewHistoryBtn.Text = "View Topup History";
            viewHistoryBtn.UseVisualStyleBackColor = true;
            viewHistoryBtn.Click += viewHistoryBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.memberDashboard;
            ClientSize = new Size(1370, 749);
            Controls.Add(labelUsername);
            Controls.Add(mainPanel);
            Controls.Add(labelTime);
            Controls.Add(membersignoutBtn);
            Controls.Add(topupBtn);
            Controls.Add(accountdetailsBtn);
            Controls.Add(memberplayBtn);
            Controls.Add(pictureBox3);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            mainPanel.ResumeLayout(false);
            UserAccPanel.ResumeLayout(false);
            UserAccPanel.PerformLayout();
            UserTopPanel.ResumeLayout(false);
            UserTopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button memberplayBtn;
        private PictureBox pictureBox3;
        private Button accountdetailsBtn;
        private Button topupBtn;
        private Button membersignoutBtn;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private Panel mainPanel;
        private Label label1;
        private Label successLabel;
        private Button submittopupBtn;
        private Label processLabel;
        private System.Windows.Forms.Timer DelayTimer;
        private Panel UserAccountLabel;
        private Label label7;
        private Panel UserTopPanel;
        private Panel UserAccPanel;
        private Label label3;
        private Label UpdateConfirmPassTbx;
        private Label UpdateNewPassTbx;
        private Label label4;
        private TextBox usertopupTbx;
        private Button UpdateAccInfoBtn;
        private Button UserDeleteBtn;
        private TextBox UserConPassTbx;
        private TextBox UserPassTbx;
        private TextBox UpdateUsernameTbx;
        private TextBox textBox1;
        private Label label2;
        private TextBox OldPassTbx;
        private CheckBox ShowHidePassCbx;
        private Label labelUsername;
        private Button viewHistoryBtn;
    }
}
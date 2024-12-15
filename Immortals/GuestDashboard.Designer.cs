namespace Immortals
{
    partial class GuestDashboard
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
            playBtn = new Button();
            topupBtn = new Button();
            signoutBtn = new Button();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            UserTopPanel = new Panel();
            submittopupBtn = new Button();
            label7 = new Label();
            usertopupTbx = new TextBox();
            label1 = new Label();
            labelGuest = new Label();
            labelGuestID = new Label();
            UserTopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // playBtn
            // 
            playBtn.BackColor = Color.Transparent;
            playBtn.Cursor = Cursors.Hand;
            playBtn.FlatAppearance.BorderSize = 0;
            playBtn.FlatStyle = FlatStyle.Flat;
            playBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playBtn.ForeColor = Color.White;
            playBtn.Location = new Point(128, 350);
            playBtn.Name = "playBtn";
            playBtn.Size = new Size(223, 50);
            playBtn.TabIndex = 1;
            playBtn.Text = "Play Now";
            playBtn.TextAlign = ContentAlignment.MiddleLeft;
            playBtn.UseVisualStyleBackColor = false;
            playBtn.Click += playBtn_Click;
            // 
            // topupBtn
            // 
            topupBtn.BackColor = Color.Transparent;
            topupBtn.Cursor = Cursors.Hand;
            topupBtn.FlatAppearance.BorderSize = 0;
            topupBtn.FlatStyle = FlatStyle.Flat;
            topupBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            topupBtn.ForeColor = Color.White;
            topupBtn.Location = new Point(128, 431);
            topupBtn.Name = "topupBtn";
            topupBtn.Size = new Size(223, 50);
            topupBtn.TabIndex = 1;
            topupBtn.Text = "Top - up";
            topupBtn.TextAlign = ContentAlignment.MiddleLeft;
            topupBtn.UseVisualStyleBackColor = false;
            topupBtn.Click += topupBtn_Click;
            // 
            // signoutBtn
            // 
            signoutBtn.BackColor = Color.Transparent;
            signoutBtn.Cursor = Cursors.Hand;
            signoutBtn.FlatAppearance.BorderSize = 0;
            signoutBtn.FlatStyle = FlatStyle.Flat;
            signoutBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signoutBtn.ForeColor = Color.White;
            signoutBtn.Location = new Point(128, 511);
            signoutBtn.Name = "signoutBtn";
            signoutBtn.Size = new Size(223, 50);
            signoutBtn.TabIndex = 1;
            signoutBtn.Text = "Sign Out";
            signoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            signoutBtn.UseVisualStyleBackColor = false;
            signoutBtn.Click += signoutBtn_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.Transparent;
            labelTime.FlatStyle = FlatStyle.Flat;
            labelTime.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(113, 709);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(197, 38);
            labelTime.TabIndex = 7;
            labelTime.Text = "00 : 00 : 00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // UserTopPanel
            // 
            UserTopPanel.BackColor = Color.Transparent;
            UserTopPanel.Controls.Add(submittopupBtn);
            UserTopPanel.Controls.Add(label7);
            UserTopPanel.Controls.Add(usertopupTbx);
            UserTopPanel.Controls.Add(label1);
            UserTopPanel.Location = new Point(398, 47);
            UserTopPanel.Name = "UserTopPanel";
            UserTopPanel.Size = new Size(297, 545);
            UserTopPanel.TabIndex = 13;
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
            // labelGuest
            // 
            labelGuest.AutoSize = true;
            labelGuest.BackColor = Color.Transparent;
            labelGuest.FlatStyle = FlatStyle.Flat;
            labelGuest.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGuest.ForeColor = Color.White;
            labelGuest.Location = new Point(115, 236);
            labelGuest.Name = "labelGuest";
            labelGuest.Size = new Size(91, 19);
            labelGuest.TabIndex = 14;
            labelGuest.Text = "GuestUser";
            labelGuest.Click += labelUsername_Click;
            // 
            // labelGuestID
            // 
            labelGuestID.AutoSize = true;
            labelGuestID.BackColor = Color.Transparent;
            labelGuestID.FlatStyle = FlatStyle.Flat;
            labelGuestID.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGuestID.ForeColor = Color.White;
            labelGuestID.Location = new Point(203, 236);
            labelGuestID.Name = "labelGuestID";
            labelGuestID.Size = new Size(58, 19);
            labelGuestID.TabIndex = 15;
            labelGuestID.Text = "label1";
            // 
            // GuestDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.guestDashboard;
            ClientSize = new Size(1370, 749);
            Controls.Add(labelGuestID);
            Controls.Add(labelGuest);
            Controls.Add(UserTopPanel);
            Controls.Add(labelTime);
            Controls.Add(signoutBtn);
            Controls.Add(topupBtn);
            Controls.Add(playBtn);
            Name = "GuestDashboard";
            Text = "GuestDashboard";
            UserTopPanel.ResumeLayout(false);
            UserTopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playBtn;
        private Button topupBtn;
        private Button signoutBtn;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private Panel UserTopPanel;
        private Button submittopupBtn;
        private Label label7;
        private TextBox usertopupTbx;
        private Label label1;
        private Label labelGuest;
        private Label labelGuestID;
    }
}
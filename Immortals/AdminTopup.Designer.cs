namespace Immortals
{
    partial class AdminTopup
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
            pictureBox1 = new PictureBox();
            UserTopPanel = new Panel();
            submittopupBtn = new Button();
            label7 = new Label();
            amountTbx = new TextBox();
            label2 = new Label();
            usertopupTbx = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            UserTopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 512);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UserTopPanel
            // 
            UserTopPanel.BackColor = Color.Transparent;
            UserTopPanel.Controls.Add(submittopupBtn);
            UserTopPanel.Controls.Add(label7);
            UserTopPanel.Controls.Add(amountTbx);
            UserTopPanel.Controls.Add(label2);
            UserTopPanel.Controls.Add(usertopupTbx);
            UserTopPanel.Controls.Add(label1);
            UserTopPanel.Location = new Point(43, 1);
            UserTopPanel.Name = "UserTopPanel";
            UserTopPanel.Size = new Size(282, 505);
            UserTopPanel.TabIndex = 14;
            // 
            // submittopupBtn
            // 
            submittopupBtn.Cursor = Cursors.Hand;
            submittopupBtn.FlatAppearance.BorderSize = 2;
            submittopupBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            submittopupBtn.FlatStyle = FlatStyle.Flat;
            submittopupBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            submittopupBtn.ForeColor = SystemColors.ButtonHighlight;
            submittopupBtn.Location = new Point(69, 330);
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
            label7.Location = new Point(75, 28);
            label7.Name = "label7";
            label7.Size = new Size(133, 39);
            label7.TabIndex = 8;
            label7.Text = "Top-up";
            // 
            // amountTbx
            // 
            amountTbx.BackColor = Color.FromArgb(218, 244, 251);
            amountTbx.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            amountTbx.Location = new Point(26, 234);
            amountTbx.Name = "amountTbx";
            amountTbx.Size = new Size(231, 30);
            amountTbx.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 210);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 8;
            label2.Text = "Enter amount:";
            // 
            // usertopupTbx
            // 
            usertopupTbx.BackColor = Color.FromArgb(218, 244, 251);
            usertopupTbx.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usertopupTbx.Location = new Point(26, 155);
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
            label1.Location = new Point(26, 131);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 8;
            label1.Text = "Enter username:";
            // 
            // AdminTopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login;
            ClientSize = new Size(368, 506);
            Controls.Add(UserTopPanel);
            Controls.Add(pictureBox1);
            Name = "AdminTopup";
            Text = "AdminTopup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            UserTopPanel.ResumeLayout(false);
            UserTopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel UserTopPanel;
        private Button submittopupBtn;
        private Label label7;
        private TextBox amountTbx;
        private Label label2;
        private TextBox usertopupTbx;
        private Label label1;
    }
}
namespace Immortals
{
    partial class RegistrationForm
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
            panel1 = new Panel();
            labelSuccess = new Label();
            labelUserExist = new Label();
            label71 = new Label();
            panel10 = new Panel();
            panel111 = new Panel();
            label5 = new Label();
            panel12 = new Panel();
            panel13 = new Panel();
            button52 = new Button();
            button42 = new Button();
            confirmpasswordTbx = new TextBox();
            label6 = new Label();
            backtologinBtn = new Button();
            registerBtn = new Button();
            panel6 = new Panel();
            panel71 = new Panel();
            label3 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            button51 = new Button();
            button41 = new Button();
            newpasswordTbx = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            panel51 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            newusernameTbx = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            panel111.SuspendLayout();
            panel12.SuspendLayout();
            panel6.SuspendLayout();
            panel71.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel51.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(labelSuccess);
            panel1.Controls.Add(labelUserExist);
            panel1.Controls.Add(label71);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(backtologinBtn);
            panel1.Controls.Add(registerBtn);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(444, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 447);
            panel1.TabIndex = 3;
            // 
            // labelSuccess
            // 
            labelSuccess.AutoSize = true;
            labelSuccess.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSuccess.ForeColor = Color.Lime;
            labelSuccess.Location = new Point(198, 82);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(166, 18);
            labelSuccess.TabIndex = 10;
            labelSuccess.Text = "Registration successful.";
            labelSuccess.Visible = false;
            // 
            // labelUserExist
            // 
            labelUserExist.AutoSize = true;
            labelUserExist.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserExist.ForeColor = Color.Red;
            labelUserExist.Location = new Point(163, 83);
            labelUserExist.Name = "labelUserExist";
            labelUserExist.Size = new Size(313, 18);
            labelUserExist.TabIndex = 9;
            labelUserExist.Text = "Username already exists please try a new one.";
            labelUserExist.Visible = false;
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label71.ForeColor = Color.Red;
            label71.Location = new Point(161, 82);
            label71.Name = "label71";
            label71.Size = new Size(292, 18);
            label71.TabIndex = 8;
            label71.Text = "Password does not match please try again.";
            label71.Visible = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel111);
            panel10.Controls.Add(panel12);
            panel10.Location = new Point(198, 210);
            panel10.Name = "panel10";
            panel10.Size = new Size(230, 53);
            panel10.TabIndex = 7;
            // 
            // panel111
            // 
            panel111.Controls.Add(label5);
            panel111.Dock = DockStyle.Top;
            panel111.Location = new Point(0, 31);
            panel111.Name = "panel111";
            panel111.Size = new Size(230, 17);
            panel111.TabIndex = 3;
            panel111.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 18);
            label5.TabIndex = 4;
            label5.Text = "This field is required.";
            // 
            // panel12
            // 
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(button52);
            panel12.Controls.Add(button42);
            panel12.Controls.Add(confirmpasswordTbx);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(230, 31);
            panel12.TabIndex = 2;
            // 
            // panel13
            // 
            panel13.Location = new Point(11, 95);
            panel13.Name = "panel13";
            panel13.Size = new Size(267, 42);
            panel13.TabIndex = 2;
            // 
            // button52
            // 
            button52.BackColor = Color.White;
            button52.BackgroundImage = Properties.Resources.HideEye1;
            button52.BackgroundImageLayout = ImageLayout.Stretch;
            button52.FlatStyle = FlatStyle.Flat;
            button52.ForeColor = Color.Black;
            button52.Location = new Point(197, 9);
            button52.Name = "button52";
            button52.Size = new Size(25, 20);
            button52.TabIndex = 3;
            button52.UseVisualStyleBackColor = false;
            button52.Click += button52_Click;
            // 
            // button42
            // 
            button42.BackColor = Color.White;
            button42.BackgroundImage = Properties.Resources.ShowEye1;
            button42.BackgroundImageLayout = ImageLayout.Zoom;
            button42.FlatStyle = FlatStyle.Flat;
            button42.ForeColor = Color.Black;
            button42.Location = new Point(197, 9);
            button42.Name = "button42";
            button42.Size = new Size(25, 20);
            button42.TabIndex = 3;
            button42.UseVisualStyleBackColor = false;
            button42.Click += button42_Click;
            // 
            // confirmpasswordTbx
            // 
            confirmpasswordTbx.BackColor = Color.FromArgb(218, 244, 251);
            confirmpasswordTbx.BorderStyle = BorderStyle.None;
            confirmpasswordTbx.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirmpasswordTbx.ForeColor = Color.DimGray;
            confirmpasswordTbx.Location = new Point(3, 10);
            confirmpasswordTbx.Name = "confirmpasswordTbx";
            confirmpasswordTbx.Size = new Size(219, 17);
            confirmpasswordTbx.TabIndex = 1;
            confirmpasswordTbx.Text = "Confirm password";
            confirmpasswordTbx.TextAlign = HorizontalAlignment.Center;
            confirmpasswordTbx.MouseClick += confirmpasswordTbx_MouseClick;
            confirmpasswordTbx.TextChanged += confirmpasswordTbx_TextChanged;
            confirmpasswordTbx.Enter += confirmpasswordTbx_Enter;
            confirmpasswordTbx.Leave += confirmpasswordTbx_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.PaleTurquoise;
            label6.Location = new Point(38, 220);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 6;
            label6.Text = "Confirm Password";
            // 
            // backtologinBtn
            // 
            backtologinBtn.Cursor = Cursors.Hand;
            backtologinBtn.FlatAppearance.BorderSize = 2;
            backtologinBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            backtologinBtn.FlatStyle = FlatStyle.Flat;
            backtologinBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backtologinBtn.ForeColor = SystemColors.ButtonHighlight;
            backtologinBtn.Location = new Point(170, 339);
            backtologinBtn.Name = "backtologinBtn";
            backtologinBtn.Size = new Size(250, 33);
            backtologinBtn.TabIndex = 6;
            backtologinBtn.Text = "Back to Login";
            backtologinBtn.UseVisualStyleBackColor = true;
            backtologinBtn.Click += backtologinBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 2;
            registerBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.ForeColor = SystemColors.ButtonHighlight;
            registerBtn.Location = new Point(170, 296);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(250, 33);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel71);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(198, 151);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 53);
            panel6.TabIndex = 5;
            // 
            // panel71
            // 
            panel71.Controls.Add(label3);
            panel71.Dock = DockStyle.Top;
            panel71.Location = new Point(0, 31);
            panel71.Name = "panel71";
            panel71.Size = new Size(230, 17);
            panel71.TabIndex = 3;
            panel71.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 18);
            label3.TabIndex = 4;
            label3.Text = "This field is required.";
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(button51);
            panel8.Controls.Add(button41);
            panel8.Controls.Add(newpasswordTbx);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(230, 31);
            panel8.TabIndex = 2;
            panel8.Enter += panel8_Enter;
            panel8.Leave += panel8_Leave;
            // 
            // panel9
            // 
            panel9.Location = new Point(11, 95);
            panel9.Name = "panel9";
            panel9.Size = new Size(267, 42);
            panel9.TabIndex = 2;
            // 
            // button51
            // 
            button51.BackColor = Color.White;
            button51.BackgroundImage = Properties.Resources.HideEye1;
            button51.BackgroundImageLayout = ImageLayout.Stretch;
            button51.FlatStyle = FlatStyle.Flat;
            button51.ForeColor = Color.Black;
            button51.Location = new Point(197, 8);
            button51.Name = "button51";
            button51.Size = new Size(25, 20);
            button51.TabIndex = 3;
            button51.UseVisualStyleBackColor = false;
            button51.Click += button51_Click;
            // 
            // button41
            // 
            button41.BackColor = Color.White;
            button41.BackgroundImage = Properties.Resources.ShowEye1;
            button41.BackgroundImageLayout = ImageLayout.Zoom;
            button41.FlatStyle = FlatStyle.Flat;
            button41.ForeColor = Color.Black;
            button41.Location = new Point(197, 9);
            button41.Name = "button41";
            button41.Size = new Size(25, 20);
            button41.TabIndex = 3;
            button41.UseVisualStyleBackColor = false;
            button41.Click += button41_Click;
            // 
            // newpasswordTbx
            // 
            newpasswordTbx.BackColor = Color.FromArgb(218, 244, 251);
            newpasswordTbx.BorderStyle = BorderStyle.None;
            newpasswordTbx.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            newpasswordTbx.ForeColor = Color.DimGray;
            newpasswordTbx.Location = new Point(3, 10);
            newpasswordTbx.Name = "newpasswordTbx";
            newpasswordTbx.Size = new Size(219, 17);
            newpasswordTbx.TabIndex = 1;
            newpasswordTbx.Text = "Enter password";
            newpasswordTbx.TextAlign = HorizontalAlignment.Center;
            newpasswordTbx.MouseClick += newpasswordTbx_MouseClick;
            newpasswordTbx.TextChanged += newpasswordTbx_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.PaleTurquoise;
            label4.Location = new Point(111, 161);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel51);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(201, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 53);
            panel4.TabIndex = 3;
            // 
            // panel51
            // 
            panel51.Controls.Add(label2);
            panel51.Dock = DockStyle.Top;
            panel51.Location = new Point(0, 31);
            panel51.Name = "panel51";
            panel51.Size = new Size(230, 16);
            panel51.TabIndex = 3;
            panel51.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 18);
            label2.TabIndex = 4;
            label2.Text = "This field is required.";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(newusernameTbx);
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
            // newusernameTbx
            // 
            newusernameTbx.BackColor = Color.FromArgb(218, 244, 251);
            newusernameTbx.BorderStyle = BorderStyle.None;
            newusernameTbx.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            newusernameTbx.ForeColor = Color.DimGray;
            newusernameTbx.Location = new Point(0, 5);
            newusernameTbx.Name = "newusernameTbx";
            newusernameTbx.Size = new Size(219, 17);
            newusernameTbx.TabIndex = 1;
            newusernameTbx.Text = "Enter new username";
            newusernameTbx.TextAlign = HorizontalAlignment.Center;
            newusernameTbx.MouseClick += newusernameTbx_MouseClick;
            newusernameTbx.TextChanged += newusernameTbx_TextChanged;
            newusernameTbx.Enter += newusernameTbx_Enter;
            newusernameTbx.Leave += newusernameTbx_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(107, 104);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.RegisterPage;
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1422, 771);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RegisterPage;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel10.ResumeLayout(false);
            panel111.ResumeLayout(false);
            panel111.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel6.ResumeLayout(false);
            panel71.ResumeLayout(false);
            panel71.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel51.ResumeLayout(false);
            panel51.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button backtologinBtn;
        private Button registerBtn;
        private Panel panel6;
        private Panel panel71;
        private Label label3;
        private Panel panel8;
        private Button button51;
        private Button button41;
        private Panel panel9;
        private TextBox newpasswordTbx;
        private Label label4;
        private Panel panel4;
        private Panel panel51;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private TextBox newusernameTbx;
        private Label label1;
        private Panel panel10;
        private Panel panel111;
        private Label label5;
        private Panel panel12;
        private Button button52;
        private Button button42;
        private Panel panel13;
        private TextBox confirmpasswordTbx;
        private Label label6;
        private Label label71;
        private PictureBox pictureBox2;
        private Label labelUserExist;
        private Label labelSuccess;
    }
}
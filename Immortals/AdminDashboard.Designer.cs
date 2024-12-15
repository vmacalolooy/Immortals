namespace Immortals
{
    partial class AdminDashboard
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
            adminsignoutBtn = new Button();
            admintopupBtn = new Button();
            salesreportBtn = new Button();
            analyticsBtn = new Button();
            topuphistoryDgv = new DataGridView();
            searchTbx = new TextBox();
            searchBtn = new Button();
            label7 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)topuphistoryDgv).BeginInit();
            SuspendLayout();
            // 
            // adminsignoutBtn
            // 
            adminsignoutBtn.BackColor = Color.Transparent;
            adminsignoutBtn.Cursor = Cursors.Hand;
            adminsignoutBtn.FlatAppearance.BorderSize = 0;
            adminsignoutBtn.FlatStyle = FlatStyle.Flat;
            adminsignoutBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminsignoutBtn.ForeColor = Color.White;
            adminsignoutBtn.Location = new Point(126, 595);
            adminsignoutBtn.Name = "adminsignoutBtn";
            adminsignoutBtn.Size = new Size(223, 50);
            adminsignoutBtn.TabIndex = 1;
            adminsignoutBtn.Text = "Sign Out";
            adminsignoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            adminsignoutBtn.UseVisualStyleBackColor = false;
            adminsignoutBtn.Click += adminsignoutBtn_Click;
            // 
            // admintopupBtn
            // 
            admintopupBtn.BackColor = Color.Transparent;
            admintopupBtn.Cursor = Cursors.Hand;
            admintopupBtn.FlatAppearance.BorderSize = 0;
            admintopupBtn.FlatStyle = FlatStyle.Flat;
            admintopupBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            admintopupBtn.ForeColor = Color.White;
            admintopupBtn.Location = new Point(126, 358);
            admintopupBtn.Name = "admintopupBtn";
            admintopupBtn.Size = new Size(223, 50);
            admintopupBtn.TabIndex = 2;
            admintopupBtn.Text = "Top - up";
            admintopupBtn.TextAlign = ContentAlignment.MiddleLeft;
            admintopupBtn.UseVisualStyleBackColor = false;
            admintopupBtn.Click += admintopupBtn_Click;
            // 
            // salesreportBtn
            // 
            salesreportBtn.BackColor = Color.Transparent;
            salesreportBtn.Cursor = Cursors.Hand;
            salesreportBtn.FlatAppearance.BorderSize = 0;
            salesreportBtn.FlatStyle = FlatStyle.Flat;
            salesreportBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            salesreportBtn.ForeColor = Color.White;
            salesreportBtn.Location = new Point(126, 437);
            salesreportBtn.Name = "salesreportBtn";
            salesreportBtn.Size = new Size(223, 50);
            salesreportBtn.TabIndex = 2;
            salesreportBtn.Text = "Sales Report";
            salesreportBtn.TextAlign = ContentAlignment.MiddleLeft;
            salesreportBtn.UseVisualStyleBackColor = false;
            salesreportBtn.Click += salesreportBtn_Click;
            // 
            // analyticsBtn
            // 
            analyticsBtn.BackColor = Color.Transparent;
            analyticsBtn.Cursor = Cursors.Hand;
            analyticsBtn.FlatAppearance.BorderSize = 0;
            analyticsBtn.FlatStyle = FlatStyle.Flat;
            analyticsBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            analyticsBtn.ForeColor = Color.White;
            analyticsBtn.Location = new Point(126, 522);
            analyticsBtn.Name = "analyticsBtn";
            analyticsBtn.Size = new Size(223, 50);
            analyticsBtn.TabIndex = 2;
            analyticsBtn.Text = "Analytics";
            analyticsBtn.TextAlign = ContentAlignment.MiddleLeft;
            analyticsBtn.UseVisualStyleBackColor = false;
            analyticsBtn.Click += analyticsBtn_Click;
            // 
            // topuphistoryDgv
            // 
            topuphistoryDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            topuphistoryDgv.Location = new Point(506, 77);
            topuphistoryDgv.Name = "topuphistoryDgv";
            topuphistoryDgv.RowTemplate.Height = 25;
            topuphistoryDgv.Size = new Size(710, 584);
            topuphistoryDgv.TabIndex = 3;
            // 
            // searchTbx
            // 
            searchTbx.BackColor = Color.FromArgb(218, 244, 251);
            searchTbx.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchTbx.Location = new Point(506, 694);
            searchTbx.Name = "searchTbx";
            searchTbx.Size = new Size(247, 30);
            searchTbx.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Transparent;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.FlatAppearance.BorderSize = 2;
            searchBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.ForeColor = SystemColors.ButtonHighlight;
            searchBtn.Location = new Point(1064, 694);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(150, 33);
            searchBtn.TabIndex = 7;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Rockwell", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(727, 21);
            label7.Name = "label7";
            label7.Size = new Size(259, 39);
            label7.TabIndex = 9;
            label7.Text = "Top-up History";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(506, 672);
            label1.Name = "label1";
            label1.Size = new Size(167, 19);
            label1.TabIndex = 10;
            label1.Text = "Search by Username:";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AdminDashboard;
            ClientSize = new Size(1370, 749);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(searchBtn);
            Controls.Add(searchTbx);
            Controls.Add(topuphistoryDgv);
            Controls.Add(analyticsBtn);
            Controls.Add(salesreportBtn);
            Controls.Add(admintopupBtn);
            Controls.Add(adminsignoutBtn);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)topuphistoryDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adminsignoutBtn;
        private Button admintopupBtn;
        private Button salesreportBtn;
        private Button analyticsBtn;
        private DataGridView topuphistoryDgv;
        private TextBox searchTbx;
        private Button searchBtn;
        private Label label7;
        private Label label1;
    }
}
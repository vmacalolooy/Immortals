namespace Immortals
{
    partial class GamesMenu
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
            dotaBtn = new Button();
            valorantBtn = new Button();
            lolBtn = new Button();
            csBtn = new Button();
            forniteBtn = new Button();
            chromeBtn = new Button();
            SuspendLayout();
            // 
            // dotaBtn
            // 
            dotaBtn.BackColor = Color.Transparent;
            dotaBtn.Cursor = Cursors.Hand;
            dotaBtn.FlatAppearance.BorderSize = 0;
            dotaBtn.FlatStyle = FlatStyle.Flat;
            dotaBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dotaBtn.ForeColor = Color.White;
            dotaBtn.Location = new Point(179, 275);
            dotaBtn.Name = "dotaBtn";
            dotaBtn.Size = new Size(89, 92);
            dotaBtn.TabIndex = 1;
            dotaBtn.Text = "Dota 2";
            dotaBtn.TextAlign = ContentAlignment.BottomCenter;
            dotaBtn.UseVisualStyleBackColor = false;
            dotaBtn.Click += dotaBtn_Click;
            // 
            // valorantBtn
            // 
            valorantBtn.BackColor = Color.Transparent;
            valorantBtn.Cursor = Cursors.Hand;
            valorantBtn.FlatAppearance.BorderSize = 0;
            valorantBtn.FlatStyle = FlatStyle.Flat;
            valorantBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            valorantBtn.ForeColor = Color.White;
            valorantBtn.Location = new Point(382, 275);
            valorantBtn.Name = "valorantBtn";
            valorantBtn.Size = new Size(89, 92);
            valorantBtn.TabIndex = 1;
            valorantBtn.Text = "Valorant";
            valorantBtn.TextAlign = ContentAlignment.BottomCenter;
            valorantBtn.UseVisualStyleBackColor = false;
            valorantBtn.Click += valorantBtn_Click;
            // 
            // lolBtn
            // 
            lolBtn.BackColor = Color.Transparent;
            lolBtn.Cursor = Cursors.Hand;
            lolBtn.FlatAppearance.BorderSize = 0;
            lolBtn.FlatStyle = FlatStyle.Flat;
            lolBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lolBtn.ForeColor = Color.White;
            lolBtn.Location = new Point(581, 275);
            lolBtn.Name = "lolBtn";
            lolBtn.Size = new Size(89, 113);
            lolBtn.TabIndex = 1;
            lolBtn.Text = "League of Legends";
            lolBtn.TextAlign = ContentAlignment.BottomCenter;
            lolBtn.UseVisualStyleBackColor = false;
            lolBtn.Click += lolBtn_Click;
            // 
            // csBtn
            // 
            csBtn.BackColor = Color.Transparent;
            csBtn.Cursor = Cursors.Hand;
            csBtn.FlatAppearance.BorderSize = 0;
            csBtn.FlatStyle = FlatStyle.Flat;
            csBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csBtn.ForeColor = Color.White;
            csBtn.Location = new Point(786, 275);
            csBtn.Name = "csBtn";
            csBtn.Size = new Size(89, 92);
            csBtn.TabIndex = 1;
            csBtn.Text = "CS:GO 2";
            csBtn.TextAlign = ContentAlignment.BottomCenter;
            csBtn.UseVisualStyleBackColor = false;
            csBtn.Click += csBtn_Click;
            // 
            // forniteBtn
            // 
            forniteBtn.BackColor = Color.Transparent;
            forniteBtn.Cursor = Cursors.Hand;
            forniteBtn.FlatAppearance.BorderSize = 0;
            forniteBtn.FlatStyle = FlatStyle.Flat;
            forniteBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            forniteBtn.ForeColor = Color.White;
            forniteBtn.Location = new Point(962, 275);
            forniteBtn.Name = "forniteBtn";
            forniteBtn.Size = new Size(89, 92);
            forniteBtn.TabIndex = 1;
            forniteBtn.Text = "Fortnite";
            forniteBtn.TextAlign = ContentAlignment.BottomCenter;
            forniteBtn.UseVisualStyleBackColor = false;
            forniteBtn.Click += forniteBtn_Click;
            // 
            // chromeBtn
            // 
            chromeBtn.BackColor = Color.Transparent;
            chromeBtn.Cursor = Cursors.Hand;
            chromeBtn.FlatAppearance.BorderSize = 0;
            chromeBtn.FlatStyle = FlatStyle.Flat;
            chromeBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chromeBtn.ForeColor = Color.White;
            chromeBtn.Location = new Point(179, 464);
            chromeBtn.Name = "chromeBtn";
            chromeBtn.Size = new Size(89, 111);
            chromeBtn.TabIndex = 1;
            chromeBtn.Text = "Google Chrome";
            chromeBtn.TextAlign = ContentAlignment.BottomCenter;
            chromeBtn.UseVisualStyleBackColor = false;
            chromeBtn.Click += chromeBtn_Click;
            // 
            // GamesMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GameScreen;
            ClientSize = new Size(1484, 811);
            Controls.Add(chromeBtn);
            Controls.Add(forniteBtn);
            Controls.Add(csBtn);
            Controls.Add(lolBtn);
            Controls.Add(valorantBtn);
            Controls.Add(dotaBtn);
            Name = "GamesMenu";
            Text = "GamesMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button dotaBtn;
        private Button valorantBtn;
        private Button lolBtn;
        private Button csBtn;
        private Button forniteBtn;
        private Button chromeBtn;
    }
}
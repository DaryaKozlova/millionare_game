namespace MillionareGame
{
    partial class Form1
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
            this.startGameButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.hello_label = new System.Windows.Forms.Label();
            this.playerGames = new System.Windows.Forms.ListView();
            this.AnsweredQuestions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.BackgroundImage = global::MillionareGame.Properties.Resources.btm1;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startGameButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.Color.SeaShell;
            this.startGameButton.Location = new System.Drawing.Point(942, 39);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(7);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(351, 79);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "START GAME";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.BackgroundImage = global::MillionareGame.Properties.Resources.btm1;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrationButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.registrationButton.ForeColor = System.Drawing.Color.SeaShell;
            this.registrationButton.Location = new System.Drawing.Point(942, 132);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(7);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(351, 84);
            this.registrationButton.TabIndex = 1;
            this.registrationButton.Text = "REGISTRATION";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImage = global::MillionareGame.Properties.Resources.btm1;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginButton.ForeColor = System.Drawing.Color.SeaShell;
            this.loginButton.Location = new System.Drawing.Point(942, 230);
            this.loginButton.Margin = new System.Windows.Forms.Padding(7);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(351, 80);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.Location = new System.Drawing.Point(51, 39);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(0, 39);
            this.hello_label.TabIndex = 3;
            // 
            // playerGames
            // 
            this.playerGames.BackgroundImage = global::MillionareGame.Properties.Resources.LHc0RaYGI3U1;
            this.playerGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AnsweredQuestions,
            this.TotalScore});
            this.playerGames.Location = new System.Drawing.Point(12, 12);
            this.playerGames.Name = "playerGames";
            this.playerGames.Size = new System.Drawing.Size(385, 726);
            this.playerGames.TabIndex = 4;
            this.playerGames.UseCompatibleStateImageBehavior = false;
            this.playerGames.Visible = false;
            // 
            // AnsweredQuestions
            // 
            this.AnsweredQuestions.Text = "Answered questions";
            this.AnsweredQuestions.Width = 200;
            // 
            // TotalScore
            // 
            this.TotalScore.Text = "Total score";
            this.TotalScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalScore.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MillionareGame.Properties.Resources.mainMenuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 750);
            this.Controls.Add(this.playerGames);
            this.Controls.Add(this.hello_label);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.startGameButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label hello_label;
        private System.Windows.Forms.ListView playerGames;
        private System.Windows.Forms.ColumnHeader AnsweredQuestions;
        private System.Windows.Forms.ColumnHeader TotalScore;
    }
}


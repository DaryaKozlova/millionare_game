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
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(468, 416);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(7);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(367, 97);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "Start game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(892, 114);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(7);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(377, 84);
            this.registrationButton.TabIndex = 1;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(892, 16);
            this.loginButton.Margin = new System.Windows.Forms.Padding(7);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(377, 84);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MillionareGame.Properties.Resources.mainMenuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 750);
            this.Controls.Add(this.hello_label);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.startGameButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label hello_label;
    }
}


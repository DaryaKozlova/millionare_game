namespace MillionareGame.Forms
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.passwordLable = new System.Windows.Forms.Label();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.8F);
            this.nicknameLabel.Location = new System.Drawing.Point(29, 89);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(186, 28);
            this.nicknameLabel.TabIndex = 1;
            this.nicknameLabel.Text = "Имя пользователя:";
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Font = new System.Drawing.Font("Yu Gothic UI", 11.8F);
            this.passwordLable.Location = new System.Drawing.Point(130, 132);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(85, 28);
            this.passwordLable.TabIndex = 0;
            this.passwordLable.Text = "Пароль:";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameTextBox.Location = new System.Drawing.Point(221, 89);
            this.nicknameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nicknameTextBox.MaxLength = 32;
            this.nicknameTextBox.Multiline = true;
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(167, 34);
            this.nicknameTextBox.TabIndex = 1;
            this.nicknameTextBox.Text = "Dasha";
            this.nicknameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nicknameTextBox_KeyPress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(221, 132);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.MaxLength = 64;
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(167, 34);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "123";
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logButton.BackgroundImage = global::MillionareGame.Properties.Resources.btm1;
            this.logButton.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.ForeColor = System.Drawing.Color.SeaShell;
            this.logButton.Location = new System.Drawing.Point(137, 204);
            this.logButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(195, 46);
            this.logButton.TabIndex = 1;
            this.logButton.Text = "Войти";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 1000;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(475, 318);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.passwordLable);
            this.Controls.Add(this.nicknameLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
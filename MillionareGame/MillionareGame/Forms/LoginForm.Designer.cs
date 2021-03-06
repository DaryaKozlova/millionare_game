﻿namespace MillionareGame.Forms
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
            this.nicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameLabel.Location = new System.Drawing.Point(35, 34);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(70, 17);
            this.nicknameLabel.TabIndex = 1;
            this.nicknameLabel.Text = "Nickname";
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLable.Location = new System.Drawing.Point(35, 107);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(69, 17);
            this.passwordLable.TabIndex = 0;
            this.passwordLable.Text = "Password";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameTextBox.Location = new System.Drawing.Point(111, 34);
            this.nicknameTextBox.MaxLength = 32;
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(228, 22);
            this.nicknameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(111, 107);
            this.passwordTextBox.MaxLength = 64;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(228, 22);
            this.passwordTextBox.TabIndex = 2;
            // 
            // logButton
            // 
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.Location = new System.Drawing.Point(38, 162);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(301, 34);
            this.logButton.TabIndex = 3;
            this.logButton.Text = "Log in";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            this.logButton.Validating += new System.ComponentModel.CancelEventHandler(this.logButton_Validating);
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
            this.ClientSize = new System.Drawing.Size(383, 247);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.passwordLable);
            this.Controls.Add(this.nicknameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
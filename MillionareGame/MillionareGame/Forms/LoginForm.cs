using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MillionareGame.DataAccess.Models;
using MillionareGame.DataAccess.Repositories;
using MillionareGame.Services;

namespace MillionareGame.Forms
{
    public partial class LoginForm : Form
    {
        private UserService _userService = new UserService();
        private bool _inputsValidated = false;
        public Player Player;

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            ValidateInputs();

            if (_inputsValidated)
            {
                var nickname = nicknameTextBox.Text;
                var password = passwordTextBox.Text;

                var player = _userService.LoginPlayer(nickname, password);

                if (player != null)
                {
                    if (this.Owner is MainForm mainMenu)
                    {
                        mainMenu.Player = player;
                    }

                    Close();
                }
                else
                {
                    MessageBox.Show($@"Игрока с такими данными не существует.");
                }
            }
        }

        private void ValidateInputs()
        {
            if (!string.IsNullOrWhiteSpace(nicknameTextBox.Text)) errorProvider.SetError(nicknameTextBox, null);
            else errorProvider.SetError(nicknameTextBox, "Введите ваше имя пользователя.");

            if (!string.IsNullOrWhiteSpace(passwordTextBox.Text)) errorProvider.SetError(passwordTextBox, null);
            else errorProvider.SetError(passwordTextBox, "Введите ваш пароль.");

            if (!string.IsNullOrWhiteSpace(nicknameTextBox.Text) && !string.IsNullOrWhiteSpace(passwordTextBox.Text))
                _inputsValidated = true;
            else _inputsValidated = false;
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckValidSymbols(e);
        }

        private void nicknameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckValidSymbols(e);
        }

        private bool CheckValidSymbols(KeyPressEventArgs e)
        {
            return e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Enter;
        }
    }
}

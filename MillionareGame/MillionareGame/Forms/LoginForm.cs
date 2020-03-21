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
        public Player Player;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            var nickname = nicknameTextBox.Text;
            var password = passwordTextBox.Text;

            var player = _userService.LoginPlayer(nickname, password);

            if (player != null)
            {
                if (this.Owner is Form1 mainMenu)
                {
                    mainMenu.Player = player;
                }

                Close();
            }
            else
            {
                MessageBox.Show($"Игрока с такими данными не существует.");
            }
        }

        private void logButton_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nicknameTextBox.Text) && !string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                errorProvider.SetError(nicknameTextBox, null);
                errorProvider.SetError(passwordTextBox, null);
            }
            else
            {
                e.Cancel = true;

                errorProvider.SetError(passwordTextBox, "Введите ваш пароль.");
                errorProvider.SetError(nicknameTextBox, "Введите ваше имя пользователя.");
            }
        }
    }
}

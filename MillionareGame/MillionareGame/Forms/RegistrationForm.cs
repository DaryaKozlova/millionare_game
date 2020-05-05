using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MillionareGame.Services;

namespace MillionareGame.Forms
{
    public partial class RegistrationForm : Form
    {
        UserService _userService = new UserService();

        public RegistrationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var nickname = nicknameTextBox.Text;
                var password = passwordTextBox.Text;

                var newPlayer = _userService.RegisterUser(nickname, password);

                if (newPlayer != null)
                {
                    var messageBoxResult = MessageBox.Show($@"{newPlayer.Nickname}, вы успешно зарегистрированы!");

                    if (messageBoxResult == DialogResult.OK) Close();
                }
                else
                {
                    MessageBox.Show($@"Игрок с таким именем уже зарегистрирован!");
                }
            }
        }

        private void registerButton_Validating(object sender, CancelEventArgs e)
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

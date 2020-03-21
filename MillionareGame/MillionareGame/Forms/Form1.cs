using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MillionareGame.DataAccess.Models;
using MillionareGame.Forms;
using MillionareGame.Services;
using WMPLib;

namespace MillionareGame
{
    public partial class Form1 : Form
    {
        private GameService _gameService = new GameService();
        private UserService _userService = new UserService();
        public Player _player;

        public static string _soundPath = System.IO.Path.GetFullPath("../../sounds/");
        public WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();

            musicPlayer.URL = musicPlayer.URL = _soundPath + "mainTheme.mp3";
            musicPlayer.controls.play();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            var game = _gameService.StartGame();

            var gameForm = new GameForm(game, musicPlayer, _soundPath);
            musicPlayer.controls.stop();
            gameForm.ShowDialog();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm
            {
                Owner = this
            };

            loginForm.FormClosed += CheckIfPlayerLogged;

            loginForm.ShowDialog();
        }

        private void CheckIfPlayerLogged(object sender, EventArgs e)
        {
            if (_player != null)
            {
                loginButton.Hide();
                registrationButton.Hide();
            }
        }
    }
}

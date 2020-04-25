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
        private readonly GameService _gameService = new GameService();
        private UserService _userService = new UserService();
        public Player Player;

        public Form1()
        {
            InitializeComponent();

            MusicService.StartMusic("mainTheme");
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            var game = _gameService.StartGame();

            var gameForm = new GameForm(game, Player);
            MusicService.StopMusic();
            Hide();
            gameForm.ShowDialog();
            Show();
            MusicService.StartMusic("mainTheme");
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
            if (Player != null)
            {
                loginButton.Hide();
                registrationButton.Hide();
                var games = _gameService.GetPlayerGames(Player.Id);
                games.ForEach(delegate(Game game)
                    {
                        playerGames.Items.Add(new ListViewGame
                        {
                            AnsweredQuestions = game.AnsweredQuestionsCount.ToString(),
                            TotalScore = game.TotalScore.ToString()
                        });
                    });
                playerGames.Show();

                hello_label.Text = $"Привет, {Player.Nickname}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private class ListViewGame : ListViewItem
        {
            public string AnsweredQuestions { get; set; }
            public string TotalScore { get; set; }
        }
    }
}

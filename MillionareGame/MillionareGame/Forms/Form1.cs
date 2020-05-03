using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.hello_label.BackColor = System.Drawing.Color.Transparent;

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            var game = _gameService.StartGame();

            var gameForm = new GameForm(game, Player);

            MusicService.StopMusic();
            Hide();

            gameForm.ShowDialog();

            if (Player != null) RefreshScoreTable();
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

                RefreshScoreTable();

                playerGames.Show();
                logoutButton.Show();

                
                hello_label.Text = $"HELLO, {Player.Nickname}";
            }

            if (Player == null)
            {
                loginButton.Show();
                registrationButton.Show();

                playerGames.Hide();
                logoutButton.Hide();
                hello_label.Text = "";
            }
        }

        private void RefreshScoreTable()
        {
            var games = _gameService.GetPlayerGames(Player.Id);

            playerGames.Items.Clear();
            games.OrderByDescending(game => game.DateTime).ToList().ForEach(delegate (Game game)
            {
                var values = new[] { game.DateTime.ToLongDateString(), game.AnsweredQuestionsCount.ToString(), game.TotalScore.ToString() };
                playerGames.Items.Add(new ListViewItem(values));
            });
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Player = null;
            CheckIfPlayerLogged(sender, e);
        }

        private void playerGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

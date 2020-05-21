using System;
using System.Linq;
using System.Windows.Forms;
using MillionareGame.DataAccess.Models;
using MillionareGame.Services;

namespace MillionareGame.Forms
{
    public partial class MainForm : Form
    {
        private readonly GameService _gameService = new GameService();
        private UserService _userService = new UserService();
        public Player Player;
        public bool DisableMusic = false;

        public MainForm()
        {
            InitializeComponent();

            PlayMusic(MusicService.Sounds.MainTheme);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.hello_label.BackColor = System.Drawing.Color.Transparent;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            var game = _gameService.StartGame();
            
            MusicService.StopMusic();
            Hide();

            var gameForm = new GameForm(game, Player, DisableMusic) {Owner = this}; 

            gameForm.ShowDialog();

            SoundCheck();

            if (Player != null) RefreshScoreTable();
            Show();

            PlayMusic(MusicService.Sounds.MainTheme);
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

            loginForm.ShowDialog();
            CheckIfPlayerLogged();
        }

        private void PlayMusic(MusicService.Sounds sound)
        {
            MusicService.SetMusic(sound);
            if (!DisableMusic) MusicService.PlayMusic();
            else MusicService.StopMusic();
        }

        private void CheckIfPlayerLogged()
        {
            if (Player != null)
            {
                loginButton.Hide();
                registrationButton.Hide();

                RefreshScoreTable();

                playerGames.Show();
                logoutButton.Show();

                
                hello_label.Text = $"Привет, {Player.Nickname}";
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
            CheckIfPlayerLogged();
        }

        private void SoundCheck()
        {
            if (DisableMusic)
            {
                musicButton.BackgroundImage = Properties.Resources.disabledSound;
                MusicService.StopMusic();

            }
            else
            {
                musicButton.BackgroundImage = Properties.Resources.activeSound;
                MusicService.PlayMusic();
            }
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            if (DisableMusic)
            {
                DisableMusic = false;
                musicButton.BackgroundImage = Properties.Resources.activeSound;
                MusicService.PlayMusic();
            }
            else
            {
                DisableMusic = true;
                musicButton.BackgroundImage = Properties.Resources.disabledSound;
                MusicService.StopMusic();
            }
        }
    }
}

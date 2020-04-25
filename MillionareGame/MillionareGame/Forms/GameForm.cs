using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MillionareGame.DataAccess.Models;
using MillionareGame.Services;

namespace MillionareGame.Forms
{
    public partial class GameForm : Form
    {
        private Game _game;
        private Player _player;
        private readonly GameService _gameService = new GameService();
        private int _currentQuestion;

        private int[] winnings =
        {
            0, 500, 1000, 3000, 5000, 10000, 15000, 25000, 50000, 100000, 200000, 400000, 800000, 1500000, 3000000
        };

        public GameForm(Game game, Player player)
        {
            InitializeComponent();

            StartGame(game, player);
        }

        public void StartGame(Game game, Player player)
        {
            _game = game;
            _player = player;
            _currentQuestion = game.AnsweredQuestionsCount;

            winningsLabel.Text = $@"Текущий выигрыш: {winnings[_currentQuestion]}$";
            LoadQuestion(_currentQuestion);
        }

        public void StopGame()
        {
            MusicService.StopMusic();
            if (_player != null)
            {
                _game.TotalScore = winnings[_currentQuestion];
                _game.AnsweredQuestionsCount = _currentQuestion;
                _game.UserId = _player.Id;

                _gameService.SaveResult(_player, _game);
            }

            Close();
        }

        public void LoadQuestion(int questionNumber)
        {
            var question = _game.Questions[questionNumber];
            questionLabel.Text = question.QuestionText;

            buttonAnswerA.Text = question.Variants[0].Text;
            buttonAnswerB.Text = question.Variants[1].Text;
            buttonAnswerC.Text = question.Variants[2].Text;
            buttonAnswerD.Text = question.Variants[3].Text;

            buttonAnswerA.BackColor = default;
            buttonAnswerB.BackColor = default;
            buttonAnswerC.BackColor = default;
            buttonAnswerD.BackColor = default;

            buttonAnswerA.Enabled = true;
            buttonAnswerB.Enabled = true;
            buttonAnswerC.Enabled = true;
            buttonAnswerD.Enabled = true;

            MusicService.StartMusic("questionThreeMusic");
        }

        private async void ShowRightAnswer(string clickedButton)
        {
            MusicService.StartMusic("buttonWaitAnswer");

            buttonAnswerA.Enabled = false;
            buttonAnswerB.Enabled = false;
            buttonAnswerC.Enabled = false;
            buttonAnswerD.Enabled = false;

            await Task.Delay(4000);
         
            var question = _game.Questions[_currentQuestion];

            MusicService.StartMusic(question.AnswerId == clickedButton ? "correctAnswer" : "wrongAnswer");

            switch (question.AnswerId)
            {
                case "1":
                {
                    buttonAnswerA.BackColor = Color.LawnGreen;
                    break;
                }
                case "2":
                {
                    buttonAnswerB.BackColor = Color.LawnGreen;
                    break;
                }
                case "3":
                {
                    buttonAnswerC.BackColor = Color.LawnGreen;
                    break;
                }
                case "4":
                {
                    buttonAnswerD.BackColor = Color.LawnGreen;
                    break;
                }
            }

            await Task.Delay(4000);

            if (question.AnswerId == clickedButton)
            {
                ++_currentQuestion;

                if (_currentQuestion == _game.Questions.Count)
                {
                    var messageBox = MessageBox.Show($@"Вы выиграли {winnings[_currentQuestion]} рублей!");
                    if (messageBox == DialogResult.OK)
                    {
                        StopGame();
                    }
                }
                else
                {
                    winningsLabel.Text = $@"Текущий выигрыш: {winnings[_currentQuestion]}$";
                    LoadQuestion(_currentQuestion);
                }
            }
            else
            {
                var messageBox = MessageBox.Show($@"Вы выиграли {winnings[_currentQuestion]} рублей!");

                if (messageBox == DialogResult.OK)
                {
                    StopGame();
                }
            }
        }

        private async void buttonAnswerA_Click(object sender, EventArgs e)
        {
            buttonAnswerA.BackColor = Color.Moccasin;

            ShowRightAnswer("1");
        }
        private async void buttonAnswerB_Click(object sender, EventArgs e)
        {
            buttonAnswerB.BackColor = Color.Moccasin;

            ShowRightAnswer("2");
        }
        private async void buttonAnswerC_Click(object sender, EventArgs e)
        {
            buttonAnswerC.BackColor = Color.Moccasin;

            ShowRightAnswer("3");
        }
        private async void buttonAnswerD_Click(object sender, EventArgs e)
        {
            buttonAnswerD.BackColor = Color.Moccasin;

            ShowRightAnswer("4");
        }

    }
}

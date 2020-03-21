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
        private int _currentQuestion;

        public GameForm(Game game)
        {
            InitializeComponent();

            StartGame(game);
        }

        public void StartGame(Game game)
        {
            _game = game;
            _currentQuestion = game.AnsweredQuestionsCount;

            LoadQuestion(_currentQuestion);
        }

        public void StopGame()
        {
            MusicService.StopMusic();
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

            MusicService.StartMusic("questionThreeMusic");
        }

        private async void ShowRightAnswer(string clickedButton)
        {
            MusicService.StartMusic("buttonWaitAnswer");

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
                LoadQuestion(++_currentQuestion);
            }
            else
            {
                StopGame();
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

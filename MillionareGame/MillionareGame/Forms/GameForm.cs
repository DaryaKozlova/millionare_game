using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MillionareGame.DataAccess.Models;
using WMPLib;
using Timer = System.Threading.Timer;

namespace MillionareGame.Forms
{
    public partial class GameForm : Form
    {
        private string _musicPath;
        private WindowsMediaPlayer _musicPlayer;
        private List<Question> _questions;
        private int _currentQuestion;

        public GameForm(Game game, WindowsMediaPlayer musicPlayer, string musicPath)
        {
            InitializeComponent();

            _musicPlayer = musicPlayer;
            _musicPath = musicPath;

            StartGame(game);
        }

        public void StartGame(Game game)
        {
            _questions = game.Questions;
            _currentQuestion = game.AnsweredQuestionsCount;

            LoadQuestion(_currentQuestion);
        }

        public void LoadQuestion(int questionNumber)
        {
            var question = _questions[questionNumber];
            questionLabel.Text = question.QuestionText;

            buttonAnswerA.Text = question.Variants[0].Text;
            buttonAnswerB.Text = question.Variants[1].Text;
            buttonAnswerC.Text = question.Variants[2].Text;
            buttonAnswerD.Text = question.Variants[3].Text;

            _musicPlayer.URL = _musicPath + "questionThreeMusic.mp3";
            _musicPlayer.controls.play();
        }

        private async void ShowRightAnswer(string clickedButton)
        {
            var question = _questions[_currentQuestion];
            
            switch (question.AnswerId)
            {
                case "1":
                    buttonAnswerA.BackColor = Color.LawnGreen;

                    if (clickedButton == "1")
                    {
                        _musicPlayer.URL = _musicPath + "correctAnswer.mp3";
                    }
                    else
                    {
                        _musicPlayer.URL = _musicPath + "wrongAnswer.mp3";
                    }
                    break;
                case "2":
                    buttonAnswerB.BackColor = Color.LawnGreen;
                    if (clickedButton == "2")
                    {
                        _musicPlayer.URL = _musicPath + "correctAnswer.mp3";
                    }
                    else
                    {
                        _musicPlayer.URL = _musicPath + "wrongAnswer.mp3";
                    }
                    break;
                case "3":
                    buttonAnswerC.BackColor = Color.LawnGreen;
                    if (clickedButton == "3")
                    {
                        _musicPlayer.URL = _musicPath + "correctAnswer.mp3";
                    }
                    else
                    {
                        _musicPlayer.URL = _musicPath + "wrongAnswer.mp3";
                    }
                    break;
                case "4":
                    buttonAnswerD.BackColor = Color.LawnGreen;
                    if (clickedButton == "4")
                    {
                        _musicPlayer.URL = _musicPath + "correctAnswer.mp3";
                    }
                    else
                    {
                        _musicPlayer.URL = _musicPath + "wrongAnswer.mp3";
                    }
                    break;
                default:
                    break;
            }

            _musicPlayer.controls.play();

            await Task.Delay(4000);

            LoadQuestion(++_currentQuestion);

        }

        private async void buttonAnswerA_Click(object sender, EventArgs e)
        {
            buttonAnswerA.BackColor = Color.Moccasin;
            _musicPlayer.URL = _musicPath + "buttonWaitAnswer.mp3";
            _musicPlayer.controls.play();

            await Task.Delay(4000);

            ShowRightAnswer("1");
        }
        private async void buttonAnswerB_Click(object sender, EventArgs e)
        {
            buttonAnswerB.BackColor = Color.Moccasin;
            _musicPlayer.URL = _musicPath + "buttonWaitAnswer.mp3";
            _musicPlayer.controls.play();

            var question = _questions[_currentQuestion];

            await Task.Delay(4000);

            ShowRightAnswer("2");
        }
        private async void buttonAnswerC_Click(object sender, EventArgs e)
        {
            buttonAnswerC.BackColor = Color.Moccasin;
            _musicPlayer.URL = _musicPath + "buttonWaitAnswer.mp3";
            _musicPlayer.controls.play();


            var question = _questions[_currentQuestion];

            await Task.Delay(4000);

            ShowRightAnswer("3");
        }
        private async void buttonAnswerD_Click(object sender, EventArgs e)
        {
            buttonAnswerD.BackColor = Color.Moccasin;
            _musicPlayer.URL = _musicPath + "buttonWaitAnswer.mp3";
            _musicPlayer.controls.play();


            var question = _questions[_currentQuestion];

            await Task.Delay(4000);

            ShowRightAnswer("4");
        }
    }
}

using System;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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
        private Timer timer = new Timer();

        private int _roundTime;
        private static int GameTime = 30;
        private static int timerInterval = 1000;
        private bool fiftyUsed = false;
        private bool manUsed = false;
        private bool callUsed = false;
        private bool isClosingEvent = false;
        private bool DisableMusic = false;

        private string[] _names = {
            "Кирилл", "Лёха", "Саня", "Паша", "Димон", "Ярик", "Гришаня", "Тоха", "Петя", "Мишаня", "Игорь", "Никитос",
            "Женя", "Славик", "Андрюха", "Владос"
        };

        private int[] winnings =
        {
            0, 500, 1000, 3000, 5000, 10000, 15000, 25000, 50000, 100000, 200000, 400000, 800000, 1500000, 3000000
        };

        public GameForm(Game game, Player player, bool disableMusic)
        {
            InitializeComponent();

            this.DisableMusic = disableMusic;
            SoundCheck();

            StartGame(game, player);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.winningsLabel.BackColor = System.Drawing.Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.Owner is MainForm mainMenu)
            {
                mainMenu.DisableMusic = this.DisableMusic;
            }

            if (!isClosingEvent)
            {
                isClosingEvent = true;
                EndGameEvent();
            }
        }

        public void StartGame(Game game, Player player)
        {
            _game = game;
            _player = player;
            _currentQuestion = game.AnsweredQuestionsCount;
            timer.Tick += timer_Tick;
            timer.Interval = timerInterval;

            winningsLabel.Text = $@"Текущий выигрыш: {winnings[_currentQuestion]}р.";
            LoadQuestion(_currentQuestion);
        }

        public void StopGame()
        {
            MusicService.StopMusic();
            timer.Dispose();
            
            if (_player != null)
            {
                _game.TotalScore = winnings[_currentQuestion];
                _game.AnsweredQuestionsCount = _currentQuestion;
                _game.UserId = _player.Id;

                _gameService.SaveResult(_player, _game);
            }

            if (!isClosingEvent)
            {
                isClosingEvent = true;

                Close();
            }
        }

        public void LoadQuestion(int questionNumber)
        {
            var question = _game.Questions[questionNumber];
            questionLabel.Text = question.QuestionText;

            buttonAnswerA.Text = "A: " + question.Variants[0].Text;
            buttonAnswerB.Text = "Б: " + question.Variants[1].Text;
            buttonAnswerC.Text = "В: " + question.Variants[2].Text;
            buttonAnswerD.Text = "Г: " + question.Variants[3].Text;

            buttonAnswerA.BackColor = default;
            buttonAnswerB.BackColor = default;
            buttonAnswerC.BackColor = default;
            buttonAnswerD.BackColor = default;

            buttonAnswerA.Enabled = true;
            buttonAnswerB.Enabled = true;
            buttonAnswerC.Enabled = true;
            buttonAnswerD.Enabled = true;

            buttonAnswerA.Visible = true;
            buttonAnswerB.Visible = true;
            buttonAnswerC.Visible = true;
            buttonAnswerD.Visible = true;

            if (!fiftyUsed) fiftyButton.Enabled = true;
            if (!manUsed) manButton.Enabled = true;
            if (!callUsed) callButton.Enabled = true;

            PlayMusic(MusicService.Sounds.QuestionThreeMusic);

            _roundTime = GameTime;
            SetTimerLabelSeconds(_roundTime);
            timer.Start();
        }

        private async void ShowRightAnswer(string clickedButton)
        {
            timer.Stop();
            PlayMusic(MusicService.Sounds.ButtonWaitAnswer);

            buttonAnswerA.Enabled = false;
            buttonAnswerB.Enabled = false;
            buttonAnswerC.Enabled = false;
            buttonAnswerD.Enabled = false;

            fiftyButton.Enabled = false;
            manButton.Enabled = false;
            callButton.Enabled = false;

            await Task.Delay(4000);
         
            var question = _game.Questions[_currentQuestion];

            PlayMusic(question.AnswerId == clickedButton ? MusicService.Sounds.CorrectAnswer : MusicService.Sounds.WrongAnswer);

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

            this.Enabled = true;
            if (question.AnswerId == clickedButton)
            {
                ++_currentQuestion;
                CheckGameEnd();
            }
            else
            {
                EndGameEvent();
            }
        }

        private void PlayMusic(MusicService.Sounds sound)
        {
            MusicService.SetMusic(sound);
            if (!DisableMusic) MusicService.PlayMusic();
            else MusicService.StopMusic();
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

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_roundTime == 0)
            {
                timer.Stop();
                CheckGameEnd();
            }
            else
            {
                _roundTime--;
                SetTimerLabelSeconds(_roundTime);
            }
        }

        private void SetTimerLabelSeconds(int seconds)
        {
            timerLabel.Text = "Оставшееся время: " + seconds + " секунд";
        }

        private void CheckGameEnd()
        {
            if (!isClosingEvent)
            {
                if (_roundTime == 0)
                {
                    EndGameEvent();
                }
                else
                {
                    if (_currentQuestion == _game.Questions.Count)
                    {
                        EndGameEvent();
                    }
                    else
                    {
                        winningsLabel.Text = $@"Текущий выигрыш: {winnings[_currentQuestion]}р.";
                        LoadQuestion(_currentQuestion);
                    }
                }
            }
        }

        private void EndGameEvent()
        {
            timer.Stop();

            if (_roundTime == 0)
            {
                var messageBox =
                    MessageBox.Show($@"Время на ответ закончилось. Вы выиграли {winnings[_currentQuestion]} рублей!");
                if (messageBox == DialogResult.OK)
                {
                    StopGame();
                }
            }
            else
            {
                if (_game.Questions.Count==_currentQuestion)
                {
                    var messageBox = MessageBox.Show($@"Поздравдяем! Вы выиграли {winnings[_currentQuestion-1]} рублей!");

                    if (messageBox == DialogResult.OK)
                    {
                        StopGame();
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

        }

        private void fiftyButton_Click(object sender, EventArgs e)
        {
            var question = _game.Questions[_currentQuestion];

            var firstSuggestion = int.Parse(question.AnswerId);

            var random = new Random();
            var secondSuggestion = random.Next(1,4);

            while (secondSuggestion == firstSuggestion)
            {
                secondSuggestion = random.Next(1, 4);
            }

            var suggestions = new[] { firstSuggestion, secondSuggestion };

            if (!suggestions.Contains(1))
            {
                buttonAnswerA.Visible = false;
            }
            if (!suggestions.Contains(2))
            {
                buttonAnswerB.Visible = false;
            }
            if (!suggestions.Contains(3))
            {
                buttonAnswerC.Visible = false;
            }
            if (!suggestions.Contains(4))
            {
                buttonAnswerD.Visible = false;
            }

            this.fiftyButton.Enabled = false;
            fiftyUsed = true;
        }

        private void manButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            
            var leastPercents = 100;
            
            var randomRightAnswerPercent = random.Next(51, 75);
            leastPercents -= randomRightAnswerPercent;

            var randomWrongPercent = leastPercents;

            string aButtonPercents ="", bButtonPercents ="", cButtonPercents ="", dButtonPercents ="";

            var question = _game.Questions[_currentQuestion];

            if (question.AnswerId == "1")
            {
                aButtonPercents = randomRightAnswerPercent.ToString();
            }
            else
            {
                randomWrongPercent = random.Next(0, leastPercents);
                aButtonPercents = randomWrongPercent.ToString();
                leastPercents -= randomWrongPercent;
            }
            if (question.AnswerId == "2")
            {
                bButtonPercents = randomRightAnswerPercent.ToString();
            }
            else
            {
                randomWrongPercent = random.Next(0, leastPercents);
                bButtonPercents = randomWrongPercent.ToString();
                leastPercents -= randomWrongPercent;
            }
            if (question.AnswerId == "3")
            {
                cButtonPercents = randomRightAnswerPercent.ToString();
            }
            else
            {
                if (question.AnswerId == "4")
                {
                    cButtonPercents = leastPercents.ToString();
                }
                else
                {
                    randomWrongPercent = random.Next(0, leastPercents);
                    cButtonPercents = randomWrongPercent.ToString();
                    leastPercents -= randomWrongPercent;
                }
            }

            if (question.AnswerId == "4")
            {
                dButtonPercents = randomRightAnswerPercent.ToString();
            }
            else
            {
                dButtonPercents = leastPercents.ToString();
            }

            MessageBox.Show($"Ответы зала: \r\n A: {aButtonPercents}% \r\n Б: {bButtonPercents}% \r\n В: {cButtonPercents}% \r\n Г: {dButtonPercents}%");

            this.manButton.Enabled = false;
            manUsed = true;
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var randomSuggestion = random.Next(1, 4);

            var answer = "";
            var randomName = _names[random.Next(0, _names.Length)];

            switch (randomSuggestion)
            {
                case 1:
                    answer = "A";
                    break;
                case 2:
                    answer = "Б";
                    break;
                case 3:
                    answer = "В";
                    break;
                case 4:
                    answer = "Г";
                    break;
            }

            MessageBox.Show($@"{randomName} сказал, что правильный ответ: {answer}");
            this.callButton.Enabled = false;
            callUsed = true;
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

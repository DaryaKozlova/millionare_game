using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MillionareGame.DataAccess.Models;
using MillionareGame.DataAccess.Repositories;

namespace MillionareGame.Services
{
    public class GameService
    {
        private QuestionsRepository _questionsRepository = new QuestionsRepository();

        public Game StartGame()
        {
            var questions = _questionsRepository.GetGameQuestions();

            var game = new Game
            {
                Id = Guid.NewGuid().ToString(),
                DateTime = DateTime.Now,
                Questions = questions,
                AnsweredQuestionsCount = 0,
            };

            // запись игры в файл рЕШИТЬ ЧТО ДЕЛАТЬ

            return game;
        } 
    }
}

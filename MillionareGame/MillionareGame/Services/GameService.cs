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
        private UserRepository _userRepository = new UserRepository();
        private GameRepository _gameRepository = new GameRepository();

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

        public List<Game> GetPlayerGames(string playerId)
        {
            var games =_gameRepository.GetAllGames();

            var playerGames = games.Where(game => game.UserId == playerId).ToList();

            return playerGames;
        }

        public void SaveResult(Player player, Game game)
        {
            _userRepository.UpdatePlayer(player, game);
            _gameRepository.SaveGame(game);
        }
    }
}

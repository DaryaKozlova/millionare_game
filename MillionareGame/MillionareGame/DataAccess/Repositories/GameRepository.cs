using System.Collections.Generic;
using System.IO;
using System.Linq;
using MillionareGame.DataAccess.Models;
using Newtonsoft.Json;

namespace MillionareGame.DataAccess.Repositories
{
    public class GameRepository
    {
        private static string _filePath = System.IO.Path.GetFullPath("../../data/games.json");

        public Game SaveGame(Game game)
        {
            var games = GetAllGames();

            if (!games.Exists(existGame => existGame.Id == game.Id))
            {
                games.Add(game);
            }
            else
            {
                var playerIndex = games.FindIndex(existGame => existGame.Id == game.Id);

                games[playerIndex] = game;
            }

            File.WriteAllText(_filePath, JsonConvert.SerializeObject(games));

            return game;
        }

        public List<Game> GetAllGames()
        {
            List<Game> games = new List<Game>();

            if (File.Exists(_filePath))
            {
                var file = File.ReadAllText(_filePath);

                if (file.Length != 0) games = JsonConvert.DeserializeObject<List<Game>>(file);
            }
            else
            {
                File.WriteAllText(_filePath, JsonConvert.SerializeObject(games));
            }

            return games;
        }
    }
}
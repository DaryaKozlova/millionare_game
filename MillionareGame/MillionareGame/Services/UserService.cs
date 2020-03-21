using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MillionareGame.DataAccess.Models;
using MillionareGame.DataAccess.Repositories;
using Newtonsoft.Json;

namespace MillionareGame.Services
{
    public class UserService
    {
        private UserRepository _userRepository = new UserRepository();

        public Player RegisterUser(string nickname, string password)
        {
            var player = new Player
            {
                Id = Guid.NewGuid().ToString(),
                Nickname = nickname,
                Password = password,
                RegistrationDate = DateTime.Now,
            };

            var newPlayer = _userRepository.SavePlayer(player);

            return newPlayer;
        }

        public Player LoginPlayer(string nickname, string password)
        {
            var player = _userRepository.FindPlayer(nickname);

            if (player != null && player.Password == password)
            {
                return player;
            }

            return null;
        }
    }
}
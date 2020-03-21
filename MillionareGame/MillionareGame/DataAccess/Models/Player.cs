using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionareGame.DataAccess.Models
{
    public enum UserType
    {
        Admin,
        Player
    }

    public class Player
    {
        public string Id { get; set; }

        public string Nickname { get; set; }

        public string Password { get; set; }

        public UserType Type { get; set; } = UserType.Player;

        public DateTime RegistrationDate { get; set; }

        public int PlayedGamesCount { get; set; } = 0;

        public long TotalScore { get; set; } = 0;
    }
}
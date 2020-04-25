using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionareGame.DataAccess.Models
{
    public class Game
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public DateTime DateTime { get; set; }

        public List<Question> Questions { get; set; }

        public int AnsweredQuestionsCount { get; set; }

        public int TotalScore { get; set; }
    }
}
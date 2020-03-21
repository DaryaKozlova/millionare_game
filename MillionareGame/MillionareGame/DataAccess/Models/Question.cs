using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionareGame.DataAccess.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string QuestionText { get; set; }

        public string AnswerId { get; set; }

        public int Complexity { get; set; }

        public List<Answer> Variants { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MillionareGame.DataAccess.Models;
using Newtonsoft.Json;

namespace MillionareGame.DataAccess.Repositories
{
    public class QuestionsRepository
    {
        private static string _filePath = "../../data/questions.json";

        public List<Question> GetGameQuestions()
        {
            var allQuestions = GetAllQuestions();

            var gameQuestions = new List<Question>();
            var random = new Random();

            for (var complexity = 1; complexity <= 5; complexity++)
            {
                var allComplexityQuestions = allQuestions.FindAll(question => question.Complexity == complexity).ToList();
                var complexityQuestions = new List<Question>();

                while (complexityQuestions.Count != 3)
                {
                    var randomIndex = random.Next(0, allComplexityQuestions.Count);

                    var newQuestion = allComplexityQuestions[randomIndex];

                    if (!complexityQuestions.Exists(question => question.Id == newQuestion.Id))
                    {
                        complexityQuestions.Add(newQuestion);
                    }
                }

                gameQuestions.AddRange(complexityQuestions);

            }


            return gameQuestions;
        }

        public List<Question> GetAllQuestions()
        {
            var filePath = System.IO.Path.GetFullPath(_filePath);
            var file = File.ReadAllText(filePath);
            var questions = JsonConvert.DeserializeObject<List<Question>>(file);

            return questions;
        }


    }
}

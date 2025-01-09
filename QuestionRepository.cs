using System.Collections.Generic;

namespace SimpleQuizGame
{
    public class QuestionRepository
    {
        public List<Question> LoadQuestions()
        {
            return new List<Question>
            {
                new Question("What is the capital of France?",
                             new string[] { "Berlin", "Madrid", "Paris", "Rome" },
                             2),
                new Question("How many continents are there?",
                             new string[] { "5", "6", "7", "8" },
                             2),
                new Question("What is the largest mammal in the world?",
                             new string[] { "Elephant", "Giraffe", "Blue Whale", "Gorilla" },
                             2),
                new Question("Who painted the Mona Lisa?",
                             new string[] { "Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Rembrandt" },
                             1),
                new Question("Which element has the chemical symbol 'O'?",
                             new string[] { "Gold", "Silver", "Oxygen", "Osmium" },
                             2),
                new Question("In which year did World War II end?",
                             new string[] { "1943", "1944", "1945", "1946" },
                             2),
                new Question("Which planet is closest to the Sun?",
                             new string[] { "Venus", "Mars", "Mercury", "Jupiter" },
                             2),
                new Question("Who wrote 'Romeo and Juliet'?",
                             new string[] { "Charles Dickens", "William Shakespeare", "Jane Austen", "Mark Twain" },
                             1),
                new Question("What is the capital of Japan?",
                             new string[] { "Beijing", "Seoul", "Bangkok", "Tokyo" },
                             3),
                new Question("Which is the longest river in the world?",
                             new string[] { "Amazon", "Nile", "Yangtze", "Mississippi" },
                             1)
            };
        }
    }
}


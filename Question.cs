namespace SimpleQuizGame
{
    public class Question
    {
        public string Text { get; }
        public string[] Options { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string text, string[] options, int correctAnswerIndex)
        {
            Text = text;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}

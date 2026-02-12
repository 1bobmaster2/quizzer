namespace quizzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question question1 = new Question("I", "ja");
            Question question2 = new Question("you", "wy");
            Question question3 = new Question("thou", "ty");

            Question[] questions = {question1, question2, question3};

            Quiz quiz = new Quiz(questions);

            Quizzer quizzer = new Quizzer(quiz);

            quizzer.Test();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace quizzer
{
    internal class Quizzer
    {
        Quiz quiz;

        public Quizzer(Quiz quiz)
        {
            this.quiz = quiz;
        }

        public void Test()
        {
            Random rnd = new Random();
            Quiz quizOfTest = quiz;

            foreach (Question questions in quizOfTest.question)
            {
                int binary = rnd.Next(2);
                int quizIndex = rnd.Next(quizOfTest.question.Length - 1);

                Console.WriteLine(quiz.question[quizIndex]);
            }
        }
    }
}

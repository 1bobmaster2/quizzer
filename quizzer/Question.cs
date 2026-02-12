using System;
using System.Collections.Generic;
using System.Text;

namespace quizzer
{
    internal class Question
    {
        string FirstVariant;
        string SecondVariant;

        public Question(string firstVariant, string secondVariant)
        {
            this.FirstVariant = firstVariant;
            this.SecondVariant = secondVariant;
        }
    }
}

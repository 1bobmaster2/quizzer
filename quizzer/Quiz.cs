using System;
using System.Collections.Generic;
using System.Text;

namespace quizzer
{
    internal class Quiz
    {
        public Question[] question;

        public Quiz(Question[] questions)
        {
            this.question = questions;
        }
    }
}

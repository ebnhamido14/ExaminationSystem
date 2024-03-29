﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }

        public Answer() { }

        public Answer(int answerid, string answertext)
        {
            AnswerId = answerid;
            AnswerText = answertext;
        }

        public override string ToString()
        {
            return $"{AnswerId}--{AnswerText}";
        }

    }
}

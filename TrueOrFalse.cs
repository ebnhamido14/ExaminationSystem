using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class TrueOrFalse : Question
    {
        public override string Header => "True OR False Question";
        public TrueOrFalse() 
        {
            AnswerList = new Answer[2];
            AnswerList[0]=new Answer(1,"True");
            AnswerList[1]=new Answer(2,"False");
        }

        public override void AddQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Please Enter Body Of Question");
            Body = Console.ReadLine();
            int mark;
            do
            {
                Console.WriteLine("Enter Marks Of Question");
            } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);

            Marks = mark;
            int rightanswerid;
            do
            {
                Console.WriteLine("Please Enter id of right answer");
            } while (!int.TryParse(Console.ReadLine(), out rightanswerid) || rightanswerid < 1 || rightanswerid > 2);
            RightAnswer.AnswerId = rightanswerid;
            RightAnswer.AnswerText = AnswerList[rightanswerid - 1].AnswerText;
            Console.Clear();
        }
    }
}

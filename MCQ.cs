using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class MCQ : Question
    {

        public override string Header { get => "MCQ Question"; }

        public MCQ()
        {
            AnswerList = new Answer[3];
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
            }while (!int.TryParse(Console.ReadLine(),out mark)||mark<1);

            Marks=mark;
            Console.WriteLine("Enter Answers Of Question");
            for(int i=0;i<3;i++)
            {
                AnswerList[i] = new Answer()
                {
                    AnswerId = i+1
                };
                Console.WriteLine($"Enter Answer Number {i+1}");
                AnswerList[i].AnswerText = Console.ReadLine();
            }
            int rightanswerid;
            do
            {
                Console.WriteLine("Please Enter id of right answer");
            }while(!int.TryParse(Console.ReadLine(),out rightanswerid)||rightanswerid<1||rightanswerid>3);
            RightAnswer.AnswerId = rightanswerid;
            RightAnswer.AnswerText = AnswerList[rightanswerid-1].AnswerText;
            Console.Clear();

        }
    }
}

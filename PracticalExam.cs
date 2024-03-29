using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numofquestions) : base(time, numofquestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new MCQ[NumberOfQuestions];
            for(int i = 0; i < NumberOfQuestions; i++)
            {
                ListOfQuestions[i] = new MCQ();
                ListOfQuestions[i].AddQuestion();
                Console.Clear();
            }
        }

        public override void ShowExam()
        {          
            foreach (var Question in ListOfQuestions)
            {
                Console.WriteLine(Question);
                for (int i = 0; i < Question.AnswerList.Length; i++)
                {
                    Console.WriteLine(Question.AnswerList[i]);
                }
                Console.WriteLine("----------------------------------------");
                int useranswerid;
               
                    do
                    {
                        Console.WriteLine("Enter Number Of Your Answer");
                    } while (!int.TryParse(Console.ReadLine(), out useranswerid) || useranswerid < 1 || useranswerid > 3);
                    Question.UserAnswer.AnswerId = useranswerid;
                    Question.UserAnswer.AnswerText = Question.AnswerList[useranswerid - 1].AnswerText;
                    Console.WriteLine("--------------------------------");
                Console.Clear();               
            }
            Console.WriteLine();

            for (int i = 0; i < ListOfQuestions.Length; i++)           
                Console.WriteLine($"Right Answer Of Question Number{i+1} is : {ListOfQuestions[i].RightAnswer.AnswerText}");                   
        }
    }
}

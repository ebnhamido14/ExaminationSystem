using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class FinalExam : Exam
    {
        public FinalExam(int time,int numberofquestions):base(time,numberofquestions) { }
        
            
        
        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new Question[NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int choice;
                do
                {
                    Console.WriteLine("Enter 1:MCQ or 2:TF");
                }while(!int.TryParse(Console.ReadLine(), out choice)||choice<1||choice>2);
                Console.Clear();
                if (choice == 1)
                {
                    ListOfQuestions[i] = new MCQ();
                    ListOfQuestions[i].AddQuestion();
                }
                else if (choice == 2)
                {
                    ListOfQuestions[i] = new TrueOrFalse();
                    ListOfQuestions[i].AddQuestion();
                }

            }
        }

        public override void ShowExam()
        {
            int TotalMarks = 0, Grade = 0;
            foreach (var Question in ListOfQuestions)
            {
                Console.WriteLine(Question);
                for(int i=0;i<Question.AnswerList.Length;i++)
                {
                    Console.WriteLine(Question.AnswerList[i]);
                }
                Console.WriteLine("----------------------------------------");
                int useranswerid;
                if(Question.Header== "MCQ Question")
                {
                    do
                    {
                        Console.WriteLine("Enter Number Of Your Answer");
                    }while(!int.TryParse(Console.ReadLine(),out useranswerid) ||useranswerid<1||useranswerid>3);
                   Question.UserAnswer.AnswerId= useranswerid;
                    Question.UserAnswer.AnswerText = Question.AnswerList[useranswerid - 1].AnswerText;
                    Console.WriteLine("--------------------------------");
                }
                else if(Question.Header== "True OR False Question")
                {
                    do
                    {
                        Console.WriteLine("Enter Number Of Your Answer");
                    } while (!int.TryParse(Console.ReadLine(), out useranswerid) || useranswerid < 1 || useranswerid > 2);
                    Question.UserAnswer.AnswerId = useranswerid;
                    Question.UserAnswer.AnswerText = Question.AnswerList[useranswerid - 1].AnswerText;
                    Console.WriteLine("--------------------------------");
                }

               Console.Clear();
                TotalMarks += Question.Marks;
            }
            Console.WriteLine();

            for(int  i = 0; i < ListOfQuestions.Length; i++)
            {
                if (ListOfQuestions[i].RightAnswer.AnswerId == ListOfQuestions[i].UserAnswer.AnswerId)              
                    Grade += ListOfQuestions[i].Marks;
                Console.WriteLine($"Question ({i+1}): {ListOfQuestions[i].Body}");
                Console.WriteLine($"Your Answer: {ListOfQuestions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Right Answer: {ListOfQuestions[i].RightAnswer.AnswerText}");              
            }
            Console.WriteLine($"Your Grade is = {Grade}/{TotalMarks}");

        }
    }
}

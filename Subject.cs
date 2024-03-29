using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Subject
    {
        public int Subject_Id { get; set; }
        public string? Subject_Name { get; set; }

        public Exam Subject_Exam { get; set; }

        public Subject(int id, string name)
        {
            Subject_Id = id;
            Subject_Name = name;
        }
        public void Create_Exam()
        {
            int Exam_Type, Exam_Time, Number_Of_Questions;
            do
            {
                Console.WriteLine("Enter 1:Practical Exam Or 2:Final Exam");
            }while(!int.TryParse(Console.ReadLine(),out Exam_Type)&&Exam_Type<1||Exam_Type>2);
            do
            {
                Console.WriteLine("Enter Time Of Exam (30:90 Minute)");
            } while (!int.TryParse(Console.ReadLine(), out Exam_Time) || Exam_Time < 30 || Exam_Time > 90);

            do
            {
                Console.WriteLine("Enter Number Of Questions");
            }while(!int.TryParse(Console.ReadLine(),out Number_Of_Questions)||Number_Of_Questions<1);

            if (Exam_Type == 1)
            {
                Subject_Exam = new PracticalExam(Exam_Time,Number_Of_Questions);
            }
            else
                Subject_Exam = new FinalExam(Exam_Time, Number_Of_Questions);

            Console.Clear();
            Subject_Exam.CreateListOfQuestions();
            

        }

    }
}

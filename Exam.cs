using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public abstract class Exam
    {
        public int Time {  get; set; }
        public int NumberOfQuestions { get; set; }

        public Question[] ListOfQuestions { get; set; }

        public Exam(int time,int numofquestions)
        {
            Time = time;
            NumberOfQuestions = numofquestions;  
        }

        public abstract void ShowExam();
        public abstract void CreateListOfQuestions();


    }
}

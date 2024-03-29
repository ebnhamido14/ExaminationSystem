using System.Diagnostics;

namespace ExamSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new(1, "C#");
            subject.Create_Exam();
            Console.Clear();
            Console.WriteLine("Do You Want To Start The Exam (Y) or (N)");
            char c =char.Parse(Console.ReadLine());
            if (c == 'y' || c == 'Y')
            {
                Console.Clear();
                Stopwatch sw = new();
                sw.Start();
                subject.Subject_Exam.ShowExam();
                Console.WriteLine($"Taken Time ={sw.Elapsed}");
            }
            else
                Console.WriteLine("Thank You");
        }
    }
}

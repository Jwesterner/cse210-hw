using System;

namespace Learning04 {

    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");

            MathAssignemnt mathAssignemnt1 = new MathAssignemnt("Roberto Rodriguez", "Fractions", "7.3", "8-19");

            WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

            Console.WriteLine(assignment1.GetSummary());

            Console.WriteLine(mathAssignemnt1.GetSummary());
            Console.WriteLine(mathAssignemnt1.GetHomeworkList());

            Console.WriteLine(writingAssignment1.GetSummary());
            Console.WriteLine(writingAssignment1.GetWritingInformation());
        }
    }
}
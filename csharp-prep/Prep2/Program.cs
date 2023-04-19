using System;

class Program
{
    static void Main(string[] args)
    {
        char letter;
        int grade;
        string passFail;

        Console.WriteLine("Please enter your grade: ");
        grade = Convert.ToInt32(Console.ReadLine());

        if (grade>=70) {
            passFail = "You are passing your class! Nice!";
        }
        else {
            passFail = "Work a bit harder and you might pass!";
        }

        if (grade>=90) {
            letter = 'A';
        }
        else if (grade>=80 && grade<90) {
            letter = 'B';
        }
        else if (grade>=70 && grade<80) {
            letter = 'C';
        }
        else if (grade>=60 && grade<70) {
            letter = 'D';
        }
        else {
            letter = 'F';
        }

        Console.WriteLine($"Your letter grade is {letter}. {passFail}");

    }
}
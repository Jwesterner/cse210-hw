using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int numberSquared;

        DisplayWelcome();
        name = PromptUserName();
        numberSquared = SquareNumber(PromptUserNumber());
        DisplayResults(name, numberSquared);

    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite integer: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int number) {
        int square = number*number;
        return square;
    }

    static void DisplayResults(string name, int number) {
        Console.WriteLine($"{name}, your favorite number squared is {number}");
    }
}
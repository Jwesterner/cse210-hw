using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber;
        int minAboveZero;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true) {
            Console.Write("Enter number: ");
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber==0) {
                break;
            }

            numbers.Add(userNumber);
        }

        minAboveZero = numbers.Max();

        foreach (int number in numbers) {
            if (number>0 && number<minAboveZero) {
                minAboveZero = number;
            }
        }

        Console.Write($"The Sum is: {numbers.Sum()}\nThe Average is: {numbers.Average()}\nThe Largest Number is: {numbers.Max()}\n");
        Console.Write($"The Smallest Positive Number is: {minAboveZero}\n");
        Console.WriteLine("The Sorted List is: ");

        foreach (int number in numbers.Order()) {
            Console.WriteLine(number);
        }
    }
}
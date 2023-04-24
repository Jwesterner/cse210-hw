using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int guess;
        char keepPlaying='y';
        int guesses=0;

        while (keepPlaying=='y') {
            guesses=0;
            int randNum = randomGenerator.Next(1, 100);
            do {
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                guesses++;

                if (guess>randNum) {
                    Console.WriteLine("Lower");
                }
                else if (guess<randNum) {
                    Console.WriteLine("Higher");
                }
            } while (guess != randNum);

            Console.WriteLine($"You Guessed the number in {guesses} guesses!");
            Console.Write("Would you like to keep playing[y/n]? ");
            keepPlaying = Convert.ToChar(Console.ReadLine());
        }
    }
}
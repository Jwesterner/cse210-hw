using System;

namespace Learning03 {
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(3,4);
            Fraction fraction2 = new Fraction(5);
            Fraction fraction3 = new Fraction();

            Console.WriteLine(fraction1.getDecimalValue());
            Console.WriteLine(fraction1.getFractionString());
            Console.WriteLine(fraction2.getFractionString());
            Console.WriteLine(fraction3.getFractionString());
        }
    }
}
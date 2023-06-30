using System;

class Program
{
    static void Main(string[] args)
    {
        string[] dope = {"|", "/", "-", "\\"};
        while (true) {
            foreach (string str in dope) {
                Console.Write(str);
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
        }
    }
}
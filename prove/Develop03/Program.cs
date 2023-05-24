using System;

namespace Develop03 {
class Program
    {
        static void Main(string[] args)
        {
            Scriptures scripture = new Scriptures();

            int index = scripture.GetRandomIndex();
            bool quit = false;

            TargetPhrase phrase = new TargetPhrase(scripture.GetRef(index), scripture.GetVerse(index));

            while (!quit) {
            Console.Clear();
            Console.WriteLine("Tap Enter to erase more words, type quit to exit.");
            Console.WriteLine(scripture.GetRef(index));
            Console.WriteLine(phrase.GetModifiedVerse());
            if (Console.ReadLine() == "quit") {
                quit = true;
            }
            else {
                phrase.HideWords(10);
            }
            }

        }
    }
}
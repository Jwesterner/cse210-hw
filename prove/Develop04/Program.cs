using System;

namespace Develop04 {

    class Program {

        static void Main(string[] args) {

            Breathing breathing = new Breathing();
            Listing listing = new Listing();
            Reflection reflection = new Reflection();

            int choice = 0;
            int time;

            while (choice == 0) {
                Console.WriteLine("\nWelome to the Mindulness Program");
                Console.WriteLine("Please choose from one of the activities below: ");
                Console.WriteLine("1. Breathing Activity\n2. Listing Activity\n3. Reflection Activity\n4. Quit");
                
                choice = int.Parse(Console.ReadLine());

                switch (choice) {
                    case 1:
                        breathing.DisplayStartMsg();
                        time = Convert.ToInt16(Console.ReadLine());
                        breathing.SetTime(time);

                        breathing.BeginPrep();
                        breathing.Timer();
                        choice = 0;
                        break;
                    case 2:
                        listing.DisplayStartMsg();
                        time = Convert.ToInt16(Console.ReadLine());
                        listing.SetTime(time);

                        listing.BeginPrep();
                        listing.Timer();
                        choice = 0;
                        break;
                    case 3:
                        reflection.DisplayStartMsg();
                        time = Convert.ToInt16(Console.ReadLine());
                        reflection.SetTime(time);

                        reflection.BeginPrep();
                        reflection.Timer();
                        choice = 0;
                        break;
                    case 4:
                        break;
                    default:
                        choice = 0;
                        break;

                }
            }
        }
    }
}
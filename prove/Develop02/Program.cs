using System.Globalization;
using System;
using System.Collections.Generic;

namespace Develop02 {
    class Program {
        static void Main(string[] args) {
            
            DataStore ds = new DataStore();
            Journal journal = new Journal();
            Prompt prompts = new Prompt();


            string current_date = DateTime.Now.ToShortDateString();
            string response;
            string random_prompt;
            string file;
            int choice;

            Console.WriteLine("Welcome to the Journal Program!");
            do {
                Console.WriteLine("Please select on of the following choices");
                Console.WriteLine("1) Write\n2) Display\n3) Load\n4) Save\n5) Quit");
                choice = Convert.ToInt16(Console.ReadLine());

                if (choice == 1) {
                    random_prompt = prompts.GetRandomString();
                    Console.WriteLine(random_prompt);
                    response = Console.ReadLine();

                    journal.StoreEntry(new Entry() {
                        date = current_date,
                        prompt = random_prompt,
                        response = response
                    });
                }

                if (choice == 2) {
                    foreach (Entry item in journal.GetAllEntries()) {
                        Console.WriteLine(item.GetAsString());
                    }
                }

                if (choice == 3) {
                    Console.WriteLine("\nEnter the name of the file you would like to load: ");
                    file = Console.ReadLine();
                    ds.LoadFile(file, journal);
                }

                if (choice == 4) {
                    Console.WriteLine("\nEnter the name of the file you would like to save to: ");
                    file = Console.ReadLine();
                    ds.SaveToFile(file, journal.GetAllEntries());
                }


            } while (choice != 5);

            



            }
        }
    }
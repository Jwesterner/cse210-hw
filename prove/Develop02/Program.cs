using System;
using System.Collections.Generic;

namespace Develop02 {
    class Program
    {
        static void Main(string[] args)
        {
            Entry myEntry = new Entry();
            myEntry.store("What is your name?", "Jack West", "8 May 2023");

            Journal journal = new Journal();
            journal.StoreEntry(myEntry);

            List<Entry> entries = journal.GetAllEntries();
            
            foreach (Entry entry in entries) {
                string message = entry.GetAsString();
                Console.WriteLine(message);
            }
        }
    }
}
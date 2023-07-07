using System;

namespace Foundation3 {
class Program
    {
        static void Main(string[] args)
        {
            
            LectureEvent lecEvent = new LectureEvent("John Smith", 250, "blah blah blah...", "All about the wonders of communication", "8/24/24", "2:00 pm", "123 Street Ln");
            OutdoorEvent outEvent = new OutdoorEvent("Sunny", "Fishing Tournament", "Come and compete for the largest bass!", "5/13/24", "9:00 am", "453 Lakeside Drive");
            ReceptionEvent recEvent = new ReceptionEvent("rsvp@gmail.com", "John & Janes Wedding Reception", "Come and celebrate!", "9/25/23", "6:00 pm", "678 Real St");

            Console.WriteLine(lecEvent.GetStandardInfo());
            Console.WriteLine(lecEvent.GetShortInfo());
            Console.WriteLine(lecEvent.GetFullInfo());

            Console.WriteLine(outEvent.GetStandardInfo());
            Console.WriteLine(outEvent.GetShortInfo());
            Console.WriteLine(outEvent.GetFullInfo());

            Console.WriteLine(recEvent.GetStandardInfo());
            Console.WriteLine(recEvent.GetShortInfo());
            Console.WriteLine(recEvent.GetFullInfo());
        }
    }
}
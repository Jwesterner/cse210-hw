using System;
using System.Collections.Generic;

namespace Foundation4 {
    class Program
    {
        static void Main(string[] args)
        {
            
            Running running = new Running(25, "12 Jul 2023", 5.6);
            Cycling cycling = new Cycling(45, "23 Jun 2023", 26);
            Swimming swimming = new Swimming(38, "15 Sep 2023", 32);

            List<Activity> activities = new List<Activity>{running, cycling, swimming};

            foreach (Activity activity in activities) {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
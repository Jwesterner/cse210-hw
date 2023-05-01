using System.Threading.Tasks.Dataflow;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Declare objects.
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resume = new Resume();

        // Add information to Job objects.
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Add information to resume object.
        resume._name = "Jack West";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Diplay resume contents to terminal.
        resume.Display();

        

    }
}
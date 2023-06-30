using System.Collections.Generic;
using System;

namespace Develop05 {

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the filename you would like to use: ");
            string filename = Console.ReadLine();

            User user = new User(filename);

            string choice;

            do {
                Console.WriteLine($"\nYou have {user.GetTotalScore()} points!\n");
                Console.WriteLine("Choose what you would like to do:\n1. Create New Goal\n2. List Goals\n3. Record Event\n0. Quit\n");
                choice = Console.ReadLine();

                if (choice == "1") {

                    Console.WriteLine("What type of goal would you like to add?\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
                    string type = Console.ReadLine();

                    Console.Write("Enter a name for the goal: ");
                    string newName = Console.ReadLine();
                    Console.Write("Write a short description of the goal: ");
                    string newDesc = Console.ReadLine();
                    if (type == "1") {
                        Console.Write("Enter the worth of the goal: ");
                        int points = Convert.ToInt32(Console.ReadLine());

                        user.AddNewGoal(new SimpleGoal(newName, newDesc, points, false));
                    }
                    else if (type == "2"){
                        Console.Write("Enter the worth of the goal per completion: ");
                        int points = Convert.ToInt32(Console.ReadLine());

                        user.AddNewGoal(new EternalGoal(newName, newDesc, points, 0));
                    } else {
                        Console.Write("Enter the number of times the goal needs to be done: ");
                        int target = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the number of points each completion will be worth: ");
                        int points = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("Enter the number of points the bonus will be worth: ");
                        int bonus = Convert.ToInt32(Console.ReadLine());

                        user.AddNewGoal(new ChecklistGoal(newName, newDesc, points, bonus, target, 0));
                    }

                    user.SaveFile(filename);
                    choice = "5";
                }
                else if (choice == "2") {
                    foreach (Goal goal in user.GetGoals()) {
                        Console.WriteLine(goal.GetInfo());
                    }
                    choice = "5";
                }
                else if (choice == "3") {
                    List<Goal> goalList = user.GetGoals();

                    Console.WriteLine("The goals are: ");
                    for (int i = 0; i < goalList.Count; i++) {
                        Console.WriteLine($"{i+1}. {goalList[i].GetName()}");
                    }
                    Console.Write("Which goal would you like to complete: ");
                    int updateGoal = Convert.ToInt32(Console.ReadLine());
                    goalList[updateGoal-1].Complete();
                    Console.WriteLine($"You have earned {goalList[updateGoal-1].GetPoints()} points");

                    user.SaveFile(filename);
                    choice = "5";
                }
            } while (choice != "0");


        }
    }
}
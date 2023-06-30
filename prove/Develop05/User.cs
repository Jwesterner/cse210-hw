using System.Net;
using System.IO;
using System;
using System.Collections.Generic;

namespace Develop05 {

    public class User {

        List<Goal> goals = new List<Goal>();

        public User(string filename) {

            List<string[]> contents = new List<string[]>();
            foreach (string line in File.ReadAllLines(filename)) {
                contents.Add(line.Split('|'));
            }
                
            for (int i = 0; i < contents.Count; i++) {
                switch (contents[i][0]) {
                    case "SimpleGoal":
                        bool status = (contents[i][4].ToLower() == "true");
                        goals.Add(new SimpleGoal(contents[i][1], contents[i][2], Convert.ToInt32(contents[i][3]), status));
                        continue;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(contents[i][1], contents[i][2], Convert.ToInt32(contents[i][3]), Convert.ToInt32(contents[i][4])));
                        continue;
                    case "ChecklistGoal":
                        goals.Add(new ChecklistGoal(contents[i][1], contents[i][2], Convert.ToInt32(contents[i][3]), Convert.ToInt32(contents[i][4]), Convert.ToInt32(contents[i][5]), Convert.ToInt32(contents[i][6])));
                        continue;
                    default:
                        continue;
                    }
                }
        }

        public int GetTotalScore() {
            int total = 0;
            foreach (Goal goal in goals) {
                total += goal.CalculateScore();
            }

            return total;
        }

        public void SaveFile(string filename) {
            File.WriteAllText(filename, String.Empty);

            foreach (Goal goal in goals) {
                File.AppendAllText(filename, goal.Serialize());
            }
        }

        public void AddNewGoal(Goal goal) {
            goals.Add(goal);
        }

        public List<Goal> GetGoals() {
            return goals;
        }


    }
}
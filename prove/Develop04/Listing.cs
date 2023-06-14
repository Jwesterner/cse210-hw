using System.Threading;
using System.Threading.Tasks;
using System;
namespace Develop04 {

    public class Listing : Activity {
        private bool _running = true;
        private int _listCounter = 0;
        private string[] _prompts = {"Who are people that you appreciate?",
                                    "What are personal strengths of yours?",
                                    "Who are people that you have helped this week?",
                                    "When have you felt the Holy Ghost this month?",
                                    "Who are some of your personal heroes?"};

        public Listing(int seconds) : base(seconds) {
            base.SetType("Listing");
            base.SetStartMsg("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }

        public Listing() : base(30) {
            base.SetType("Listing");
            base.SetStartMsg("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }

        private void DisplayRandomPrompt() {
            int rndIndex = new Random().Next(0, _prompts.Length);
            Console.Write(_prompts[rndIndex] + " ");
        }

        private Task TimerEnd() {
            int _timeleft = base.GetTime();
            Thread.Sleep(_timeleft*1000);
            _running = false;
            return Task.CompletedTask;
        }

        private void UserInputThread() {
            while (_running) {
                string userInput = Console.ReadLine();
                _listCounter++;
            }
        }

        public override async void Timer() {
            Thread inputThread = new Thread(UserInputThread);

            DisplayRandomPrompt();
            for (int i = 3; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

            inputThread.Start();

            await TimerEnd();

            Console.WriteLine();
            Console.WriteLine($"You listed {_listCounter} items.");
            Console.WriteLine("Tap Enter to Continue.");
            inputThread.Join();
        }
    }
}
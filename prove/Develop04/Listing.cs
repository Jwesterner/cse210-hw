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

        // An asynchronous task method that counts down the time.
        private Task TimerEnd() {
            int _timeleft = base.GetTime();
            Thread.Sleep(_timeleft*1000);
            _running = false;
            return Task.CompletedTask;
        }

        // Method used as a seperate input Thread.
        private void UserInputThread() {
            while (_running) {
                string userInput = Console.ReadLine();
                _listCounter++;
            }
        }


        public override async void Start() {
            // Initialize new thread.
            Thread inputThread = new Thread(UserInputThread);

            DisplayRandomPrompt();
            for (int i = 3; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

            // Begin writing to new thread, continues during asynchronous method.
            inputThread.Start();

            // Begin asynchronous task.
            await TimerEnd();

            // After asynchronous task is completed, execute print statements.
            Console.WriteLine();
            Console.WriteLine($"You listed {_listCounter} items.");
            Console.WriteLine("Tap Enter to Continue.");

            // Block inputThread from further use.
            inputThread.Join();
        }
    }
}